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
    public class D_Habitacion
    {
        public string sp_Habitacion(Habitacion Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Habitacion", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@id_habitacion", SqlDbType.Int).Value = Obj.id_habitacion;
                Comando.Parameters.Add("@numCamas", SqlDbType.Float).Value = Obj.numCamas;
                Comando.Parameters.Add("@tipoCama", SqlDbType.VarChar).Value = Obj.tipoCama;
                Comando.Parameters.Add("@preXpersXnoc", SqlDbType.Float).Value = Obj.preXpersXnoc;
                Comando.Parameters.Add("@canXpersXhab", SqlDbType.Float).Value = Obj.canXpersXhab;
                Comando.Parameters.Add("@nivelHab", SqlDbType.VarChar).Value = Obj.nivelHab;
                Comando.Parameters.Add("@frente", SqlDbType.Int).Value = Obj.frente;
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

        public DataTable sp_Get_Habitacion()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Habitacion", SqlCon);
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
