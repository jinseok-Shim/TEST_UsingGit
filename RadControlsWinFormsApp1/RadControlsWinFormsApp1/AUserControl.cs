using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RadControlsWinFormsApp1
{
    public partial class AUserControl : UserControl
    {
        public AUserControl()
        {
            InitializeComponent();
        }

        private bool _activeAlive;

        public bool ActiveAlive
        {
            get { return this._activeAlive; }
            set
            {
                this._activeAlive = value;
                if (!value)
                {
                }
                else
                {
                }
            }
        }
    }
}
