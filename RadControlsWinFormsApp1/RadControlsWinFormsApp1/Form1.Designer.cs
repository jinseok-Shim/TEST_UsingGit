namespace RadControlsWinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.TabA = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabB = new Telerik.WinControls.UI.RadPageViewPage();
            this.TabC = new Telerik.WinControls.UI.RadPageViewPage();
            this.object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f = new Telerik.WinControls.RootRadElement();
            this.APageButton = new Telerik.WinControls.UI.RadButton();
            this.BPageButton = new Telerik.WinControls.UI.RadButton();
            this.CPageButton = new Telerik.WinControls.UI.RadButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aUserControl = new RadControlsWinFormsApp1.AUserControl();
            this.bUserControl = new RadControlsWinFormsApp1.BUserControl();
            this.cUserControl = new RadControlsWinFormsApp1.CUserControl();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.TabA.SuspendLayout();
            this.TabB.SuspendLayout();
            this.TabC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.APageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPageButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPageButton)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.TabA);
            this.radPageView1.Controls.Add(this.TabB);
            this.radPageView1.Controls.Add(this.TabC);
            this.radPageView1.Location = new System.Drawing.Point(0, 0);
            this.radPageView1.Margin = new System.Windows.Forms.Padding(0);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.TabA;
            this.radPageView1.Size = new System.Drawing.Size(682, 406);
            this.radPageView1.TabIndex = 0;
            this.radPageView1.Text = "radPageView1";
            // 
            // TabA
            // 
            this.TabA.Controls.Add(this.aUserControl);
            this.TabA.Location = new System.Drawing.Point(10, 37);
            this.TabA.Name = "TabA";
            this.TabA.Size = new System.Drawing.Size(661, 358);
            this.TabA.Text = "APage";
            // 
            // TabB
            // 
            this.TabB.Controls.Add(this.bUserControl);
            this.TabB.Location = new System.Drawing.Point(10, 37);
            this.TabB.Name = "TabB";
            this.TabB.Size = new System.Drawing.Size(661, 358);
            this.TabB.Text = "BPage";
            // 
            // TabC
            // 
            this.TabC.Controls.Add(this.cUserControl);
            this.TabC.Location = new System.Drawing.Point(10, 37);
            this.TabC.Name = "TabC";
            this.TabC.Size = new System.Drawing.Size(661, 358);
            this.TabC.Text = "CPage";
            // 
            // object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f
            // 
            this.object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f.Name = "object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f";
            this.object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f.StretchHorizontally = true;
            this.object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f.StretchVertically = true;
            // 
            // APageButton
            // 
            this.APageButton.Location = new System.Drawing.Point(3, 3);
            this.APageButton.Name = "APageButton";
            this.APageButton.Size = new System.Drawing.Size(221, 38);
            this.APageButton.TabIndex = 1;
            this.APageButton.Text = "APage";
            this.APageButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // BPageButton
            // 
            this.BPageButton.Location = new System.Drawing.Point(230, 3);
            this.BPageButton.Name = "BPageButton";
            this.BPageButton.Size = new System.Drawing.Size(221, 38);
            this.BPageButton.TabIndex = 2;
            this.BPageButton.Text = "BPage";
            this.BPageButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // CPageButton
            // 
            this.CPageButton.Location = new System.Drawing.Point(457, 3);
            this.CPageButton.Name = "CPageButton";
            this.CPageButton.Size = new System.Drawing.Size(215, 38);
            this.CPageButton.TabIndex = 3;
            this.CPageButton.Text = "CPage";
            this.CPageButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.APageButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CPageButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.BPageButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 409);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(683, 44);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // aUserControl
            // 
            this.aUserControl.ActiveAlive = false;
            this.aUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aUserControl.Location = new System.Drawing.Point(0, 0);
            this.aUserControl.Name = "aUserControl";
            this.aUserControl.Size = new System.Drawing.Size(661, 358);
            this.aUserControl.TabIndex = 0;
            // 
            // bUserControl
            // 
            this.bUserControl.ActiveAlive = false;
            this.bUserControl.Location = new System.Drawing.Point(0, 0);
            this.bUserControl.Name = "bUserControl";
            this.bUserControl.Size = new System.Drawing.Size(662, 358);
            this.bUserControl.TabIndex = 0;
            // 
            // cUserControl
            // 
            this.cUserControl.ActiveAlive = false;
            this.cUserControl.Location = new System.Drawing.Point(0, 0);
            this.cUserControl.Name = "cUserControl";
            this.cUserControl.Size = new System.Drawing.Size(661, 358);
            this.cUserControl.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.radPageView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.TabA.ResumeLayout(false);
            this.TabB.ResumeLayout(false);
            this.TabC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.APageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BPageButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPageButton)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage TabA;
        private Telerik.WinControls.UI.RadPageViewPage TabB;
        private Telerik.WinControls.UI.RadPageViewPage TabC;
        private Telerik.WinControls.RootRadElement object_11bf8fd6_3dd0_4d86_8874_a02f0cc10f1f;
        private Telerik.WinControls.UI.RadButton APageButton;
        private Telerik.WinControls.UI.RadButton BPageButton;
        private Telerik.WinControls.UI.RadButton CPageButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private AUserControl aUserControl;
        private BUserControl bUserControl;
        private CUserControl cUserControl;
    }
}

