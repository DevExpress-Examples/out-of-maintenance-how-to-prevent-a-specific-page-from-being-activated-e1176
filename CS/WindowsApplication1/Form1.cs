using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void wizardControl1_SelectedPageChanging(object sender, DevExpress.XtraWizard.WizardPageChangingEventArgs e)
        {
            if (e.Page == wizardControl1.Pages[1] && checkEdit1.Checked)
            {
                int nextPageIndex = ((e.Direction == DevExpress.XtraWizard.Direction.Forward) ? 1 : -1) + wizardControl1.Pages.IndexOf(e.Page);
                e.Page = wizardControl1.Pages[nextPageIndex];
            }
        }
    }
}