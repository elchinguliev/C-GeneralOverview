namespace Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            A a=new A();
            // A ab=new B(); bunu etmek ucun plymorpishm istifade edirik.Bunun ucun
            //ilk once toreme etmek lazimdir
            A ab = new B();
        }

        class A
        {
            public int X { get; set; }
          
        }

        class B:A
        {
            public int Y { get; set; }
        }
    }
}
