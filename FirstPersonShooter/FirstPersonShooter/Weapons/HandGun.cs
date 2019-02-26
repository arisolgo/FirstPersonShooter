using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstPersonShooter
{
    public class HandGun : IWeapon
    {
        public int AmmoCount { get; set; }
        public void Fire()
        {
            Console.WriteLine("Handgun disparó");
            AmmoCount -= 1;
        }

        public void Reload()
        {

                this.AmmoCount += 6;
            
            Console.WriteLine("Handgun Recargado");
        }
        public HandGun()
        {
            this.AmmoCount = 6;
        }
    }
}
