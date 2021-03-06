/*
    Copyright(c) 2015 Neodymium

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in
    all copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
    THE SOFTWARE.
*/

using RageLib.Resources.Common;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Types
{
    public class TypesFile_GTA5_pc : FileBase64_GTA5_pc
    {
        public override long Length
        {
            get { return 112; }
        }

        // structure data
        public uint Unknown_10h; // 0x50524430
        public uint Unknown_14h; // 0x00010079
        public uint Unknown_18h; // 0x00000000
        public uint Unknown_1Ch;
        public ulong UnkPtr_20h;
        public ulong UnkPtr_28h;
        public ulong UnkPtr_30h;
        public ulong UnkPtr_38h;
        public ulong UnkPtr_40h;
        public ushort cnt1;
        public ushort cnt3;
        public ushort cnt2;
        public ushort Unknown_4Eh; // 0x0000
        public uint Unknown_50h; // 0x00000000
        public uint Unknown_54h; // 0x00000000
        public uint Unknown_58h; // 0x00000000
        public uint Unknown_5Ch; // 0x00000000
        public uint Unknown_60h; // 0x00000000
        public uint Unknown_64h; // 0x00000000
        public uint Unknown_68h; // 0x00000000
        public uint Unknown_6Ch; // 0x00000000

        // reference data
        public ResourceSimpleArray<Unknown_T_003> UnkPtr_20hdata;
        public ResourceSimpleArray<Unknown_T_002> UnkPtr_28hdata;
        public ResourceSimpleArray<Unknown_T_004> UnkPtr_30hdata;
        public Unknown_T_001 UnkPtr_40hdata;

        /// <summary>
        /// Reads the data-block from a stream.
        /// </summary>
        public override void Read(ResourceDataReader reader, params object[] parameters)
        {
            base.Read(reader, parameters);

            // read structure data
            this.Unknown_10h = reader.ReadUInt32();
            this.Unknown_14h = reader.ReadUInt32();
            this.Unknown_18h = reader.ReadUInt32();
            this.Unknown_1Ch = reader.ReadUInt32();
            this.UnkPtr_20h = reader.ReadUInt64();
            this.UnkPtr_28h = reader.ReadUInt64();
            this.UnkPtr_30h = reader.ReadUInt64();
            this.UnkPtr_38h = reader.ReadUInt64();
            this.UnkPtr_40h = reader.ReadUInt64();
            this.cnt1 = reader.ReadUInt16();
            this.cnt3 = reader.ReadUInt16();
            this.cnt2 = reader.ReadUInt16();
            this.Unknown_4Eh = reader.ReadUInt16();
            this.Unknown_50h = reader.ReadUInt32();
            this.Unknown_54h = reader.ReadUInt32();
            this.Unknown_58h = reader.ReadUInt32();
            this.Unknown_5Ch = reader.ReadUInt32();
            this.Unknown_60h = reader.ReadUInt32();
            this.Unknown_64h = reader.ReadUInt32();
            this.Unknown_68h = reader.ReadUInt32();
            this.Unknown_6Ch = reader.ReadUInt32();

            // read reference data
            this.UnkPtr_20hdata = reader.ReadBlockAt<ResourceSimpleArray<Unknown_T_003>>(
                this.UnkPtr_20h, // offset
                this.cnt1
            );
            this.UnkPtr_28hdata = reader.ReadBlockAt<ResourceSimpleArray<Unknown_T_002>>(
                this.UnkPtr_28h, // offset
                this.cnt3
            );
            this.UnkPtr_30hdata = reader.ReadBlockAt<ResourceSimpleArray<Unknown_T_004>>(
                this.UnkPtr_30h, // offset
                this.cnt2
            );
            this.UnkPtr_40hdata = reader.ReadBlockAt<Unknown_T_001>(
                this.UnkPtr_40h // offset
            );
        }

        /// <summary>
        /// Writes the data-block to a stream.
        /// </summary>
        public override void Write(ResourceDataWriter writer, params object[] parameters)
        {
            base.Write(writer, parameters);

            // update structure data
            this.UnkPtr_20h = (ulong)(this.UnkPtr_20hdata != null ? this.UnkPtr_20hdata.Position : 0);
            this.UnkPtr_28h = (ulong)(this.UnkPtr_28hdata != null ? this.UnkPtr_28hdata.Position : 0);
            this.UnkPtr_30h = (ulong)(this.UnkPtr_30hdata != null ? this.UnkPtr_30hdata.Position : 0);
            this.UnkPtr_38h = 0;
            this.UnkPtr_40h = (ulong)(this.UnkPtr_40hdata != null ? this.UnkPtr_40hdata.Position : 0);
            //this.cnt1 = (ushort)(this.UnkPtr_20hdata != null ? this.UnkPtr_20hdata.Count : 0);
            //this.cnt3 = (ushort)(this.UnkPtr_28hdata != null ? this.UnkPtr_28hdata.Count : 0);
            //this.cnt2 = (ushort)(this.UnkPtr_30hdata != null ? this.UnkPtr_30hdata.Count : 0);

            // write structure data
            writer.Write(this.Unknown_10h);
            writer.Write(this.Unknown_14h);
            writer.Write(this.Unknown_18h);
            writer.Write(this.Unknown_1Ch);
            writer.Write(this.UnkPtr_20h);
            writer.Write(this.UnkPtr_28h);
            writer.Write(this.UnkPtr_30h);
            writer.Write(this.UnkPtr_38h);
            writer.Write(this.UnkPtr_40h);
            writer.Write(this.cnt1);
            writer.Write(this.cnt3);
            writer.Write(this.cnt2);
            writer.Write(this.Unknown_4Eh);
            writer.Write(this.Unknown_50h);
            writer.Write(this.Unknown_54h);
            writer.Write(this.Unknown_58h);
            writer.Write(this.Unknown_5Ch);
            writer.Write(this.Unknown_60h);
            writer.Write(this.Unknown_64h);
            writer.Write(this.Unknown_68h);
            writer.Write(this.Unknown_6Ch);
        }

        /// <summary>
        /// Returns a list of data blocks which are referenced by this block.
        /// </summary>
        public override IResourceBlock[] GetReferences()
        {
            var list = new List<IResourceBlock>(base.GetReferences());
            if (UnkPtr_20hdata != null) list.Add(UnkPtr_20hdata);
            if (UnkPtr_28hdata != null) list.Add(UnkPtr_28hdata);
            if (UnkPtr_30hdata != null) list.Add(UnkPtr_30hdata);
            if (UnkPtr_40hdata != null) list.Add(UnkPtr_40hdata);
            return list.ToArray();
        }

    }
}