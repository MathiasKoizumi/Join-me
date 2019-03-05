using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Mood
	{
		private Color temper = Color.Red;

		private Color joint = Color.Black;

		private Color currentMood;

		private Juklas honey;

		private int p;

		public Mood()
		{
			currentMood = Color.Gray;
			honey = new Juklas();
		}

		public Mood(int p)
		{
			this.p = p;
		}

		public Color getMood()
		{
			return currentMood;
		}

		public Mood affectMood(int gummi)
		{
			temper = Color.DeepPink;
			joint = Color.LightPink;
			if (gummi < 200)
			{
				currentMood = Color.FromArgb(200, 0, 255, 0);
			}
			else
			{
				currentMood = Color.FromArgb(new Random().Next(240), new Random().Next(60), new Random().Next(255), new Random().Next(40));
			}
			return this;
		}

		public Juklas affectMood(int damn, Juklas food)
		{
			if (Jingo.getCordinates(Color.Gray) == 2)
			{
				joint = Color.Gray;
			}
			Random random = new Random();
			currentMood = Color.FromArgb(random.Next(150), random.Next(200), random.Next(255), random.Next(255));
			if (currentMood.GetBrightness() == 0f)
			{
				currentMood = Color.White;
			}
			if (damn == 2)
			{
				return food;
			}
			return honey;
		}

		private void loadColors()
		{
			string[] names = Enum.GetNames(typeof(KnownColor));
			string[] array = names;
			foreach (string text in array)
			{
			}
		}

		internal Juklas roundUp()
		{
			honey.tid();
			return new Juklas(3500, 300);
		}
	}
}
