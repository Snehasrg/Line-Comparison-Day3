namespace Line_Comparison_Problem
{
    public class Length
    {
        public static void calculatelength()
        {
            double x1, x2, y1, y2;
            double lengthofline;

            Console.WriteLine("Enter First Line(x1,y1)");
            x1= Convert.ToDouble(Console.ReadLine());
            y1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Line(x2,y2)");
            x2= Convert.ToDouble(Console.ReadLine());
            y2= Convert.ToDouble(Console.ReadLine());

            lengthofline = Math.Sqrt((x2 - x1)*(x2-x1) + (y2 - y1)*(y2-y1));
            Console.WriteLine("The length between First Line and Second Line is" + lengthofline);

        }
    }
}
