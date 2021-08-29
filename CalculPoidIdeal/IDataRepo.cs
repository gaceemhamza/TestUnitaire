using System.Collections.Generic;

namespace CalculPoidIdeal
{
    public interface IDataRepo
    {
        IEnumerable<CalculePoid> GetWeight();
    }
}
