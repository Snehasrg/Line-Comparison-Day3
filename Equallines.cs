namespace Line_Comparison_Problem
{
    public class Equallines
    {
        public  static void checkequallines()
        {
            double x1, x2, y1, y2,a1,a2,b1,b2;

            Console.WriteLine("Enter the value of (x1,y1)");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (x2,y2)");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (d1,b1)");
            a1= Convert.ToDouble(Console.ReadLine());
            b1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (d2,b2)");
            a2= Convert.ToDouble(Console.ReadLine());
            b2= Convert.ToDouble(Console.ReadLine());

           double lengthoffirstline = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The length of firstline" + lengthoffirstline);

            double lengthofsecondline = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            Console.WriteLine("The length of secondline" + lengthofsecondline);

            Console.WriteLine("Length of two lines are:" + lengthoffirstline ,"Equals" + lengthofsecondline);


        }
    }
}
