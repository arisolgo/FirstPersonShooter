using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstPersonShooter
{
    abstract class Character
    {
        public String Name { get; set; }
        public int HP { get; set; }
        public bool IsAlive { get; set; }

        public Character(string name, int hp)
        {
            this.IsAlive = true;
            this.HP = hp;
            this.Name = name;
           
        }
    }
}
