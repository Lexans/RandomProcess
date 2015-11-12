﻿using System;
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

            if (radioButtonDistributionLaw.Checked)
                if ((new FormDistrLaw().ShowDialog(this)) == DialogResult.OK)
                    Show();
            else if (radioButtonCorrelationFunction.Checked)
                 if ((new FormCorFunc().ShowDialog(this)) == DialogResult.OK)
                    Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Авторы Антоха и Леха кароч");
        }



    }
}
