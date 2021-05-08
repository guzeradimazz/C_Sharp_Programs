using System;
using System.Text.RegularExpressions;

namespace _7Lab
{
    public class Fraction : ICloneable, IComparable<Fraction>, IFormattable, IConvertible
    {
        private long num;
        private long den;

        public long Num { get => num; set => SetNum(value); }
        public long Den { get => den; set => SetDen(value); }

        public Fraction()
        {
        }
        public Fraction(long num, long den)
        {
            Num = num;
            Den = den;
        }

        public Fraction(double x)
        {
            Fraction fraction = GetFraction(x.ToString());
            Num = fraction.num;
            Den = fraction.den;
        }

        public void SetNum(long NewNum)
        {
            num = NewNum;
        }

        public void SetDen(long NewDen)
        {
            if (NewDen == 0)
            {
                throw new ArgumentException("Denominator can't be equal to zero.");
            }
            else if (NewDen < 0)
            {
                throw new ArgumentException("Denominator must be a natural number.");
            }
            den = NewDen;
        }

        private double GetDouble() => (double)num / den;

        private static long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a %= b;
                }
                else
                {
                    b %= a;
                }
            }
            return a + b;
        }
        public static Fraction GetFraction(string s)
        {
            if (TryParse(s, out Fraction fraction))
            {
                return fraction;
            }
            else
            {
                throw new FormatException("Incorrect format.");
            }
        }
        public static bool TryParse(string s, out Fraction fraction)
        {
            fraction = null;
            //exist checking
            Regex firstPattern = new Regex(@"^(-?\d+)/(\d+)$");
            Regex secondPattern = new Regex(@"^(-?\d+)\((\d+)/(\d+)\)$");
            Regex thirdPattern = new Regex(@"^(-?\d+)[,\.](\d+)$");
            Regex fourthPattern = new Regex(@"^(-?\d+)$");

            if (firstPattern.IsMatch(s))
            {
                Match match = firstPattern.Match(s);
                long num = long.Parse(match.Groups[1].Value);
                long den = long.Parse(match.Groups[2].Value);
                fraction = new Fraction(num, den);
                return true;
            }
            else if (secondPattern.IsMatch(s))
            {
                Match match = secondPattern.Match(s);
                long integer = long.Parse(match.Groups[1].Value);
                long num = long.Parse(match.Groups[2].Value);
                long den = long.Parse(match.Groups[3].Value);
                int sign = integer >= 0 ? 1 : -1;
                fraction = new Fraction(sign * (Math.Abs(integer) * den + num), den);
                return true;
            }
            else if (thirdPattern.IsMatch(s))
            {
                Match match = thirdPattern.Match(s);
                long integer = long.Parse(match.Groups[1].Value);
                int sign = integer >= 0 ? 1 : -1;
                string dec = match.Groups[2].Value;
                long den = (long)Math.Pow(10, dec.Length);
                long num = (Math.Abs(integer) * den + long.Parse(dec)) * sign;
                fraction = new Fraction(num, den);
                return true;
            }
            else if (fourthPattern.IsMatch(s))
            {
                Match match = fourthPattern.Match(s);
                fraction = new Fraction(long.Parse(match.Groups[1].Value));
                return true;
            }
            return false;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != GetType())
            {
                return false;
            }
            return CompareTo((Fraction)obj) == 0;
        }
        public override string ToString() => ToString("S");
        public object Clone()
        {
            return new Fraction(num, den);
        }

        public int CompareTo(Fraction fraction)
        {
            long lcm = den * fraction.den / Gcd(Math.Abs(den), fraction.den);
            long num1 = num * (lcm / den);
            long num2 = fraction.num * (lcm / fraction.den);
            return num1.CompareTo(num2);
        }

        public string ToString(string format) => ToString(format, null);
        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
            {
                format = "S";
            }

            if (format == "S")
            {
                return $"{num}/{den}";
            }
            else if (format == "M")
            {
                if (Math.Abs(num) > den && den != 1)
                {
                    long integer = num / den;
                    return $"{integer}({Math.Abs(num) % den}/{den})";
                }
                else
                {
                    return ToString("I");
                }
            }
            else if (format == "D")
            {
                return GetDouble().ToString();
            }
            else if (format == "I")
            {
                if (Math.Abs(num) > den)
                {
                    long integer = num / den;
                    return integer.ToString();
                }
                else
                {
                    return ToString("S");
                }
            }
            else
            {
                throw new FormatException("format incorrect.");
            }
        }

        public TypeCode GetTypeCode()=> TypeCode.Object;

        public bool ToBoolean(IFormatProvider provider) => num != 0;
        public byte ToByte(IFormatProvider provider)=> Convert.ToByte(GetDouble(), provider);
        public char ToChar(IFormatProvider provider)=> Convert.ToChar(GetDouble(), provider);
        public DateTime ToDateTime(IFormatProvider provider)=> Convert.ToDateTime(GetDouble(), provider);
        public decimal ToDecimal(IFormatProvider provider)=> Convert.ToDecimal(GetDouble(), provider);
        public double ToDouble(IFormatProvider provider)=> GetDouble();
        public short ToInt16(IFormatProvider provider)=> Convert.ToInt16(GetDouble(), provider);
        public int ToInt32(IFormatProvider provider)=> Convert.ToInt32(GetDouble(), provider);
        public long ToInt64(IFormatProvider provider)=> Convert.ToInt64(GetDouble(), provider);
        public SByte ToSByte(IFormatProvider provider)=> Convert.ToSByte(GetDouble(), provider);
        public float ToSingle(IFormatProvider provider)=> Convert.ToSingle(GetDouble(), provider);
        public string ToString(IFormatProvider provider)=> ToString("S", provider);
        public object ToType(Type conversionType, IFormatProvider provider)=> Convert.ChangeType(GetDouble(), conversionType);
        public UInt16 ToUInt16(IFormatProvider provider)=> Convert.ToUInt16(GetDouble(), provider);
        public UInt32 ToUInt32(IFormatProvider provider)=> Convert.ToUInt32(GetDouble(), provider);
        public UInt64 ToUInt64(IFormatProvider provider)=> Convert.ToUInt64(GetDouble(), provider);
        //yavno
        public static explicit operator sbyte(Fraction x)=> x.ToSByte(null);
        public static explicit operator short(Fraction x)=> x.ToInt16(null);
        public static explicit operator int(Fraction x)=> x.ToInt32(null);
        public static explicit operator long(Fraction x)=> x.ToInt64(null);
        public static explicit operator float(Fraction x)=> x.ToSingle(null);
        public static explicit operator double(Fraction x)=> x.ToDouble(null);
        public static explicit operator decimal(Fraction x)=> x.ToDecimal(null);
        //operations...
        public static Fraction operator +(Fraction x) => x;
        public static Fraction operator -(Fraction x) => new Fraction(-x.num, x.den);
        public static Fraction operator +(Fraction a, Fraction b) => new Fraction(a.num * b.den + b.num * a.den, a.den * b.den);
        public static Fraction operator -(Fraction a, Fraction b) => a + (-b);
        public static Fraction operator *(Fraction a, Fraction b) => new Fraction(a.num * b.num, a.den * b.den);
        public static Fraction operator *(Fraction a, long b) => new Fraction(a.num * b, a.den);
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num * b.den, a.den * b.num);
        }
        public static Fraction operator /(Fraction a, long b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return new Fraction(a.num, a.den * b);
        }
        //comparing...
        public static bool operator ==(Fraction first, Fraction second)
        {
            first.num *= second.den;
            second.num *= first.den;
            if (first.num == second.num) return true;
            else return false;
        }
        public static bool operator !=(Fraction first, Fraction second)
        { 
            first.num *= second.den;
            second.num *= first.den;
            if (first.num != second.num) return true;
            else return false;
        }
        public static bool operator >(Fraction first, Fraction second)
        {
            first.num *= second.den;
            second.num *= first.den;
            if (first.num > second.num) return true;
            else return false;
        }
        public static bool operator <(Fraction first, Fraction second)
            {
            first.num *= second.den;
            second.num *= first.den;
            if (first.num < second.num) return true;
            else return false;
        }
        public static bool operator >=(Fraction first, Fraction second)
        {
            first.num *= second.den;
            second.num *= first.den;
            if (first.num >= second.num) return true;
            else return false;
        }
        public static bool operator <=(Fraction first, Fraction second)
        {
            first.num *= second.den;
            second.num *= first.den;
            if (first.num <= second.num) return true;
            else return false;
        }
    }


