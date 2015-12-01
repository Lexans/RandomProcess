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
    public partial class FormSelectDistr : Form
    {
        public FormSelectDistr()
        {
            InitializeComponent();
            comboBoxDistr.SelectedIndex = 0;
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxChoiceLawDistribution_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxDistr.SelectedItem.ToString())
            {
                case "Равномерный":
                    labelParam1.Text = "a";
                    labelParam2.Visible = true;
                    numericUpDownParam2.Visible = true;
                    labelParam2.Text = "b";

                    numericUpDownParam1.Minimum = -100;
                    numericUpDownParam1.Maximum = 100;


                    numericUpDownParam2.Minimum = numericUpDownParam1.Value + 0.01M;
                    numericUpDownParam1.Maximum = 100;

                    numericUpDownParam1.Value = 0;
                    numericUpDownParam2.Value = 1;

                    break;

                case "Экспоненциальный":
                    labelParam1.Text = "λ";
                    labelParam2.Visible = false;
                    numericUpDownParam2.Visible = false;

                    numericUpDownParam1.Minimum = 0.01M;
                    numericUpDownParam1.Maximum = 100;
                    numericUpDownParam1.Value = 1;

                    break;

                case "Нормальный":
                    labelParam1.Text = "Mx";
                    labelParam2.Visible = true;
                    numericUpDownParam2.Visible = true;
                    labelParam2.Text = "Dx";

                    numericUpDownParam1.Minimum = -100;
                    numericUpDownParam1.Maximum = 100;

                    numericUpDownParam2.Minimum = 0.01M;
                    numericUpDownParam2.Maximum = 100;

                    numericUpDownParam1.Value = 0;
                    numericUpDownParam2.Value = 1;
                    break;
            }
        }

        private void numericUpDownParam1_ValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxDistr.SelectedItem.ToString())
            {
                case "Равномерный":
                    if(numericUpDownParam2.Value <= numericUpDownParam1.Value)
                        numericUpDownParam2.Value = numericUpDownParam1.Value + 1;

                    numericUpDownParam2.Minimum = numericUpDownParam1.Value+0.01M;

                    break;

                case "Экспоненциальный":
                   
                    break;

                case "Нормальный":
                    
                    break;
            }
        }


        private void FormDistrLaw_FormClosed(object sender, FormClosedEventArgs e)
        {
            //закрытие всего приложения по крестику в заголовке
            if (DialogResult == DialogResult.Cancel)
                Application.Exit();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            switch (comboBoxDistr.SelectedItem.ToString())
            {
                case "Равномерный":
                    DistrUniform du = new DistrUniform(
                        (double)numericUpDownParam1.Value,
                        (double)numericUpDownParam2.Value);

                    RandomProcess.Inst.Stochastic = du;

                    break;

                case "Экспоненциальный":
                    DistrExpon de = new DistrExpon(
                        (double)numericUpDownParam1.Value);

                    RandomProcess.Inst.Stochastic = de;
                    break;

                case "Нормальный":
                    DistrNormal dn = new DistrNormal(
                        (double)numericUpDownParam2.Value,
                        (double)numericUpDownParam1.Value);

                    RandomProcess.Inst.Stochastic = dn;
                    break;
            }

            RandomProcess.Inst.Generate();

            Hide();
            if ((new FormModelingDistr().ShowDialog(this)) == DialogResult.OK)
                Show();

        }

        private void FormSelectDistr_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Program.ShowHelp();
        }


    }
}
