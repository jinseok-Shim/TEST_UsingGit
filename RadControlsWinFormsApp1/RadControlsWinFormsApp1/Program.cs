using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RadControlsWinFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Publisher p = new Publisher();
            //p.Click += new Publisher.MyEventHandler(p_Click);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //static void p_Click()
        //{
        //    Console.WriteLine("Event 발생");
        //}
    }
}
