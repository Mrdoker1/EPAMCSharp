using System;

namespace DartsGame
{
    public static class Darts
    {
        public static int GetScore(double x, double y)
        {
            try
            {
                double hypotenuse = Math.Sqrt((x * x) + (y * y));

                if (hypotenuse <= 10 && hypotenuse > 0)
                {
                    if (hypotenuse <= 5)
                    {
                        if (hypotenuse <= 1)
                        {
                            return 10;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch
            {
                throw new NotImplementedException("You need to implement this method.");
            }
        }
    }
}