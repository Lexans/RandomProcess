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
			throw new System.NotImplementedException();
		}

		public double GetSample()
		{
			throw new System.NotImplementedException();
		}

		public OscillatoryCF(double A, double W)
		{
		}

	}
}

