using System;

namespace ClassAndObject.OperasiMatematika
{
    public class Kalkulator
    {
        public double Tambah(double a, double b)
        {
            return a + b;
        }

        public double Kurang(double a, double b)
        {
            return a - b;
        }

        public double Kali(double a, double b)
        {
            return a * b;
        }

        public double Bagi(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                return double.PositiveInfinity;
            }
        }
    }

}
