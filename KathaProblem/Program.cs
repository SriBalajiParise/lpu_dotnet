using System;
namespace KathaProblem;

class Program
{
    public static void Main()
    {
         
         Console.WriteLine("Enter your choice: \n1.Add item\n2.View total amount\n3.view repeated amounts");
         int choice =Int32.Parse(Console.ReadLine());
         
            Katha objKatha = new Katha();

         
         if(choice == 1)
        {
            Console.WriteLine("Enter the item name :");
            string itemName = Console.ReadLine();
            Console.WriteLine("Enter the item price :");
            int itemPrice = Int32.Parse(Console.ReadLine());
            objKatha.AddItem(itemName,itemPrice);

            Console.WriteLine("Item added successfully");
            
        }
        else if (choice == 2)
        {
            Console.WriteLine("The total amount is : {0}",objKatha.GetTotal());
        }
        else if (choice == 3)
        {
            Console.WriteLine("The repated amount is : {0}",objKatha.GetRepeatAmount());
            
        }
        
    }

}