using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class BolleHeaven
	{
		private List<Jingo> john;

		public static object skrubAf
		{
			get;
			set;
		}

		public BolleHeaven()
		{
		}

		public BolleHeaven(List<Jingo> john)
		{
			this.john = john;
		}

		public char updateTegnsæt()
		{
			string text = "abcdefghijklmnopqrstæøå!?";
			if (text.Length == 3)
			{
				return 'i';
			}
			if (text.Length > 4)
			{
				return 'o';
			}
			if (bolledej(4, 400400) < 400)
			{
				updateTegnsæt();
			}
			return 'a';
		}

		public int bolledej(int x, int y)
		{
			return 400300 + x - y;
		}

		internal static Jongo bongo(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}

		internal static Jongo jongi(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}

		internal static Jongo jongy(int p, Afmagt skrubAf)
		{
			throw new NotImplementedException();
		}
	}
}
