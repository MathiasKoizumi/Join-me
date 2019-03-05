using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Jongo
	{
		private int colorTime;

		private List<Jingo> john;

		public Jongo()
		{
			if (john != null)
			{
				fillList(john[john.Count]);
			}
			else
			{
				fillList(new JoyRomeo().partyTime());
			}
			colorTime++;
			if (john.Count == 200)
			{
				john = tidTilAtForståJongo(new JoyRomeo().partyTime());
			}
		}

		public List<Jingo> tidTilAtForståJongo(Jingo j)
		{
			for (int num = 1000; num > 0; num--)
			{
				john.Add(new Jingo(j, j));
			}
			return john;
		}

		private void fillList(Jingo troja)
		{
			john = new List<Jingo>();
			int num = 50;
			for (int num2 = num; num2 > 0; num2--)
			{
				Jingo item = new Jingo();
				troja = troja.changeCourse();
				troja.moodChange(troja, new Juklas());
				john.Add(item);
			}
		}

		public List<Jingo> getJohn()
		{
			return john;
		}

		private BolleHeaven callJongo(int t)
		{
			return new BolleHeaven(john);
		}

		internal void blivHosMig(int p)
		{
			throw new NotImplementedException();
		}
	}
}
