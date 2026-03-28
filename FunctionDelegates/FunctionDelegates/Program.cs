using System;
namespace FunctionDelegates
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Price:");
            double Price;
            while(!double.TryParse(Console.ReadLine(),out Price)||Price<=0)
            {
                Console.WriteLine("Invalid Number, Please enter valid Number");
            }
            Console.WriteLine("==========================");
            double Discount = CalculateDiscount(Price);                  //CALLING CalculateDiscount  FUNCTION DELEGATE.
            double FinalPrice = CalculateFinalPrice(Price, Discount);   //CALLING  CalculateFinalPrice FUNCTION DELEGATE.
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Discount obtained: " + Discount);
            Console.WriteLine("Final Price: " + FinalPrice);
        }

        //FUNCTION DELEGATE TO CALCULATE DISCOUNT ACCEPTS A PARAMTER OF TYPE DOUBLE
        //AND RETURN THE VALUE WITH TYPE DOUBLE.
       static Func<double, double> CalculateDiscount = price =>
        {
            if (price >=1200)
            {
                Console.WriteLine("You have obtained 15% discount");
                return 0.15 * price; 
            }
            else
            {
                Console.WriteLine("You have obtained 5% discount,Shop more to get additional discount.");
                return 0.05 * price;
            }
        };

        //FUNCTION DELEGATE TO CALCULATE FINAL PRICE ACCEPTS TWO PARAMETERS OF TYPE DOUBLE
        //AND RETURNS THE VALUE WITH TYPE DOUBLE.
        static Func<double,double,double> CalculateFinalPrice = (price,Discount) =>
        {
            return price - Discount;
        };
    }
}