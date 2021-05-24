using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateShapes
{
	class Shape
	{
		protected Point[] points;
		protected Point center;

		public Shape()
		{ points = null; }

		public Shape(Point[] points, Point center)
		{
			this.center = center;
			this.points = points;
		}
		public Shape(Point[] points)
		{ this.points = points; }
		public void Draw()
		{
			if (points == null) return;
		}


	}

}
