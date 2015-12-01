using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomProcess
{
    public partial class FormSelectMethod : Form
    {
        public FormSelectMethod()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            RandomProcess.Inst.N = (int) numericUpDownN.Value;

            Hide();

            if (radioButtonDistr.Checked)
            {
                if ((new FormSelectDistr().ShowDialog(this)) == DialogResult.OK)
                    Show();
            }
            else if (radioButtonCF.Checked) {
                 if ((new FormSelectCF().ShowDialog(this)) == DialogResult.OK)
                    Show();
            }

            numericUpDownN.Value = RandomProcess.Inst.N;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           new FormAbout().ShowDialog(this);
        }

        private void FormSelectMethod_Activated(object sender, EventArgs e)
        {
        }

        private void FormSelectMethod_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Program.ShowHelp();
        }

        private void FormSelectMethod_Load(object sender, EventArgs e)
        {

        }



    }
}
