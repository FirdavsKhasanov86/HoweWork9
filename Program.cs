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


            //Medthood Push
            //string[] numbers = { "1", "2", "3", "4", "5",  };
            //int [] numbers = {1,2,3,4,5,6,7,8};
           //  double[] numbers = {0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8};
            // decimal[] numbers = {10.35m,12.35m,14.35m,16.35m};
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            //ArrayHelper.Push(ref numbers, "6");
            //ArrayHelper.Push(ref numbers, 9);
             // ArrayHelper.Push(ref numbers, 0.9);
             // ArrayHelper.Push(ref numbers, 18.35m);
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }


            //Medthood Shift
            //string[] numbers = { "1", "2", "3", "4", "5",  };
            //int [] numbers = {1,2,3,4,5,6,7,8};
            //double[] numbers = {0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8};
            //decimal[] numbers = {10.35m,12.35m,14.35m,16.35m};
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            // ArrayHelper.Shift(ref numbers);
            // foreach (var y in numbers)
            // {
            //     Console.WriteLine(y);
            // }

            //Medthood UnShift
            //string[] numbers = { "1", "2", "3", "4", "5",  };
            //int [] numbers = {1,2,3,4,5,6,7,8};
            //double[] numbers = {0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8};
            //decimal[] numbers = {10.35m,12.35m,14.35m,16.35m};
            // foreach (var y in numbers) 
            // {
            //     Console.WriteLine(y);
            // }
            // Console.WriteLine("------------------------------");
            //ArrayHelper.UnShift(ref numbers,"0");
             //ArrayHelper.UnShift(ref numbers, 0);
            //  ArrayHelper.UnShift(ref numbers, 8.35m);
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
       
       public static void Push(ref string[] stringArr,string mac)
        {

            string[] arr = new string[stringArr.Length + 1];
            for (int i = 0; i < stringArr.Length; i++)
            {
                arr[i] = stringArr[i];

            }
            arr[arr.Length - 1] = mac;
            stringArr = arr;
        }

        public static  void Push(ref int[] intArr, int mac)
        {

            int[] arr = new int[intArr.Length + 1];
            for (int i = 0; i < intArr.Length; i++)
            {
                arr[i] = intArr[i];

            }
            arr[arr.Length - 1] = mac;
            intArr = arr;

            
        }

        public static  void Push(ref double[] doubleArr, double mac)
        {

            double[] arr = new double[doubleArr.Length + 1];
            for (int i = 0; i < doubleArr.Length; i++)
            {
                arr[i] = doubleArr[i];

            }
            arr[arr.Length - 1] = mac;
            doubleArr = arr;

            
        }

        public static  void Push(ref decimal[] decimalArr, decimal mac)
        {

            decimal[] arr = new decimal[decimalArr.Length + 1];
            for (int i = 0; i < decimalArr.Length; i++)
            {
                arr[i] = decimalArr[i];

            }
            arr[arr.Length - 1] = mac;
            decimalArr = arr;

            
        }

        public static string Shift(ref string[] stringArr)
        {

            string[] arr = new string[stringArr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = stringArr[i+1];

            }
            string s = stringArr[0];
            stringArr = arr;
            return s;
        }

        public static int Shift(ref int[] intArr)
        {

            int[] arr = new int[intArr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = intArr[i+1];

            }
            int s = intArr[0];
            intArr = arr;
            return s;
        }

        public static double Shift(ref double[] doubleArr)
        {

            double[] arr = new double[doubleArr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = doubleArr[i+1];

            }
            double s = doubleArr[0];
            doubleArr = arr;
            return s;
        }

        public static decimal Shift(ref decimal[] decimalArr)
        {

            decimal[] arr = new decimal[decimalArr.Length-1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = decimalArr[i+1];

            }
            decimal s = decimalArr[0];
            decimalArr = arr;
            return s;
        }

         public static void UnShift(ref string[] stringArr, string mac)
        {
            string[] arr = new string[stringArr.Length + 1];
            arr[0] = mac;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = stringArr[i];
            }
            stringArr = arr;
        }

        public static void UnShift(ref int[] intArr, int mac)
        {
            int[] arr = new int[intArr.Length + 1];
            arr[0] = mac;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = intArr[i];
            }
            intArr = arr;
        }

        public static void UnShift(ref double[] doubleArr, double mac)
        {
            double[] arr = new double[doubleArr.Length + 1];
            arr[0] = mac;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = doubleArr[i];
            }
            doubleArr = arr;
        }

        public static void UnShift(ref decimal[] decimalArr, decimal mac)
        {
            decimal[] arr = new decimal[decimalArr.Length + 1];
            arr[0] = mac;
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i+1] = decimalArr[i];
            }
            decimalArr = arr;
        }
    }


    }
   

}
