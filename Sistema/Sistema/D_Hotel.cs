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
    public class D_Hotel
    {
        public string sp_Hotel(Hotel Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Hotel", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_hotel", SqlDbType.Int).Value = Obj.id_hotel;
                Comando.Parameters.Add("@nombreH", SqlDbType.VarChar).Value = Obj.nombreH;
                Comando.Parameters.Add("@ubicacion", SqlDbType.VarChar).Value = Obj.ubicacion;
                Comando.Parameters.Add("@domicilioH", SqlDbType.VarChar).Value = Obj.domicilioH;
                Comando.Parameters.Add("@numPiso", SqlDbType.Float).Value = Obj.numPiso;
                Comando.Parameters.Add("@canHabitacion", SqlDbType.Float).Value = Obj.canHabitacion;
                Comando.Parameters.Add("@zonaTuris", SqlDbType.Bit).Value = Obj.zonaTuris;
                Comando.Parameters.Add("@servicioAdi", SqlDbType.Bit).Value = Obj.servicioAdi;
                Comando.Parameters.Add("@frentePlaya", SqlDbType.Bit).Value = Obj.frentePlaya;
                Comando.Parameters.Add("@salonEventos", SqlDbType.Bit).Value = Obj.salonEventos;
                Comando.Parameters.Add("@fechaReg", SqlDbType.Date).Value = Obj.fechaReg;
                Comando.Parameters.Add("@fechaInicioOp", SqlDbType.Date).Value = Obj.fechaInicioOp;
                Comando.Parameters.Add("@regAdim", SqlDbType.VarChar).Value = Obj.regAdim;
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

        public DataTable sp_Get_Hotel()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Hotel", SqlCon);
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
