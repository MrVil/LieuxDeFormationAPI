using System;

namespace LieuxDeFormationAPI.Models.TrainingProblem
{
	public class Agency : City
	{

		protected int nbPers;

		public Agency(string _id, string _name, string _codepostal, double _longitude, double _latitude, int _nbPers) : base(_id, _name, _codepostal, _longitude, _latitude) {
			nbPers = _nbPers;
		}

		public Agency() : base()
		{
			nbPers = 0;
		}

		public Agency(string csvLine) : base(csvLine)
		{
			nbPers = int.Parse(csvLine.Split (';')[5]);
		}

		public int getNbPers()
		{
			return nbPers;
		}

		public void setNbPers(int n)
		{
			nbPers = n;
		}
	}
}

