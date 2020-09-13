using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Savannah
{
    class AnimalsDoStuff
    {
        Initialize inst = new Initialize();
        ExecuteMove exec = new ExecuteMove();
        CheckForMate chk = new CheckForMate();
        CheckForFood food = new CheckForFood();
        Random rnd = new Random();

        public void MaleLionsDoStuff(Lion lion)
        {
            int x = 0;
            int z = lion.location;
            bool v = Initialize.SavannaGrid[exec.MoveLion(rnd.Next(1, 9), lion.location)].lionCheck();
            while (v == true && x != z)
            {
                x = exec.MoveLion(rnd.Next(1, 9), lion.location);
 
            }
            lion.location = x;
            Initialize.SavannaGrid[x].addLionToField();
            lion.weight = lion.weight - 10;

            if (chk.CheckForLionMateForMale(x) == true)
            {
                inst.AddLion();
               // inst.AddLion();
            }
            if (food.checkForLionFood(x) == true)
            {
                lion.weight = lion.weight + 20;
                foreach (var rabbit in Initialize.RabbitList.ToList())
                {
                    if (rabbit.location == lion.location)
                    {
                        Initialize.RabbitList.Remove(rabbit);

                    }
                }
            }

            if (lion.weight <= 0)
            {
                foreach (var Lion in Initialize.LionList.ToList())
                {
                    if (Lion.location == lion.location)
                    {
                        Initialize.LionList.Remove(Lion);
                        
                    } 
                }
            }
            Console.WriteLine(lion.weight);
            Console.WriteLine(lion.genderMaleIfTrue);
            Console.WriteLine(lion.location);
            Console.WriteLine(" ");
        }
        public void FemaleLionsDoStuff(Lion lion)
        {
            int x = 0;
            int z = lion.location;
            while (Initialize.SavannaGrid[exec.MoveLion(rnd.Next(1, 9), lion.location)].lionCheck() == true && x != z)
            {
                x = exec.MoveLion(rnd.Next(1, 9), lion.location);
            }
            lion.location = x;
            Initialize.SavannaGrid[x].addLionToField();
            lion.weight = lion.weight - 10;

            if (chk.CheckForLionMateForFemale(x) == true)
            {
                //inst.AddLion();
                inst.AddLion();
            }
            if (food.checkForLionFood(x) == true)
            {
                lion.weight = lion.weight + 20;
                foreach (var rabbit in Initialize.RabbitList.ToList())
                {
                    if (rabbit.location == lion.location)
                    {
                        Initialize.RabbitList.Remove(rabbit);

                    }
                }
            }

            Console.WriteLine(lion.weight);
            Console.WriteLine(lion.genderMaleIfTrue);
            Console.WriteLine(lion.location);
            Console.WriteLine(" ");
        }

        public void MaleRabbitsDoStuff(Rabbit rabbit)
        {
            int x = 0;
            int z = rabbit.location;
            while (Initialize.SavannaGrid[exec.MoveRabbit(rnd.Next(1, 9), rabbit.location)].lionCheck() == true || Initialize.SavannaGrid[exec.MoveRabbit(rnd.Next(1, 9), rabbit.location)].rabbitCheck() == true && x != z)
            {
                x = exec.MoveLion(rnd.Next(1, 9), rabbit.location);
            }
            rabbit.location = x;
            Initialize.SavannaGrid[x].addRabbitToField();
            rabbit.weight = rabbit.weight - 1;


            if (chk.CheckForRabbitMateForMale(x) == true)
            {
                inst.AddRabbit();
                inst.AddRabbit();
                inst.AddRabbit();
                inst.AddRabbit();
            }
            if (food.checkForRabbitFood(x) == true)
            {
                rabbit.weight = rabbit.weight + 20;
            }
            if (rabbit.weight <= 0)
            {
                Initialize.RabbitList.Remove(rabbit);
            }


            Console.WriteLine(rabbit.weight);
            Console.WriteLine(rabbit.genderMaleIfTrue);
            Console.WriteLine(rabbit.location);
            Console.WriteLine(" ");
        }
        public void FemaleRabbitsDoStuff(Rabbit rabbit)
        {
            int x = 0;
            int z = rabbit.location;
            while (Initialize.SavannaGrid[exec.MoveRabbit(rnd.Next(1, 9), rabbit.location)].lionCheck() == true || Initialize.SavannaGrid[exec.MoveRabbit(rnd.Next(1, 9), rabbit.location)].rabbitCheck() == true && x != z)
            {
                x = exec.MoveLion(rnd.Next(1, 9), rabbit.location);
            }
            rabbit.location = x;
            Initialize.SavannaGrid[x].addRabbitToField();
            rabbit.weight = rabbit.weight - 1;


            if (chk.CheckForRabbitMateForFemale(x) == true)
            {
                //inst.AddRabbit();
                //inst.AddRabbit();
                inst.AddRabbit();
                inst.AddRabbit();
            }
            if (food.checkForRabbitFood(x) == true)

            if (rabbit.weight <= 0)
            {
                Initialize.RabbitList.Remove(rabbit); 
            }

            Console.WriteLine(rabbit.weight);
            Console.WriteLine(rabbit.genderMaleIfTrue);
            Console.WriteLine(rabbit.location);
            Console.WriteLine(" ");
        }
    }
}
