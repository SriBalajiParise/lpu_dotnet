using System;

namespace MethodOverloading;


    public class Source
    {
        public int Add(int a , int b ,int c)
        {
            int sum= a + b + c;
            return sum;
            
        }

        public double Add(double a , double b,double c)
        {
            double sum=a+b+c;
            return sum;
            
        }
    }


