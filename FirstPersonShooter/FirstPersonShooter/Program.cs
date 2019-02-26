using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPersonShooter
{
    class Program
    {
        static void Main(string[] args)
        {
            RunFirstPersonShooter();
            Console.ReadLine();
        }

        public static void RunFirstPersonShooter()
        {
            var ak47 = new AK47();
           
            var handGun = new HandGun();
           
            var shotGun = new ShotGun();

            var player = new Player("Ariel", 100);

            /*   player.Attack();
               player.DropWeapon(handGun);
               player.PickWeapon(handGun);

               player.SwitchWeapon();

               player.ShowInventory();
               player.PickWeapon(shotGun);
               player.ShowInventory();
               player.DropWeapon(shotGun);
               player.ShowInventory();
               player.DropWeapon(handGun);
               player.DropWeapon(handGun);*/

            /*  player.PickWeapon(handGun);
              player.Attack();
              player.PickWeapon(shotGun);
              player.SwitchWeapon();
              player.Attack();

              player.PickWeapon(handGun);

              player.PickWeapon(ak47);
              player.Attack();

              player.ShowInventory();
              player.DropWeapon(handGun);
              player.ShowInventory();
              player.DropWeapon(ak47);
              player.ShowInventory();

              player.PickWeapon(handGun);
             player.PickWeapon(ak47);
             player.PickWeapon(ak47);*/

            /*player.ShowInventory();
            player.PickWeapon(handGun);
            player.Attack();
            player.DropWeapon(handGun);
            player.ShowInventory();
            player.PickWeapon(handGun);*/

           /* player.PickWeapon(handGun);
            player.Attack();
            player.Attack();
            player.Attack();
            player.Attack();
            player.Attack();
            player.Attack();
            player.Attack();*/



        }
    }
}
