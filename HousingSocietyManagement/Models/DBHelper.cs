using System.Data.SqlClient;

namespace HousingSocietyManagement.Models
{
    public class DBHelper : IHousingSociety
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader reader;
        public static string conString;

        public DBHelper()
        {
            con = new SqlConnection(conString);
            
        }

        public void AddNewFlat(Flat flat)
        {
            con.Open();
            string cmdText = "insert into tbl_Flats values(" + flat.FlatNo + ",'" + flat.FlatName + "','" + flat.FlatOwner + "','" + flat.Wing + "'," + flat.Mobile + "," + flat.Aadhar + ",'" + flat.Email + "')";
            com = new SqlCommand(cmdText, con);
            com.ExecuteNonQuery();
            con.Close();
        }

        public Flat GetFlatById(int flatNo)
        {
            Flat flat = GetFlats().Find(f => f.FlatNo == flatNo);
            return flat;
        }

        public List<Flat> GetFlats()
        {
            con.Open();
            com = new SqlCommand("Select * from tbl_flats", con);
            reader = com.ExecuteReader();
            List<Flat> _flats = new List<Flat>();
            while (reader.Read())
            {
                Flat flat = new Flat();
                flat.FlatNo = reader.GetInt32(0);
                flat.FlatName = reader.GetString(1);
                flat.FlatOwner = reader.GetString(2);
                flat.Wing = reader.GetString(3);
                flat.Mobile = reader.GetInt64(4);
                flat.Aadhar = reader.GetInt64(5);
                flat.Email = reader.GetString(6);
                _flats.Add(flat);

            }
            reader.Close();
            return _flats;

        }

        public void DeleteFlat(int flatNo)
        {
            con.Open();
            string cmdText = "Delete from tbl_Flats where flatNo=" + flatNo;
            com = new SqlCommand(cmdText, con);
            com.ExecuteNonQuery();
            con.Close();
           
        }
    }
}







