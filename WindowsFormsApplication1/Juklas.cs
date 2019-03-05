using System;

namespace WindowsFormsApplication1
{
	public class Juklas
	{
		private float time = 2f;

		private DateTime join = DateTime.Now.AddMilliseconds(1500.0);

		private float obstruction;

		private int p;

		private Bongo bongo;

		private decimal returnInt(int j)
		{
			return join.Second + 4;
		}

		public Juklas()
		{
		}

		public Juklas(int p)
		{
			this.p = p;
		}

		public Juklas(int p, int j)
		{
			this.p = p;
		}

		internal void tid()
		{
			join = join.Add(join.Subtract(DateTime.Today.AddDays(4.0)));
		}

		internal Bongo firetusindeFunnyItems(int p)
		{
			float num = 400f + (float)p;
			return new Bongo(new BolleHeaven().bolledej(4, 500) * (int)num);
		}
	}
}
