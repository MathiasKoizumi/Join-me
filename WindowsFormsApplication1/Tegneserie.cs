using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Tegneserie
	{
		private Lingo børnemuseum;

		private Jingo juklas;

		private JoyRomeo jongo;

		public Tegneserie(JoyRomeo romeo)
		{
			børnemuseum = new Lingo();
			juklas = romeo.partyTime();
			jongo = romeo;
		}

		internal IEnumerable<Mood> farvedeFolk()
		{
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(200));
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(400));
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(100));
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(300));
			yield return new Mood().affectMood(new Random().Next(2000));
			throw new NotImplementedException();
		}
	}
}
