using DependecjInjectionGencayYildiz.Services.Interface;

namespace DependecjInjectionGencayYildiz.Services
{
    public class ConsoleLog:ILog
    {

        public ConsoleLog(int a)
        {
            
        }
        public void Log()
        {
            Console.WriteLine("Console Log");
        }
    }
}
