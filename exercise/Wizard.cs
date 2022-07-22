using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
    public class Wizard: Player
    {
        public int ManaPoints { get; private set; }
        public int ManaLevel { get; private set; }
        public Wizard (int manaPoints, int manaLevel): base ()
        { }
    }
}
