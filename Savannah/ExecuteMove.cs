using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Savannah
{
    public class ExecuteMove
    {
        public int MoveLion(int x, int location)
        {
            
            switch (x)
            {
                //Left
                case 1:
                    location = location - 1;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //Right
                case 2:
                    location = location + 1;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalFrontLeft
                case 3:
                    location = location - 21;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalFrontRight
                case 4:
                    location = location - 19;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalBackleft
                case 5:
                    location = location + 19;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalBackRight
                case 6:
                    location = location + 21;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //Back
                case 7:
                    location = location + 20;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //Front
                case 8:
                    location = location - 20;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;

                default:
                    return location;
            }
        }
        public int MoveRabbit(int x, int location)
        {
            switch (x)
            {
                //Left
                case 1:
                    location = location - 2;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //Right
                case 2:
                    location = location + 2;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalFrontLeft
                case 3:
                    location = location - 42;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalFrontRight
                case 4:
                    location = location - 37;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalBackLeft
                case 5:
                    location = location + 37;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //DiagonalBackRight
                case 6:
                    location = location + 42;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //Back
                case 7:
                    location = location + 40;
                    if (location < 0)
                    {
                        return x;
                    }
                    return location;
                //front
                case 8:
                    location = location - 40;
                    if (x < 0)
                    {
                        return x;
                    }
                    return location;

                default:
                    return location;
            }
        }
    }
    public class CheckForMate
    {
        public bool CheckForRabbitMateForFemale(int L)
        {
            if (L - 1 > -1)
            {
                if (Initialize.SavannaGrid[L - 1].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 1].genderCheck() == true)
                    {
                        return true;
                    }

                }
            }
            if (L + 1 < 400)
            {
                if (Initialize.SavannaGrid[L + 1].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 1].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 21 > -1)
            {
                if (Initialize.SavannaGrid[L - 21].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 21].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 19 > -1)
            {
                if (Initialize.SavannaGrid[L - 19].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 19].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 19 > 400)
            {
                if (Initialize.SavannaGrid[L + 19].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 19].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 21 > 400)
            {
                if (Initialize.SavannaGrid[L + 21].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 21].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 20 > 400)
            {
                if (Initialize.SavannaGrid[L + 20].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 20].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 20 > -1)
            {
                if (Initialize.SavannaGrid[L - 20].rabbitCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 20].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckForRabbitMateForMale(int L)
        {
                if (L - 1 > -1)
                {
                    if (Initialize.SavannaGrid[L - 1].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L - 1].genderCheck() == false)
                        {
                            return true;
                        }

                    }
                }
                if (L + 1 < 400)
                {
                    if (Initialize.SavannaGrid[L + 1].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L + 1].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L - 21 > -1)
                {
                    if (Initialize.SavannaGrid[L - 21].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L - 21].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L - 19 > -1)
                {
                    if (Initialize.SavannaGrid[L - 19].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L - 19].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L + 19 > 400)
                {
                    if (Initialize.SavannaGrid[L + 19].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L + 19].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L + 21 > 400)
                {
                    if (Initialize.SavannaGrid[L + 21].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L + 21].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L + 20 > 400)
                {
                    if (Initialize.SavannaGrid[L + 20].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L + 20].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                if (L - 20 > -1)
                {
                    if (Initialize.SavannaGrid[L - 20].rabbitCheck() == true)
                    {
                        if (Initialize.SavannaGrid[L - 20].genderCheck() == false)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        public bool CheckForLionMateForFemale(int L)
        {
            if (L - 1 > -1)
            {
                if (Initialize.SavannaGrid[L - 1].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 1].genderCheck() == true)
                    {
                        return true;
                    }

                }
            }
            if (L + 1 < 400)
            {
                if (Initialize.SavannaGrid[L + 1].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 1].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 21 > -1)
            {
                if (Initialize.SavannaGrid[L - 21].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 21].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 19 > -1)
            {
                if (Initialize.SavannaGrid[L - 19].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 19].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 19 > 400)
            {
                if (Initialize.SavannaGrid[L + 19].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 19].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 21 > 400)
            {
                if (Initialize.SavannaGrid[L + 21].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 21].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L + 20 > 400)
            {
                if (Initialize.SavannaGrid[L + 20].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 20].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            if (L - 20 > -1)
            {
                if (Initialize.SavannaGrid[L - 20].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 20].genderCheck() == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public bool CheckForLionMateForMale(int L)
        {

            if (L - 1 > -1)
            {
                if (Initialize.SavannaGrid[L - 1].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 1].genderCheck() == false)
                    {
                        return true;
                    }

                }
            }
            if (L + 1 < 400)
            {
                if (Initialize.SavannaGrid[L + 1].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 1].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L - 21 > -1)
            {
                if (Initialize.SavannaGrid[L - 21].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 21].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L - 19 > -1)
            {
                if (Initialize.SavannaGrid[L - 19].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 19].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L + 19 > 400)
            {
                if (Initialize.SavannaGrid[L + 19].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 19].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L + 21 > 400)
            {
                if (Initialize.SavannaGrid[L + 21].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 21].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L + 20 > 400)
            {
                if (Initialize.SavannaGrid[L + 20].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L + 20].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            if (L - 20 > -1)
            {
                if (Initialize.SavannaGrid[L - 20].lionCheck() == true)
                {
                    if (Initialize.SavannaGrid[L - 20].genderCheck() == false)
                    {
                        return true;
                    }
                }
            }
            return false;

        }

    }
        public class CheckForFood
        {
            public bool checkForLionFood(int x)
            {
                if (Initialize.SavannaGrid[x].rabbitCheck() == true)
                {
                    return true;
                }
                else return false;
            }
            public bool checkForRabbitFood(int x)
            {
                if (Initialize.SavannaGrid[x].grassCheck() == true)
                {
                    return true;
                }
                else return false;
            }
        }
    }
