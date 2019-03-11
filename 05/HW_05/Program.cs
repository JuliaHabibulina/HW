using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_05
{
    class Arrays
    {
        int N;
        int[] A ;//= { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] B;// = { 121, 14641, 20736, 36100, 25921, 361, 20736, 361 };
        public Arrays(int n)
        {
            N=n;
            A = new int[N];
            B = new int[N];
        }
        public void InputElements()
        {
            Console.WriteLine("Put elements of massive A");
            for (int i=0; i<N;i++)
                A[i]=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Put elements of massive B");
            for (int i = 0; i < N; i++)
                B[i] = Convert.ToInt32(Console.ReadLine());
        }
        
        public bool Comp()
        {
            bool flag = false;
            
            Array.Sort(A);
            Array.Sort(B);
          
            for (int i = 0; i < N; i++)
            {
                if (A[i] * A[i] == B[i])
                {
                    flag = true;

                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put number of elements in massives");
            int number = Convert.ToInt32(Console.ReadLine());
            Arrays myArrays = new Arrays(number);
            myArrays.InputElements();
            if (myArrays.Comp())
                Console.WriteLine("Valid arrays");
            else Console.WriteLine("Invalid arrays");

            Console.ReadLine();

        }
    }
}
