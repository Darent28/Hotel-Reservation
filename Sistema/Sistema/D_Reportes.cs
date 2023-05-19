using Sistema.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Datos
{
    public class D_Reportes
    {
        public DataTable sp_Get_Rhotel(string pais, string ciudad, string hotel, string fecha)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rhotel", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = pais;
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudad;
                Comando.Parameters.Add("@hotel", SqlDbType.VarChar).Value = hotel;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable sp_Get_Rhotelall(string pais, string ciudad, string fecha)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rhotelall", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = pais;
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudad;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable sp_Get_Rventas(string pais, string ciudad, string hotel, string fecha)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rventas", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = pais;
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudad;
                Comando.Parameters.Add("@hotel", SqlDbType.VarChar).Value = hotel;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable sp_Get_Rventasall(string pais, string ciudad, string fecha)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rventasall", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@pais", SqlDbType.VarChar).Value = pais;
                Comando.Parameters.Add("@ciudad", SqlDbType.VarChar).Value = ciudad;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable sp_Get_Rcliente(string cliente, string fecha)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rcliente", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cliente", SqlDbType.VarChar).Value = cliente;
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        public DataTable sp_Get_Rclienteall(string cliente)
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Rclienteall", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cliente", SqlDbType.VarChar).Value = cliente;

                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Table.Load(Resultado);
                return Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

    }
}
