using BeastAutoRun.option;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastAutoRun.script
{
    class AutoLoot
    {
        private Option option = new Option();

        public AutoLoot()
        {

        }

        public void start()
        {
            int onlyHome = 0;
            int goon = 0;

            while (true)
            {
                // get treasure at home
                if (option.RegnizeColor(267, 485, "BFC4CC")
                    && option.RegnizeColor(322, 485, "BFC4CC")
                    && option.RegnizeColor(376, 485, "BFC4CC"))
                {
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
                    option.Click(516, 638);
                    option.Wait(2000);
                }

                // run dungeon close dialogue
                if (option.RegnizeColor(335, 300, "BC752F")
                    && option.RegnizeColor(626, 330, "BC752F")
                    && option.RegnizeColor(478, 300, "BC752F"))
                {
                    option.Click(626, 330);
                    option.Wait(2000);
                }

                // get treasure in dungeon
                if (option.RegnizeColor(585, 485, "A1A5AC")
                    && option.RegnizeColor(637, 485, "A1A5AC")
                    && option.RegnizeColor(688, 485, "A1A5AC"))
                {
                    for(int i = 0; i < 10; i++)
                    {
                        option.Click(637, 500);
                    }
                    option.Wait(2000);
                }

                // get treasure when treasure!
                if (option.RegnizeColor(281, 255, "F4F1E1")
                    && option.RegnizeColor(648, 271, "F4F1E1")
                    && option.RegnizeColor(1018, 272, "F4F1E1"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        option.Click(637, 500);
                    }
                    option.Wait(2000);
                    option.Click(1188, 620);
                    option.Wait(2000);
                }

                // get treasure when defeat
                if (option.RegnizeColor(429, 296, "E52023")
                    && option.RegnizeColor(610, 292, "E52023")
                    && option.RegnizeColor(893, 313, "E52023"))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        option.Click(637, 500);
                    }
                    option.Wait(2000);

                    // go home
                    option.Click(91, 658);
                    option.Wait(2000);
                }

                // close dialogue when run
                if (option.RegnizeColor(584, 370, "BC752F")
                    && option.RegnizeColor(637, 350, "BC752F")
                    && option.RegnizeColor(710, 370, "BC752F"))
                {
                    option.Click(637, 350);
                    option.Wait(2000);
                }

                // start run
                if (option.RegnizeColor(1135, 620, "FF5C54"))
                {
                    goon++;
                    if(goon>=20)
                    {
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
                        option.Click(91, 658);
                        option.Wait(2000);
                    }

                }else
                {
                    onlyHome = 0;
                }

                option.Click(637, 357);
                option.Wait(100);
            }

        }
    }
}
