using System;

namespace GenericsMadeSimple
{

    class GenericsMadeSimple<T>
    {
        public T MyProperty { get; set; }

    }


    class MyChishuvaition
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public T Add<T>(T num1, T num2)
        {
            //**********   Error - n operator + is defined for T and T
            //return num1 + num2;
        }


        public void Print<T>(T arg1) { }
    }

    class Program
    {

        public static void Print(int a, int b)
        {
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }

        static void Main(string[] args)
        {
            //GenericsMadeSimple<int> genericsMadeSimpleInt = new GenericsMadeSimple<int>();
            //genericsMadeSimpleInt.MyProperty = 5;
            //Console.WriteLine(genericsMadeSimpleInt.MyProperty);
            ////genericsMadeSimpleInt.MyProperty = "Moshe";


            //GenericsMadeSimple<string> genericsMadeSimpleSytring = new GenericsMadeSimple<string>();
            //genericsMadeSimpleSytring.MyProperty = "Some string";
            //Console.WriteLine(genericsMadeSimpleSytring.MyProperty);
            ////genericsMadeSimpleSytring.MyProperty = 5;


            //MyChishuvaition myChishuvaition = new MyChishuvaition();
            //myChishuvaition.Print<int>(5);
            //myChishuvaition.Print<string>("");

            //myChishuvaition.Print(5);
            //myChishuvaition.Print("Or");
            //myChishuvaition.Print(new object());

            /*******************************************************************************/
            /*******************************************************************************/
            /*******************************************************************************/
            /*******************************************************************************/




            SwapClass swap = new SwapClass();
            int a = 28, b = 29;
            Print(a, b);
            swap.Swap(ref a, ref b);
            Print(a, b);

            Person p1 = new Person() { Id = 1 };
            Person p2 = new Person() { Id = 22 };

            //swap.Swap(ref p1, ref p2);



        }
    }
}
