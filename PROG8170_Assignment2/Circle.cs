using System;
using System.Collections.Generic;
using System.Text;

namespace PROG8170_Assignment2
{

    public class Circle
    {
        private int pRadius;

        /// <summary>
        /// Circle counstructor
        /// </summary>
        public Circle()
        {
            pRadius = 1;
        }

        /// <summary>
        /// Circle counstructor
        /// </summary>
        /// <param name="inputRadius">The Radius.</param>
        public Circle(int inputRadius)
        {
            pRadius = inputRadius;
        }

        /// <summary>
        /// Get Radius
        /// </summary>
        /// <returns>The Radius</returns>
        public int GetRadius()
        {
            return pRadius;
        }

        /// <summary>
        /// Set Radius
        /// </summary>
        /// <param name="radius">The Radius</param>
        public void SetRadius(int radius)
        {
            pRadius =radius;
        }

        /// <summary>
        /// Get Circumference
        /// </summary>
        /// <returns>The Circumference Of Circle</returns>
        public double GetCircumference()
        {
            return 2 * Math.PI * pRadius;
        }
        /// <summary>
        /// Get Area
        /// </summary>
        /// <returns>The Area Of Circle</returns>
        public double GetArea()
        {
            return (Math.PI * pRadius * pRadius);
        }
    }
}