class Program
    {
        static void Main()
        {
            Console.WriteLine("Standart operations:");
            var DecimalOne = new Fraction(1, 2);
            var DecimalSecond = new Fraction(2, 3);
            var DecimalSum = DecimalOne + DecimalSecond;
            Console.WriteLine(DecimalSum);
            var DecimalThird = new Fraction(4, 5);
            var DecimalForth = new Fraction(6, 7);
            var DecimalMultiple = DecimalThird * DecimalForth;
            Console.WriteLine(DecimalMultiple);
            var DecimalClonned = DecimalOne.Clone();
            Console.WriteLine(DecimalClonned);
            
            Console.WriteLine("Decimal in different formats:");
            Fraction DecimalConvartion = new Fraction(8, 9);
            Console.WriteLine("{0:S}", DecimalConvartion);
            Console.WriteLine("{0:M}", DecimalConvartion);
            Console.WriteLine("{0:D}", DecimalConvartion);
            Console.WriteLine("{0:I}", DecimalConvartion);

            Console.WriteLine("Coversion:");
            Console.WriteLine((short)DecimalConvartion);
            Console.WriteLine((int)DecimalConvartion);
            Console.WriteLine((long)DecimalConvartion);
            Console.WriteLine((float)DecimalConvartion);
            Console.WriteLine((double)DecimalConvartion);
            Console.WriteLine(Convert.ToBoolean(DecimalConvartion));
            Console.WriteLine(Convert.ToString(DecimalConvartion));

            Console.WriteLine("Comparing:");
            var DecimalFifth = new Fraction(10, 11);
            var DecimalSix = new Fraction(12, 13);
            Console.WriteLine(DecimalFifth > DecimalSix);
            Console.WriteLine(DecimalFifth != DecimalSix);

            Console.ReadKey();
        }
    }
}