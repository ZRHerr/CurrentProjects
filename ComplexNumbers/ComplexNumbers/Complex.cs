using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Complex
    {
        //Constructors
        public Complex(int real, int imaginary)
        {
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public Complex(int real)
        {
            this.Real = real;
            this.Imaginary = 0;
        }

        //ints
        public int Real { get; set; }
        public int Imaginary { get; set; }
        // Default hash function
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //String
        public override string ToString()
        {
            return $"({this.Real} + {this.Imaginary}i)";
        }

        //Bools
        //comparing instances of a class against another instance specified as an arg.
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return lhs.Equals(rhs);
        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs.Equals(rhs));
        }
        // Verifies that the type of the param is actually a complex object.
        public override bool Equals(object obj)
        {
            if (obj is Complex)
            {
                Complex compare = (Complex)obj;
                return (this.Real == compare.Real) && (this.Imaginary == compare.Imaginary);
            }
            else
            {
                return false;
            }
        }

        //Implicit & Explicit
        //Converts an int to a complex object by returning a new instance using the constructor
        public static implicit operator Complex(int from)
        {
            return new Complex(from);
        }
        //Takes a complex object and returns the value of the Real property.
        public static explicit operator int(Complex from)
        {
            return from.Real;
        }

        //Overloaded - operators
        //Binary addition operator. Taking 2 complex objects and adding them together.
        public static Complex operator +(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);
        }
        //provides the same form as the complex + operator
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
        }
        //Same operations as above just slightly more complex calculations
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            return new Complex(lhs.Real * rhs.Real - lhs.Imaginary * rhs.Imaginary, lhs.Imaginary * rhs.Real + lhs.Real * rhs.Imaginary);
        }
        //Broken down into two steps to avoid lengthy lines.
        public static Complex operator /(Complex lhs, Complex rhs)
        {
            int realElement = (lhs.Real * rhs.Real + lhs.Imaginary * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);
            int imaginaryElement = (lhs.Imaginary * rhs.Real - lhs.Real * rhs.Imaginary) / (rhs.Real * rhs.Real + rhs.Imaginary * rhs.Imaginary);
            return new Complex(realElement, imaginaryElement);
        }

    }
}
