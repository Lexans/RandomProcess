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
    public partial class FormSelectCF : Form
    {
        public FormSelectCF()
        {
            InitializeComponent();
            comboBoxCF.SelectedIndex = 0;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (comboBoxCF.SelectedItem.ToString())
            {
                case "Затухающая":
                    ICorrFunc dcf = new CFDecaying(
                        (double)numericUpDownParam1.Value
                        );

                    RandomProcess.Inst.Stochastic = dcf;
                    break;

                case "Колебательная":
                    ICorrFunc ocf = new CFOscillatory(
                        (double)numericUpDownParam1.Value,
                        (double)numericUpDownParam2.Value
                        );

                    RandomProcess.Inst.Stochastic = ocf;
                    break;
            }

            RandomProcess.Inst.Generate();

            Hide();
            if ((new FormModelingCF().ShowDialog(this)) == DialogResult.OK)
                Show();

        }

        private void comboBoxCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxCF.SelectedItem.ToString())
            {
                case "Затухающая":
                    labelParam2.Visible = false;
                    numericUpDownParam2.Visible = false;
                    break;

                case "Колебательная":
                    labelParam2.Visible = true;
                    numericUpDownParam2.Visible = true;
                    break;
            }
        }

        private void FormSelectCF_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Program.ShowHelp();
        }
    }
}
