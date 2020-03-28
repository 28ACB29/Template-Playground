using System;
using System.ComponentModel.DataAnnotations;

namespace TemplatePlayground.Models
{
	public class Test
	{
		public int ID
		{
			get;
			set;
		}

		public bool Bool
		{
			get;
			set;
		}

		public byte Byte
		{
			get;
			set;
		}

		public char Char
		{
			get;
			set;
		}

		public DateTime DateTime
		{
			get;
			set;
		}

		public decimal Decimal
		{
			get;
			set;
		}

		public double Double
		{
			get;
			set;
		}

		public float Float
		{
			get;
			set;
		}

		public int Int
		{
			get;
			set;
		}

		public long Long
		{
			get;
			set;
		}

		//public sbyte Sbyte
		//{
		//	get;
		//	set;
		//}

		public short Short
		{
			get;
			set;
		}

		public uint Uint
		{
			get;
			set;
		}

		public ulong Ulong
		{
			get;
			set;
		}

		public ushort Ushort
		{
			get;
			set;
		}

		public Test()
		{
			this.Bool = new bool();
			this.Byte = new byte();
			this.Char = new char();
			this.DateTime = DateTime.Now;
			this.Decimal = new decimal();
			this.Double = new double();
			this.Float = new float();
			this.Int = new int();
			this.Long = new long();
			//this.Sbyte = new sbyte();
			this.Short = new short();
			this.Uint = new uint();
			this.Ulong = new ulong();
			this.Ushort = new ushort();
		}
	}
}