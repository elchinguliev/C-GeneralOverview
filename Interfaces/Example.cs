namespace Interfaces
{
    public class Example:IExample
    {
        static void Main(string[] args)
        {
            IExample example = new Example();
            example.Example();
        }

        void IExample.Example()
        {
            Console.WriteLine("I am coming form IExample");
        }
    }
}
