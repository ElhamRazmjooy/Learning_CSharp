using MyContacts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyContacts
{
    class MyContacts : IMyContacts
    {
        private string Connection = "Data source=;Initial catalog=Contact_DB;Integrated Security=true";
        private object connection;

        public bool insert(string Name, string Family, int Age, string Email, string Mobile)
        {
            throw new NotImplementedException();
        }

        public bool Update(int ContactID, string Name, string Family, int Age, string Email, string Mobile, object connection)
        {
            throw new NotImplementedException();
        }

        bool IMyContacts.delete(int ContactID)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try 
            {
                string query = "Delete From MyContacts where ContactID=@ID";
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@ID",ContactID);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch 
            {
                return false;
            }
            finally 
            { 
                connection.Close();
            }
        }

        bool IMyContacts.Insert(string Name, string Family, int Age, string Email, string Mobile)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try
            {
                string query = "Insert Into MyContacts (Name,Family,Age,Email,Mobile) values (@Name,@Family,@Age,@Email,@Mobile)";
                SqlCommand command =new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Name",Name);
                command.Parameters.AddWithValue("@Family",Family);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Email",Email);
                command.Parameters.AddWithValue("@Mobile",Mobile);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch 
            {

                return false;
            }
            finally 
            {
                connection.Close(); 
            }
        }

        DataTable IMyContacts.Search(string word)
        {
            string query = "select * from MyContacts Where Name like @word or Family like @word";
            SqlConnection connection = new SqlConnection(Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@word", "%" + word + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        DataTable IMyContacts.SelectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        DataTable IMyContacts.SelectRow(int ContactID)
        {
            string query = "select * from MyContacts where ContactID="+ContactID;
            SqlConnection connection = new SqlConnection(Connection);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        bool IMyContacts.Update(int ContactID, string Name, string Family, int Age, string Email, string Mobile)
        {
            SqlConnection connection = new SqlConnection(Connection);
            try
            {
                string query = "Update myContacts set Name=@Name,Family=@Family,Age=@Age,Email=@Email,Mobile=@Mobile where ContactID=@ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", ContactID);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Family", Family);
                command.Parameters.AddWithValue("@Age", Age);
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Mobile", Mobile);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch 
            { 
                return false;
            }
            finally 
            {
                connection.Close();
            }
        }
    }
}
