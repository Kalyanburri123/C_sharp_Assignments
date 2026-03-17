namespace CommandLineDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            int average = 0;
            int max = 0;
            int min = int.Parse(args[0]);
            int count = args.Length;
            Console.WriteLine($"The count of total numbers are :{count}");
            for(int i=0;i<args.Length; i++)
            {

                sum = sum + int.Parse(args[i]);
            }
            for(int i=0;i<args.Length;i++)
            {
                max = Math.Max(max, int.Parse(args[i]));
                min=Math.Min(min,int.Parse(args[i]));
            }
            Console.WriteLine($"The sum of Numbers is {sum}");
            Console.WriteLine($"The average of numbers is {(double)sum / count}");
            Console.WriteLine($"The max of Numbers is {max}");
            Console.WriteLine($"The min of Numbers is {min}");
        }
    }
}