using System;
using System.Collections.Generic;
using System.Text;

namespace CalculPoidIdeal
{


   public class CalculePoid
    {
        private IDataRepo repo;

        public double Taille { get; set; }
        public char Sexe { get; set; }
        

        public CalculePoid(IDataRepo repo)
        {
            this.repo = repo;
        }

        public CalculePoid()
        {
        }

        public double GetPoidIdeal()
        {
            switch (Sexe)
            {
                case 'm':
                    return (Taille - 100) - ((Taille - 150) / 4);
                case 'f':
                    return (Taille - 100) - ((Taille - 150) / 2);
                default:
                    return 0;


            }
        }

        public List<double> GetPoidFromDataSource()
        {
            List<double> Results = new List<double>();

            IEnumerable<CalculePoid> calculePoids = repo.GetWeight();
            foreach (var item in calculePoids)
            {
                Results.Add(item.GetPoidIdeal());

            }

            return Results;
        }
    }
}

