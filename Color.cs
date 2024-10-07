using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCode
{
    internal class Color
    {
        public Color() { }
        #region calculator
        private double max(double a, double b, double c)
        {
            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            return max;
        }
        private double min(double a, double b, double c)
        {
            double min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            return min;
        }
        private double mod(double a, double b)
        {
            return a < 0 ? a : a % b;
        }
        #endregion
        #region base_number_change
        private string decimal_to_hexa(int n)
        {
            int k = n;
            if (n < 0) return "";
            string hexa = "";
            while (n>0)
            {
                int i = n % 16;
                if(i<10) hexa = i + hexa;
                else
                {
                    switch (i)
                    {
                        case 10: hexa = "A" + hexa; break;
                        case 11: hexa = "B" + hexa; break;
                        case 12: hexa = "C" + hexa; break;
                        case 13: hexa = "D" + hexa; break;
                        case 14: hexa = "E" + hexa; break;
                        case 15: hexa = "F" + hexa; break;
                        default: hexa = "" + hexa; break;
                    }
                }
                n /= 16;
            }
            if (k<16) hexa = "0" + hexa;
            return hexa;
        }
        private int hexa_to_decimal(string hexa)
        {
            int n = 0, t = 1;
            for(int i = hexa.Length - 1; i>=0; i--)
            {
                if (hexa[i] >= '0' && hexa[i] <='9')
                {
                    n += t * int.Parse(hexa[i].ToString());
                }
                else
                {
                    switch(hexa[i])
                    {
                        case 'A': n += t * 10; break;
                        case 'B': n += t * 11; break;
                        case 'C': n += t * 12; break;
                        case 'D': n += t * 13; break;
                        case 'E': n += t * 14; break;
                        case 'F': n += t * 15; break;
                    }
                }
                t *= 16;
            }
            return n;
        }
        #endregion
        #region color_code_change
        public string RGBToHex(int red, int green, int blue)
        {
            return decimal_to_hexa(red) + decimal_to_hexa(green) + decimal_to_hexa(blue);
        }
        public string HexToRGB(string hexa)
        {
            string[] hex = new string[3];
            hex[0] = hexa[0] + "" + hexa[1];
            hex[1] = hexa[2] + "" + hexa[3];
            hex[2] = hexa[4] + "" + hexa[5];
            int red = hexa_to_decimal(hex[0]);
            int green = hexa_to_decimal(hex[1]);
            int blue = hexa_to_decimal(hex[2]);
            return + red + "," + green + "," + blue;
        }
        public string RGBToCMYK(int r, int g, int b)
        {
            string CMYK = "";
            double r1 = 1.0 * r / 255;
            double g1 = 1.0 * g / 255;
            double b1 = 1.0 * b / 255;
            double K = 1.0-max(r1, g1, b1);
            double C = (1 - r1 - K) / (1 - K)*100;
            double M = (1 - g1 - K) / (1 - K)*100;
            double Y = (1 - b1 - K) / (1 - K)*100;
            CMYK = Math.Round(C, 0) + "," + Math.Round(M, 0) + "," + Math.Round(Y, 0) + "," + Math.Round(K*100, 0); 
            return CMYK;
        }
        public string CMYKToRGB(int C, int M, int Y, int K) 
        {
            double C1 = C / 100 * 1.0;
            double M1 = M / 100 * 1.0;
            double Y1 = Y / 100 * 1.0;
            double K1 = K / 100 * 1.0;
            int R = (int)Math.Round(255 * (1 - C1) * (1 - K1));
            int G = (int)Math.Round(255 * (1 - M1) * (1 - K1));
            int B = (int)Math.Round(255 * (1 - Y1) * (1 - K1));
            return R + "," + G + "," + B;
        }
        public string RGBToHSL(int r, int g, int b)
        {
            double H, S, L;
            double r1 = (double)r / 255;
            double g1 = (double)g / 255;
            double b1 = (double)b / 255;
            double cmax = max(r1, g1, b1);
            double cmin = min(r1, g1, b1);
            double delta = cmax - cmin;
            L = (cmax + cmin) / 2;
            if (delta == 0) S = 0;
            else if(L <= 0.5) S =delta/(cmax + cmin);
            else S = delta/(2 - cmax - cmin);
            if (delta == 0) H = 0;
            else if (cmax == r1) H = mod(60 * (g1 - b1) / delta, 6);
            else if (cmax == g1) H = 60 * ((b1 - r1) / delta + 2);
            else H = 60 * ((r1 - g1) / delta + 4);
            if (H < 0) H += 360;
            return H + "," + Math.Round(S*100, 1) + "," + Math.Round(L*100, 1);
        }
        #endregion
    }
}
