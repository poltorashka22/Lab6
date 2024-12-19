using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Fraction_cache : InterfaceFraction
    {
        private readonly InterfaceFraction fraction;
        private double? cached_real_value;

        public Fraction_cache(InterfaceFraction fract)
        {
            fraction = fract;
            cached_real_value = null;
        }

        public double GetDecimalValue()
        {
            if (cached_real_value == null)
            {
                cached_real_value = fraction.GetDecimalValue();
            }
            return cached_real_value.Value;
        }

        public void SetNumerator(int numerator)
        {
            fraction.SetNumerator(numerator);
            cached_real_value = null;
        }

        public void SetDenominator(int denominator)
        {
            fraction.SetDenominator(denominator);
            cached_real_value = null;
        }

        public override string ToString()
        {
            return fraction.ToString();  // Делегируем вызов ToString() классу Fraction
        }
    }


}
