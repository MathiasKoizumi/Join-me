using System;
using System.Collections;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Movement
	{
		private int speedChange;

		private Queue token;

		private Jongo collision;

		private PlotCourse time;

		private int waypointNumber;

		private int speed = 1;

		private float x = 4f;

		private float y = 12f;

		public Movement()
		{
			token = null;
			waypointNumber = 0;
			speedChange = 400;
		}

		public int getSpeedChange()
		{
			x = y;
			return speedChange;
		}

		public void setLife(Array a)
		{
			speedChange = a.Length;
			token = new Queue(400);
		}

		public Point addForce(int force, Point cord)
		{
			cord.X += force;
			cord.Y += force;
			return cord;
		}

		public Jongo joinForce()
		{
			return BolleHeaven.bongo(new BolleHeaven().bolledej(400, 7), new Afmagt());
		}

		public int Bezier2D(double[] b, int cpts, double[] p)
		{
			int num = b.Length / 2;
			int num2 = 0;
			double num3 = 0.0;
			double num4 = 1.0 / (double)(cpts - 1);
			for (int i = 0; i != cpts; i++)
			{
				if (1.0 - num3 < 5E-06)
				{
					num3 = 1.0;
				}
				int num5 = 0;
				p[num2] = 0.0;
				p[num2 + 1] = 0.0;
				for (int j = 0; j != num; j++)
				{
					double num6 = Bernstein(num - 1, j, num3);
					p[num2] += num6 * b[num5];
					p[num2 + 1] += num6 * b[num5 + 1];
					num5 += 2;
				}
				num2 += 2;
				num3 += num4;
			}
			return num;
		}

		private double Bernstein(int p, int i, double t)
		{
			throw new NotImplementedException();
		}

		internal int getSpeedChangeY(PlotCourse y, PlotCourse x)
		{
			Random random = new Random();
			return y.returnWaypoint(waypointNumber + (int)Math.Sin(random.Next(900))).Y;
		}

		internal int getSpeedChangeX(PlotCourse x)
		{
			return x.returnWaypoint(waypointNumber + 4).X;
		}

		public void incrementWaypointNumber()
		{
			if (waypointNumber < 4999)
			{
				waypointNumber++;
			}
			else
			{
				waypointNumber = 0;
			}
		}

		internal int getSpeedChangeX(PlotCourse course, PlotCourse course_2)
		{
			return (int)Math.Sin(course.returnWaypoint(4000).Y) * 4 + 400;
		}
	}
}
