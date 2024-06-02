using Microsoft.Data.SqlClient;
namespace Homework2.models
{
    public class Person
    {
        public void SaveData(string Name, string Mobile, string Address)
        {
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=information;Integrated Security=True";
            string sqlQuery = "INSERT INTO PERSON (Name, Mobile, Address)VALUES(" + "'" + Name + "'" + ", " + "'" + Mobile + "'" + ", " + "'" + Address + "'" + ")";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sc = new SqlCommand(sqlQuery, con);
            sc.ExecuteNonQuery();
            con.Close();
        }

        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public List<Person> GetPerson()
        {
            List<Person> PersonList = new List<Person>();
            string connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=information;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            string sqlQuery = "select Name, Mobile, Address from PERSON";
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                while (dr.Read())
                {
                    Person PersonParameter = new Person();
                    PersonParameter.Name = dr["Name"].ToString();
                    PersonParameter.Mobile = dr["Mobile"].ToString();
                    PersonParameter.Address = dr["Address"].ToString();
                    PersonList.Add(PersonParameter);
                }
            }
            return PersonList;
        }
    }
}
