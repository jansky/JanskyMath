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
    
    //String format should be (x,y)
    public Point(string pointAsString)
    {
      x = Convert.ToDouble(pointAsString[1]);
      y = Convert.ToDouble(pointAsString[3]);
    }
    
    public string ToString()
    {
      return "(" + Convert.ToString(x) + "," + Convert.ToString(y) + ")";
    }
    
    
  }
    

    
    public class Segment
    {
      public Point StartPoint;
      public Point EndPoint;
      public Fraction Slope;
      
      public Segment (Point sp, Point ep)
      {
        StartPoint = sp;
        EndPoint = ep;
        
        //Calculate the slope
        Slope = new Fraction(ep.y - sp.y, ep.x - sp.x);
      }
      
      public Segment (Point sp, Point ep, Fraction segmentSlope)
      {
        StartPoint = sp;
        EndPoint = ep;
        
        Slope = segmentSlope;
      }
    }
    
    public class Operations
    {
      public static Fraction CalculateSlope(Point p1, Point p2)
      {
        return new Fraction(p2.y - p1.y, p2.x - p1.x);
      }
      
      public static Point CalculateMidpoint(Segment s)
      {
        double x1 = s.StartPoint.x;
        double x2 = s.EndPoint.x;
        
        double y1 = s.StartPoint.y;
        double y2 = s.EndPoint.y;
        
        
        double xMean = (x1 + x2) / 2;
        double yMean = (y1 + y2) / 2;
        
        return new Point(xMean, yMean);
        
        
      }
    }
  }
