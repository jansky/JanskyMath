namespace System;

namespace JanskyMath
{
  public class Point
  {
    public double x {get; set;}
    public double y {get; set;}
    
    public Point(double xarg, double yarg)
    {
      x = xarg;
      y = yarg;
    }
    
    public class Line
    {
      public List<Point> Points = new List<Point>();
      public Fraction Slope;
      
      public Line(Point p1, Point p2)
      {
        Points.Add(p1);
        Points.Add(p2);
        
        //Calculate the slope
        Slope = new Fraction(p2.y - p1.y, p2.x - p1.x);
      }
    }
  }
