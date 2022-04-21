using appCitas1010114049.Entidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCitas1010114049.Datos
{
    class clMedicoD
    {
        public List<clMedicoE> mtdEnviarM(int especialidad)
        {
            string sql = "select * from medico where idEspecialidad='"+especialidad+"'";
            clConexion objConexion = new clConexion();
            DataTable tblMedico = new DataTable();
            tblMedico = objConexion.mtdDesconectado(sql);

            List<clMedicoE> listarMedicos = new List<clMedicoE>();

            for (int i = 0; i < tblMedico.Rows.Count; i++)
            {
                clMedicoE objDatosMedico = new clMedicoE();
                objDatosMedico.idMedico = int.Parse(tblMedico.Rows[i]["idMedico"].ToString());
                objDatosMedico.documento = tblMedico.Rows[i]["documento"].ToString();
                objDatosMedico.nombre = tblMedico.Rows[i]["nombre"].ToString();
                objDatosMedico.apellido = tblMedico.Rows[i]["apellido"].ToString();
                objDatosMedico.email = tblMedico.Rows[i]["email"].ToString();
                objDatosMedico.direccion = tblMedico.Rows[i]["direccion"].ToString();
                objDatosMedico.celular = tblMedico.Rows[i]["celular"].ToString();
                objDatosMedico.idEspecialidad = int.Parse(tblMedico.Rows[i]["idEspecialidad"].ToString());
                listarMedicos.Add(objDatosMedico);

            }
            return listarMedicos;
        }
        public List<clMedicoE> mtdListar()
        {
            string sql = "select * from medico";
            clConexion objConexion = new clConexion();
            DataTable tblMedico = new DataTable();
            tblMedico = objConexion.mtdDesconectado(sql);

            List<clMedicoE> listarMedicos = new List<clMedicoE>();

            for (int i = 0; i < tblMedico.Rows.Count; i++)
            {
                clMedicoE objDatosMedico = new clMedicoE();
                objDatosMedico.idMedico = int.Parse(tblMedico.Rows[i]["idMedico"].ToString());
                objDatosMedico.documento = tblMedico.Rows[i]["documento"].ToString();
                objDatosMedico.nombre = tblMedico.Rows[i]["nombre"].ToString();
                objDatosMedico.apellido = tblMedico.Rows[i]["apellido"].ToString();
                objDatosMedico.email = tblMedico.Rows[i]["email"].ToString();
                objDatosMedico.direccion = tblMedico.Rows[i]["direccion"].ToString();
                objDatosMedico.celular = tblMedico.Rows[i]["celular"].ToString();
                objDatosMedico.idEspecialidad = int.Parse(tblMedico.Rows[i]["idEspecialidad"].ToString());
                listarMedicos.Add(objDatosMedico);

            }
            return listarMedicos;
        }

        public int mtdRegistrarMedico(clMedicoE objDatosMedico)
        {
            string sql = "insert into medico(documento,nombre,apellido,email,direccion,celular,idEspecialidad) values('" + objDatosMedico.documento + "'," +
                "'" + objDatosMedico.nombre + "','" + objDatosMedico.apellido + "','" + objDatosMedico.email + "'," +
                "'" + objDatosMedico.direccion + "','" + objDatosMedico.celular + "'," + objDatosMedico.idEspecialidad + ")";
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
            return resultado;
        }
        public void mtdEliminarMedico(int idMedico)
        {
            string sql = "delete  from medico where idMedico=" + idMedico + "";
            clConexion objConexion = new clConexion();
            objConexion.mtdConectado(sql);
            
        }

        public void mtdEditarDatos(clMedicoE objDatosEditar)
        {
            string sql = "update medico " +
                "set documento='"+ objDatosEditar.documento+ "',nombre='" + objDatosEditar.nombre + "',apellido='" + objDatosEditar.apellido + "'" +
                ",email='" + objDatosEditar.email + "',direccion='" + objDatosEditar.direccion + "',celular='" + objDatosEditar.celular + "'" +
                ",idEspecialidad ="+ objDatosEditar.idEspecialidad+"" +
                " where idMedico='" + objDatosEditar.idMedico + "'";
            Console.WriteLine(sql);
            clConexion objConexion = new clConexion();
            int resultado = objConexion.mtdConectado(sql);
        }
    }
}
