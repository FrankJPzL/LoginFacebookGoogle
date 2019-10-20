using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using Entidades;

namespace DA_Access
{


    public class DA_Producto
    {
        private SqlConnection cn = new SqlConnection
          (ConfigurationManager.ConnectionStrings["FFA_PROYECTO"].ConnectionString);


        public List<BE_Producto> Listar_Productos()
        {
            List<BE_Producto> lstLista = new List<BE_Producto>();

            SqlCommand cmd = new SqlCommand("USP_LISTARPRODUCTOS", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataReader dr = null;

            try
            {
                cn.Open();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        BE_Producto objReg = new BE_Producto();
                        BE_Marca objMarca = new BE_Marca();
                        objReg.cod_Producto = dr.GetInt32(0);                        
                        objReg.Des_Producto = dr.GetString(1);
                        objReg.stock = dr.GetInt32(2);
                        objReg.precio = dr.GetDecimal(3);
                        objMarca.nom_Marca= dr.GetString(4);
                       // objReg.Marca.nom_Marca = objMarca.nom_Marca;
                        objReg.imagen = dr.GetString(5);
                        lstLista.Add(objReg);
                    }
                }
            }
            catch (Exception ex)
            {
                lstLista = new List<BE_Producto>();
            }
            finally
            {
                dr.Close();

                cn.Close();
            }

            return lstLista;
        }


    }
}
