using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class OscillatoryCF : ICorrFunc
	{
		public double A;

		public double W;

		public double CorrFunc(double tau)
		{
            return Math.Exp(-A * Math.Abs(tau)) * Math.Cos(W * tau);

		}

		public double GetSample()
		{
            double dt = 0.0785 / A;
            double gamma = A * dt;
            double gamma0 = W * dt;
            double p = Math.Exp(-A);
            double alfa0 = p * (Math.Pow(p, 2) - 1) * Math.Cos(gamma0);
            double alfa1 = 1 - Math.Pow(p, 4);
           // double a0 = Math.Sqrt(); как тут сделать +- ?
            double a1 = alfa0 / alfa1;
            double b1 = 2 * p * Math.Cos(gamma0);
            double b2 = -Math.Pow(p,2);

            double yn=0;
            return yn;
		}

		public OscillatoryCF(double A, double W)
		{
            this.A = A;
            this.W = W;

		}

	}
}

