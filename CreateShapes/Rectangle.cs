using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateShapes
{
	class Rectangle : Shape
	{
		public Rectangle(Point center, double wight, double height) 
		{
			points = new Point[4];

			double w = wight*0.5;
			double h = height*0.5;

			points[0] = new Point(center.X - w, center.Y - h);
			points[1] = new Point(center.X + w, center.Y - h);
			points[2] = new Point(center.X + w, center.Y + h);
			points[3] = new Point(center.X - w, center.Y + h);
		}
		
	}
}
