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

        private void progressBar_reset()
        {
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Value = 0;
            progressBar1.Enabled = false;
        }

        private void progressBar_start()
        {
            progressBar1.Enabled = true;
            progressBar1.MarqueeAnimationSpeed = 15;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool jump_vault = checkBox1.Checked;
            bool dungeon_full_reward = checkBox2.Checked;

            if (!autoLoot.run)
            {
                autoLootTask = new Task(() =>
                {
                    autoLoot.start(jump_vault, dungeon_full_reward);
                });
                autoLootTask.Start();
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
            }
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
                progressBar_start();
            } 
            else
            {
                autoLoot.stop();
                progressBar_reset();
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
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
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
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
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
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
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
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
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
                progressBar_start();
            }
            else
            {
                autoLoot.stop();
                progressBar_reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 5;
            progressBar1.Value %= 110;
            
            
        }
    }
}
