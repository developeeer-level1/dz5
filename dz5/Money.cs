using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Money
    {
        public int Hryvnas { get; set; }
        public int Kopecks { get; set; }
        public Money(int hryvnas, int kopecks)
        {
            Hryvnas = hryvnas + kopecks / 100;
            Kopecks = kopecks % 100;
            Normalize();
        }
        private void Normalize()
        {
            if (Kopecks < 0 || Hryvnas < 0)
            {
                throw new WrongEntering("Bankrupt: the amount cannot be taken into account");
            }
        }
        public static Money operator +(Money a, Money b)
        {
            return new Money(a.Hryvnas + b.Hryvnas, a.Kopecks + b.Kopecks);
        }
        public static Money operator -(Money a, Money b)
        {
            return new Money(a.Hryvnas - b.Hryvnas, a.Kopecks - b.Kopecks);
        }
        public static Money operator *(Money a, int multiplier)
        {
            return new Money(a.Hryvnas * multiplier, a.Kopecks * multiplier);
        }
        public static Money operator /(Money a, int divisor)
        {
            if (divisor == 0) throw new DivideByZeroException("Dividing by zero is impossible");
            int totalKopecks = (a.Hryvnas * 100 + a.Kopecks) / divisor;
            return new Money(totalKopecks / 100, totalKopecks % 100);
        }
        public static bool operator ==(Money a, Money b)
        {
            return a.Hryvnas == b.Hryvnas && a.Kopecks == b.Kopecks;
        }
        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
        public static bool operator >(Money a, Money b)
        {
            return (a.Hryvnas * 100 + a.Kopecks) > (b.Hryvnas * 100 + b.Kopecks);
        }
        public static bool operator <(Money a, Money b)
        {
            return (a.Hryvnas * 100 + a.Kopecks) < (b.Hryvnas * 100 + b.Kopecks);
        }
        public static Money operator ++(Money a)
        {
            return new Money(a.Hryvnas, a.Kopecks + 1);
        }
        public static Money operator --(Money a)
        {
            return new Money(a.Hryvnas, a.Kopecks - 1);
        }
        public override string ToString()
        {
            return $"{Hryvnas} UAH {Kopecks} kopecks.";
        }
    }
}
