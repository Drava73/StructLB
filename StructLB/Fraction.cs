using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace StructLB
{
  
        internal struct Fraction1
        {
            int numerator;
            int denominator;

            Fraction1(int n, int d) { numerator = n; denominator = d; }
            public static Fraction1 operator +(Fraction1 f1, Fraction1 f2)
            {
                return new Fraction1(
                    f1.numerator + f2.numerator,
                    f1.denominator + f2.denominator
                );
            }
            public static Fraction1 operator -(Fraction1 f1, Fraction1 f2)
            {
                return new Fraction1(
                    f1.numerator - f2.numerator,
                    f1.denominator - f2.denominator
                );
            }
            public static Fraction1 operator *(Fraction1 f1, Fraction1 f2)
            {
                return new Fraction1(
                    f1.numerator * f2.numerator,
                    f1.denominator * f2.denominator
                );
            }
            public static Fraction1 operator /(Fraction1 f1, Fraction1 f2)
            {
                return new Fraction1(
                    f1.numerator / f2.numerator,
                    f1.denominator / f2.denominator
                );
            }
        }
    }
