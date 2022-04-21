using appCitas1010114049.Entidad;
using appCitas1010114049.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appCitas1010114049.Presentacion
{
    public partial class frmMedico : Form
    {
        int idMedico;
        public frmMedico()
        {
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {


            clMedicoL objEmpleadosL = new clMedicoL();
            dgvMedico.DataSource = objEmpleadosL.mtdListarMedico();

            //Mostrar Especialidad
            clEspecialidadL objEspecialidadL = new clEspecialidadL();
            cmbEspecialidad.DataSource = objEspecialidadL.mtdListarEspecialidad();
            cmbEspecialidad.DisplayMember = "especialidad";
            cmbEspecialidad.ValueMember = "idEspecialidad";
        }

        private void btnAgregarMedico_Click(object sender, EventArgs e)
        {
            clMedicoE objDatosMedico = new clMedicoE();
            objDatosMedico.documento = txtDocumento.Text;
            objDatosMedico.nombre = txtNombre.Text;
            objDatosMedico.apellido = txtApellido.Text;
            objDatosMedico.email = txtEmail.Text;
            objDatosMedico.celular = txtCelular.Text;
            objDatosMedico.direccion = txtDireccion.Text;
            objDatosMedico.idEspecialidad = int.Parse(cmbEspecialidad.SelectedValue.ToString());


            clMedicoL objMedicoL = new clMedicoL();
            int filas = objMedicoL.mtdRegistrarMedico(objDatosMedico);
            if (filas > 0)
            {
                MessageBox.Show("Medico Registrado");

            }
            else
            {
                MessageBox.Show("Error al Registrar");
            }
        }

        private void dgvMedico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idMedico = int.Parse(dgvMedico.CurrentRow.Cells[0].Value.ToString());
                txtDocumento.Text = dgvMedico.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvMedico.CurrentRow.Cells[2].Value.ToString();
                txtApellido.Text = dgvMedico.CurrentRow.Cells[3].Value.ToString();
                txtEmail.Text = dgvMedico.CurrentRow.Cells[4].Value.ToString();
                txtDireccion.Text = dgvMedico.CurrentRow.Cells[5].Value.ToString();
                txtCelular.Text = dgvMedico.CurrentRow.Cells[6].Value.ToString();
                cmbEspecialidad.Text = dgvMedico.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            clMedicoL objEmpleadosL = new clMedicoL();
            dgvMedico.DataSource = objEmpleadosL.mtdListarMedico();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar Registros", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                clMedicoL objMedicoL = new clMedicoL();
                objMedicoL.mtdEliminarMedico(idMedico);
                
                MessageBox.Show("Registro eliminado");

                clMedicoL objEmpleadosL = new clMedicoL();
                dgvMedico.DataSource = objEmpleadosL.mtdListarMedico();
            }

            else

            {

                MessageBox.Show("Registro no eliminado");

            }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clMedicoE objDatosEditar = new clMedicoE();
            objDatosEditar.idMedico = idMedico;
            objDatosEditar.documento = txtDocumento.Text;
            objDatosEditar.nombre = txtNombre.Text;
            objDatosEditar.apellido = txtApellido.Text;
            objDatosEditar.email = txtEmail.Text;
            objDatosEditar.celular = txtCelular.Text;
            objDatosEditar.direccion = txtDireccion.Text;
            objDatosEditar.idEspecialidad = int.Parse(cmbEspecialidad.SelectedValue.ToString());

            clMedicoL objMedicoL = new clMedicoL();
            objMedicoL.mtdEditarDatos(objDatosEditar);



        }

        private void cmbEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            //OpenFileDialog BuscarImagen = new OpenFileDialog();
            //BuscarImagen.Filter = "Archivos de Imagen|*.jpg";
            ////Aquí incluiremos los filtros que queramos.
            //BuscarImagen.FileName = "";
            //BuscarImagen.Title = "Titulo del Dialogo";
            //BuscarImagen.InitialDirectory = "C:\\"; BuscarImagen.FileName = this.textBox1.Text;
            string nombreFoto = "2222" + ".png";
            string urlFotos = Directory.GetCurrentDirectory() + "\\fotos\\" + nombreFoto;
            MessageBox.Show(urlFotos);
            if (ofdFoto.ShowDialog() == DialogResult.OK)
            {
                // Si esto se cumple, capturamos la propiedad File Name y la guardamos en el control
                this.textBox1.Text = ofdFoto.FileName;
                String Direccion = ofdFoto.FileName; 
                this.pbFoto.ImageLocation = Direccion;
                //Pueden usar tambien esta forma para cargar la Imagen solo activenla y comenten la linea donde se cargaba anteriormente 
                this.pbFoto.ImageLocation = textBox1.Text;
                pbFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            //ofdFoto.ShowDialog();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            //string nombreFoto = "2222" + ".png";
            //string urlFotos = Directory.GetCurrentDirectory() + "\\fotos\\" + nombreFoto; 
            //MessageBox.Show(urlFotos);

            //string urlFotos2 = Path.GetFullPath("..\\..\\Presentacion\\fotosMedico");
            //MessageBox.Show(urlFotos2);

            //string urlFotos3 = Path.GetFullPath(@"fotosMedico");
            //MessageBox.Show(urlFotos3);

           // string urlFotos4 = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembl().loquetion);

        }
    }
}
