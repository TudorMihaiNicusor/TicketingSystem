using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TicketingSystem.data_layer
{
    
    class UsersDAL
    {
        private static UsersDAL _usersDAL = null;
        private String _connectionString = @"Data Source=DESKTOP-EQ3D1RM\SQLEXPRESS;Initial Catalog=TicketingSystem;User ID=Mihai;Password=Nicusor20@";
        SqlConnection _conn = null;

        public UsersDAL()
        {
            try
            {
                _conn = new SqlConnection(_connectionString);
            }
            catch (SqlException e)
            {
                _conn = null;
                throw e;
            }
        }


        public Users getUser(String username, String password)
        {
            Users u = null;
            String sql = "SELECT * FROM users WHERE username='" + username + "' AND password='" + password + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                _conn.Close();

            }
            catch (SqlException e)
            {
                throw e;
                return null;
            }
            finally
            {
                _conn.Close();
            }
            return u;
        }

        public Users getUser(String username)
        {
            Users u = null;
            String sql = "SELECT * FROM users WHERE username='" + username;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                u = new Users(reader["username"].ToString(), reader["password"].ToString(), reader["name"].ToString(), reader["role"].ToString());
                _conn.Close();

            }
            catch (SqlException e)
            {
                throw e;
                return null;
            }
            finally
            {
                _conn.Close();
            }
            return u;
        }

        public void addUser(String username, String password, String role, String name)
        {
            String sql = "INSERT INTO users(username, password, role, name) VALUES (@username,@password,@role,@name)";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }

        }

        public void deleteUser(String username)
        {
            String sql = "DELETE FROM users WHERE username='" + username;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }

        public void updateUser(String username, String password, String role, String name)
        {
            String sql = "UPDATE Users SET Username = @username, Password = @password, Role = @role, Name = @name Where username = @username";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }
    }

}
