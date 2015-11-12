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
    public partial class FormCheckResult : Form
    {
        private ICriterion crit;

        public FormCheckResult(ICriterion crit) : this()
        {
            this.crit = crit;
        }

        public FormCheckResult()
        {
            InitializeComponent();
        }

        private void labelValueStatistics_Click(object sender, EventArgs e)
        {

        }

        private void FormCheckResult_Load(object sender, EventArgs e)
        {
            double critPoint;
            double statValue;
            if (crit.CheckCriterion(out critPoint, out statValue))
                labelResult.Text = "Гипотеза принята";
            else
                labelResult.Text = "Гипотеза отвергнута";

            textBoxCritPoint.Text = NumFormat(critPoint);
            textBoxStat.Text = NumFormat(statValue);

        }

        private string NumFormat(double num)
        {
            return String.Format("{0:0.######}", num);
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
