using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.main.classwork.lesson10
{
    public class Line
    {
        private Pixel[] point = new Pixel[2]; 

         public Line (Pixel point0, Pixel point1)
         {
               this.point[1] = point0;
               this.point[2] = point1;
          }
        public void DoublePixel (Pixel pix)
        {
            int l = point.Length;

            Pixel[] NewPoint = new Pixel[l + 1];//dobalenie odnoi dop coordinate
            for (int i = 0; i <= l; i++)
            {
                NewPoint[i] = point[i];
                if ( i == l)
                {
                    NewPoint[i] = pix;
                }
            }
            //point = NewPoint;
        }

    }
}


