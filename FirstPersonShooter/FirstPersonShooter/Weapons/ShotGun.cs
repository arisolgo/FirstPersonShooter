using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPersonShooter
{
   public class ShotGun : IWeapon
    {
        public int AmmoCount { get; set; }
        public void Fire()
        {
            Console.WriteLine("ShotGun disparó");
            AmmoCount -= 1;
        }

        public void Reload()
        {
            
            
                this.AmmoCount += 6;
            
            Console.WriteLine("Shotgun Recargado\n");
        }

        public ShotGun()
        {
            this.AmmoCount = 6;
        }
    }
}
