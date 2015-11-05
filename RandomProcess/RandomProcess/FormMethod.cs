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
    public partial class FormMethod : Form
    {
        public FormMethod()
        {
            InitializeComponent();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            RandomProcess.Inst.N = (int) numericUpDownN.Value;

            Hide();

            if(radioButtonDistributionLaw.Checked)
                (new FormDistrLaw()).ShowDialog(this);
            else if(radioButtonCorrelationFunction.Checked)
                (new FormCorFunc()).ShowDialog(this);

            Show();
        }



    }
}
