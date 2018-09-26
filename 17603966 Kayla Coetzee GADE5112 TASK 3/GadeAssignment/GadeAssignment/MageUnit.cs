using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace GadeAssignment
{
    class MageUnit: Unit
    {
        public MageUnit() { }

        private const int BUFF = 5;

        //constructors

        public MageUnit(int x, int y, int health, int speed, bool attack, int attackRange, string faction, string symbol, string name)
            : base(x, y, health, speed, attack, attackRange, faction, symbol, name)
        {
        }

        public override void move(int x, int y)
        {
            if (x >= 0 && x < 20)
            {
                X = x;
            }

            if (y >= 20 && y < 20)
            {
                Y = y;
            }
        }

        public override void combat(Unit teammate)
        {
            if (this.isWithinAttackRange(teammate))
            {
                teammate.Speed += BUFF;
            }
        }

        public override bool isWithinAttackRange(Unit teammate)
        {
            if (!this.Faction.Equals(teammate.Faction))
            {
                if ((Math.Abs(this.X - teammate.X) <= this.AttackRange) && (Math.Abs(this.Y - teammate.Y) <= this.AttackRange))
                {
                    return true;
                }

            }
            return false;

        }

        public override Unit nearestUnit(List<Unit> list)
        {
            Unit closest = null;
            int attackRangeX, attackRangeY;
            double range;
            int shortestRange = 1000;

            foreach (Unit u in list)
            {
                attackRangeX = Math.Abs(this.X - u.X);
                attackRangeY = Math.Abs(this.Y = u.Y);

                range = Math.Sqrt(Math.Pow(attackRangeX, 2) + Math.Pow(attackRangeY, 2));

                if (attackRangeX < shortestRange)
                {
                    shortestRange = attackRangeX;
                    closest = u;
                }
                if (attackRangeY < shortestRange)
                {
                    shortestRange = attackRangeY;
                    closest = u;
                }
            }
            return closest;
        }

        public override bool isAlive()
        {
            if (this.Health <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string toString()
        {
            string output = "x : " + X + Environment.NewLine
                + "y : " + Y + Environment.NewLine
                + "Health : " + Health + Environment.NewLine
                + "Speed : " + Speed + Environment.NewLine
                + "Attack : " + Attack + Environment.NewLine
                + "Attack Range : " + AttackRange + Environment.NewLine
                + "Faction : " + Faction + Environment.NewLine
                + "Symbol : " + Symbol + Environment.NewLine
                + "Name: " + Name + Environment.NewLine;
            return output;
        }
        public override void save()
        {
            FileStream outFile = null;
            StreamWriter writer = null;

            try
            {
                //open file
                outFile = new FileStream(@"Files\mageunit.txt", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(outFile);

                //wrtite to the file
                writer.WriteLine(x);
                writer.WriteLine(y);
                writer.WriteLine(health);
                writer.WriteLine(speed);
                writer.WriteLine(attack);
                writer.WriteLine(attackRange);
                writer.WriteLine(faction);
                writer.WriteLine(symbol);
                writer.WriteLine(name);

                writer.Close();
                outFile.Close();
            }
            catch (Exception fe)
            {
                Debug.WriteLine(fe.Message);
            }

        }
        public override void read() { }

    }
}

