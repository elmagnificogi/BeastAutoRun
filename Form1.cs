using BeastAutoRun.script;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace BeastAutoRun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AutoLoot autoLoot = new AutoLoot();
        Task autoLootTask;
        private void button1_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.start();
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            autoLoot.stop();
        }

        //bool run=false;
        private void button6_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Animals);
                });
                autoLootTask.Start();
            } 
            else
            {
                autoLoot.stop();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Legend_Equips);
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Skills);
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Range_Skills);
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Melee_Skills);
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!autoLoot.run)
            {
                autoLootTask = new Task(() => {
                    autoLoot.buy(BuyItems.Magic_Skills);
                });
                autoLootTask.Start();
            }
            else
            {
                autoLoot.stop();
            }
        }
    }
}
