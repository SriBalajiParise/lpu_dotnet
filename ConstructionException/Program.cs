using System;
class Construction
{
    public float ConstructionArea{get;set;}
    public float SiteArea{get;set;}

    public void ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea <=siteArea){
            
            Console.WriteLine("Construction estimate is valid.");
        }
        else
        {
            throw new ConstructionException("Construction area cannot be greater than site area.");
            
        }
    }
}

public class ConstructionException : Exception
{
    public ConstructionException(string message):base(message)
    {
        
    }
}

class Program
{
    public static void Main()
    {
        try
        {
            Construction obj = new Construction();
            obj.ValidateConstructionEstimate(500,400);
            
        }
        catch(ConstructionException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}