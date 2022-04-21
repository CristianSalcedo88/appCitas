using appCitas1010114049.Entidad;
using appCitas1010114049.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCitas1010114049.Presentacion
{
    public partial class frmPaciente : Form
    {
        int idPaciente;
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            clPacienteL objPaciente = new clPacienteL();
            dgvPaciente.DataSource = objPaciente.mtdListarPaciente();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clPacienteE objDatosPaciente = new clPacienteE();
            objDatosPaciente.documento = txtDocumento.Text;
            objDatosPaciente.nombre = txtNombre.Text;
            objDatosPaciente.apellido = txtApellido.Text;
            objDatosPaciente.fechaNacimiento = DateTime.Parse(mtxFechaNacimiento.Text);
            if (rdbMasculino.Checked == true)
            {
                objDatosPaciente.genero = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked == true)
            {
                objDatosPaciente.genero = rdbFemenino.Text;
            }
            objDatosPaciente.estatura = float.Parse(txtEstatura.Text);
            objDatosPaciente.peso = float.Parse(txtPeso.Text);
            objDatosPaciente.direccion = txtDireccion.Text;
            objDatosPaciente.celular = txtCelular.Text;
            objDatosPaciente.email = txtEmail.Text;

            clPacienteL objPacienteL = new clPacienteL();
            int filas = objPacienteL.mtdRegistrarPaciente(objDatosPaciente);
            if (filas > 0)
            {
                MessageBox.Show("Paciente Registrado");

                clPacienteL objPaciente = new clPacienteL();
                dgvPaciente.DataSource = objPaciente.mtdListarPaciente();

            }
            else
            {
                MessageBox.Show("Error al Registrar");
            }



        }

        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idPaciente = int.Parse(dgvPaciente.CurrentRow.Cells[0].Value.ToString());
                txtDocumento.Text = dgvPaciente.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvPaciente.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvPaciente.CurrentRow.Cells[3].Value.ToString();
                mtxFechaNacimiento.Text = dgvPaciente.CurrentRow.Cells[4].Value.ToString();
                if (dgvPaciente.CurrentRow.Cells[5].Value.ToString() == "F")
                {
                    rdbFemenino.Checked = true;
                }
                else if (dgvPaciente.CurrentRow.Cells[5].Value.ToString() == "M")
                {
                    rdbMasculino.Checked = true;
                }

                txtEstatura.Text = dgvPaciente.CurrentRow.Cells[6].Value.ToString();
                txtPeso.Text = dgvPaciente.CurrentRow.Cells[7].Value.ToString();
                txtDireccion.Text = dgvPaciente.CurrentRow.Cells[8].Value.ToString();
                txtCelular.Text = dgvPaciente.CurrentRow.Cells[9].Value.ToString();
                txtEmail.Text = dgvPaciente.CurrentRow.Cells[10].Value.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clPacienteL objPacienteL = new clPacienteL();
                objPacienteL.mtdEliminarPaciente(idPaciente);

                MessageBox.Show("Registro eliminado");

                clPacienteL objPaciente = new clPacienteL();
                dgvPaciente.DataSource = objPaciente.mtdListarPaciente();
            }

            else

            {

                MessageBox.Show("Registro no eliminado");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clPacienteE objDatosEditar = new clPacienteE();
            objDatosEditar.idPaciente = idPaciente;
            objDatosEditar.documento = txtDocumento.Text;
            objDatosEditar.nombre = txtNombre.Text;
            objDatosEditar.apellido = txtApellido.Text;
            objDatosEditar.fechaNacimiento = DateTime.Parse(mtxFechaNacimiento.Text);
            if (rdbMasculino.Checked == true)
            {
                objDatosEditar.genero = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked == true)
            {
                objDatosEditar.genero = rdbFemenino.Text;
            }
            objDatosEditar.estatura = float.Parse(txtEstatura.Text);
            objDatosEditar.peso = float.Parse(txtPeso.Text);
            objDatosEditar.direccion = txtDireccion.Text;
            objDatosEditar.celular = txtCelular.Text;
            objDatosEditar.email = txtEmail.Text;

            clPacienteL objPacienteL = new clPacienteL();
            objPacienteL.mtdEditarDatos(objDatosEditar);



        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clPacienteL objPaciente = new clPacienteL();
            dgvPaciente.DataSource = objPaciente.mtdListarPaciente();
        }
    }
}
