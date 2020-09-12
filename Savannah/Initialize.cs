using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Savannah
{
    class Initialize
    {
        Random rnd = new Random();

        public static List<Field> SavannaGrid = new List<Field>();
        public static List<Lion> LionList = new List<Lion>();
        public static List<Animals> AnimalList = new List<Animals>();
        public static List<Rabbit> RabbitList = new List<Rabbit>();


        public void InitializeSavannah()
        {
            for (int i = 0; i < 400; i++)
            {

                int x = rnd.Next(1, 4);
                bool z = false;
                if (x == 1)
                {
                    z = true;
                }
                Field F = new Field(i, z);
                SavannaGrid.Add(F);
            }
        }
        public void InitalizeLions()
        {
            for (int i = 0; i < 20; i++)
            {
                int x = rnd.Next(1, 3);
                bool z = false;
                int weight = 300;
                if (x == 1)
                {
                    z = true;
                }
                int tryLocation = rnd.Next(0, 400);

                while (SavannaGrid[tryLocation].lionCheck() == true || SavannaGrid[tryLocation].rabbitCheck() == true)
                {
                    tryLocation = rnd.Next(0, 400);
                }

                Lion L = new Lion(z, weight, tryLocation);
                SavannaGrid[tryLocation].maleIfTrue = z;
                LionList.Add(L);

            }
        
        }
        public void InitalizeRabbits()
        {
            for (int i = 0; i < 20; i++)
            {
                int x = rnd.Next(1, 3);
                bool z = false;
                int weight = 20;
                if (x == 1)
                {
                    z = true;
                }
                int tryLocation = rnd.Next(0, 400);

                while (SavannaGrid[tryLocation].lionCheck() == true || SavannaGrid[tryLocation].rabbitCheck() == true)
                {
                    tryLocation = rnd.Next(0, 400);
                }
                Rabbit R = new Rabbit(z, weight, tryLocation);
                SavannaGrid[tryLocation].maleIfTrue = z;
                RabbitList.Add(R);
            }
        }
        public void AddLion()
        {
            int x = rnd.Next(1, 3);
            bool z = false;
            int weight = 300;
            if (x == 1)
            {
                z = true;
            }
            int tryLocation = rnd.Next(0, 400);

            while (SavannaGrid[tryLocation].lionCheck() == true || SavannaGrid[tryLocation].rabbitCheck() == true)
            {
                tryLocation = rnd.Next(0, 400);
            }

            Lion L = new Lion(z, weight, tryLocation);
            SavannaGrid[tryLocation].maleIfTrue = z;
            LionList.Add(L);
        }
        public void AddRabbit()
        {
            int x = rnd.Next(1, 3);
            bool z = false;
            int weight = 20;
            if (x == 1)
            {
                z = true;
            }
            int tryLocation = rnd.Next(0, 400);

            while (SavannaGrid[tryLocation].lionCheck() == true || SavannaGrid[tryLocation].rabbitCheck() == true)
            {
                tryLocation = rnd.Next(0, 400);
            }
            Rabbit R = new Rabbit(z, weight, tryLocation);
            SavannaGrid[tryLocation].maleIfTrue = z;
            RabbitList.Add(R);
        }
        public void deleteRabbit(int x)
        {
            foreach (var Rabbit in RabbitList)
            {
                if (Rabbit.location == x)
                {
                    RabbitList.Remove(Rabbit);
                }
            }
        }
        public void deleteLion(int x)
        {
            for (int i = 0; i < LionList.Count; i++)
            {
                if (true)
                {
                    LionList[i].location = x;
                    LionList.RemoveAt(i);
                }
                
            }
               
        }
    }
}
