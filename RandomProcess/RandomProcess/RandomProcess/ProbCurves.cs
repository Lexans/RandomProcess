using System;
using System.Collections.Generic;
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

		/// <summary>
		/// рисует гистограмму
		/// </summary>
		public void DrawHistogram()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// отрисовка произвольного графика функции
		/// </summary>
		private void DrawFunc(FuncOfX F, double scaleX, double scaleY, double leftX)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// расчитывает массив границ Bounds и частот
		/// </summary>
		private void SplitSample()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// построение оценки корреляционной функции
		/// </summary>
		public void DrawCorrFunc()
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// описание оценки функции распредления
		/// </summary>
		public void DrawDistrFunc()
		{
			throw new System.NotImplementedException();
		}

		public ProbCurves()
		{
		}

	}
}

