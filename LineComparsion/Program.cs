using System.Security.Cryptography.X509Certificates;

namespace LineComparsion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program");

            Console.WriteLine("Enter all the Points");
            int x1 =Convert.ToInt32(Console.ReadLine());
            int x2 =Convert.ToInt32(Console.ReadLine());
            int y1 =Convert.ToInt32(Console.ReadLine());
            int y2 =Convert.ToInt32(Console.ReadLine());

            double line1 = Math.Pow((x2 - x1), 2);
            double line2 = Math.Pow((y2 - y1), 2);
            double length = line1 + line2;
            double lengthOfLine = Math.Sqrt(length);

            Console.WriteLine("Lenth Of Line :" + lengthOfLine);
            

        }
    }
}