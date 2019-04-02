using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace C_Sharp_Class_Address_Book
{
    public class Portal
    {
        public bool Save(Contacts contact)
        {
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            //This is the create or C portion of CRUD

            string query = "INSERT INTO [Dbo].[Table] VALUES ('" + contact.Name + "','" + contact.Phone + "','" + contact.Street + "','" + contact.City + "','" + contact.State + "'," + contact.Zip + ");";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;

        }

        public Contacts Get(string Name)
        {
            Contacts contacts = new Contacts();
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            //This is for the R in CRUD

            string newQuery = @"SELECT * FROM [Dbo].[Table] WHERE Name = " + Name.Trim();
            SqlCommand command = new SqlCommand(newQuery, connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                contacts.Id = Convert.ToInt32(reader["Id"].ToString());
                contacts.Name = reader["Name"].ToString();
                contacts.Phone = reader["Phone"].ToString();
                contacts.Street = reader["Street"].ToString();
                contacts.City = reader["City"].ToString();
                contacts.State = reader["State"].ToString();
                contacts.Zip = reader["Zip"].ToString();
            }
            return contacts;
        }

        public bool Update(Contacts contacts)

            //Update gives us the U in CRUD
        {
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE [Dbo].[Table] SET Name = '" + contacts.Name + "', Phone = '" + contacts.Phone + "', Street = '" + contacts.Street + "', City = '" + contacts.City + "', State = '" + contacts.State + "', Zip = " + contacts.Zip + "' WHERE Name = '" + contacts.Name + "';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;


        }

        public bool Delete(Contacts contacts)
        {

            //This covers the D in CRUD and should make my project requirements complete.
            string connectionString = @"Data Source=LAPTOP-P0TS8S9C\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True";
            var connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "DELETE FROM [Dbo].[Table] WHERE Name = '" + contacts.Name + "';";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        

        //private void Get(string v, object name)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
