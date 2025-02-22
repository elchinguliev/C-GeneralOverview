namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Example example = new Work();
            example.X();
        }

        abstract class Example
        {
            abstract public void X();
            public abstract int Y { get; set; }
        }

        class Work : Example
        {
            public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public override void X()
            {
                Console.WriteLine("Hello Elchin");
            }
        }
    }
}
