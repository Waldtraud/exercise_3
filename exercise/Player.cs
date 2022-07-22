using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    internal abstract class Player
    {
        private string _name;
        private int _damage;
        private int _hp;
        private int _level;

        public string Name { get => _name; private set => _name = value; }
        public int Damage { get => _damage; private set => _damage = value; }
        public int Hp { get => _hp; private set => _hp = value; }
        

        public Player(string name, int damage, int hp)
        {
            Random random = new Random();
            Name = name;
            Damage = damage;
            Hp = hp;
            _level = random.Next(1, 10); 
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{Name} - Hp {Hp}, Damage {Damage}, {_level} level");
        }

        public virtual void ReceiveDamage(Enemy enemy)
        {
            Hp-=enemy.Damage;
            Console.WriteLine($"{this.Name} recive {enemy.Damage} damage");
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name} ")
        }

    }
    
}
