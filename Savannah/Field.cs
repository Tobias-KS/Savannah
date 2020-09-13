using System;
using System.Collections.Generic;
using System.Text;

namespace Savannah
{
   public class Field
    {
        private int location;
        private bool hasGrass;
        bool hasLion;
        bool hasRabbit;
        public bool maleIfTrue;

        public Field(int x, bool z)
            {
            location = x;
            hasGrass = z;
            }
        public bool lionCheck()
        {
            return hasLion;
        }
        public bool rabbitCheck()
        {
            return hasRabbit;
        }
        public bool genderCheck()
        {
            return maleIfTrue;
        }
        public bool grassCheck()
        {
            return hasGrass;
        }
        public int locationCheck()
        {
            return location;
        }
        public void addLionToField()
        {
            hasLion = true;
        }
        public void addRabbitToField()
        {
            hasRabbit = true;
        }
    }
}

