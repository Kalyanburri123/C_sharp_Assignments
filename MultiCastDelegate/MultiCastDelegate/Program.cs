using System;
namespace MultiCastDelegate
{
    class Program
    {

        //Declared a delegate.
        public delegate void Notify(string message);
        public static void Main(string[] args)
        {
            // Multicast delegate
            Notify notify = new Notify(SendEmail);

            // Adding methods
            //notify += SendEmail;
            notify += SendSMS;
            notify += SendWhatsApp;

            // Invoking the delegate
            notify("Order Placed");

            // Remove SMS
            notify -= SendSMS;

            Console.WriteLine("---- After Removing SMS ----");
            notify("Order Shipped");
            notify -= SendWhatsApp;
            Console.WriteLine("---- After Removing Whatsapp ----");
            notify("Order Received");
        }
        public static void SendEmail(string message)
        {
            Console.WriteLine("Email Sent: " + message);
        }

        public static void SendSMS(string message)
        {
            Console.WriteLine("SMS Sent: " + message);
        }

        public static void SendWhatsApp(string message)
        {
            Console.WriteLine("WhatsApp Sent: " + message);
        }
    }
}