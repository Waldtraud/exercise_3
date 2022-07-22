using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    abstract class Enemy
   {
        private string _name;
        private int _damage;
        private int _hp;
        public string Name { get=>_name; private set => _name= value; }
        public int Damage { get => _damage; private set => _damage = value; }
        public int Hp { get => _hp; private set => _hp = value;}        

        public Enemy (string name, int damage, int hp)
        {           
            Name = name;
            Damage = damage;
            Hp = hp;            
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} - Hp {Hp}, Damage {Damage}");
        }
    }
}
