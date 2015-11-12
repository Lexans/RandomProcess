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
    public partial class FormHypCheck : Form
    {
        ProbCurves pc;

        public FormHypCheck(ProbCurves pc) : this()
        {
            this.pc = pc;
        }

        public FormHypCheck()
        {
            InitializeComponent();
            comboBoxA.SelectedIndex = 1;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            ICriterion crit = null;
            if(radioButtonKolmogorov.Checked)
            {
                KolmogorovCrit kolCrit = new KolmogorovCrit(pc);
                kolCrit.SignificanceLevel = double.Parse(comboBoxA.SelectedItem.ToString());
                crit = kolCrit;
            }
            else if(radioButtonPirson.Checked)
            {
                PirsonCrit pirCrit = new PirsonCrit(pc);
                pirCrit.SignificanceLevel = double.Parse(comboBoxA.SelectedItem.ToString());
                crit = pirCrit;
            }

            (new FormCheckResult(crit)).ShowDialog();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
