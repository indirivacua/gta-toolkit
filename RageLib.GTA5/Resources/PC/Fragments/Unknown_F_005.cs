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

namespace RageLib.Resources.GTA5.PC.Fragments
{
    public class Unknown_F_005: ResourceSystemBlock
	{
		public override long Length
		{
			get { return 384; }
		}

		// structure data
		public uint VFT;
		public uint Unknown_4h; // 0x00000001
        public uint Unknown_8h; // 0x00000000
        public uint Unknown_Ch; // 0x00000000
        public uint Unknown_10h; // 0x00000000
        public uint Unknown_14h; // 0x00000000
        public ulong Unknown_18h_Pointer;
		public uint Unknown_20h; // 0x00000000
        public uint Unknown_24h; // 0x00000000
        public uint Unknown_28h; // 0x00000000
        public uint Unknown_2Ch; // 0x00000000
        public uint Unknown_30h;
		public uint Unknown_34h;
		public uint Unknown_38h;
		public uint Unknown_3Ch;
		public uint Unknown_40h;
		public uint Unknown_44h;
		public uint Unknown_48h;
		public uint Unknown_4Ch;
		public uint Unknown_50h;
		public uint Unknown_54h; // 0x00000001
        public uint Unknown_58h; // 0x00000000
        public uint Unknown_5Ch; // 0x00000000
        public uint Unknown_60h; // 0x00000000
        public uint Unknown_64h; // 0x00000000
        public uint Unknown_68h; // 0x00000000
        public uint Unknown_6Ch; // 0x00000000
        public uint Unknown_70h; // 0x00000000
        public uint Unknown_74h; // 0x00000000
        public uint Unknown_78h; // 0x00000000
        public uint Unknown_7Ch; // 0x00000000
        public ulong Unknown_80h_Pointer;
		public ushort Count1;
		public ushort Count2;
		public uint Unknown_8Ch; // 0x00000000
        public uint Unknown_90h; // 0x00000000
        public uint Unknown_94h; // 0x00000000
        public uint Unknown_98h; // 0x00000000
        public uint Unknown_9Ch; // 0x00000000
        public uint Unknown_A0h; // 0x00000000
        public uint Unknown_A4h; // 0x00000000
        public uint Unknown_A8h;
		public uint Unknown_ACh;
		public uint Unknown_B0h; // 0x00000000
        public uint Unknown_B4h; // 0x00000000
        public uint Unknown_B8h; // 0x00000000
        public uint Unknown_BCh; // 0x00000000
        public uint Unknown_C0h; // 0x00000000
        public uint Unknown_C4h; // 0x00000000
        public uint Unknown_C8h; // 0x00000000
        public uint Unknown_CCh; // 0x00000000
        public uint Unknown_D0h; // 0x00000000
        public uint Unknown_D4h; // 0x00000000
        public uint Unknown_D8h; // 0x00000000
        public uint Unknown_DCh; // 0x00000000
        public uint Unknown_E0h; // 0x00000000
        public uint Unknown_E4h; // 0x00000000
        public uint Unknown_E8h;
		public uint Unknown_ECh;
		public uint Unknown_F0h;
		public uint Unknown_F4h; // 0x00000000
        public uint Unknown_F8h;
		public uint Unknown_FCh; // 0x00000000
        public ulong Unknown_100h_Pointer;
		public ushort Count3;
		public ushort Count4;
		public uint Unknown_10Ch; // 0x00000000
        public ulong Unknown_110h_Pointer;
		public ushort Count5;
		public ushort Count6;
		public uint Unknown_11Ch; // 0x00000000
        public uint Unknown_120h; // 0x00000000
        public uint Unknown_124h; // 0x00000000
        public uint Unknown_128h; // 0x00000000
        public uint Unknown_12Ch; // 0x00000000
        public ulong Unknown_130h_Pointer;
		public uint Unknown_138h; // 0x00100000
        public uint Unknown_13Ch; // 0x00000000
        public ulong Unknown_140h_Pointer;
		public uint Unknown_148h;
		public uint Unknown_14Ch; // 0x00000000
        public uint Unknown_150h; // 0x00000000
        public uint Unknown_154h; // 0x00000000
        public uint Unknown_158h;
		public uint Unknown_15Ch; // 0x00000000
        public uint Unknown_160h; // 0x00000000
        public uint Unknown_164h; // 0x00000000
        public uint Unknown_168h; // 0x00000000
        public uint Unknown_16Ch; // 0x00000000
        public uint Unknown_170h; // 0x00000000
        public uint Unknown_174h; // 0x00000000
        public uint Unknown_178h; // 0x00000000
        public uint Unknown_17Ch; // 0x00000000

