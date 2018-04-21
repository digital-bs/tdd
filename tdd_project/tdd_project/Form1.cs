using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tdd_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void enterNamesVisible(bool visible)
        {
            textBoxName1.Visible = visible;
            textBoxName2.Visible = visible;
            labelName1.Visible = visible;
            labelName2.Visible = visible;
            labelNames.Visible = visible;
            buttonStart.Visible = visible;
            buttonStartForm.Visible = !visible;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            enterNamesVisible(false);
        }

        private void buttonStartForm_Click(object sender, EventArgs e)
        {
            enterNamesVisible(true);
        }
    }
}
