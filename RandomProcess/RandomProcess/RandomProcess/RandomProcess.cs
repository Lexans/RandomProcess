using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomProcess
{
	/// <summary>
	/// Случайный процесс, моделирумый системой. Паттерн Одиночка
	/// </summary>
	public sealed class RandomProcess
	{
		public double[] Sample;

		public int N;

		public IModeling Stochastic;

		/// <summary>
		/// свойство получение объекта синглтон класса
		/// </summary>
		public static RandomProcess Inst;

		/// <summary>
		/// ссылка на объект синглтон класса
		/// </summary>
		private static RandomProcess inst;

		private RandomProcess()
		{
		}

		/// <summary>
		/// получение новой выборки Sample объема N
		/// </summary>
		public void Generate()
		{
			throw new System.NotImplementedException();
		}

		public void ToFile(string FileName)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// сброс состояния синглтон класса
		/// </summary>
		public void Reset()
		{
			throw new System.NotImplementedException();
		}

	}
}

