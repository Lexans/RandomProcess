using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	public interface ICorrFunc  : IModeling
	{
        //шаг дискретизации
        double Dt { get; }

        //количество точек оценки КФ
        int PointsAmount { get; }

		double CorrFunc(double tau);


	}
}

