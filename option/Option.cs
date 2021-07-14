using opLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastAutoRun.option
{
    class Option
    {
        private OpInterface opdll;
        public Option()
        {
            // reg the opdll and bind to the game
            Opdll.Binding();
            opdll = Opdll.GetInstance();
            //opdll.SetDict(0, "img/字库.dict");

            // the default reslution
            //resolution = new Resolution(1600, 900);
        }
        public void Click(int x, int y)
        {
            opdll.MoveTo(x, y);
            opdll.Sleep(100);
            opdll.LeftDown();
            opdll.Sleep(100);
            opdll.LeftUp();
            opdll.MoveTo(1200, 50);
        }

        public String GetColor(int x1, int y1)
        {
            return opdll.GetColor(x1, y1);
        }

        public bool RegnizeColor(int x1, int y1,String color)
        {
            String temp = opdll.GetColor(x1, y1);
            return temp.Equals(color);
        }
        public void Wait(int time)
        {
            opdll.Sleep(time);
        }

    }
}
