using System;

namespace December23Prob;

class Laptop : Computer
{
    public int display_size {get;set;}
    public int battery_volt {get;set;}
    int processor_cost=0;




    public double LaptopPriceCalculation()
    {

            if (processor=="i3"){
        processor_cost=2500;
    }
    else if (processor=="i5"){
        processor_cost=5000;
    }
    else if (processor =="i7")
    {
        processor_cost=6500;
    }
        double laptop_price;
        laptop_price=(processor_cost + (ram_size*200) + (hard_disk*1500) + (graphic_card*2500)+ (display_size*250) + battery_volt*20);

        return laptop_price;
    }
}
