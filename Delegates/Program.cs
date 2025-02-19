namespace Delegates
{
    public class Program
    {

        public  delegate int MyDelegate(int x,int y);

        //static void FirstMethod()
        //{
        //    Console.WriteLine("First method");
        //}

        static int AddMethod(int x,int y)
        {
            return x + y;
        }


        static int SubtractMethod(int x,int y)
        {
            return x-y;
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(AddMethod);

            myDelegate+=SubtractMethod;
            Console.WriteLine( myDelegate(10,15));
        }
    }
}
