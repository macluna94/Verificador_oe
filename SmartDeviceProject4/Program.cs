using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SmartDeviceProject4
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}