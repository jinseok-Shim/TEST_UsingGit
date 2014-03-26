using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.Primitives;

namespace RadControlsWinFormsApp1
{
    public partial class Form1 : Form
    {
        private RadPageViewPage OldTabItem { get; set; }

        public Form1()
        {
            InitializeComponent();

            // RadPageView TabMenu(Strip 메뉴) ElementVisibility.Collapsed 처리
            RadPageViewStripElement el = radPageView1.ViewElement as RadPageViewStripElement;
            el.ItemContainer.Visibility = Telerik.WinControls.ElementVisibility.Collapsed;

            //this.radPageView1.SelectedPageChanging += new EventHandler<RadPageViewCancelEventArgs>(radPageView1_SelectedPageChanging);
            //Publisher p = new Publisher();
            //p.DoClick();
        }

        private void MainButton_Click(object sender, EventArgs e)
        {
            RadButton button = (RadButton)sender;
            if (button != null)
            {
                if (button == this.APageButton)
                    this.radPageView1.SelectedPage = this.TabA;
                else if (button == this.BPageButton)
                    this.radPageView1.SelectedPage = this.TabB;
                else if (button == this.CPageButton)
                    this.radPageView1.SelectedPage = this.TabC;
            }
        }

        private void radPageView1_SelectedPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
            RadPageView tab = (RadPageView)sender;
            if (tab != null)
            {
                if (tab.SelectedPage != null)
                {
                    this.OldTabItem = (RadPageViewPage)tab.SelectedPage;
                }
            }
        }

        private void radTabMain_SelectedPageChanged(object sender, EventArgs e)
        {
                RadPageView tab = (RadPageView)sender;
                if (tab != null)
                {
                    foreach (var item in tab.Pages)
                    {
                        if (((RadPageViewPage)item).Controls.Count > 0)
                        {
                            if (String.Compare(item.Name, tab.SelectedPage.Name, true) == 0)
                            {
                                #region 선택된 Tab

                                object control = ((RadPageViewPage)item).Controls[0];
                                this.AliveContent(control, true);

                                #endregion

                                #region 선택 해제된 Tab
                                if (this.OldTabItem != null && this.OldTabItem.Controls.Count > 0 && this.OldTabItem != item)
                                {
                                    object oldcontrol = this.OldTabItem.Controls[0];
                                    this.AliveContent(oldcontrol, false);
                                }
                                #endregion
                                break;
                            }
                        }
                    }
                }
        }

        private void AliveContent(object control, bool activeAlive)
        {

            if (control != null)
            {
                RadButton button = null;
                if (control.GetType() == typeof(AUserControl))
                {
                    AUserControl content = control as AUserControl;
                    if (content != null)
                    {
                        if (activeAlive && !content.ActiveAlive)
                            content.ActiveAlive = true;
                        else if (!activeAlive && content.ActiveAlive)
                            content.ActiveAlive = false;
                    }
                    button = this.APageButton;
                }
                else if (control.GetType() == typeof(BUserControl))
                {
                    BUserControl content = control as BUserControl;
                    if (content != null)
                    {
                        if (activeAlive && !content.ActiveAlive)
                            content.ActiveAlive = true;
                        else if (!activeAlive && content.ActiveAlive)
                            content.ActiveAlive = false;
                    }
                    button = this.BPageButton;
                }
                else if (control.GetType() == typeof(CUserControl))
                {
                    CUserControl content = control as CUserControl;
                    if (content != null)
                    {
                        if (activeAlive && !content.ActiveAlive)
                            content.ActiveAlive = true;
                        else if (!activeAlive && content.ActiveAlive)
                            content.ActiveAlive = false;
                    }
                    button = this.CPageButton;
                }
            }
        }
    }
}
