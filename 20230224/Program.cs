using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230224
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                try
                {
                    checked
                    {
                        int counter = 0;

                        for(int n1=1; n1<=4; n1++)  
                        {                           
                            for (int n2 = 1; n2 <= 4; n2++)  
                            {
                                if (n2 == n1) continue;

                                for (int n3 = 1; n3 <= 4; n3++)  
                                {
                                    if (n3 == n1||n3==n2) continue;

                                    for (int n4 = 1; n4 <= 4; n4++)
                                    {

                                    if (n4 == n1 || n4 == n2 || n4 == n3) continue;
                                        counter++;

                                        Console.WriteLine(counter + ". ");
                                        Console.WriteLine(n1 + " " + n2);
                                        Console.WriteLine(n3 + " " + n4+"\n");
                                    }
                                }
                            }
                        }

                        Console.WriteLine(counter+"組解:");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("Press any key try again! \n");
                    Console.ReadKey();
                }
            }
        }
    }
}
