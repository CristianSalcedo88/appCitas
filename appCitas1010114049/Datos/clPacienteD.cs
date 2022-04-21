using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Datos
{
    class clPacienteD
    {

        public List<clPacienteE> mtdEnviar(String documento)
        {
            string sql = "select * from paciente where documento = '" + documento + "'";
            clConexion objConexion = new clConexion();
            DataTable tblPaciente = new DataTable();
            tblPaciente = objConexion.mtdDesconectado(sql);

            List<clPacienteE> listarPacientes = new List<clPacienteE>();

            for (int i = 0; i < tblPaciente.Rows.Count; i++)
            {
                clPacienteE objDatosPaciente = new clPacienteE();
                objDatosPaciente.idPaciente = int.Parse(tblPaciente.Rows[i]["idPaciente"].ToString());
                objDatosPaciente.documento = tblPaciente.Rows[i]["documento"].ToString();
                objDatosPaciente.nombre = tblPaciente.Rows[i]["nombre"].ToString();
                objDatosPaciente.apellido = tblPaciente.Rows[i]["apellido"].ToString();
                objDatosPaciente.fechaNacimiento = DateTime.Parse(tblPaciente.Rows[i]["fechaNacimiento"].ToString());
                objDatosPaciente.genero = tblPaciente.Rows[i]["genero"].ToString();
                objDatosPaciente.estatura = float.Parse(tblPaciente.Rows[i]["estatura"].ToString());
                objDatosPaciente.peso = float.Parse(tblPaciente.Rows[i]["peso"].ToString());
                objDatosPaciente.direccion = tblPaciente.Rows[i]["direccion"].ToString();
                objDatosPaciente.celular = tblPaciente.Rows[i]["celular"].ToString();
                objDatosPaciente.email = tblPaciente.Rows[i]["email"].ToString();
                listarPacientes.Add(objDatosPaciente);

            }
            return listarPacientes;
        }
        public List<clPacienteE> mtdListar()

        {


            string sql = "select * from paciente";
            clConexion objConexion = new clConexion();
            DataTable tblPaciente = new DataTable();
            tblPaciente = objConexion.mtdDesconectado(sql);

            List<clPacienteE> listarPacientes = new List<clPacienteE>();

            for (int i = 0; i < tblPaciente.Rows.Count; i++)
            {
                clPacienteE objDatosPaciente = new clPacienteE();
                objDatosPaciente.idPaciente = int.Parse(tblPaciente.Rows[i]["idPaciente"].ToString());
                objDatosPaciente.documento = tblPaciente.Rows[i]["documento"].ToString();
                objDatosPaciente.nombre = tblPaciente.Rows[i]["nombre"].ToString();
                objDatosPaciente.apellido = tblPaciente.Rows[i]["apellido"].ToString();
                objDatosPaciente.fechaNacimiento = DateTime.Parse(tblPaciente.Rows[i]["fechaNacimiento"].ToString());
                objDatosPaciente.genero = tblPaciente.Rows[i]["genero"].ToString();
                objDatosPaciente.estatura = float.Parse(tblPaciente.Rows[i]["estatura"].ToString());
                objDatosPaciente.peso = float.Parse(tblPaciente.Rows[i]["peso"].ToString());
                objDatosPaciente.direccion = tblPaciente.Rows[i]["direccion"].ToString();
                objDatosPaciente.celular = tblPaciente.Rows[i]["celular"].ToString();
                objDatosPaciente.email = tblPaciente.Rows[i]["email"].ToString();
                listarPacientes.Add(objDatosPaciente);



            }
            return listarPacientes;


        }




        public int mtdRegistrarPaciente(clPacienteE objDatosPaciente)
        {
            string sql = "insert into paciente(documento,nombre,apellido,fechaNacimiento,genero,estatura,peso,direccion,celular,email) values('" + objDatosPaciente.documento + "'," +
                "'" + objDatosPaciente.nombre + "','" + objDatosPaciente.apellido + "','" + objDatosPaciente.fechaNacimiento + "','" + objDatosPaciente.genero + "'," + objDatosPaciente.estatura + "," + objDatosPaciente.peso + "," +
                "'" + objDatosPaciente.direccion + "','" + objDatosPaciente.celular + "','" + objDatosPaciente.email + "')";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }
        public void mtdEliminarPaciente(int idPaciente)
        {
            string sql = "delete  from paciente where idPaciente=" + idPaciente + "";
            clConexion objConexion = new clConexion();
            objConexion.mtdConectado(sql);

        }
        public void mtdEditarDatos(clPacienteE objDatosEditar)
        {
            string sql = "update paciente " +
                "set documento='" + objDatosEditar.documento + "',nombre='" + objDatosEditar.nombre + "',apellido='" + objDatosEditar.apellido + "'" +
                ",fechaNacimiento='" + objDatosEditar.fechaNacimiento + "',genero='" + objDatosEditar.genero + "',estatura=" + objDatosEditar.estatura + "," +
                "peso=" + objDatosEditar.peso + ",direccion='" + objDatosEditar.direccion + "',email='" + objDatosEditar.email + "',celular='" + objDatosEditar.celular + "'" +
                " where idPaciente='" + objDatosEditar.idPaciente + "'";
            Console.WriteLine(sql);
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
        }
    }
}
