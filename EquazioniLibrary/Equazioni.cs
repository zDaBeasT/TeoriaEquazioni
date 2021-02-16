using System;

namespace EquazioniLibrary
{
    public class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            if(a != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsInconsisted(double a, double b)
        {
            if (a==0 && b!=0)
            {
                return true;
            }
            return false;
        }
        public static bool IsDegree(double c)
        {
            return c == 2;
        }
        public static double Delta(double a, double b, double c)
        {
            return (b * b) - (4 * a * c);
        }
        public static string Eq2Grado(double a, double b, double c)
        {
            double x1, x2;
            double delta = Delta(a, b, c), radiceDelta;
            if(delta > 0)
            {
                radiceDelta = Math.Sqrt(delta);
                x1 = (-b + radiceDelta) / (2 * a);
                x2 = (-b - radiceDelta) / (2 * a);
                return $"x1-{x1} x2-{x2}";
            }else if (delta == 0)
            {
                return $"{-b / 2 * a}";
            }
            else
            {
                return "Non ci sono punti di intersezione";
            }
        }
    }
}
