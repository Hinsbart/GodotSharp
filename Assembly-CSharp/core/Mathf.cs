using System;

namespace GodotEngine
{
    public static class Mathf
    {
        public const float PI = 3.14159274f;

        private const float Deg2RadConst = 0.0174532924f;
        private const float Rad2DegConst = 57.29578f;

        public static float Abs(float s)
        {
            return Math.Abs(s);
        }

        public static float Acos(float s)
        {
            return (float)Math.Acos((double)s);
        }

        public static float Asin(float s)
        {
            return (float)Math.Asin((double)s);
        }

        public static float Atan(float s)
        {
            return (float)Math.Atan((double)s);
        }

        public static float Atan2(float x, float y)
        {
            return (float)Math.Atan2((double)y, (double)x);
        }

        public static float Ceil(float s)
        {
            return (float)Math.Ceiling((double)s);
        }

        public static float Clamp(float val, float min, float max)
        {
            if (val < min)
            {
                return min;
            }
            else if (val > max)
            {
                return max;
            }

            return val;
        }

        public static float Cos(float s)
        {
            return (float)Math.Cos((double)s);
        }

        public static float Cosh(float s)
        {
            return (float)Math.Cosh((double)s);
        }

        public static float Decimals(float step)
        {
            // TODO
            return 0f;
        }

        public static float Deg2Rad(float deg)
        {
            return deg * Deg2RadConst;
        }

        public static float Ease(float s, float curve)
        {
            if (s < 0f)
            {
                s = 0f;
            }
            else if (s > 1.0f)
            {
                s = 1.0f;
            }

            if (curve > 0f)
            {
                if (curve < 1.0f)
                {
                    return 1.0f - Pow(1.0f - s, 1.0f / curve);
                }

                return Pow(s, curve);
            }
            else if (curve < 0f)
            {
                if (s < 0.5f)
                {
                    return Pow(s * 2.0f, -curve) * 0.5f;
                }

                return (1.0f - Pow(1.0f - (s - 0.5f) * 2.0f, -curve)) * 0.5f + 0.5f;
            }

            return 0f;
        }

        public static float Exp(float s)
        {
            return (float)Math.Exp((double)s);
        }

        public static float Floor(float s)
        {
            return (float)Math.Floor((double)s);
        }

        public static float PosMod(float x, float y)
        {
            if (x >= 0f)
            {
                return x % y;
            }
            else
            {
                return y - (-x % y);
            }
        }

        public static float Letp(float from, float to, float weigth)
        {
            return from + (to - from) * Clamp(weigth, 0f, 1f);
        }

        public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }

        public static float Max(float a, float b)
        {
            return (a > b) ? a : b;
        }

        public static int Min(int a, int b)
        {
            return (a < b) ? a : b;
        }

        public static float Min(float a, float b)
        {
            return (a < b) ? a : b;
        }

        public static int NearestPo2(int val)
        {
            val--;
            val |= val >> 1;
            val |= val >> 2;
            val |= val >> 4;
            val |= val >> 8;
            val |= val >> 16;
            val++;
            return val;
        }

        public static float Pow(float x, float y)
        {
            return (float)Math.Pow((double)x, (double)y);
        }

        public static float Rad2Deg(float rad)
        {
            return rad * Rad2DegConst;
        }

        public static float Round(float s)
        {
            return (float)Math.Round((double)s);
        }

        public static float Sign(float s)
        {
            return (s < 0f) ? -1f : 1f;
        }

        public static float Sin(float s)
        {
            return (float)Math.Sin((double)s);
        }

        public static float Sinh(float s)
        {
            return (float)Math.Sinh((double)s);
        }

        public static float Sqrt(float s)
        {
            return (float)Math.Sqrt((double)s);
        }

        public static float Stepify(float s, float step)
        {
            if (step != 0f)
            {
                s = Floor(s / step + 0.5f) * step;
            }

            return s;
        }

        public static float Tan(float s)
        {
            return (float)Math.Tan((double)s);
        }

        public static float Tanh(float s)
        {
            return (float)Math.Tanh((double)s);
        }
    }
}