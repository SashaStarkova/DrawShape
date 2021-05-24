using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateShapes
{
	class Triangle : Shape
	{
		public Triangle(Point p1, Point p2, Point p3)
		{
			points = new Point[3];
			points[0] = p1;
			points[1] = p2;
			points[2] = p3;
		}
	}
}
