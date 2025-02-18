using System.Text;

namespace StringVsStringBuilder
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string ?str = "Hello";
            //Console.WriteLine(str);
            //str+="World";
            //Console.WriteLine("Modified string : " + str);
            ////deyisiklik outputda yox memory adress ve allocationdadir.
            ///
            StringBuilder sb = new StringBuilder("Salam");
            Console.WriteLine("Əvvəlki StringBuilder: " + sb.ToString());

            // StringBuilder dəyişdiririk
            sb.Append(" Dünya");
            Console.WriteLine("Dəyişdirilmiş StringBuilder: " + sb.ToString());

            // Eyni StringBuilder obyektində dəyişiklik oldu
            Console.WriteLine("Sonrakı StringBuilder: " + sb.ToString());
        }
    }
}
