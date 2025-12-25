using System;
namespace December23Prob;
class Program
{
    public static void Main()
    {

        Desktop a=new Desktop();
        Laptop b=new Laptop();

        Console.WriteLine("Select the device: ");
        Console.WriteLine("1.Desktop \n2.Laptop");
        int choice=Int32.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("Enter the processor" );
            a.processor=Console.ReadLine();
            Console.WriteLine("Enter the ram size: ");
            a.ram_size=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size");
            a.hard_disk=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size");
            a.graphic_card=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monitor size");
            a.monitor_size=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power supply");
            a.power_supply=Int32.Parse(Console.ReadLine());

            Console.WriteLine("The price of the desktop is: "+a.DesktopPriceCalculation()); 

        }
        else
        {
            Console.WriteLine("Enter the processor" );
            b.processor=Console.ReadLine();
            Console.WriteLine("Enter the ram size: ");
            b.ram_size=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size");
            b.hard_disk=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size");
            b.graphic_card=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the display size");
            b.display_size=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the battery volt");
            b.battery_volt=Int32.Parse(Console.ReadLine());

            Console.WriteLine("The price of the laptop is: "+b.LaptopPriceCalculation());
        }



    }
}