        // reference data
        public Unknown_F_020 Unknown_18h_Data;
		public ResourceSimpleArray<RAGE_Vector4> Unknown_100h_Data;
		public ResourceSimpleArray<RAGE_Vector4> Unknown_80h_Data;
		public ResourceSimpleArray<RAGE_Vector4> Unknown_110h_Data;
		public Unknown_F_024 Unknown_130h_Data;
		public Unknown_F_023 Unknown_140h_Data;

		/// <summary>
		/// Reads the data-block from a stream.
		/// </summary>
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			// read structure data
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h_Pointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h_Pointer = reader.ReadUInt64();
			this.Count1 = reader.ReadUInt16();
			this.Count2 = reader.ReadUInt16();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadUInt32();
			this.Unknown_B4h = reader.ReadUInt32();
			this.Unknown_B8h = reader.ReadUInt32();
			this.Unknown_BCh = reader.ReadUInt32();
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.Unknown_C8h = reader.ReadUInt32();
			this.Unknown_CCh = reader.ReadUInt32();
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadUInt32();
			this.Unknown_E4h = reader.ReadUInt32();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
			this.Unknown_F0h = reader.ReadUInt32();
			this.Unknown_F4h = reader.ReadUInt32();
			this.Unknown_F8h = reader.ReadUInt32();
			this.Unknown_FCh = reader.ReadUInt32();
			this.Unknown_100h_Pointer = reader.ReadUInt64();
			this.Count3 = reader.ReadUInt16();
			this.Count4 = reader.ReadUInt16();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.Unknown_110h_Pointer = reader.ReadUInt64();
			this.Count5 = reader.ReadUInt16();
			this.Count6 = reader.ReadUInt16();
			this.Unknown_11Ch = reader.ReadUInt32();
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.Unknown_130h_Pointer = reader.ReadUInt64();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h_Pointer = reader.ReadUInt64();
			this.Unknown_148h = reader.ReadUInt32();
			this.Unknown_14Ch = reader.ReadUInt32();
			this.Unknown_150h = reader.ReadUInt32();
			this.Unknown_154h = reader.ReadUInt32();
			this.Unknown_158h = reader.ReadUInt32();
			this.Unknown_15Ch = reader.ReadUInt32();
			this.Unknown_160h = reader.ReadUInt32();
			this.Unknown_164h = reader.ReadUInt32();
			this.Unknown_168h = reader.ReadUInt32();
			this.Unknown_16Ch = reader.ReadUInt32();
			this.Unknown_170h = reader.ReadUInt32();
			this.Unknown_174h = reader.ReadUInt32();
			this.Unknown_178h = reader.ReadUInt32();
			this.Unknown_17Ch = reader.ReadUInt32();

			// read reference data
			this.Unknown_18h_Data = reader.ReadBlockAt<Unknown_F_020>(
				this.Unknown_18h_Pointer // offset
			);
			this.Unknown_100h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(
				this.Unknown_100h_Pointer, // offset
				this.Count3
			);
			this.Unknown_80h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(
				this.Unknown_80h_Pointer, // offset
				this.Count1
			);
			this.Unknown_110h_Data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(
				this.Unknown_110h_Pointer, // offset
				this.Count5
			);
			this.Unknown_130h_Data = reader.ReadBlockAt<Unknown_F_024>(
				this.Unknown_130h_Pointer // offset
			);
			this.Unknown_140h_Data = reader.ReadBlockAt<Unknown_F_023>(
				this.Unknown_140h_Pointer // offset
			);
		}

