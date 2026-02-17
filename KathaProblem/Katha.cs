using System;

namespace KathaProblem;

public class Katha

{

    Dictionary<string,int> record =new Dictionary<string,int>();
    public Katha()
    {
        record.Add("Tea",20);
        record.Add("Coffee",30);
        record.Add("oil",100);
        record.Add("rice",200);
        record.Add("sugar",70);
        record.Add("tamarinmd",150);
        record.Add("wheat",300);
    }

    public void AddItem(string itemName,int itemPrice)
    {
        record.Add(itemName,itemPrice);
        
    }
    
    public int GetTotal()
    {
        int total=0;
        foreach(var item in record)
        {
            total+=item.Value;
        }
        return total;
    }


    public int GetRepeatAmount()
    {
        
        int count = 0;
            //Implement Your code here
            Dictionary<int,int> repeat = new Dictionary<int,int>();
            foreach(var item in record.Values)
            {
                if(repeat.ContainsKey(item))
                {
                    repeat[item]++;
                }else
                {
                    repeat[item]=1;
                }
            }
            foreach(var num in repeat.Values){
                if(num>1){
                    count++;
                }
            }
            return count;
    }

}
