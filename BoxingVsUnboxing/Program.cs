namespace BoxingVsUnboxing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 5;
            object boxednum = number;
            Console.WriteLine($"Boxing : "+boxednum);
            object unboxedNum = 15;
            int number2 = (int)unboxedNum;
            Console.WriteLine($"Unboxing : "+number2);
        }
    }
}
