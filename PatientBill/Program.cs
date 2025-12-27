using System;
namespace PatientBill;

class Patient
{
    public static void Main()
    {
        bool status =true;

        while (status == true){


        PatientBill obj=new PatientBill();

        Console.WriteLine("\n*************************** Medisure Clinic Billing ***************************");
        Console.WriteLine("1.Create new bill \n2.View  last bill\n3.Clear last bill\n4.Exit");
        Console.Write("Enter your option : ");
        int option=Int32.Parse(Console.ReadLine());

        if(option == 1)
        {
            Console.Write("Enter bill ID : ");
            obj.BillID=Console.ReadLine();

            Console.Write("Enter the patient name : ");
            obj.PatientName=Console.ReadLine();

            Console.Write("Is the patient insured ?  (Y/N)");
            string hasInsurance=Console.ReadLine();
            if (hasInsurance == "Y")
            {
                obj.HasInsurance=true;
            }
            else if (hasInsurance == "N")
            {
                obj.HasInsurance=false;
            }
            

            Console.Write("Enter consultation fee : ");
            obj.ConsultationFee=double.Parse(Console.ReadLine());

            Console.Write("Enter lab charges: ");
            obj.LabCharges=double.Parse(Console.ReadLine());

            Console.Write("Enter Medicine charges: ");
            obj.MedicineCharges=double.Parse(Console.ReadLine());

            
            
            Console.WriteLine("\nBill created successfully");
            Console.WriteLine("\n\nGross Amount: {0:F2}",obj.GrossAmount());
            Console.WriteLine("Discount Amount: {0:F2}",obj.DiscountAmount());
            Console.WriteLine("Payable Amount: {0:F2}",obj.FinalPayable());

            
            PatientBill.LastBill=obj;
            PatientBill.HasLastBill=true;

            
        }
        else if (option == 2)
        {
                if (!PatientBill.HasLastBill)
                {
                    Console.WriteLine("No bill available. Please create a new bill first");
                }
                else
                {
                    PatientBill lastBillObj = PatientBill.LastBill;

                    Console.WriteLine("\n===============Last Bill===============");
                    Console.WriteLine("Bill Id is : {0}",lastBillObj.BillID);
                    Console.WriteLine("Patient name: {0}",lastBillObj.PatientName);
                    Console.WriteLine("Is the patient Insured: {0}",lastBillObj.HasInsurance);
                    Console.WriteLine("Consultation Fees: {0:F2}",lastBillObj.ConsultationFee);
                    Console.WriteLine("Lab charges: {0:F2}",lastBillObj.LabCharges);
                    Console.WriteLine("Medicine Charges: {0:F2}",lastBillObj.MedicineCharges);
                    Console.WriteLine("Gross Amount: {0:F2}",lastBillObj.GrossAmount());
                    Console.WriteLine("Discount Amount: {0:F2}",lastBillObj.DiscountAmount());
                    Console.WriteLine("Final Payable amount: {0:F2}",lastBillObj.FinalPayable());
                }
            
        }
        else if (option == 3)
        {
            PatientBill.HasLastBill=false;

            Console.WriteLine("\nLast bill cleared.");

            
        }
        else if (option == 4)
        {
            status =false;
            Console.Write("\nThank you .Application closed normally");   
        }
            else
            {
                Console.Write("\nChoose from the above options only!.");
            }



    }

    }
}