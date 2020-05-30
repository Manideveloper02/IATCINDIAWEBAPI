using System.Collections.Generic;
using System.Data;

namespace IATCINDIA.DOMAIN.Interface
{
    public interface ISPRepository 
    {
        DataSet  ExecuteQuery(string spQuery, Dictionary<string, object> parameters);

    }
}
