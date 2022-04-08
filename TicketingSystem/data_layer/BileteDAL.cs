using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketingSystem.entities;

namespace TicketingSystem.data_layer
{
    class BileteDAL
    {
        private static BileteDAL _bileteDAL = null;
        private String _connectionString = @"Data Source=DESKTOP-EQ3D1RM\SQLEXPRESS;Initial Catalog=TicketingSystem;User ID=Mihai;Password=password";
        SqlConnection _conn = null;


        public BileteDAL()
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
        public Bilete getBilet(int numar, int rand, int spectacolId)
        {
            Bilete b = null;
            String sql = "SELECT * FROM bilete WHERE spectacolid=@spectacolId AND numar=@numar AND rand=@rand";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@rand", rand);
                cmd.Parameters.AddWithValue("@numar", numar);
                cmd.Parameters.AddWithValue("@spectacolId", spectacolId);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int id = int.Parse(reader["id"].ToString());
                bool stare = bool.Parse(reader["stare"].ToString());
                b = new Bilete(id, rand, numar, stare, spectacolId);
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return b;
        }

        public int nbBileteSpectacol(int id)
        {
            int nr = 0;
            String sql = "SELECT Count(id) as nrB FROM bilete WHERE spectacolid=" + id;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    nr = int.Parse(reader["nrB"].ToString());
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return nr;
        }

        public void addBilet(int rand, int numar, bool stare, int idSpectacol)
        {
            String sql = "INSERT INTO bilete(rand, numar, stare, spectacolid) VALUES (@rand, @numar, '" + stare + "', @spectacolid)";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@rand", rand);
                cmd.Parameters.AddWithValue("@numar", numar);
                cmd.Parameters.AddWithValue("@spectacolid", idSpectacol);
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
        public void updateBilet(int id, int rand, int numar, bool stare, int spectacolId)
        {
            String sql = "UPDATE Bilete SET rand=@rand, numar=@numar, stare='" + stare + "', spectacolId=@spectacolId WHERE id=@id";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@rand", rand);
                cmd.Parameters.AddWithValue("@numar", numar);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@spectacolId", spectacolId);
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

        public void deleteBilete(int id)
        {
            String sql = "DELETE FROM bilete WHERE spectacolid=@id";
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@id", id);
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

        public List<Bilete> getBilete(int spectacolId)
        {
            List<Bilete> bilete = new List<Bilete>();
            String sql = "SELECT * FROM bilete WHERE spectacolId=" + spectacolId;
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = int.Parse(reader["id"].ToString());
                    int rand = int.Parse(reader["rand"].ToString());
                    int numar = int.Parse(reader["numar"].ToString());
                    bool stare = bool.Parse(reader["stare"].ToString());
                    Bilete b = new Bilete(id, rand, numar, stare, spectacolId);
                    bilete.Add(b);
                }
            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }

            return bilete;
        }

        public DataTable getTabelBilete()
        {
            DataTable dataTableS = new DataTable();
            String sql = "SELECT * FROM bilete";
            try
            {
                _conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, _conn);
                sqlDataAdapter.Fill(dataTableS);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return dataTableS;
        }
        public DataTable getTableBileteSpectacol(int spectacolId)
        {
            DataTable dataTableS = new DataTable();
            String sql = "SELECT * FROM bilete where spectacolId=" + spectacolId;
            try
            {
                _conn.Open();
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, _conn);
                sqlDataAdapter.Fill(dataTableS);

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                _conn.Close();
            }
            return dataTableS;
        }

    }
}
