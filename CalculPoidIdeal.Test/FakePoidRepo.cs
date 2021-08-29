using System;
using System.Collections.Generic;
using System.Text;

namespace CalculPoidIdeal.Test
{
    class FakePoidRepo : IDataRepo
    {
        IEnumerable<CalculePoid> calcules;
        public FakePoidRepo()
        {
            calcules = new List<CalculePoid>()
             {
                    new CalculePoid {Taille= 175, Sexe= 'f' }, //62.5
                    new CalculePoid {Taille= 167, Sexe ='m'},  //62.75
                    new CalculePoid {Taille = 182, Sexe ='m'}, //74

             };


        }



        public IEnumerable<CalculePoid> GetWeight()
        {
            return calcules;
        }
    }
}
