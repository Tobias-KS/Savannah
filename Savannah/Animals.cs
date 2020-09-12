using System;
using System.Collections.Generic;
using System.Text;

namespace Savannah
{
    public abstract class Animals
    {
        public bool genderMaleIfTrue;

        public int weight;

        public int location;
    }
    public class Rabbit : Animals 
    {
        public Rabbit(bool z, int x, int y)
        {
            genderMaleIfTrue = z;
            weight = x;
            location = y;
        }
    }
    public class Lion : Animals
    {
        public Lion(bool z, int x, int y)
        {
            genderMaleIfTrue = z;
            weight = x;
            location = y;
        }
    }

}