		/// <summary>
		/// Writes the data-block to a stream.
		/// </summary>
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			// update structure data
			this.Unknown_18h_Pointer = (ulong)(this.Unknown_18h_Data != null ? this.Unknown_18h_Data.Position : 0);
			this.Unknown_80h_Pointer = (ulong)(this.Unknown_80h_Data != null ? this.Unknown_80h_Data.Position : 0);
			//this.cnt2a = (ushort)(this.pxxxxx_2data != null ? this.pxxxxx_2data.Count : 0);
			this.Unknown_100h_Pointer = (ulong)(this.Unknown_100h_Data != null ? this.Unknown_100h_Data.Position : 0);
			//this.cnt2aaaa = (ushort)(this.pxxxxx_2aaadata != null ? this.pxxxxx_2aaadata.Count : 0);
			this.Unknown_110h_Pointer = (ulong)(this.Unknown_110h_Data != null ? this.Unknown_110h_Data.Position : 0);
			//this.cnt3a = (ushort)(this.pxxxxx_3data != null ? this.pxxxxx_3data.Count : 0);
			this.Unknown_130h_Pointer = (ulong)(this.Unknown_130h_Data != null ? this.Unknown_130h_Data.Position : 0);
			this.Unknown_140h_Pointer = (ulong)(this.Unknown_140h_Data != null ? this.Unknown_140h_Data.Position : 0);

			// write structure data
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h_Pointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h_Pointer);
			writer.Write(this.Count1);
			writer.Write(this.Count2);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.Unknown_B0h);
			writer.Write(this.Unknown_B4h);
			writer.Write(this.Unknown_B8h);
			writer.Write(this.Unknown_BCh);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.Unknown_C8h);
			writer.Write(this.Unknown_CCh);
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h);
			writer.Write(this.Unknown_E4h);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
			writer.Write(this.Unknown_F0h);
			writer.Write(this.Unknown_F4h);
			writer.Write(this.Unknown_F8h);
			writer.Write(this.Unknown_FCh);
			writer.Write(this.Unknown_100h_Pointer);
			writer.Write(this.Count3);
			writer.Write(this.Count4);
			writer.Write(this.Unknown_10Ch);
			writer.Write(this.Unknown_110h_Pointer);
			writer.Write(this.Count5);
			writer.Write(this.Count6);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
			writer.Write(this.Unknown_130h_Pointer);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h_Pointer);
			writer.Write(this.Unknown_148h);
			writer.Write(this.Unknown_14Ch);
			writer.Write(this.Unknown_150h);
			writer.Write(this.Unknown_154h);
			writer.Write(this.Unknown_158h);
			writer.Write(this.Unknown_15Ch);
			writer.Write(this.Unknown_160h);
			writer.Write(this.Unknown_164h);
			writer.Write(this.Unknown_168h);
			writer.Write(this.Unknown_16Ch);
			writer.Write(this.Unknown_170h);
			writer.Write(this.Unknown_174h);
			writer.Write(this.Unknown_178h);
			writer.Write(this.Unknown_17Ch);
		}

		/// <summary>
		/// Returns a list of data blocks which are referenced by this block.
		/// </summary>
		public override IResourceBlock[] GetReferences()
		{
			var list = new List<IResourceBlock>();
			if (Unknown_18h_Data != null) list.Add(Unknown_18h_Data);
			if (Unknown_100h_Data != null) list.Add(Unknown_100h_Data);
			if (Unknown_80h_Data != null) list.Add(Unknown_80h_Data);
			if (Unknown_110h_Data != null) list.Add(Unknown_110h_Data);
			if (Unknown_130h_Data != null) list.Add(Unknown_130h_Data);
			if (Unknown_140h_Data != null) list.Add(Unknown_140h_Data);
			return list.ToArray();
		}

	}
}
