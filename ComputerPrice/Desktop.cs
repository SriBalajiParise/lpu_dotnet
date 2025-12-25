using System;

namespace December23Prob;

class Desktop : Computer
{
    public int monitor_size{get;set;}
    public int power_supply{get;set;}

    // int processor_cost{get;set;}
    int processor_cost;



    public double DesktopPriceCalculation()
    {

            if (processor=="i3"){
        processor_cost=1500;
    }
    else if (processor=="i5"){
        processor_cost=3000;
    }
    else
    {
        processor_cost=4500;
    }
        double desktop_price;
        desktop_price=(processor_cost + (ram_size*200) + (hard_disk*1500) + (graphic_card*2500) + power_supply*20) +(monitor_size*250);

        return desktop_price;
    }

}
