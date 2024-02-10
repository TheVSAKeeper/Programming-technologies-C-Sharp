﻿using System.Windows.Forms;

namespace TextFiles
{
    internal static class ControlExtension
    {
        public static void TurnOn(this Control control)
        {
            control.Enabled = true;
        }

        public static void TurnOff(this Control control)
        {
            control.Enabled = false;
        }
    }
}