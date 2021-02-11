
using CRUDCaptura.Servicio;
using FormularioConsultas.bd;
using FormularioConsultas.Modelo;
using FormularioConsultas.Servicio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDCaptura
{
    public partial class CapturaForm : Form
    {
        public CapturaForm()
        {
            InitializeComponent();

        }

        void combousuario()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> list = fd.getayuda();
            boxInformacionSolicitada.ValueMember = "AyudaSolicitada";
            boxInformacionSolicitada.DataSource = list;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }
        void personal()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> listpersona = fd.getpersonaldeapoyo();
            boxPersonalAtendio.ValueMember = "Respuesta";
            boxPersonalAtendio.DataSource = listpersona;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }
        void id()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetId", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtId.Text = Convert.ToString(reader["IdCliente"]);
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (bd != null)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                        bd.Dispose();
                    }
                }//cierraif1
            }//cierra finally
        }
        void fecha()
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            bd.Open();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetFecha", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader reader = objCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtFecha.Text = Convert.ToString(reader["Fecha"]);
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (bd != null)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                        bd.Dispose();
                    }
                }//cierraif1
            }//cierra finally
        }
        void inversion()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> listinversion = fd.getMontoInversion();
            boxMontoInversion.ValueMember = "MontoInvercion";
            boxMontoInversion.DataSource = listinversion;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }

        void contacto()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> listcontacto = fd.getMedioContacto();
            boxDondellegoMensaje.ValueMember = "ComoLlegoMensaje";
            boxDondellegoMensaje.DataSource = listcontacto;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }

        void estado()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> listestado = fd.getEstados();
            boxEstado.ValueMember = "EstadoRespuestaAyuda";
            boxEstado.DataSource = listestado;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }
        void seguimiento()
        {
            Consultas fd = new Consultas();
            List<FormularioConsultasModelo> listestado = fd.getSeguimiento();
            boxStatus.ValueMember = "Seguimiento";
            boxStatus.DataSource = listestado;
            // boxInformacionSolicitada.DisplayMember = "AyudaSolicitad";
        }
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string mensaje = "";
            FormularioConsultasModelo b = new FormularioConsultasModelo();
            b.Nombre = txtNombre.Text;
            b.ApeidoPaterno = txtApeidoPaterno.Text;
            b.ApeidoMaterno = txtApeidoMaterno.Text;
            b.Empresa = txtEmpresa.Text;
            b.RFC = txtRFC.Text;
            b.Direccion = txtDireccion.Text;
            b.NumeroExt = txtNumeroExterior.Text;
            b.NumeroInt = txtNumeroInterior.Text;
            b.Colonia = txtColonia.Text;
            b.CiudadRespuestaAyuda = txtCiudadRespuestaAyuda.Text;
            b.EstadoRespuestaAyuda = boxEstado.Text;
            b.CodigoPostal = txtCodigoPostal.Text;
            b.TelefonoCasa = txtTelefonoCasa.Text;
            b.Celular = txtCelular.Text;
            b.Correo1 = txtCorreoPrincipal.Text;
            b.Correo2 = txtCorreoAdicional.Text;
            b.AyudaSolicitada = boxInformacionSolicitada.Text;
            b.Respuesta = boxPersonalAtendio.Text;
            b.CiudadInteres = txtCiudadInteres.Text;
            b.MontoInvercion = boxMontoInversion.Text;
            b.ComoLlegoMensaje = boxDondellegoMensaje.Text;
            b.Seguimiento = boxStatus.Text;
            FormularioConsultaCrud fd = new FormularioConsultaCrud();
            fd.Ingresar(b);

            if (mensaje != " ")
            {
                txtNombre.Clear();
                txtApeidoPaterno.Clear();
                txtApeidoMaterno.Clear();
                txtEmpresa.Clear();
                txtRFC.Clear();
                txtDireccion.Clear();
                txtNumeroExterior.Clear();
                txtNumeroInterior.Clear();
                txtColonia.Clear();
                txtCiudadRespuestaAyuda.Clear();
                txtCodigoPostal.Clear();
                txtTelefonoCasa.Clear();
                txtCelular.Clear();
                txtCorreoPrincipal.Clear();
                txtCorreoAdicional.Clear();
                txtCiudadInteres.Clear();
                boxEstado.SelectedIndex = 0;
                boxInformacionSolicitada.SelectedIndex = 0;
                boxMontoInversion.SelectedIndex = 0;
                boxDondellegoMensaje.SelectedIndex = 0;
                boxPersonalAtendio.SelectedIndex = 0;
                id();
                fecha();
                string dato = Convert.ToString(b.IdCliente);
                txtId.Text = dato;
                MessageBox.Show("Datos Guardados correctamente", " ", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show("Los datos no se han guardado correctamente", " ", MessageBoxButtons.OK);
            }
        }

        private void CapturaForm_Load(object sender, EventArgs e)
        {
            combousuario();
            personal();
            inversion();
            contacto();
            estado();
            seguimiento();
            id();
            fecha();
        }

        /// <summary>
        /// Aqui se ponen  todas las Restriciones 
        /// para validar los textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Nombre", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void txtApeidoPaterno_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Apeidos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtApeidoMaterno.CharacterCasing = CharacterCasing.Upper;
                txtApeidoPaterno.CharacterCasing = CharacterCasing.Upper;
            }
        }

        private void txtEmpresa_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Empresa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtDireccion_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Dirección", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtColonia_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Colonia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtCiudadRespuestaAyuda_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Ciudad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boxEstado_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boxInformacionSolicitada_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Información Solicitada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void boxPersonalAtendio_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten Caracteres", "Personal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void txtCodigoPostal_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pérmiten números", "Codigo Postal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoPostal.SelectAll();
                txtCodigoPostal.Focus();
            }
        }

        private void txtCelular_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se pérmiten números", "Validación de Telefono", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCelular.SelectAll();
                txtCelular.Focus();
            }
        }
        /// <summary>
        /// Metodo para validar Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static Boolean mail(string email)
        {
            string espresion = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            if (Regex.IsMatch(email, espresion))
            {
                if (Regex.Replace(email, espresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }
        private void txtCorreoPrincipal_Leave_1(object sender, EventArgs e)
        {
            if (mail(txtCorreoPrincipal.Text))
            {

            }
            else
            {
                MessageBox.Show("La Direccion de correo ingresada no es valida, debe tener el formato: nombre@dominio.com "
                    + "\nPorfavor Ingresa Un Correo Valido", "Validacón de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreoPrincipal.SelectAll();
                txtCorreoPrincipal.Focus();
            }
        }
        private void txtCorreoAdicional_Leave_1(object sender, EventArgs e)
        {
            // validar correo adicional 
            if (mail(txtCorreoAdicional.Text))
            {

            }
            else
            {
                MessageBox.Show("La Direccion de correo ingresada no es valida, debe tener el formato: nombre@dominio.com"
                   + "\nPorfavor Ingresa Un Correo Valido", "Validacón de correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreoAdicional.SelectAll();
                txtCorreoAdicional.Focus();
            }
        }
        private static Boolean validarrfc(string rfc)
        {
            string espresion = @"^(([A-ZÑ&]{4})([0-9]{2})([0][13578]|[1][02])(([0][1-9]|[12][\\d])|[3][01])([A-Z0-9]{3}))|(([A-ZÑ&]{4})([0-9]{2})([0][13456789]|[1][012])(([0][1-9]|[12][\\d])|[3][0])([A-Z0-9]{3}))|(([A-ZÑ&]{4})([02468][048]|[13579][26])[0][2]([0][1-9]|[12][\\d])([A-Z0-9]{3}))|(([A-ZÑ&]{4})([0-9]{2})[0][2]([0][1-9]|[1][0-9]|[2][0-8])([A-Z0-9]{3}))$";
            if (Regex.IsMatch(rfc, espresion))
            {
                if (Regex.Replace(rfc, espresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        private void txtRFC_Leave_1(object sender, EventArgs e)
        {
            // validar correo adicional 
            if (validarrfc(txtRFC.Text))
            {

            }
            else
            {
                MessageBox.Show("El RFC ingresado  no es valido"
                   + "\nPorfavor ingrese nuevamente el RFC", "Validacón de RFC", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorreoAdicional.SelectAll();
                txtCorreoAdicional.Focus();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Conexion conn = new Conexion();
            SqlConnection bd = conn.GetConnection;
            FormularioConsultasModelo b = new FormularioConsultasModelo();
            txtId.Enabled = true;
            txtFecha.Visible = false;
            lbFecha.Visible = false;
            //btnEditar.Visible = false;
            //btnGuardar.Visible = false;
            //btnBuscar.Visible = false;
            b.IdCliente = txtId.Text;
            bd.Open();
            try
            {
                SqlCommand objCommand = new SqlCommand("spGetPorId", bd);
                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.Parameters.Add("IdCliente", System.Data.SqlDbType.VarChar).Value = b.IdCliente;
                objCommand.ExecuteNonQuery();
                SqlDataReader reader = objCommand.ExecuteReader();
                if (reader.Read())
                {
                    txtNombre.Text = Convert.ToString(reader["Nombre"]);
                    txtApeidoPaterno.Text = Convert.ToString(reader["ApeidoPaterno"]);
                    txtApeidoMaterno.Text = Convert.ToString(reader["ApeidoMaterno"]);
                    txtEmpresa.Text = Convert.ToString(reader["Empresa"]);
                    txtRFC.Text = Convert.ToString(reader["RFC"]);
                    txtDireccion.Text = Convert.ToString(reader["Direccion"]);
                    txtNumeroExterior.Text = Convert.ToString(reader["NumeroExt"]);
                    txtNumeroInterior.Text = Convert.ToString(reader["NumeroInt"]);
                    txtColonia.Text = Convert.ToString(reader["Colonia"]);
                    txtCiudadRespuestaAyuda.Text = Convert.ToString(reader["CiudadRespuestaAyuda"]);
                    boxEstado.Text = Convert.ToString(reader["EstadoRespuestaAyuda"]);
                    txtCodigoPostal.Text = Convert.ToString(reader["CodigoPostal"]);
                    txtTelefonoCasa.Text = Convert.ToString(reader["TelefonoCasa"]);
                    txtCelular.Text = Convert.ToString(reader["Celular"]);
                    txtCorreoPrincipal.Text = Convert.ToString(reader["Correo1"]);
                    txtCorreoAdicional.Text = Convert.ToString(reader["Correo2"]);
                    txtCiudadInteres.Text = Convert.ToString(reader["CiudadInteres"]);
                    boxInformacionSolicitada.Text = Convert.ToString(reader["AyudaSolicitada"]);
                    boxPersonalAtendio.Text = Convert.ToString(reader["Respuesta"]);
                    boxMontoInversion.Text = Convert.ToString(reader["MontoInvercion"]);
                    boxDondellegoMensaje.Text = Convert.ToString(reader["ComoLlegoMensaje"]);
                    boxStatus.Text = Convert.ToString(reader["Seguimiento"]);
                }

            }
            catch
            {
                throw;
            }
            finally
            {
                if (bd != null)
                {
                    if (bd.State == ConnectionState.Open)
                    {
                        bd.Close();
                        bd.Dispose();
                    }
                }//cierraif1
            }//cierra finally
        }

    }
}
