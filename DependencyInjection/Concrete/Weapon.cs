using DependencyInjection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Concrete
{
    public class Weapon
    {
        IAmo usingAmmo;

        public Weapon(IAmo amo)
        {
            usingAmmo=amo; 
        }
        public void Fire()
        {
            usingAmmo.Fire();
        }
    }
}
