using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsTheDiameter
{
    class Circle
    {
        private double radius;
        // You can use Math.PI to get pi.

        public Circle(double radius)
        {
            this.radius = radius;
        }

        /// <summary>
        /// Should give me the radius d'oh
        /// </summary>
        /// <returns>THE RADIUS</returns>
        public double getRadius()
        {
            return this.radius;
        }

        public void setRadius(double r)
        {
            this.radius = r;
        }

        override public String ToString()
        {
            return this.radius.ToString();
        }

        // Need now getDiameter, getCircumference, getArea.

        public double getDiameter()
        {
            return this.radius * 2;
        }

        // Neet also setRadius.
        public double getCircumference()
        {
            return this.radius * 2 * 3.14159; 
        }
        public double getArea()
        {
            return this.radius * this.radius * 3.14159;
        }
    }
}
