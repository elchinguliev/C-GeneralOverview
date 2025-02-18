
using System;
namespace ReadonlyVsConst
{
    public class Program
    {
        public static  readonly int readNum=5;
        public  const int constNum = 0;
        public static int intNum = 20;
        static Program()
        {
            //readNum=10;
            //constNum=25;
        }
    

        public static void ShowValues()
        {
            Console.WriteLine($"ConstValue: {constNum}");
            Console.WriteLine($"ReadonlyValue: {readNum}");
        }
        static public void Main(string[] args)
        {
            Program.ShowValues();


        }
    }
}
