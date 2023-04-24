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
    public class D_Cliente
    {
        public string sp_Cliente(Cliente Obj)
        {
            string Rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Cliente", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@RFC", SqlDbType.VarChar).Value = Obj.RFC;
                Comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = Obj.nombre;
                Comando.Parameters.Add("@apellidoP", SqlDbType.VarChar).Value = Obj.apellidoP;
                Comando.Parameters.Add("@apellidoM", SqlDbType.VarChar).Value = Obj.apellidoM;
                Comando.Parameters.Add("@domicilio", SqlDbType.VarChar).Value = Obj.domicilio;
                Comando.Parameters.Add("@correo", SqlDbType.VarChar).Value = Obj.correo;
                Comando.Parameters.Add("@telefono", SqlDbType.Float).Value = Obj.telefono;
                Comando.Parameters.Add("@referencia", SqlDbType.VarChar).Value = Obj.referencia;
                Comando.Parameters.Add("@fNacimiento", SqlDbType.Date).Value = Obj.fNacimiento;
                Comando.Parameters.Add("@eCivil", SqlDbType.VarChar).Value = Obj.eCivil;
                Comando.Parameters.Add("@fRegistro", SqlDbType.Date).Value = Obj.fRegistro;
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

        public DataTable sp_Get_Cliente()
        {
            SqlDataReader Resultado;
            DataTable Table = new DataTable();
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon = Connection.Get_Instancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("sp_Get_Cliente", SqlCon);
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
