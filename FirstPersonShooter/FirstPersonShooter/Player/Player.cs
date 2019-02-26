using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPersonShooter
{
    class Player: Character
    {
        public Player(string name, int hp) : base(name, hp)
        {
            //TODO:
        }

       public IWeapon ActiveWeapon;
        

        int weaponCount = 0;
        List<IWeapon> weapons = new List<IWeapon>();
     
       public void PickWeapon(IWeapon weapon)
        {
            weaponCount++;

           //Cogiendo primer arma
            if(weaponCount == 1 || weapons[0] == null)
            {
                    this.ActiveWeapon = weapon;
                    weapons.Add(weapon);
                    Console.WriteLine("\nHaz obtenido un " + weapon);

            }

            //Verificando si el arma a escoger es igual al arma de la primera posicion
           else if (weapons[0] == weapon && weaponCount>=2)
            {
                weapons[0].Reload();
            }


             
            //Escogiendo el segundo arma
             else if (weaponCount == 2 || weapons[1] == null )
            // else if(weapons.Count != 2)
             {
                weapons.Add(weapon);
                weapons[1] = weapon;
                Console.WriteLine("\nHaz obtenido un " + weapon);
             }
                //Verificando si el arma a escoger es igual al segundo arma
                else if(weapons[1] == weapon) 
                {
                    weapons[1].Reload();
                }
            
            //Verificando si se esta escogiendo un tercer arma
            else if (weaponCount > 2)
            {
                weapons.Add(weapon);
                CycleWeapon();
                this.ActiveWeapon = weapon; 
            }

        }

        //Atacando
        public void Attack()
        {
            //Validando si tiene algun arma
            if (weapons.Count > 0)
            {
                this.ActiveWeapon.Fire();
                Console.WriteLine("Balas disponibles: " + this.ActiveWeapon.AmmoCount.ToString() + "\n");
                if (this.ActiveWeapon.AmmoCount <= 0)
                this.ActiveWeapon.Reload();
            }
            else //Si no tiene ningun arma no disparara.
            {
                Console.WriteLine("No tienes armas disponibles");
            }
        }

        //Cambiando el primer arma por el 3ero
        public void CycleWeapon()
        {
            weapons[0] = weapons[2];
            weapons.RemoveAt(2);
            Console.WriteLine( "\n" + this.ActiveWeapon + " ha sido reemplazada por " + weapons[0] + "\n");
        }

        //Cambiando el orden de las armas en la lista
        public void SwitchWeapon()
        {
            //Verificar si hay 2 armas para cambiar el orden
            if(weapons.Count>=2)
            {
                IWeapon SaveWeapon;
                SaveWeapon = weapons[0];
                weapons[0] = weapons[1];
                weapons[1] = SaveWeapon;
                this.ActiveWeapon = weapons[0];
                Console.WriteLine("\nHaz cambiado el orden de tus armas");
                ShowInventory();
            }
            else
            {
                Console.WriteLine("No tienes armas suficientes para poder cambiar entre ellas.");
            }
           

        }

        //Mostrando armas disponibles
        public void ShowInventory()
        {//Si no hay armas
            if (weapons.Count == 0)
            {
                Console.WriteLine("No hay armas disponibles");
            }
            //Si tiene armas
            else if(weapons.Count > 0)
            {
                //Si tiene solo 1 arma
                if (weapons[1] != null && weapons[0] == null || weapons[0] != null && weapons[1] == null)
                {
                    Console.WriteLine("\n\tArmas disponibles:\n");
                    Console.WriteLine("\t\t" + weapons[0].ToString() + "\n");

                }
                else if(weapons[1] != null && weapons[0] != null)
                {
                    Console.WriteLine("\n\tArmas disponibles:\n");
                    for (int i = 0; i <2 ; i++)
                    {
                        Console.WriteLine("\t\t" + weapons[i].ToString() + "\n");
                    }
                }
            }
          
           
        }

        //Soltando el arma
        public void DropWeapon(IWeapon weapon)
        {
            if(weapons.Count > 0)
            {
                if (weapon == weapons[0] || weapon == weapons[0] && weapons[1] == null)
                {
                    Console.WriteLine("Haz soltado el arma " + weapons[0]);
                    weapons[0] = null;
                    Console.WriteLine("\nNo tienes armas en el inventario!\n");


                }
                else if (weapon == weapons[0])
                {
                    Console.WriteLine("Haz soltado el arma " + weapons[0]);
                    Console.WriteLine("Ahora tu active weapon es: " + weapon + "\n");
                    weapons[0] = weapons[1];
                    weapons[1] = null;

                }

                else if (weapon == weapons[1])
                {
                    Console.WriteLine("Haz soltado el arma " + weapons[1]);
                    weapons[1] = null;

                }
                
            }
            else if (weapons.Count == 0)
            {
                Console.WriteLine("No tienes ningun arma para soltarla.");
            }


        }
    }

}
