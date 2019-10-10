using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VehicleInfo
{
	[Serializable]
	public class Vehicle
	{
		public string VehicleName, RegNo;
		public List<double> Speed=new List<double>();

		public double GetMaxSpeed()
		{
			double max = Speed.Max();
			return max;
		}
		public double GetMMinSpeed()
		{
			double min = Speed.Min();
			return min;
		}
		public double GetAvgSpeed()
		{
		
			double avg = Speed.Average();
			return avg;
		}




	}
}