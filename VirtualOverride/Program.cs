namespace VirtualOverride
{
    public class Program
    {
        static void Main(string[] args)
        {
            B b=new B();  
            b.Show();
        }


        class A
        {
            public virtual void Show() //virtual edirik ki B classinda override ederek islede bilek
            {
                Console.WriteLine("Show comes from A");
            }
        }

        class B :A
        {
            public override void Show()  //override yazmasaq A dan geldiyi melum olmayacaq.
            {
                Console.WriteLine("Show comes from B ");
            }
        }

    }
}
