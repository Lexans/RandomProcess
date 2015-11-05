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
    public partial class FormModelingDistr : Form
    {
        public FormModelingDistr()
        {
            InitializeComponent();

            FillNumericChs();
        }

        private void listViewChar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormModelingDistr_Load(object sender, EventArgs e)
        {

        }


        private string NumFormat(double num) {
            return String.Format("{0:0.##}", num);
        }

        private void FillNumericChs() {
            IDistrLaw dl = (IDistrLaw) RandomProcess.Inst.Stochastic;
            NumericCharacteristic nc = new NumericCharacteristic();

            listViewChar.Items[0] = new ListViewItem(new string[] { "Mx",
                NumFormat(nc.CalcMx()),
                NumFormat(dl.CalcMx())});


            listViewChar.Items[1] = new ListViewItem(new string[] { "Dx",
                NumFormat(nc.CalcDx()),
                NumFormat(dl.CalcDx())});

            listViewChar.Items[2] = new ListViewItem(new string[] { "Ka",
                NumFormat(nc.CalcKa()),
                NumFormat(dl.CalcKa())});

            listViewChar.Items[3] = new ListViewItem(new string[] { "Kε",
                NumFormat(nc.CalcKe()),
                NumFormat(dl.CalcKe())});
        }
    }
}
