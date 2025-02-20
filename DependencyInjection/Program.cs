using DependencyInjection.Concrete;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon weaponX = new Weapon(new XAmo() );
            Weapon weaponY = new Weapon(new YAmo() );

            weaponX.Fire();
            weaponY.Fire();
        }
    }
}
