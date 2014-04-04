using System;

namespace JanskyFractions
{
  class Fraction
  {
    public double numerator {get; set;}
    public double denominator {get; set;}
    
    public Fraction(double n, double d)
    {
      numerator = n;
      denominator = d;
    }
    
    public double ConvertToDecimal()
    {
      return numerator / denominator;
    }
    
    
  }
  
  class FractionOperations
  {
    public static Fraction MultiplyFractions(Fraction f, Fraction f1)
    {
      double newDenominator = f.denominator * f1.denominator;
      double newNumerator = f.numerator * f1.numerator;
      
      return new Fraction(newNumerator, newDenominator);
    }
    
    public static Fraction Reciprocal(Fraction f)
    {
      double newDenominator = f.numerator;
      double newNumerator = f.denominator;
      
      return new Fraction(newNumerator, newDenominator);
    }
    
    public static Fraction DivideFractions(Fraction f, Fraction f1)
    {
      Fraction reciprocal = Reciprocal(f1);
      
      Fraction dividedF = MultiplyFractions(f, reciprocal);
      
      return dividedF;
    }
  }
