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
    public partial class FormModelingCF : Form
    {
        ProbCurves pc;

        public FormModelingCF()
        {
            InitializeComponent();

            FillNumericChs();
            DrawProbCurces();
        }

        private string NumFormat(double num)
        {
            return String.Format("{0:0.######}", num);
        }


        private void FillNumericChs()
        {
            NumericCharacteristic nc = new NumericCharacteristic();

            listViewChar.Items[0] = new ListViewItem(new string[] { "Mx",
                NumFormat(nc.CalcMx())});


            listViewChar.Items[1] = new ListViewItem(new string[] { "Dx",
                NumFormat(nc.CalcDx())});

            listViewChar.Items[2] = new ListViewItem(new string[] { "Ka",
                NumFormat(nc.CalcKa())});

            listViewChar.Items[3] = new ListViewItem(new string[] { "Kε",
                NumFormat(nc.CalcKe())});
        }

        private void DrawProbCurces()
        {
            pc = new ProbCurves();
            pc.Canvas = panelCanvas.CreateGraphics();

            if (radioButtonDensity.Checked)
                pc.DrawHistogram();
            else if (radioButtonDistrFunction.Checked)
                pc.DrawDistrFunc();
            else if (radioButtonCorrF.Checked)
                pc.DrawCorrFunc();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSaveArray_Click(object sender, EventArgs e)
        {
            if (saveFileDialogSample.ShowDialog() == DialogResult.OK)
            {
                RandomProcess.Inst.ToFile(saveFileDialogSample.FileName);
            }
        }

        private void buttonNewArray_Click(object sender, EventArgs e)
        {
            if (new FormResample().ShowDialog() == DialogResult.OK)
            {
                FillNumericChs();
                DrawProbCurces();
            }
        }

        private void FormModelingCF_FormClosed(object sender, FormClosedEventArgs e)
        {
            //закрытие всего приложения по крестику в заголовке
            if (DialogResult == DialogResult.Cancel)
                Application.Exit();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawProbCurces();
        }

        private void radioButtonDensity_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDensity.Checked)
                DrawProbCurces();
        }

        private void radioButtonDistrFunction_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDistrFunction.Checked)
                DrawProbCurces();
        }

        private void radioButtonCorrF_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCorrF.Checked)
                DrawProbCurces();
        }
    }
}
