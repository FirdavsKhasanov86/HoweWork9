using System;

namespace HomeWokr9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Medthood Pop
            // string[] numbers = { "1", "2", "3", "4", "5" };
            // int [] numbers = {1,2,3,4,5,6,7,8};
            //double[] numbers = {0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8};
            // decimal[] numbers = {10.35m,12.35m,14.35m,16.35m};
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            // ArrayHelper.Pop(ref numbers);
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }
            
        }

         static class ArrayHelper
        {
        public static string Pop(ref string[] stringArr)
        {

            string[] arr = new string[stringArr.Length - 1];
            for (int i = 0; i < stringArr.Length - 1; i++)
            {
                arr[i] = stringArr[i];

            }
            string a = stringArr[stringArr.Length - 1];
            stringArr = arr;
            return a;

        }

        public static int Pop(ref int[] intArr)
        {

            int[] arr = new int[intArr.Length - 1];
            for (int i = 0; i < intArr.Length - 1; i++)
            {
                arr[i] = intArr[i];

            }
            int b = intArr[intArr.Length - 1];
            intArr = arr;
            return b;

        }
        public static double Pop(ref double[] doubleArr)
        {

            double[] arr = new double[doubleArr.Length - 1];
            for (int i = 0; i < doubleArr.Length - 1; i++)
            {
                arr[i] = doubleArr[i];

            }
            double c = doubleArr[doubleArr.Length - 1];
            doubleArr = arr;
            return c;

        }
        public static decimal Pop(ref decimal[] decimalArr)
        {

            decimal[] arr = new decimal[decimalArr.Length - 1];
            for (int i = 0; i < decimalArr.Length - 1; i++)
            {
                arr[i] = decimalArr[i];

            }
            decimal d = decimalArr[decimalArr.Length - 1];
            decimalArr = arr;
            return d;

        }


       
    }


    }
   

}
