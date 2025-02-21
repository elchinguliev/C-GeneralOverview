using DependecjInjectionGencayYildiz.Services.Interface;

namespace DependecjInjectionGencayYildiz.Services
{
    public class TestLog:ILog
    {
        public void Log()
        {
            Console.WriteLine("Test Log");
        }
    }
}
