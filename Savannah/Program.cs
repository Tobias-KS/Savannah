using System;
using System.Collections.Generic;

namespace Savannah
{
    class Program
    {

        static void Main(string[] args)
        {
            Initialize inst = new Initialize();
            AnimalsDoStuff ADS = new AnimalsDoStuff();
            inst.InitializeSavannah();
            inst.InitalizeLions();
            inst.InitalizeRabbits();
            while (Initialize.LionList.Count > 0)
            {
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
}






