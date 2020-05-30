using IATCINDIA.DOMAIN.Interface;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace IATCINDIA.DATA.Repository
{

    public class SPRepository : ISPRepository
    {
        public DataSet ExecuteQuery(string spQuery, Dictionary<string, object> parameters)
        {
            using SqlConnection con = new SqlConnection("Data Source = 43.255.152.25; Initial Catalog = IATC_INDIA; User ID = IATC_INDIA; Password=IATC_INDIA@03");
            con.Open();
            using SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spQuery;
            foreach (var parm in parameters)
            {
                cmd.Parameters.AddWithValue(parm.Key, parm.Value.ToString());
            }
            using SqlDataAdapter daview = new SqlDataAdapter(cmd);
            DataSet dsview = new DataSet();
            daview.Fill(dsview);
            con.Close();
            return dsview;
        }


    }
}