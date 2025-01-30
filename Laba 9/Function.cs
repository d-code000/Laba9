namespace Laba_9;

public class Function
{
    public static double Calc(double x)
    {
        return
            Math.Pow
            (
                Math.Log(Math.Sin(Math.Pow(x, 3) + 0.0025)),
                3.0 / 2
            ) +
            0.8 * Math.Pow(10, -3);
    }
}