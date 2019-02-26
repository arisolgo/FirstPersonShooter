using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPersonShooter
{
    public class AK47: IWeapon
    {
        public int AmmoCount { get; set; }
       
        public void Fire()
        {
            Console.WriteLine("AK47 disparó");
            AmmoCount -= 6;
        }

        public void Reload()
        {
            
            
                this.AmmoCount += 30;
            
           

            Console.WriteLine("AK47 Recargado");

        }

      public AK47()
        {
            this.AmmoCount = 30;
        }
    }
}
