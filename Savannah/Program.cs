using System;
using System.Collections.Generic;

namespace Savannah
{
   public class Program
    {

        public static void Main()
        {
            Initialize inst = new Initialize();
           
            inst.InitializeSavannah();
            inst.InitalizeLions();
            inst.InitalizeRabbits();
        }
        public static void runSavannah()
        {
            AnimalsDoStuff ADS = new AnimalsDoStuff();

            for (int i = 0; i < Initialize.LionList.Count; i++)
            {
                try
                {
                    if (Initialize.LionList[i].genderMaleIfTrue == true)
                    {
                        ADS.MaleLionsDoStuff(Initialize.LionList[i]);
                    }
                    if (Initialize.LionList[i].genderMaleIfTrue == false)
                    {
                        ADS.FemaleLionsDoStuff(Initialize.LionList[i]);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                    //skips lion if it does not exist in the list any longer
                }
            }
            for (int i = 0; i < Initialize.RabbitList.Count; i++)
            {
                try
                {
                    if (Initialize.RabbitList[i].genderMaleIfTrue == true)
                    {
                        ADS.MaleRabbitsDoStuff(Initialize.RabbitList[i]);
                    }
                    if (Initialize.LionList[i].genderMaleIfTrue == false)
                    {
                        ADS.FemaleRabbitsDoStuff(Initialize.RabbitList[i]);
                    }
                }
                catch (ArgumentOutOfRangeException)
                {

                    //skips rabb if it does not exist in the list any longer
                }

            }
        }
    }
}






