using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind3_Isomatov_h_v3
{
    public class Vector
    {
        double x { get; set; }
        double y { get; set; }
        double z { get; set; }

        public Vector(double A, double B, double C)
        {
            x = A;
            y = B;
            z = C;
            
        }
        public Vector(string coordinate)
        {
            string[] coor = (coordinate.Split('.'));
            x = Convert.ToDouble(coor[0]);
            y = Convert.ToDouble(coor[1]);
            z = Convert.ToDouble(coor[2]);
        }
        public static bool isCoordinate(string coor)
        {
            bool correct = true;
            if (coor != "" && coor.IndexOf('.') != 0 && coor.IndexOf('.') != coor.Length - 1)
            {
                for (int i = 1; i < coor.Length; i++)
                {
                    if (coor[i - 1] == '.' && coor[i] == '.')
                    {
                        correct = false;
                        break;
                    }
                }
                if (correct)
                {
                    return true;
                }
                else
                    return false;

            }
            else
                return false;
        }
            public Vector Plus(Vector vectB)
        {
            double A = x + vectB.x;
            double B = y + vectB.y;
            double C = z + vectB.z;
            return new Vector(A, B, C);
        }
        public Vector Minus(Vector vectB)
        {
            double A = x - vectB.x;
            double B = y - vectB.y;
            double C = z - vectB.z;
            return new Vector(A,B,C);
        }
        public double Multiply(Vector B)
        {
            double A = x * B.x + y * B.y + z * B.z;
            return A;
        }
        public double Length()
        {
            double length = Math.Sqrt(Math.Pow(x,2)+ Math.Pow(y, 2)+ Math.Pow(z, 2));
            return Math.Abs(length);
        }
        public string FullVectorCoordinate()
        {
            return $"{x}.{y}.{z}";
        }

    }
}
