using IATCINDIA.DOMAIN.Interface;
using Microsoft.Data.SqlClient;
using System.Data;

namespace IATCINDIA.DATA.Repository
{
    public class GetSpRepository : IGetSpRepository
    {

        public DataSet GetTs()
        {
            SqlConnection con = new SqlConnection("Data Source = 43.255.152.25; Initial Catalog = IATC_INDIA; User ID = IATC_INDIA; Password=IATC_INDIA@03");
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd = new SqlCommand("GetDepartment", con)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id", "1");
            SqlDataAdapter daview = new SqlDataAdapter(cmd);
            DataSet dsview = new DataSet();
            daview.Fill(dsview);
            if (dsview.Tables.Count > 0)
            {
            }
            con.Close();
            return dsview;
        }
    }
}
