using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketingSystem.entities;

namespace TicketingSystem.data_layer
{
    class SpectacoleDAL
    {
        private static SpectacoleDAL _spectacoleDAL = null;
        private String _connectionString = @"Data Source=DESKTOP-EQ3D1RM\SQLEXPRESS;Initial Catalog=TicketingSystem;User ID=Mihai;Password=Nicusor20@";
        SqlConnection _conn = null;

        public SpectacoleDAL()
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

        public Spectacole getSpectacol(String titlu)
        {
            Spectacole s = null;
            String sql = "SELECT * FROM spectacole WHERE titlu='" + titlu + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                DateTime date = DateTime.Parse(reader["data"].ToString());

                String data = date.ToString("yyyy.MM.dd HH:mm:ss");
                
                s = new Spectacole(int.Parse(reader["id"].ToString()), reader["titlu"].ToString(), reader["regizor"].ToString(), reader["actori"].ToString(), data, int.Parse(reader["nrbilete"].ToString()));
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
            return s;
        }

        public Spectacole getSpectacol(int id)
        {
            Spectacole s = null;
            String sql = "SELECT * FROM spectacole WHERE id='" + id + "'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                DateTime date = DateTime.Parse(reader["data"].ToString());

                String data = date.ToString("yyyy.MM.dd HH:mm:ss");

                s = new Spectacole(id, reader["titlu"].ToString(), reader["regizor"].ToString(), reader["actori"].ToString(), data, int.Parse(reader["nrbilete"].ToString()));
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
            return s;
        }

        public void addSpectacol(String titlu, String regizor, String actori, String data, int nrBilete)
        {
            String sql = "INSERT INTO spectacole(titlu, regizor, actori, data, nrbilete) VALUES (@titlu, @regizor, @actori, @data, @nrbilete)";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@titlu", titlu);
                cmd.Parameters.AddWithValue("@regizor", regizor);
                cmd.Parameters.AddWithValue("@actori", actori);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@nrbilete", nrBilete);
                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }

        public void updateSpectacol(String titlu, String regizor, String actori, String data, int nrBilete)
        {
            String sql = "UPDATE Spectacole SET Titlu='@titlu1', Regizor='@regizor', Actori='@actori', Data='"+ data +"', NrBilete=@nrbilete WHERE titlu='@titlu2'";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@titlu1", titlu);
                cmd.Parameters.AddWithValue("@regizor", regizor);
                cmd.Parameters.AddWithValue("@actori", actori);
                cmd.Parameters.AddWithValue("@data", data);
                cmd.Parameters.AddWithValue("@nrbilete", nrBilete);
                cmd.Parameters.AddWithValue("@titlu2", titlu);
                Console.WriteLine(cmd.CommandText);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
            finally
            {
                _conn.Close();
            }
        }

        public void deleteSpectacol(String titlu)
        {
            String sql = "DELETE FROM spectacole WHERE titlu='" + titlu + "'";
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


        public DataTable getTabelSpectacole()
        {
            DataTable tabelSpectacole = new DataTable();
            String sql = "SELECT * FROM spectacole";
            try
            {
                _conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, _conn);
                sqlDataAdapter.Fill(tabelSpectacole);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            { 
                _conn.Close();
            }
            return tabelSpectacole;
        }
    }
}
