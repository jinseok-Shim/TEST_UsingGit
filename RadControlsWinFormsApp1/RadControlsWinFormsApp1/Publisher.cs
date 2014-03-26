using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RadControlsWinFormsApp1
{
    class Publisher
    {
        public delegate void MyEventHandler();

        public event MyEventHandler Click;

        public void DoClick()
        {
            if (Click != null)
            {
                Click();
            }
        }
    }
}
