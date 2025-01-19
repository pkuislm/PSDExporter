using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PsdParser
{
    public class ImageDataSection
    {
        private protected PsdBinaryReader reader;
        public long Position { get; }
        public ChannelImageDataCompression Compression { get; }
        public byte[] Data { get; }

        internal ImageDataSection(PsdBinaryReader reader)
        {
            this.reader = reader;
            Position = reader.BaseStream.Position;
            if(reader.BaseStream.Length == Position)
            {
                Compression = ChannelImageDataCompression.RawData;
                Data = [];
                return;
            }
            Compression = (ChannelImageDataCompression)reader.ReadInt16();
            Data = reader.ReadBytes(Convert.ToInt32(reader.BaseStream.Length - Position - 2));
        }

        public byte[] GetData(FileHeaderSection header)
        {
            switch (header.Depth)
            {
                case 8:
                {
                    switch (Compression)
                    {
                        case ChannelImageDataCompression.RawData:
                        {
                            var channelSize = header.Width * header.Height;
                            var pixelData = new byte[channelSize * header.Channels];

                            var startPos = 0;
                            for (var c = 0; c < header.Channels; c++)
                            {
                                for (var o = 0; o < channelSize; o++)
                                {
                                    pixelData[c + o] = Data[startPos + o];
                                }
                                startPos += channelSize;
                            }
                            return pixelData;
                        }
                        case ChannelImageDataCompression.RLE:
                            return DecodeRLE8(header);
                        default:
                            throw new NotSupportedException($"Not supported compression mode:{Compression}");
                    }
                }
                default:
                    throw new NotSupportedException($"Not supported image pixel depth:{header.Depth}");
            }
        }

        byte[] DecodeRLE8(FileHeaderSection header)
        {
            using var br = new BinaryReader(new MemoryStream(Data));
            var channelSize = header.Width * header.Height;

            var pixelData = new byte[channelSize * header.Channels];

            var rleIndex = new int[header.Height * header.Channels];

            if(header.Version is 2)
            {
                for (int i = 0; i < rleIndex.Length; i++)
                    rleIndex[i] = br.ReadByte() << 24 | br.ReadByte() << 16 | br.ReadByte() << 8 | br.ReadByte();  
            }
            else
            {
                for (int i = 0; i < rleIndex.Length; i++)
                    rleIndex[i] = br.ReadByte() << 8 | br.ReadByte();
            }
            
            var position = br.BaseStream.Position;

            var prevY = 0;
            var pixelOffset = 0;
            for(var c = 0; c < header.Channels; c++)
            {
                pixelOffset = c;
                for (var y = 0; y < header.Height; y++)
                {
                    br.BaseStream.Position = position + rleIndex.Take(prevY + y).Sum();
                    var rle = br.ReadBytes(rleIndex[prevY + y]);

                    int di = 0;
                    for (var si = 0; si < rle.Length;)
                    {
                        var count = (sbyte)rle[si];
                        if (count > 0)
                        {
                            for (int i = 0; i < count + 1; i++)
                                pixelData[pixelOffset + ((di + i) * header.Channels)] = rle[si + 1 + i];
                            di += count + 1;
                            si += count + 1 + 1;
                        }
                        else
                        {
                            for (int i = 0; i < -count + 1; i++)
                                pixelData[pixelOffset + ((di + i) * header.Channels)] = rle[si + 1];
                            di += -count + 1;
                            si += 2;
                        }
                    }
                    if (di != header.Width)
                        throw new InvalidStreamPositionException(di, 0, header.Width);
                    pixelOffset += header.Width * header.Channels;
                }
                prevY += header.Height;
            }
            return pixelData;
        }
    }
}
