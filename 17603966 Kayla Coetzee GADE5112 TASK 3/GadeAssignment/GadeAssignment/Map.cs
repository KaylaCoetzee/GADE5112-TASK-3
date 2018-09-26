using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeAssignment
{
    public class Map
    {
        
        private string[,] map = new string[20, 20];
        private MeleeUnit[] mU = new MeleeUnit[50];
        private HealerUnit[] hU = new HealerUnit[10];
        private MageUnit[] mageU = new MageUnit[50];
        private ThiefUnit[] thiefU = new ThiefUnit[50];
        private DevilUnit[] dU = new DevilUnit[50];
        private RangedUnit[] rU = new RangedUnit[50];
        private SpyUnit[] sU = new SpyUnit[50];
        private int numberBHealerUnits = 0;
        private int numberBMageUnits = 0;
        private int numberBMeleeUnits = 0;
        private int numberBRangeUnits = 0;
        private int numberGHealerUnits = 0;
        private int numberGMageUnits = 0;
        private int numberGMeleeUnits = 0;
        private int numberGRangeUnits = 0;
        private int numberGThiefUnits = 0;
        private int numberBThiefUnits = 0;
        private int numberGSpyUnits = 0;
        private int numberBSpyUnits = 0;
        private int numberGDevilUnits = 0;
        private int numberBDevilUnits = 0;



        //public string unitFaction;

        //public void team()
        //{
        //    Random rnd = new Random();
        //    int factionChoice = rnd.Next(1, 3);

        //    if (factionChoice == 1)
        //    {
        //        unitFaction = "G";
        //    }
        //    else if (factionChoice == 2)
        //    {
        //        unitFaction = "B";
        //    }

        //}


        public string initialiseMap()
        {
            string showMap = "";


            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    map[i, j] = ".";

                }
            }

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    showMap += map[i, j];
                }
                showMap += "\n";
            }

            FactoryBuilding f = new FactoryBuilding(4, 16, 100, "Green", "#");
            factoryList.Add(f);
            map[4, 16] = factoryList[0].Symbol;
            ResourceBuilding rb = new ResourceBuilding(15, 9, 100, "Blue", "$", "Food", 2, 100);
            resourceList.Add(rb);
            map[15, 9] = resourceList[0].Symbol;

            return showMap;


        }

        public string redraw()
        {
            
            string display = "";
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    display += map[i, j] + " ";
                }
                display += Environment.NewLine;
            }
            return display;

            
        }
        //placing units in different teams

        private void placeGMeleeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GM";

        }
        private void placeGRangeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GR";

        }
        private void placeGHealerUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GH";

        }
        private void placeGMageUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GM";

        }
        private void placeGThiefUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GT";

        }
        private void placeGSpyUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GS";

        }
        private void placeGDevilUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "GD";

        }
        private void placeBMeleeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BM";

        }
        private void placeBRangeUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BR";

        }
        private void placeBHealerUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BH";

        }
        private void placeBMageUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BM";

        }
        private void placeBThiefUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BT";

        }

        private void placeBSpyUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BS";

        }
        private void placeBDevilUnit(int xPosition, int yPosition)
        {
            map[xPosition, yPosition] = "BD";

        }



        public void generateUnits()
        {

            //team();

            Random rnd = new Random();
                numberBMeleeUnits = rnd.Next(0, 25);
                int x, y;

            //blue team

                for (int i = 0; i < numberBMeleeUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");


                    mU[i] = new MeleeUnit(x, y, 100, 2, true, 1, "B", "M", "Foot Soldier");
                    placeBMeleeUnit(x, y);
                }

                numberBRangeUnits = rnd.Next(0, 25);
    
                for (int i = 0; i < numberBRangeUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                        x = rnd.Next(0, 20);
                        y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");

                    rU[i] = new RangedUnit(x, y, 100, 3, true, 5, "G", "R", "Archer");
                    placeBRangeUnit(x, y);
                }

                numberBHealerUnits = rnd.Next(0, 10);
                for (int i = 0; i < numberBHealerUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                        x = rnd.Next(0, 20);
                        y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");

                    hU[i] = new HealerUnit(x, y, 100, 5, true, 5, "B", "H", "Healer");
                    placeBHealerUnit(x, y);
                }

                numberBMageUnits = rnd.Next(0, 10);
                for (int i = 0; i < numberBMageUnits; i++)
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                    do
                    {
                        x = rnd.Next(0, 20);
                        y = rnd.Next(0, 20);
                    } while (map[x, y] != ".");

                    mageU[i] = new MageUnit(x, y, 100, 2, true, 5, "B", "M", "Mage");
                    placeBMageUnit(x, y);
                }

            numberBThiefUnits = 1;
            for (int i = 0; i < numberBThiefUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                thiefU[i] = new ThiefUnit(x, y, 100, 5, true, 1, "B", "M", "Thief");
                placeBThiefUnit(x, y);
            }

            numberBSpyUnits = rnd.Next(0,5);
            for (int i = 0; i < numberBSpyUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                sU[i] = new SpyUnit(x, y, 100, 2, true, 5, "B", "S", "Spy");
                placeBSpyUnit(x, y);
            }

            numberBDevilUnits = 1;
            for (int i = 0; i < numberBDevilUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                dU[i] = new DevilUnit(x, y, 100, 10, true, 15, "B", "D", "Devil");
                placeBDevilUnit(x, y);
            }
            //green team

            numberGMeleeUnits = rnd.Next(0, 25);


            for (int i = 0; i < numberGMeleeUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");


                mU[i] = new MeleeUnit(x, y, 100, 2, true, 1, "B", "M", "Foot Soldier");
                placeGMeleeUnit(x, y);
            }

            
            numberGRangeUnits = rnd.Next(0, 25);
            

            for (int i = 0; i < numberGRangeUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                rU[i] = new RangedUnit(x, y, 100, 3, true, 5, "G", "R", "Archer");
                placeGRangeUnit(x, y);
            }

            numberGHealerUnits = rnd.Next(0, 10);
            for (int i = 0; i < numberGHealerUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                hU[i] = new HealerUnit(x, y, 100, 5, true, 5, "G", "H", "Healer");
                placeGHealerUnit(x, y);

            }
            numberGMageUnits = rnd.Next(0, 10);
            for (int i = 0; i < numberGMageUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                mageU[i] = new MageUnit(x, y, 100, 2, true, 5, "G", "M", "Mage");
                placeGMageUnit(x, y);
            }

            numberGThiefUnits = 1;
            for (int i = 0; i < numberGThiefUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                thiefU[i] = new ThiefUnit(x, y, 100, 5, true, 1, "G", "M", "Thief");
                placeGThiefUnit(x, y);
            }

            numberGSpyUnits = rnd.Next(0, 5);
            for (int i = 0; i < numberGSpyUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                sU[i] = new SpyUnit(x, y, 100, 2, true, 5, "G", "S", "Spy");
                placeBSpyUnit(x, y);
            }

            numberGDevilUnits = 1;
            for (int i = 0; i < numberGDevilUnits; i++)
            {
                x = rnd.Next(0, 20);
                y = rnd.Next(0, 20);
                do
                {
                    x = rnd.Next(0, 20);
                    y = rnd.Next(0, 20);
                } while (map[x, y] != ".");

                dU[i] = new DevilUnit(x, y, 100, 10, true, 15, "B", "D", "DEVIL");
                placeGDevilUnit(x, y);
            }

        }


        
        public void moveUnit()
        {

            
        }

        #region read
        //reading from a file
        private List<MeleeUnit> meleeList = new List<MeleeUnit>();
        private List<MeleeUnit> MeleeList
        {
            get { return meleeList; }
        }

        private List<RangedUnit> rangedList = new List<RangedUnit>();
        private List<RangedUnit> RangedList
        {
            get { return rangedList; }
        }

        private List<FactoryBuilding> factoryList = new List<FactoryBuilding>();
        private List<FactoryBuilding> FactoryBuilding
        {
            get { return factoryList; }
        }

        private List<ResourceBuilding> resourceList = new List<ResourceBuilding>();
        private List<ResourceBuilding> ResourceList

        {
            get { return resourceList; }
        }

        private List<HealerUnit> healerList = new List<HealerUnit>();
        private List<HealerUnit> HealerList
        {
            get { return healerList; }
        }

        private List<MageUnit> mageList = new List<MageUnit>();
        private List<MageUnit> MageList
        {
            get { return mageList; }
        }

        private List<ThiefUnit> thiefList = new List<ThiefUnit>();
        private List<ThiefUnit> ThiefList
        {
            get { return thiefList; }
        }


        private List<DevilUnit> devilList = new List<DevilUnit>();
        private List<DevilUnit> DevilList
        {
            get { return devilList; }
        }

        private List<SpyUnit> spyList = new List<SpyUnit>();
        private List<SpyUnit> SpyList
        {
            get { return spyList; }
        }


        public void loadMap()
        {

            FileStream inFile = null;
            StreamReader reader = null;
            string input;
            int x;
            int y;
            int health;
            int speed;
            bool attack;
            int attackRange;
            string faction;
            string symbol;
            string name;
            string resourceType;
            int resourcesPerTick;
            int resourcesRemaining;

            try
            {
                inFile = new FileStream(@"Files\meleeunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    MeleeUnit m = new MeleeUnit(x,y,health,speed,attack,attackRange,faction,symbol,name);
                    meleeList.Add(m);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            
            
            try
            {
                inFile = new FileStream(@"Files\rangedunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    RangedUnit r = new RangedUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    rangedList.Add(r);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }

            try
            {
                inFile = new FileStream(@"Files\factorybuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    
                    FactoryBuilding f = new FactoryBuilding(x, y, health, faction, symbol);
                    factoryList.Add(f);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }

            try
            {
                inFile = new FileStream(@"Files\resourcebuilding.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    resourceType = reader.ReadLine();
                    resourcesPerTick = int.Parse(reader.ReadLine());
                    resourcesRemaining = int.Parse(reader.ReadLine());


                    ResourceBuilding rb = new ResourceBuilding(x, y, health, faction, symbol, resourceType, resourcesPerTick, resourcesRemaining);
                    resourceList.Add(rb);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }

            try
            {
                inFile = new FileStream(@"Files\healerunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    HealerUnit h = new HealerUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    healerList.Add(h);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }

            try
            {
                inFile = new FileStream(@"Files\mageunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    MageUnit m = new MageUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    mageList.Add(m);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\thiefunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    ThiefUnit t = new ThiefUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    thiefList.Add(t);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\spyunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    SpyUnit s = new SpyUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    spyList.Add(s);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
            try
            {
                inFile = new FileStream(@"Files\devilunit.txt", FileMode.Open, FileAccess.Read);
                reader = new StreamReader(inFile);
                input = reader.ReadLine();      // priming read
                while (input != null)
                {
                    x = int.Parse(reader.ReadLine());
                    y = int.Parse(reader.ReadLine());
                    health = int.Parse(reader.ReadLine());
                    speed = int.Parse(reader.ReadLine());
                    attack = bool.Parse(reader.ReadLine());
                    attackRange = int.Parse(reader.ReadLine());
                    faction = reader.ReadLine();
                    symbol = reader.ReadLine();
                    name = reader.ReadLine();

                    DevilUnit d = new DevilUnit(x, y, health, speed, attack, attackRange, faction, symbol, name);
                    devilList.Add(d);
                    input = reader.ReadLine();      // secondary read
                }
                reader.Close();
                inFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }
            finally
            {
                if (inFile != null)
                {
                    reader.Close();
                    inFile.Close();
                }
            }
        }


        #endregion

        //public void (MeleeUnit, int x, int y)
        //{
        //    mU.X = x;
        //    meleeUnit.Y = y;
        //}

        //public void update(Map.mU)
        //{
        //    map[uRange.X, uRange.Y] = ".";
        //    position(mU, new X, new Y);
        //    map[mU.X, M.Y] = ".";
        //}
    }

}

