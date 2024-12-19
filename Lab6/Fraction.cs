using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Fraction : ICloneable, InterfaceFraction
    {
        private int numerator;
        private int denominator;

        public Fraction(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен 0!");
            }

            if (denom < 0)
            {
                num = -num;
                denom = -denom;
            }
            numerator = num;
            denominator = denom;

        }

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }

        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Значение знаменателя не может быть равно 0");
                }
                denominator = value;
            }
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int numerator_op = f1.numerator * f2.denominator + f2.numerator * f1.denominator;
            int denominator_op = f1.denominator * f2.denominator;
            return new Fraction(numerator_op, denominator_op);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int numerator_op = f1.numerator * f2.denominator - f2.numerator * f1.denominator;
            int denominator_op = f1.denominator * f2.denominator;
            return new Fraction(numerator_op, denominator_op);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            int numerator_op = f1.numerator * f2.numerator;
            int denominator_op = f1.denominator * f2.denominator;
            return new Fraction(numerator_op, denominator_op);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {

            int numerator_op = f1.numerator * f2.denominator;
            int denominator_op = f1.denominator * f2.numerator;
            return new Fraction(numerator_op, denominator_op);
        }

        public static Fraction operator +(Fraction f1, int x)
        {
            return f1 + new Fraction(x, 1);
        }
        public static Fraction operator -(Fraction f1, int x)
        {
            return f1 - new Fraction(x, 1);
        }
        public static Fraction operator *(Fraction f1, int x)
        {
            return f1 * new Fraction(x, 1);
        }
        public static Fraction operator /(Fraction f1, int x)
        {
            return f1 / new Fraction(x, 1);
        }


        public static bool operator ==(Fraction f1, Fraction f2)
        {
            if (ReferenceEquals(f1, null) || ReferenceEquals(f2, null))
            {
                return ReferenceEquals(f1, f2);
            }

            
            return f1.Numerator * f2.Denominator == f2.Numerator * f1.Denominator;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public object Clone()
        {
            return new Fraction(this.numerator, this.denominator);
        }

        public double GetDecimalValue()
        {
            return (double)numerator / denominator;
        }

        public void SetNumerator(int numer)
        {
            numerator = numer;
        }

        public void SetDenominator(int denomin)
        {
            if (denomin == 0)
            {
                throw new ArgumentException("Значение знаменателя не может быть равно 0");
            }
            denominator = denomin;
        }
    }
}
