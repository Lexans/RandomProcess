using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public sealed class DecayingCF : ICorrFunc
	{
		public double A;

		public double CorrFunc(double tau)
		{
			throw new System.NotImplementedException();
		}

		public double GetSample()
		{
			throw new System.NotImplementedException();
		}

		public DecayingCF(double A)
		{
		}

	}
}

