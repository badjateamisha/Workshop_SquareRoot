// See https://aka.ms/new-console-template for more information

 public class SquareRoot
{
    public static void Main(String[] args)
    {
        double c = 16;
        double epsilon = 1e-15;
        double t = c;

        while(Math.Abs(t- c/t) > epsilon*t)
        {
            t = (c / t + t)/ 2.0;
        }

        Console.WriteLine("Value =" +t);

    }
    
}
