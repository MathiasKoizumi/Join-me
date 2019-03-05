using System;
using System.Collections.Generic;
using System.Drawing;
using System.Timers;

namespace WindowsFormsApplication1
{
	internal class PlotCourse
	{
		private List<Point> waypoints;

		private Form1 bolle;

		private Timer jango;

		private DateTime jolle;

		public PlotCourse()
		{
			Random random = new Random();
			waypoints = new List<Point>();
			for (int num = waypoints.Count; num >= 0; num--)
			{
				waypoints.Add(new Point(random.Next(869), random.Next(450)));
			}
		}

		public PlotCourse(Jango s)
		{
		}

		public Point returnWaypoint(int i)
		{
			if (i >= waypoints.Count || i < 0)
			{
				return waypoints[waypoints.Count - 1];
			}
			if (i == 0)
			{
				return waypoints[i];
			}
			return waypoints[i];
		}

		internal Movement typeHente()
		{
			return new Movement();
		}

		public List<Point> showPath()
		{
			return waypoints;
		}
	}
}
