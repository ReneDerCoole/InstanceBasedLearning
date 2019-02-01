using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Instance
{
	public class Dot
	{
		public Rectangle Body { get; set; }
		public bool State { get; set; }

		public Dot(Point location, bool state)
		{
			Body = new Rectangle(location, new Size(20, 20));
			State = state;
		}

		public Point LocationMiddle()
		{
			int x = Body.X + Body.Width / 2;
			int y = Body.Y + Body.Height / 2;
			return new Point(x, y);
		}
	}
}
