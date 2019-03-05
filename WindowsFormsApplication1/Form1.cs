using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private IContainer components;

		private Jingo bob = new Jingo();

		public Form1 formular;

		private Jongo trælle = new Jongo();

		private WindowsMediaPlayer wplayer = (WindowsMediaPlayer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

		private Panel panel1;

		private Button button1;

		private Label label1;

		private List<Afmagt> bollemælk;

		[DllImport("winmm.dll")]
		private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsApplication1.Form1));
			panel1 = new System.Windows.Forms.Panel();
			button1 = new System.Windows.Forms.Button();
			label1 = new System.Windows.Forms.Label();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.Controls.Add(button1);
			panel1.Location = new System.Drawing.Point(12, 45);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(869, 450);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.Font = new System.Drawing.Font("Segoe Print", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Image = (System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(366, 200);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(125, 41);
			button1.TabIndex = 2;
			button1.Text = "Come On";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(bongo);
			label1.AutoSize = true;
			label1.Font = new System.Drawing.Font("Segoe Script", 21.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			label1.ForeColor = System.Drawing.Color.ForestGreen;
			label1.Location = new System.Drawing.Point(89, -6);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(210, 48);
			label1.TabIndex = 2;
			label1.Text = "FireForge p3";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(912, 507);
			base.Controls.Add(label1);
			base.Controls.Add(panel1);
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Form1";
			Text = "BornMe";
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormClosingMeDown);
			base.Load += new System.EventHandler(Form_loadme);
			panel1.ResumeLayout(performLayout: false);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		public void newJongo()
		{
			trælle = new Jongo();
		}

		public void playMP3()
		{
			wplayer.close();
			string[] array = new string[4]
			{
				"Feed Me Headshot.mp3",
				"Metrik - Nightdrive.mp3",
				"The Island.mp3",
				"Feed Me Trapdoor.mp3"
			};
			using (Stream input = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources." + array[new Random().Next(4)]))
			{
				using (Stream output = File.Create("Math.mp3"))
				{
					CopyStream(input, output);
				}
			}
			wplayer.URL = "Math.mp3";
			wplayer.controls.play();
		}

		public void playOnMp3()
		{
		}

		public bool CheckIfFileIsBeingUsed(string fileName)
		{
			try
			{
				File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
			return false;
		}

		public static void CopyStream(Stream input, Stream output)
		{
			byte[] array = new byte[8192];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void timetoJongoisme()
		{
			for (int i = 0; i < trælle.getJohn().Count; i++)
			{
				Point[] waypoints = trælle.getJohn()[i].getWaypoints();
				for (int j = 0; j < waypoints.Length; j++)
				{
					waypoints[j].X = waypoints[j].X + 1;
					waypoints[j].Y = waypoints[j].Y + 200;
				}
				trælle.getJohn()[i].changeCourse();
			}
		}

		public void jongoTime()
		{
			Random random = new Random();
			Graphics graphics = panel1.CreateGraphics();
			for (int num = 5; num >= 0; num--)
			{
				for (int num2 = trælle.getJohn().Count - 1; num2 > 0; num2--)
				{
					trælle.getJohn()[num2].changeCourse();
					trælle.getJohn()[num2].moodChange(trælle.getJohn()[num2].changeCourse(), new Juklas());
					timetoJongoisme();
					switch (random.Next(3))
					{
					case 0:
						graphics.FillEllipse(new SolidBrush(trælle.getJohn()[num2].getColor()), new Rectangle(trælle.getJohn()[num2].getX(), trælle.getJohn()[num2].getY(), trælle.getJohn()[num2].getSize(), trælle.getJohn()[num2].getSize()));
						graphics.FillEllipse(new SolidBrush(trælle.getJohn()[num2].jingoTime(new Juklas(4)).getMood()), new Jingo().getSizeRectangle());
						break;
					case 1:
						for (int num4 = 4; num4 >= 0; num4--)
						{
							Random random2 = new Random();
							graphics.FillClosedCurve(new SolidBrush(Color.FromArgb(random2.Next(250), new Random().Next(255), 200, new Random().Next(255))), createPoints(50));
						}
						break;
					case 2:
						for (int num3 = 4; num3 >= 0; num3--)
						{
							Point[] points = createPoints(100);
							graphics.FillPolygon(new SolidBrush(Color.FromArgb(new Random().Next(240), trælle.getJohn()[num2].jingoTime(new Juklas(400)).getMood().B, trælle.getJohn()[num2].jingoTime(new Juklas(400)).getMood().R, trælle.getJohn()[num2].jingoTime(new Juklas(400)).getMood().G)), points);
						}
						break;
					}
				}
			}
		}

		private Point[] createPoints(int k)
		{
			Point[] array = new Point[k];
			for (int num = k - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(730), new Random().Next(800));
			}
			modifyPoints(array);
			return array;
		}

		public void modifyPoints(Point[] j)
		{
			for (int num = j.Length - 1; num >= 0; num--)
			{
				double num2 = Math.Sin(new Random().Next(500));
				if (num2 == 0.0)
				{
					num2 = 1.0;
				}
				j[num].X = j[num].X * (int)(Math.Sin(new Random().Next(500)) / num2);
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		private int patrol()
		{
			throw new NotImplementedException();
		}

		public Form1()
		{
			InitializeComponent();
			jongoTime();
			fillJoin();
		}

		private void bongo(object sender, EventArgs e)
		{
			playOnMp3();
			switch (new Random().Next(4))
			{
			case 0:
				button1.Text = "Find";
				break;
			case 1:
				button1.Text = "Beat";
				fillJoin();
				break;
			case 2:
				button1.Text = "Børne";
				break;
			case 3:
				button1.Text = "Join";
				break;
			default:
				button1.Text = "Dummy!!!";
				break;
			}
			for (int num = 10; num > 0; num--)
			{
				fillJoin();
				new BolleHeaven().updateTegnsæt();
				jongoTime();
			}
			newJongo();
		}

		private void fillJoin()
		{
			if (new Jingo().showBirth().Second > 4)
			{
				new Movement().joinForce();
			}
			else
			{
				new BolleHeaven().bolledej(0, 4);
			}
		}

		public void fillArrayBollemælk()
		{
			foreach (Afmagt item in bollemælk)
			{
				Bongo bongo = new Bongo();
				bongo.populationControl(new Jingo().changeCourse().jingoTime(new Juklas()).affectMood(4, new Juklas()), new Mood(), item.afMagt(5), new Token(), new PlotCourse().typeHente());
			}
			Jingo jingo = new Jingo();
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}

		private void Form_loadme(object sender, EventArgs e)
		{
			playMP3();
		}

		private void FormClosingMeDown(object sender, FormClosingEventArgs e)
		{
			TryToDelete("Math.mp3");
		}

		private static bool TryToDelete(string f)
		{
			try
			{
				File.Delete(f);
				return true;
			}
			catch (IOException)
			{
				return false;
			}
		}
	}
}
