using BeastAutoRun.option;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeastAutoRun.script
{
    enum BuyItems
    {
        Skills,
        Melee_Skills,
        Range_Skills,
        Magic_Skills,
        Animals,
        Legend_Equips
    }


    class AutoLoot
    {
        private Option option = new Option();
        private bool req_stop = true;
        public bool run = false;

        public AutoLoot()
        {

        }

        private bool ready()
        {
            if (!option.GameCheck())
            {
                MessageBox.Show("请重启本程序");
                return false;
            }

            return true;
        }

        public void buy(BuyItems item)
        {
            if (!ready())
                return;

            run = true;
            req_stop = false;
            while (!req_stop)
            {
                switch(item)
                {
                    case BuyItems.Skills:
                        option.Click(830, 150);
                        option.Click(830, 150);
                        break;
                    case BuyItems.Melee_Skills:
                        option.Click(830, 300);
                        option.Click(830, 300);
                        break;
                    case BuyItems.Animals:
                        option.Click(637, 150);
                        option.Click(637, 150);
                        break;
                    case BuyItems.Legend_Equips:
                        option.Click(450, 300);
                        option.Click(450, 300);
                        break;
                    case BuyItems.Magic_Skills:
                        option.Click(990, 300);
                        option.Click(990, 300);
                        break;
                    case BuyItems.Range_Skills:
                        option.Click(990, 150);
                        option.Click(990, 150);
                        break;
                }
                option.Wait(100);
            }
            Debug.WriteLine("buy stop");
        }

        public void stop()
        {
            req_stop = true;
            run = false;
        }

        public void start()
        {
             if (!ready())
                return;

            run = true;
            int onlyHome = 0;
            int goon = 0;
            int defeat = 0;
            int arena_time = 0;
            req_stop = false;
            int loop_time = 0;

            while (!req_stop)
            {

                // get treasure at home
                if (option.RegnizeColor(267, 485, "BFC4CC")
                    && option.RegnizeColor(322, 485, "BFC4CC")
                    && option.RegnizeColor(376, 485, "BFC4CC"))
                {
                    Debug.WriteLine("get treasure at home");
                    for (int i = 0; i < 10; i++)
                    {
                        option.Click(322, 485);
                    }
                    option.Wait(2000);
                }

                // get dungeon treasure at home
                if (option.RegnizeColor(105, 485, "BFC4CC")
                    && option.RegnizeColor(162, 485, "BFC4CC")
                    && option.RegnizeColor(214, 485, "BFC4CC"))
                {
                    Debug.WriteLine("get dungeon treasure at home");
                    for (int i = 0; i < 10; i++)
                    {
                        option.Click(162, 485);
                    }
                    option.Wait(2000);
                }

                // enter dungeon
                if (option.RegnizeColor(442, 638, "834330")
                    && option.RegnizeColor(518, 638, "834330")
                    && option.RegnizeColor(476, 612, "834330"))
                {
                    Debug.WriteLine("enter dungeon");
                    option.Click(516, 638);
                    option.Wait(2000);
                }

                // get treasure in dungeon
                if (option.RegnizeColor(585, 485, "A1A5AC")
                    && option.RegnizeColor(637, 485, "A1A5AC")
                    && option.RegnizeColor(688, 485, "A1A5AC"))
                {
                    Debug.WriteLine("get treasure in dungeon");
                    for (int i = 0; i < 10; i++)
                    {
                        option.Click(637, 500);
                    }
                    option.Wait(3000);
                }

                // enter arena
                if (option.RegnizeColor(807, 652, "BECDE5")
                    && option.RegnizeColor(825, 627, "BECDE5"))
                {
                    // more than about 100s from last arena
                    if(loop_time -arena_time > 1000)
                    {
                        Debug.WriteLine("enter arena");
                        option.Click(807, 652);
                        option.Wait(2000);
                        arena_time = loop_time;
                    }
                }

                // get arena treasure
                if (option.RegnizeColor(643, 521, "BFC4CC")
                    && option.RegnizeColor(340, 334, "FFCE0A"))
                {
                    Debug.WriteLine("get arena treasure");
                    for (int i = 0; i < 20; i++)
                    {
                        option.Click(643, 521);
                    }
                    // go home
                    Debug.WriteLine("go home");
                    option.Click(91, 658);
                    option.Wait(2000);
                }

                // get treasure when treasure!
                if (option.RegnizeColor(281, 255, "F4F1E1")
                    && option.RegnizeColor(648, 271, "F4F1E1")
                    && option.RegnizeColor(1018, 272, "F4F1E1"))
                {
                    Debug.WriteLine("get treasure when treasure!");
                    for (int i = 0; i < 20; i++)
                    {
                        option.Click(637, 500);
                    }

                    Debug.WriteLine("go ahead");
                    option.Click(1188, 620);
                    option.Wait(2000);
                }

                // get treasure when defeat
                if (option.RegnizeColor(429, 296, "E52023")
                    && option.RegnizeColor(610, 292, "E52023")
                    && option.RegnizeColor(893, 313, "E52023"))
                {
                    // if has chance to change opponent
                    if(option.RegnizeColor(1155, 641, "FF5C54")&&defeat<2)
                    {
                        Debug.WriteLine("change opponent try again");
                        defeat++;
                        option.Click(1155, 641);
                        option.Wait(2000);
                    }
                    else
                    {
                        Debug.WriteLine("get treasure when defeat");
                        for (int i = 0; i < 20; i++)
                        {
                            option.Click(637, 500);
                        }

                        // go home
                        Debug.WriteLine("go home");
                        option.Click(91, 658);
                        option.Wait(2000);
                    }

                }

                // close dialogue when run
                if (option.RegnizeColor(550, 367, "BC752F")
                    || option.RegnizeColor(637, 350, "BC752F")
                    || option.RegnizeColor(710, 370, "BC752F")
                    || option.RegnizeColor(643, 410, "BC752F"))
                {
                    Debug.WriteLine("close dialogue when run");
                    option.Click(637, 380);
                    option.Wait(500);
                }

                // auto 
                if (option.RegnizeColor(1129, 690, "A08359")
                    && option.RegnizeColor(1153, 698, "A08359")
                    && option.RegnizeColor(1177, 687, "A08359")
                    && option.RegnizeColor(1201, 698, "A08359"))
                {
                    Debug.WriteLine("close dialogue when run");
                    option.Click(1177, 698);
                    option.Wait(500);
                }

                // start run
                if (option.RegnizeColor(1135, 620, "FF5C54"))
                {
                    goon++;
                    onlyHome = 0;
                    if (goon>=20)
                    {
                        Debug.WriteLine("start run");
                        option.Click(1188, 620);
                        option.Wait(2000);
                    }
                }else
                {
                    goon = 0;
                }

                // go home
                if (option.RegnizeColor(91, 658, "BC752F"))
                {
                    onlyHome++;
                    if (onlyHome >= 20)
                    {
                        Debug.WriteLine("go home");
                        option.Click(91, 658);
                        option.Wait(2000);
                        defeat = 0;
                    }

                }else
                {
                    onlyHome = 0;
                }

                //option.Click(637, 357);
                option.Wait(100);
                loop_time++;
            }
            Debug.WriteLine("AutoLoot stop");

        }
    }
}
