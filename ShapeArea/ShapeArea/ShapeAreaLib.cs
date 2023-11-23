using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeArea
{
    public static class Rectangle
    {
        //   public double Length { get; set; }
        //   public double Width { get; set; }
        //  public double Height { get; set; }
        public static double Area(int Length,int Width,int height)
        {
            return Length * Width * height;
        }
    }
    public static class Square
    {
      //  public double Side { get; set; }
        public static double Area(int Side)
        {
            return Side * Side;
        }

    }
     public static class Circle
    {
        public static double Area(int radius)
        {
            return Math.PI * radius * radius;
        }
    }
    public static class Triangle
    {
        public static double Area(int Base, int Height)
    {
            return 0.5 * Base * Height;
    }
}
       
    

    
       

    //public class ShapeAreaLib
    //{
     
    //}
}
