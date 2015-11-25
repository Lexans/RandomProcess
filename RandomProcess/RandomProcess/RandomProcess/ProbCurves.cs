using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace RandomProcess
{
    public delegate double FuncOfX(double X);

    public sealed class ProbCurves
    {
        /// <summary>
        /// количество интервалов разбиения
        /// </summary>
        public int nIntervals;

        public System.Drawing.Graphics Canvas;

        public double[] Bounds;

        /// <summary>
        /// частоты попадания в интервалы
        /// </summary>
        public int[] Freqs;

        //цвета графиков оценки и аналитического
        private Pen PenEstim = new Pen(Color.Black, 2);
        private Pen PenAnalyt = new Pen(Color.Red, 2);

        /// <summary>
        /// рисует гистограмму
        /// </summary>
        public void DrawHistogram()
        {
            int N = RandomProcess.Inst.N;
            double[] X = RandomProcess.Inst.Sample;

            Canvas.Clear(Color.White);

            //вычисление гистограммы
            double[] h = new double[nIntervals];
            //длина столбца гистограммы
            double len = Bounds[1] - Bounds[0];

            for (int i = 0; i < nIntervals; i++)
                h[i] = Freqs[i] / (N * len);


            double xMin = X.Min();
            double xMax = X.Max();

            //масштаб по x: пикс / ед
            double scaleX = Canvas.VisibleClipBounds.Width /
                (xMax - xMin);

            double hMax = h.Max();

            //масштаб по y: пикс / ед
            double scaleY = Canvas.VisibleClipBounds.Height /
                h.Max();


            //смещение графика
            xMin -= (xMax - xMin) * 0.1;
            hMax += hMax * 0.1;
            scaleX *= 0.8;
            scaleY *= 0.9;

            //рисование аналитической функции плотности
            if (RandomProcess.Inst.Stochastic is IDistrLaw)
                DrawFunc(((IDistrLaw)RandomProcess.Inst.Stochastic).DensityFunc,
                scaleX, scaleY, xMin, hMax, PenAnalyt);


            //отрисовка гистограммы
            for (int i = 0; i < nIntervals; i++)
            {
                Canvas.DrawRectangle(
                    PenEstim,
                    (float)(scaleX * (Bounds[i] - xMin)),
                    (float)(scaleY * (hMax - h[i])),
                    (float)(len * scaleX),
                    (float)(scaleY * h[i])
                    );
            }
        }

        /// <summary>
        /// отрисовка произвольного графика функции
        /// </summary>
        /// <param name="F">функция для построения</param>
        /// <param name="scaleX">масштаб по оси X (ед/пикс)</param>
        /// <param name="scaleY">масштаб по оси Y (ед/пикс)</param>
        /// <param name="leftX">абцисса крайней левой графика</param>
        /// <param name="topY">оридината верхней точки графика</param>
        private void DrawFunc(FuncOfX F, double scaleX, double scaleY, double leftX, double topY, Pen pen)
        {
            //вертикальная координата полотна предыдущей точки
            float lastY = 0;

            //цикл по всей картинке. curX - горизонтальная координата полотна текущей точки
            for (int curX = 0; curX < Canvas.VisibleClipBounds.Width; curX++)
            {
                //curY - вертикальная координата полотна  текущей точки
                float curY = (float)(scaleY *
                    (topY - F(leftX + (double)curX / scaleX)));

                if (curX != 0)
                    Canvas.DrawLine(pen, curX, curY, curX - 1, lastY);

                lastY = curY;
            }
        }

        /// <summary>
        /// расчитывает массив границ Bounds и частот Freqs
        /// </summary>
        private void SplitSample()
        {
            int N = RandomProcess.Inst.N;
            double[] X = RandomProcess.Inst.Sample;

            //правило Стургерса
            nIntervals = (int)(Math.Floor(1 + 3.32 * Math.Log10(N)) + 1);

            //вычисление границ интервалов разбиения
            Bounds = new double[nIntervals + 1];
            double sampleMin = X.Min();
            double intervalLength = (X.Max() - sampleMin) / nIntervals;

            for (int i = 0; i <= nIntervals; i++)
                Bounds[i] = sampleMin + intervalLength * i;


            //расчет частот попадания в интервалы
            Freqs = new int[nIntervals];
            foreach (double val in X)
            {
                for (int i = 0; i < nIntervals; i++)
                    if (val >= Bounds[i] && val < Bounds[i + 1])
                        Freqs[i]++;
            }

        }

        /// <summary>
        /// построение оценки корреляционной функции
        /// </summary>
        public void DrawCorrFunc()
        {
            int N = RandomProcess.Inst.N;
            double[] X = RandomProcess.Inst.Sample;

            //расчитываемое количество точек КФ
            int v;
            //шаг дискретизации
            double Dt;

            ICorrFunc CF = null;
            if (RandomProcess.Inst.Stochastic is ICorrFunc)
            {
                CF = (ICorrFunc)RandomProcess.Inst.Stochastic;
                v = CF.PointsAmount;
                Dt = CF.Dt;
            }
            else
            {
                v = N / 10;
                Dt = 10d / N;
            }


            //оценка мат. ожидания по выборке
            double mx = X.Sum() / (double) N;

            //оценка КФ
            double[] K = new double[v + 1];

            //j - номер расчитываемой точки
            for (int j = 0; j <= v; j++)
            {
                //сумма в формуле оценки КФ
                double sum = 0;
                for (int i = 0; i < N - j; i++)
                    sum += (X[i] - mx) * (X[i + j] - mx);

                //оценка КФ
                K[j] = sum / (N - j);
            }

            //нормирование
            for (int j = v; j >= 0; j--)
                K[j] = K[j] / K[0];

            double topY = K.Max();
            double bottomY = K.Min();
            //масштаб: пикс/ед
            double scaleY = Canvas.VisibleClipBounds.Height / (topY - bottomY);
            double scaleX = Canvas.VisibleClipBounds.Width / (v * Dt);

            //смещение графика
            topY *= 1.1;
            scaleY *= 0.8;

            //отрисовка аналитической КФ
            Canvas.Clear(Color.White);

            if (RandomProcess.Inst.Stochastic is ICorrFunc)
                DrawFunc(CF.CorrFunc,
                    scaleX, scaleY, 0, topY, PenAnalyt);

            //отрисовка оценки КФ
            float lastY = (float)(
                    (topY - K[0]) * scaleY);
            float lastX = 0;

            for (int j = 1; j <= v; j++)
            {
                float curY = (float)(
                    (topY - K[j]) * scaleY);
                float curX = (float)(j * Dt * scaleX);

                Canvas.DrawLine(PenEstim, curX, curY, lastX, lastY);

                lastY = curY;
                lastX = curX;
            }
        }

        /// <summary>
        /// рисование функции распредления
        /// </summary>
        public void DrawDistrFunc()
        {
            int N = RandomProcess.Inst.N;
            double[] X = RandomProcess.Inst.Sample;

            Canvas.Clear(Color.White);

            double xMin = X.Min();
            double xMax = X.Max();

            //масштаб по x: пикс / ед
            double scaleX = Canvas.VisibleClipBounds.Width /
                (xMax - xMin);

            double hMax = 1;
            //масштаб по y: пикс / ед
            double scaleY = Canvas.VisibleClipBounds.Height /
                hMax;

            //смещение графика
            xMin -= (xMax - xMin) * 0.1;
            hMax += hMax * 0.1;
            scaleX *= 0.8;
            scaleY *= 0.9;

            //отрисовка аналитической ФР
            if (RandomProcess.Inst.Stochastic is IDistrLaw)
                DrawFunc(((IDistrLaw)RandomProcess.Inst.Stochastic).DistributionFunc,
                    scaleX, scaleY, xMin, hMax, PenAnalyt);

            //отрисовка оценки ФР
            DrawFunc(DistrFunc,
                scaleX, scaleY, xMin, hMax, PenEstim);
        }

        public double DistrFunc(double x)
        {
            int N = RandomProcess.Inst.N;
            double[] X = RandomProcess.Inst.Sample;

            return 1d / N * X.Count((xi) => xi < x);
        }

        public ProbCurves()
        {
            SplitSample();
        }

    }
}

