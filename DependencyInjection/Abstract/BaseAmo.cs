using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Abstract
{
    public abstract class BaseAmo : IAmo
    {
         protected double power { get; set; }
        public void Fire()
        {
            Console.WriteLine("Power : "  +power  +"\tFired");
        }
    }
}
