using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instance
{
	public partial class Main : Form
	{
		List<Dot> learned;
		Dot request;
		int clickState = 1;
		int k = 0;

		public Main()
		{
			InitializeComponent();
			learned = new List<Dot>();

			DoubleBuffered = true;
			UpdateK();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			Graphics g = e.Graphics;
			foreach (Dot dot in learned)
			{
				if (dot.State)
				{
					g.FillEllipse(Brushes.Black, dot.Body);
				}
				else
					g.FillEllipse(Brushes.Red, dot.Body);
			}

			if (request != null)
			{
				g.FillEllipse(Brushes.Lime, request.Body);
				if (learned.Count != 0 && k != 0)
				{
					List<Dot> dots = GetNearstDot();
					int count = 0;
					foreach (Dot dot in dots)
					{
						g.DrawLine(Pens.Black, request.LocationMiddle(), dot.LocationMiddle());

						if (dot.State)
							count++;
						else
							count--;						
					}
					if (count == 0)
						label2.Text = "Auswertung: ?";
					else if (count > 0)
						label2.Text = "Auswertung: Wahr";
					else
						label2.Text = "Auswertung: Falsch";
				}
			}
			base.OnPaint(e);
		}

		private void True_Click(object sender, EventArgs e)
		{
			clickState = 1;
		}

		private void False_Click(object sender, EventArgs e)
		{
			clickState = 2;
		}

		private void Request_Click(object sender, EventArgs e)
		{
			clickState = 3;
		}

		private void buttonPlus_Click(object sender, EventArgs e)
		{
			k++;
			UpdateK();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (k > 0)
				k--;
			UpdateK();
		}

		private void Display_Click(object sender, EventArgs e)
		{
			Point p = PointToClient(MousePosition);
			p.Offset(new Point(-10, -10));

			switch (clickState)
			{
				case 1:
					learned.Add(new Dot(p, true));
					break;
				case 2:
					learned.Add(new Dot(p, false));
					break;
				case 3:
					request = new Dot(p, true);
					break;
			}
			Invalidate();
		}

		private void UpdateK()
		{
			label1.Text = "k = " + k.ToString();
			Invalidate();
		}

		private List<Dot> GetNearstDot()
		{
			List<Dot> dots = new List<Dot>();

			for (int i = 1; i <= k && i <= learned.Count; i++)
			{
				Dot nearestDot = null;
				double nearestDis = 0;

				foreach (Dot dot in learned)        //Überprüft jeden Punkt mit dem RequestPunkt
				{
					double d = Distance(request, dot); //Rechnet die Distanz zwischen Punkt und dem RequestPunkt aus
					if (d < nearestDis || nearestDot == null)
					{
						bool flag = false;

						foreach (Dot dot1 in dots)
						{
							if (dot1 == dot)
								flag = true;
						}

						if (!flag)
						{
							nearestDot = dot;
							nearestDis = d;
						}
					}
				}

				dots.Add(nearestDot);
			}

			return dots;
		}

		private double Distance(Dot dot1, Dot dot2)
		{
			int x = Math.Abs(dot1.Body.X - dot2.Body.X);
			int y = Math.Abs(dot1.Body.Y - dot2.Body.Y);

			double d = Math.Sqrt(x * x + y * y);

			return d;
		}
	}
}
