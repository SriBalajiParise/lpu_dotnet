using System;

namespace PatientBill;

public class PatientBill
{
        public string BillID{get;set;}
        public string PatientName{get;set;}
        public bool HasInsurance{get;set;}
        public double ConsultationFee{get;set;}
        public double LabCharges{get;set;}
        public double MedicineCharges{get;set;}

        public static PatientBill LastBill;

        public static bool HasLastBill;


        public double grossAmount;
        public double discountAmount;
        public double finalPayable;




    public double GrossAmount()
    {
        grossAmount=ConsultationFee+LabCharges+MedicineCharges;
        return grossAmount;
    }


    public double DiscountAmount()
    {
        if (HasInsurance ) 
        {
            discountAmount=0.10 *  grossAmount;
            }
        else
        {
            discountAmount=0;
        }

        return discountAmount;
        
    }



        public double FinalPayable()
    {
        if (HasInsurance)
        {
            discountAmount=grossAmount * 0.10;
            }
        else
        {
            discountAmount=0;
        }
        
        finalPayable=ConsultationFee+LabCharges+MedicineCharges - discountAmount;

        return finalPayable;
        
    }
}



