using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GadeAssignment
{
    public partial class Form1 : Form
    {
        MageUnit mU = new MageUnit();
        HealerUnit h = new HealerUnit();
        MeleeUnit m = new MeleeUnit();
        RangedUnit r = new RangedUnit();
        FactoryBuilding f = new FactoryBuilding();
        ResourceBuilding rb = new ResourceBuilding();
        ThiefUnit t = new ThiefUnit();
        DevilUnit d = new DevilUnit();
        SpyUnit s = new SpyUnit();
        Map map = new Map();

        public int tick;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            //map.updateMap();
            map.initialiseMap();
            map.generateUnits();
           lblMap.Text = map.redraw();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
            lblTimer.Text = tick.ToString();
            //map.updateMap();
            lblMap.Text = map.redraw();
            
            if (tick % 5 == 1)
            {
                f.spawnUnits();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
 
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            r.save();
            f.save();
            rb.save();
            m.save();
            t.save();
            s.save();
            d.save();
            mU.save();
            h.save();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtUnitInfo.Text = "";
            map.loadMap();
            
        }

        private void txtUnitInfo_TextChanged(object sender, EventArgs e)
        {
            txtUnitInfo.Text = m.toString();
            txtUnitInfo.Text = r.toString();
            txtUnitInfo.Text = f.toString();
            txtUnitInfo.Text = rb.toString();
            txtUnitInfo.Text = h.toString();
            txtUnitInfo.Text = mU.toString();
            txtUnitInfo.Text = t.toString();
            txtUnitInfo.Text = s.toString();
            txtUnitInfo.Text = d.toString();
        }
    }
}
