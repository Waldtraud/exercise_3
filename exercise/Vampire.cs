using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    // кусает перед своим ходом
   class Vampire: Enemy    
    {
        private int _vampireBite;

        public int VampireBite { get => _vampireBite; private set => _vampireBite = value; }
        public Vampire(int vampireBite) : base(string name, int damage, int hp)
        {
            VampireBite = vampireBite;
            
        }
    }
}
