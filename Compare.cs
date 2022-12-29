namespace Line_Comparison_Problem
{
    public class Compare
    {
        public static void checkcomparison()
        {
            double x1, x2, y1, y2, a1, a2, b1, b2;
            double lengthoffirstline = 0; 
                double lengthofsecondline=1;

            Console.WriteLine("Enter the value of (x1,y1)");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (x2,y2)");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (d1,b1)");
            a1 = Convert.ToDouble(Console.ReadLine());
            b1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of (d2,b2)");
            a2 = Convert.ToDouble(Console.ReadLine());
            b2 = Convert.ToDouble(Console.ReadLine());

             lengthoffirstline = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            Console.WriteLine("The length of firstline" + lengthoffirstline);

            lengthofsecondline = Math.Sqrt((a2 - a1) * (a2 - a1) + (b2 - b1) * (b2 - b1));
            Console.WriteLine("The length of secondline" + lengthofsecondline);

            int comparelength = lengthoffirstline.CompareTo(lengthofsecondline);
            if(comparelength >0)
            {
                Console.WriteLine("length of first line greater than length of second line" ,lengthoffirstline, lengthofsecondline);
            }

            else if (comparelength<0)
            {
                Console.WriteLine("length of first line less than length of second line" ,lengthoffirstline, lengthofsecondline);
            }
            else
            {
                Console.WriteLine("length of first line equal to length of second line" ,lengthoffirstline, lengthofsecondline);
            }
        }
    }
}
