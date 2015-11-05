using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class DistrNormal : IDistrLaw
	{
		public double Dx;

		public double Mx;

        public static Random rand = new Random();

		public double CalcDx()
		{
            return Dx;
		}

		public double CalcKa()
		{
            return 0;
		}

		public double CalcKe()
		{
            return 0;
		}

		public double CalcMx()
		{
            return Mx;
		}

		public double DensityFunc(double x)
		{
            return (1 / (Math.Sqrt(2 * Math.PI) * Dx)) * Math.Exp((-Math.Pow(x-Mx,2))/2*Math.Pow(Dx,2));
		}

		public double DistributionFunc(double x)
		{
            double Fx = 1 / Math.Sqrt(2 * Math.PI * Dx) * Integrate(x);

            return Fx;
		}


		/// <summary>
		/// интегрирование функции e^-((x-a)^2)/(2*dx) от xMin до x
		/// </summary>
		/// <param name="x">верхний предел интегрирования</param>
		private double Integrate(double x)
		{
            double result = 0;
            double step = 0.01; //шаг интегрирования

            double curX = Mx - 9 * Math.Sqrt(Dx);

            do
            {
                double fx = Math.Exp(-Math.Pow(((curX + step / 2) - Mx), 2) / (2 * Dx));
                result += fx * step;

                curX += step;
            }
            while (curX <= x);

            return result;
		}

		public Double GetSample()
		{
            double sum;

            sum = 0;
            for (int i = 0; i < 12; i++)
                sum += rand.NextDouble();

            return Math.Sqrt(Dx) * (sum - 6) + Mx;
        }

		public DistrNormal(double Dx, double Mx)
		{
            this.Dx = Dx;
            this.Mx = Mx;
		}

	}
}

