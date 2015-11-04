using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RandomProcess
{
	public interface ICriterion 
	{
		bool CheckCriterion(out double CritPoint, out double Statistic);

	}
}

