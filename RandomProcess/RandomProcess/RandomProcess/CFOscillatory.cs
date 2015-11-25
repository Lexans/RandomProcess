using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class CFOscillatory : ICorrFunc
	{
		public double A;

		public double W;

        public static Random rand = new Random();

        private double yn_1;
        private double yn_2;
        private double xn_1;


        public double Dt
        {
            get
            {
                return 0.0785 / A;
            }
        }

        public int PointsAmount
        {
            get
            {
                return 39;
            }
        }

		public double CorrFunc(double tau)
		{
            return Math.Exp(-A * Math.Abs(tau)) * Math.Cos(W * tau);

		}

		public double GetSample()
		{
            double gamma = A * Dt;
            double gamma0 = W * Dt;

            double p = Math.Exp(-gamma);

            double alfa0 = p * (Math.Pow(p, 2) - 1) * Math.Cos(gamma0);
            double alfa1 = 1 - Math.Pow(p, 4);

            double a0 = Math.Sqrt((Math.Pow(alfa1, 2)
                +Math.Sqrt(Math.Pow(alfa1, 2)-4*Math.Pow(alfa0, 2)))/2);

            double a1 = alfa0 / alfa1;
            double b1 = 2 * p * Math.Cos(gamma0);
            double b2 = -Math.Pow(p,2);

            double xn = rand.NextDouble();
            double yn = a0 * xn + a1 * xn_1 + b1 * yn_1 + b2 * yn_2;

            xn_1 = xn;
            yn_2 = yn_1;
            yn_1 = yn;

            return yn;
		}

		public CFOscillatory(double A, double W)
		{
            this.A = A;
            this.W = W;
		}

	}
}

