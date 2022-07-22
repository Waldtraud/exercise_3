using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_3
{
     class Doctor: Player
    {
        private float _protection;
        public float Protection { get => _protection; private set => _protection = value; }
   
    public int Agility { get; private set; }

        public Doctor(float protection, int agility): base()
        {
            Protection = protection;            
            Agility = agility;
        }
    }
    
    
}
