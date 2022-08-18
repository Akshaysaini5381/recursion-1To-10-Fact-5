using System;

namespace recursion__1To_10__Fact_5
{



    class Program
    {
        //  1 to 10 number Print :
        int num = 1;
        void p()
        {
            if (num == 11)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            p();
        }

        // factorial 5 
        int n = 5;
        int result = 1;
        int fact()
        {
            if (n == 0)
            {
                return 1;
            }
            result = result * n;
            n--;
            fact();
            return result;
        }


        public static void Main(string[] args)
        {
            Program obj = new Program();
            obj.p();
            int f = obj.fact();

            Console.WriteLine("fact :" + f);
        }

    }
}
