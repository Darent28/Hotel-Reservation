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
    public class D_Factura
    {
            public string sp_Factura(Factura Obj)
            {
                string Rpta = "";
                SqlConnection SqlCon = new SqlConnection();
                try
                {
                    SqlCon = Connection.Get_Instancia().CrearConexion();
                    SqlCommand Comando = new SqlCommand("sp_Factura", SqlCon);
                    Comando.CommandType = CommandType.StoredProcedure;
                    Comando.Parameters.Add("@numFactura", SqlDbType.Float).Value = Obj.numFactura;
                    Comando.Parameters.Add("@servUsado", SqlDbType.VarChar).Value = Obj.servUsado;
                    Comando.Parameters.Add("@precio", SqlDbType.Float).Value = Obj.precio;
                    Comando.Parameters.Add("@descuento", SqlDbType.Float).Value = Obj.descuento;
                    Comando.Parameters.Add("@montoTotal", SqlDbType.Float).Value = Obj.montoTotal;
                    Comando.Parameters.Add("@servadd", SqlDbType.Float).Value = Obj.servadd;
                    Comando.Parameters.Add("@cod_reser", SqlDbType.VarChar).Value = Obj.cod_reser;
                    Comando.Parameters.Add("@id_checkout", SqlDbType.Int).Value = Obj.id_checkout;
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
    } 
}
