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
    public class D_HH
    {

        public string sp_HabitacionHotel(HabitacionHotel Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_HabitacionHotel", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_HH", SqlDbType.Int).Value = Obj.id_HH;
                Comando.Parameters.Add("@id_habitacion", SqlDbType.Int).Value = Obj.id_habitacion;
                Comando.Parameters.Add("@id_hotel", SqlDbType.Int).Value = Obj.id_hotel;
                Comando.Parameters.Add("@tipoHab", SqlDbType.VarChar).Value = Obj.tipoHab;
                Comando.Parameters.Add("@caract", SqlDbType.VarChar).Value = Obj.caract;
                Comando.Parameters.Add("@amenidades", SqlDbType.VarChar).Value = Obj.amenidades;
                Comando.Parameters.Add("@Op", SqlDbType.Char).Value = Obj.Op;
                SqlCon.Open();
                Rpta = Comando.ExecuteNonQuery() == 1 ? "OK" : "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return Rpta;
        }

        public DataTable sp_Get_HabitacionHotel()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_HabitacionHotel", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
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
