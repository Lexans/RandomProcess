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
            saveFileDialogSample.FileName = Application.StartupPath.ToString() + "\\Sample";

            FillNumericChs();
            DrawProbCurces();
        }

        /// <summary>
        /// форматирование вещественного числа
        /// </summary>
        /// <param name="num"></param>
        /// <param name="decPlaces">количество знаков после запятой</param>
        /// <returns></returns>
        private string NumFormat(double num, int decPlaces) {
            string decPattern = "";
            for (int i = 0; i < decPlaces; i++)
                decPattern += "#";

            return String.Format("{0:0." + decPattern + "}", num);
        }

        private void FillNumericChs() {
            IDistrLaw dl = (IDistrLaw) RandomProcess.Inst.Stochastic;
            NumericCharacteristic nc = new NumericCharacteristic();

            labelN.Text = RandomProcess.Inst.N.ToString();

            listViewChar.Items[0] = new ListViewItem(new string[] { "Mx",
                NumFormat(nc.CalcMx(), 6),
                NumFormat(dl.CalcMx(), 6)});


            listViewChar.Items[1] = new ListViewItem(new string[] { "Dx",
                NumFormat(nc.CalcDx(), 6),
                NumFormat(dl.CalcDx(), 6)});

            listViewChar.Items[2] = new ListViewItem(new string[] { "Ka",
                NumFormat(nc.CalcKa(), 6),
                NumFormat(dl.CalcKa(), 6)});

            listViewChar.Items[3] = new ListViewItem(new string[] { "Kε",
                NumFormat(nc.CalcKe(), 6),
                NumFormat(dl.CalcKe(), 6)});
        }

        private void DescriptGraph(double XMin, double XMax, double YMin, double YMax, string YName, string XName)
        {
            if (radioButtonCorrF.Checked)
            {
                labelXMin.TextAlign = ContentAlignment.MiddleLeft;
                labelXMax.TextAlign = ContentAlignment.MiddleRight;
            }
            else
            {
                labelXMin.TextAlign = ContentAlignment.MiddleRight;
                labelXMax.TextAlign = ContentAlignment.MiddleLeft;
            }

            IDistrLaw Dl = (IDistrLaw)RandomProcess.Inst.Stochastic;
            if (radioButtonDensity.Checked)
            {
                if (Dl is DistrUniform)
                    labelYAnalytMax.Text = NumFormat(
                        Dl.DensityFunc(((DistrUniform)Dl).A), 2);
                /*else if(Dl is DistrNormal)
                    labelYAnalytMax.Text = NumFormat(Dl.DensityFunc(((DistrNormal)Dl).Mx), 2);
                
                 */
                else
                    labelYAnalytMax.Text = "";
            }
            else {
                labelYAnalytMax.Text = "";
            }
            

            labelXMin.Text = NumFormat(XMin, 2);
            labelXMax.Text = NumFormat(XMax, 2);
            labelYMin.Text = NumFormat(YMin, 2);
            labelYmax.Text = NumFormat(YMax, 2);
            labelXName.Text = XName;
            labelYName.Text = YName;
        }

        private void DrawProbCurces()
        {
            pc = new ProbCurves();
            pc.Canvas = panelCanvas.CreateGraphics();
            pc.DescriptFunc += DescriptGraph;

            if (radioButtonDensity.Checked)
                pc.DrawHistogram();
            else if (radioButtonDistrFunction.Checked)
                pc.DrawDistrFunc();
            else if (radioButtonCorrF.Checked)
                pc.DrawCorrFunc();

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
            if (new FormResample().ShowDialog() == DialogResult.OK)
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

        private void labelYmax_Click(object sender, EventArgs e)
        {

        }


    }
}
