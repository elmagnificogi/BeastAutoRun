﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using opLib;

namespace BeastAutoRun.option
{
    class Opdll
    {
        static OpInterface op;
        private static int optionHwnd;
        public static bool Binding()
        {
            int ret = 0;
            op = new OpInterface();
            Debug.WriteLine(op.Ver());

            int hwnd = op.FindWindow("YYGameMakerYY", "Beastrun");
            if (hwnd <= 0)
            {
                Debug.WriteLine("cant find game");
                return false;
            }
            Debug.WriteLine("hwnd " + hwnd.ToString());

            //int mainHwnd = op.FindWindowEx(hwnd, "RenderWindow", "TheRender");
            //if (mainHwnd <= 0)
            //{
            //    Debug.WriteLine("cant find game render window");
            //    return false;
            //}
            //Debug.WriteLine("mainHwnd " + mainHwnd.ToString());

            //int subHwnd = op.FindWindowEx(mainHwnd, "subWin", "sub");
            //if (subHwnd <= 0)
            //{
            //    Debug.WriteLine("cant find game sub window");
            //    return false;
            //}
            //Debug.WriteLine("subHwnd " + subHwnd.ToString());
            int mainHwnd = hwnd;

            ret = op.BindWindow(mainHwnd, "dx", "windows", "windows", 0);
            if (ret == 0)
            {
                Debug.WriteLine("binding failed");
                return false;
            }
            // wait binding
            op.Sleep(200);

            //Test();
            return true;
        }

        static void Test()
        {
            // capture test
            op.Capture(0, 0, 200, 200, "test.bmp");
            object x, y;
            // find test
            op.FindPic(0, 0, 2000, 1000, "test.bmp", "000000", 1.0, 0, out x, out y);
            Debug.WriteLine(x.ToString() + "," + y.ToString());

            // key and mouse test
            //op.KeyPress(52);
            //op.KeyPressChar("4");
            op.MoveTo(100, 650);
            op.Sleep(200);
            op.LeftClick();
        }

        ~Opdll()
        {
            // unbinding the windows
            op.UnBindWindow();
        }

        public static OpInterface GetInstance()
        {
            return op;
        }

        public static int GetOptionHwnd()
        {
            return optionHwnd;
        }

    }
}