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
        ProbCurves pc;

        public FormModelingDistr()
        {
            InitializeComponent();

            FillNumericChs();
            DrawProbCurces();
        }

        private void listViewChar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormModelingDistr_Load(object sender, EventArgs e)
        {

        }


        private string NumFormat(double num) {
            return String.Format("{0:0.######}", num);
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

        private void DrawProbCurces()
        {
            pc = new ProbCurves();
            pc.Canvas = panelCanvas.CreateGraphics();

            if (radioButtonDensity.Checked)
                pc.DrawHistogram();
            else if (radioButtonDistrFunction.Checked)
                pc.DrawDistrFunc();

        }

        private void buttonAgo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonNewArray_Click(object sender, EventArgs e)
        {
            if (new FormRegen().ShowDialog() == DialogResult.OK)
            {
                FillNumericChs();
                DrawProbCurces();
            }
        }

        private void FormModelingDistr_FormClosed(object sender, FormClosedEventArgs e)
        {
            //закрытие всего приложения по крестику в заголовке
            if (DialogResult == DialogResult.Cancel)
                Application.Exit();
        }

        private void buttonSaveArray_Click(object sender, EventArgs e)
        {
            if(saveFileDialogSample.ShowDialog() == DialogResult.OK)
            {
                RandomProcess.Inst.ToFile(saveFileDialogSample.FileName);
            }

        }

        private void buttonHypCheck_Click(object sender, EventArgs e)
        {
            (new FormHypCheck(pc)).ShowDialog();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawProbCurces();
        }

        private void radioButtonDensity_CheckedChanged(object sender, EventArgs e)
        {
            DrawProbCurces();
        }

        private void radioButtonDistrFunction_CheckedChanged(object sender, EventArgs e)
        {
            DrawProbCurces();
        }

        private void radioButtonCorrF_CheckedChanged(object sender, EventArgs e)
        {
            DrawProbCurces();
        }


    }
}
