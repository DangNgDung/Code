using System;

namespace VietJackCsharp
{
    class TestCsharp
    {
      
        public static void Main()
        {
            int n;
            long S=0,P=1;
            Console.Write("Enter n: ");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
              P*=i;
              S+=P;
            }
            Console.WriteLine("Result: "+S);
        }
        
         
    }
}