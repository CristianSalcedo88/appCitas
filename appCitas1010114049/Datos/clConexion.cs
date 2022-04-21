using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Datos
{
    class clConexion
    {
        SqlConnection conexion;
        public clConexion()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-MUAS3NV\\SQLEXPRESS;Initial Catalog=dbCitasMedicas;Integrated Security=True");
            conexion.Open();
        }

        public DataTable mtdDesconectado(string sql)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            DataTable tblDatos = new DataTable();
            adaptador.Fill(tblDatos);
            conexion.Close();
            return tblDatos;
        }
        public int mtdConectado(string sql) //Insert,Update,Delete
        {
            SqlCommand comando = new SqlCommand(sql, conexion);
            int filasAfectadas = comando.ExecuteNonQuery();
            conexion.Close();
            return filasAfectadas;
        }
    }
}
