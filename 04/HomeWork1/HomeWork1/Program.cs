using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите исходную строку");
            string stroka = Console.ReadLine();
            int result = FindMissing(stroka);

            Console.WriteLine(result);
            Console.ReadLine();
        }
        static int FindMissing(string input)
        {
            
            int category=1; 
            int countNum= input.Length;
            do 
            {   
                int start=0;
                int countTrue=0;
                int[] massiv = new int[input.Length / category];
                for (int i = 0; i < input.Length / category; i++)
                {
                    massiv[i] = Convert.ToInt32(input.Substring(start, category));
                    start += category;
                                 
                }

                for (int i = 0; i < input.Length / category - 1; i++)
                {
                    if (massiv[i] + 1 == massiv[i + 1]) 
                    {
                        countTrue++;
                    }
                }

                if (countTrue == input.Length / category - 2)
                {
                    
                     for (int i = 0; i < input.Length / category-1; i++)
                     {    
                         if  (Math.Abs(massiv[i]-massiv[i+1] )==2) 
                         {
                             return ++massiv[i];
                         }
                      }
                
                }
                else  if (countTrue == input.Length / category - 3)  
                    return -1;
               
                category++;
 
            } while (category<=input.Length);
           
 
            return -1;
        }
    }
}
