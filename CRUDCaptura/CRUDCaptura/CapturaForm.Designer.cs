
namespace CRUDCaptura
{
    partial class CapturaForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnBorrar;
            System.Windows.Forms.Button btnBuscar;
            System.Windows.Forms.Button btnEditar;
            System.Windows.Forms.Button btnGuardar;
            this.DivicionInfo = new System.Windows.Forms.SplitContainer();
            this.info = new System.Windows.Forms.Panel();
            this.Captura = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCiudadInteres = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lbFecha = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.Label();
            this.boxStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.boxDondellegoMensaje = new System.Windows.Forms.ComboBox();
            this.boxMontoInversion = new System.Windows.Forms.ComboBox();
            this.ComoLlegoMensaje = new System.Windows.Forms.Label();
            this.MontoInvercion = new System.Windows.Forms.Label();
            this.boxPersonalAtendio = new System.Windows.Forms.ComboBox();
            this.CiudadInteres = new System.Windows.Forms.Label();
            this.PersonalAtendido = new System.Windows.Forms.Label();
            this.boxInformacionSolicitada = new System.Windows.Forms.ComboBox();
            this.txtCorreoAdicional = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreoPrincipal = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.CorreoPrincipal = new System.Windows.Forms.Label();
            this.Celular = new System.Windows.Forms.Label();
            this.txtTelefonoCasa = new System.Windows.Forms.TextBox();
            this.TelefonoCasa = new System.Windows.Forms.Label();
            this.txtCodigoPostal = new System.Windows.Forms.TextBox();
            this.CodigoPostal = new System.Windows.Forms.Label();
            this.boxEstado = new System.Windows.Forms.ComboBox();
            this.EstadoRespuestaAyuda = new System.Windows.Forms.Label();
            this.txtCiudadRespuestaAyuda = new System.Windows.Forms.TextBox();
            this.CiudadRespuestaAyuda = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.Colonia = new System.Windows.Forms.Label();
            this.txtNumeroInterior = new System.Windows.Forms.TextBox();
            this.txtNumeroExterior = new System.Windows.Forms.TextBox();
            this.NumeroExterior = new System.Windows.Forms.Label();
            this.NumeroInterior = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRFC = new System.Windows.Forms.TextBox();
            this.ApeidoMaterno = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.txtApeidoMaterno = new System.Windows.Forms.TextBox();
            this.ApeidoPaterno = new System.Windows.Forms.Label();
            this.txtApeidoPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            btnBorrar = new System.Windows.Forms.Button();
            btnBuscar = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnGuardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DivicionInfo)).BeginInit();
            this.DivicionInfo.Panel1.SuspendLayout();
            this.DivicionInfo.Panel2.SuspendLayout();
            this.DivicionInfo.SuspendLayout();
            this.info.SuspendLayout();
            this.Captura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnBorrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            btnBorrar.Image = global::CRUDCaptura.Properties.Resources.basurass;
            btnBorrar.Location = new System.Drawing.Point(787, 38);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(51, 44);
            btnBorrar.TabIndex = 105;
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnBuscar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            btnBuscar.Image = global::CRUDCaptura.Properties.Resources.buscarlup;
            btnBuscar.Location = new System.Drawing.Point(861, 38);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new System.Drawing.Size(51, 44);
            btnBuscar.TabIndex = 104;
            btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnEditar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            btnEditar.Image = global::CRUDCaptura.Properties.Resources.Imagen3;
            btnEditar.Location = new System.Drawing.Point(719, 38);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(51, 44);
            btnEditar.TabIndex = 103;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = System.Drawing.Color.DeepSkyBlue;
            btnGuardar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            btnGuardar.Image = global::CRUDCaptura.Properties.Resources.Imagen2;
            btnGuardar.Location = new System.Drawing.Point(651, 38);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new System.Drawing.Size(51, 44);
            btnGuardar.TabIndex = 102;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // DivicionInfo
            // 
            this.DivicionInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivicionInfo.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.DivicionInfo.Location = new System.Drawing.Point(0, 0);
            this.DivicionInfo.Name = "DivicionInfo";
            this.DivicionInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // DivicionInfo.Panel1
            // 
            this.DivicionInfo.Panel1.Controls.Add(this.info);
            // 
            // DivicionInfo.Panel2
            // 
            this.DivicionInfo.Panel2.Controls.Add(this.Captura);
            this.DivicionInfo.Size = new System.Drawing.Size(938, 593);
            this.DivicionInfo.SplitterDistance = 85;
            this.DivicionInfo.TabIndex = 0;
            // 
            // info
            // 
            this.info.AutoScroll = true;
            this.info.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.info.Controls.Add(btnBorrar);
            this.info.Controls.Add(btnBuscar);
            this.info.Controls.Add(btnEditar);
            this.info.Controls.Add(btnGuardar);
            this.info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info.Location = new System.Drawing.Point(0, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(938, 85);
            this.info.TabIndex = 0;
            // 
            // Captura
            // 
            this.Captura.BackColor = System.Drawing.Color.White;
            this.Captura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Captura.Controls.Add(this.groupBox1);
            this.Captura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Captura.Location = new System.Drawing.Point(0, 0);
            this.Captura.Name = "Captura";
            this.Captura.Size = new System.Drawing.Size(938, 504);
            this.Captura.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCiudadInteres);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.lbFecha);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.boxStatus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.boxDondellegoMensaje);
            this.groupBox1.Controls.Add(this.boxMontoInversion);
            this.groupBox1.Controls.Add(this.ComoLlegoMensaje);
            this.groupBox1.Controls.Add(this.MontoInvercion);
            this.groupBox1.Controls.Add(this.boxPersonalAtendio);
            this.groupBox1.Controls.Add(this.CiudadInteres);
            this.groupBox1.Controls.Add(this.PersonalAtendido);
            this.groupBox1.Controls.Add(this.boxInformacionSolicitada);
            this.groupBox1.Controls.Add(this.txtCorreoAdicional);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCorreoPrincipal);
            this.groupBox1.Controls.Add(this.txtCelular);
            this.groupBox1.Controls.Add(this.CorreoPrincipal);
            this.groupBox1.Controls.Add(this.Celular);
            this.groupBox1.Controls.Add(this.txtTelefonoCasa);
            this.groupBox1.Controls.Add(this.TelefonoCasa);
            this.groupBox1.Controls.Add(this.txtCodigoPostal);
            this.groupBox1.Controls.Add(this.CodigoPostal);
            this.groupBox1.Controls.Add(this.boxEstado);
            this.groupBox1.Controls.Add(this.EstadoRespuestaAyuda);
            this.groupBox1.Controls.Add(this.txtCiudadRespuestaAyuda);
            this.groupBox1.Controls.Add(this.CiudadRespuestaAyuda);
            this.groupBox1.Controls.Add(this.txtColonia);
            this.groupBox1.Controls.Add(this.Colonia);
            this.groupBox1.Controls.Add(this.txtNumeroInterior);
            this.groupBox1.Controls.Add(this.txtNumeroExterior);
            this.groupBox1.Controls.Add(this.NumeroExterior);
            this.groupBox1.Controls.Add(this.NumeroInterior);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtRFC);
            this.groupBox1.Controls.Add(this.ApeidoMaterno);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Controls.Add(this.txtEmpresa);
            this.groupBox1.Controls.Add(this.txtApeidoMaterno);
            this.groupBox1.Controls.Add(this.ApeidoPaterno);
            this.groupBox1.Controls.Add(this.txtApeidoPaterno);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(936, 502);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtCiudadInteres
            // 
            this.txtCiudadInteres.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudadInteres.Location = new System.Drawing.Point(293, 402);
            this.txtCiudadInteres.Name = "txtCiudadInteres";
            this.txtCiudadInteres.Size = new System.Drawing.Size(315, 22);
            this.txtCiudadInteres.TabIndex = 142;
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.No;
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.Location = new System.Drawing.Point(191, 40);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(316, 22);
            this.txtFecha.TabIndex = 141;
            // 
            // lbFecha
            // 
            this.lbFecha.AutoEllipsis = true;
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFecha.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbFecha.Location = new System.Drawing.Point(187, 16);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(58, 21);
            this.lbFecha.TabIndex = 140;
            this.lbFecha.Text = "Fecha";
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(3, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(97, 22);
            this.txtId.TabIndex = 139;
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Id.Location = new System.Drawing.Point(6, 16);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(26, 21);
            this.Id.TabIndex = 138;
            this.Id.Text = "Id";
            // 
            // boxStatus
            // 
            this.boxStatus.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxStatus.FormattingEnabled = true;
            this.boxStatus.Location = new System.Drawing.Point(649, 469);
            this.boxStatus.Name = "boxStatus";
            this.boxStatus.Size = new System.Drawing.Size(262, 25);
            this.boxStatus.TabIndex = 137;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(645, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 136;
            this.label6.Text = "Seguimiento";
            // 
            // boxDondellegoMensaje
            // 
            this.boxDondellegoMensaje.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDondellegoMensaje.FormattingEnabled = true;
            this.boxDondellegoMensaje.Location = new System.Drawing.Point(294, 469);
            this.boxDondellegoMensaje.Name = "boxDondellegoMensaje";
            this.boxDondellegoMensaje.Size = new System.Drawing.Size(315, 25);
            this.boxDondellegoMensaje.TabIndex = 135;
            // 
            // boxMontoInversion
            // 
            this.boxMontoInversion.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMontoInversion.FormattingEnabled = true;
            this.boxMontoInversion.Location = new System.Drawing.Point(2, 469);
            this.boxMontoInversion.Name = "boxMontoInversion";
            this.boxMontoInversion.Size = new System.Drawing.Size(263, 25);
            this.boxMontoInversion.TabIndex = 134;
            // 
            // ComoLlegoMensaje
            // 
            this.ComoLlegoMensaje.AutoSize = true;
            this.ComoLlegoMensaje.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComoLlegoMensaje.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ComoLlegoMensaje.Location = new System.Drawing.Point(290, 445);
            this.ComoLlegoMensaje.Name = "ComoLlegoMensaje";
            this.ComoLlegoMensaje.Size = new System.Drawing.Size(160, 21);
            this.ComoLlegoMensaje.TabIndex = 133;
            this.ComoLlegoMensaje.Text = "Medio de contacto";
            // 
            // MontoInvercion
            // 
            this.MontoInvercion.AutoSize = true;
            this.MontoInvercion.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MontoInvercion.ForeColor = System.Drawing.SystemColors.InfoText;
            this.MontoInvercion.Location = new System.Drawing.Point(3, 445);
            this.MontoInvercion.Name = "MontoInvercion";
            this.MontoInvercion.Size = new System.Drawing.Size(168, 21);
            this.MontoInvercion.TabIndex = 132;
            this.MontoInvercion.Text = "Monto de inversión";
            // 
            // boxPersonalAtendio
            // 
            this.boxPersonalAtendio.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPersonalAtendio.FormattingEnabled = true;
            this.boxPersonalAtendio.Location = new System.Drawing.Point(650, 402);
            this.boxPersonalAtendio.Name = "boxPersonalAtendio";
            this.boxPersonalAtendio.Size = new System.Drawing.Size(261, 25);
            this.boxPersonalAtendio.TabIndex = 131;
            // 
            // CiudadInteres
            // 
            this.CiudadInteres.AutoSize = true;
            this.CiudadInteres.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadInteres.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CiudadInteres.Location = new System.Drawing.Point(303, 377);
            this.CiudadInteres.Name = "CiudadInteres";
            this.CiudadInteres.Size = new System.Drawing.Size(130, 21);
            this.CiudadInteres.TabIndex = 129;
            this.CiudadInteres.Text = "Ciudad interes";
            // 
            // PersonalAtendido
            // 
            this.PersonalAtendido.AutoSize = true;
            this.PersonalAtendido.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonalAtendido.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PersonalAtendido.Location = new System.Drawing.Point(645, 377);
            this.PersonalAtendido.Name = "PersonalAtendido";
            this.PersonalAtendido.Size = new System.Drawing.Size(120, 21);
            this.PersonalAtendido.TabIndex = 128;
            this.PersonalAtendido.Text = "Atendido por:";
            // 
            // boxInformacionSolicitada
            // 
            this.boxInformacionSolicitada.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxInformacionSolicitada.FormattingEnabled = true;
            this.boxInformacionSolicitada.Location = new System.Drawing.Point(2, 401);
            this.boxInformacionSolicitada.Name = "boxInformacionSolicitada";
            this.boxInformacionSolicitada.Size = new System.Drawing.Size(263, 25);
            this.boxInformacionSolicitada.TabIndex = 127;
            // 
            // txtCorreoAdicional
            // 
            this.txtCorreoAdicional.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoAdicional.Location = new System.Drawing.Point(649, 344);
            this.txtCorreoAdicional.Name = "txtCorreoAdicional";
            this.txtCorreoAdicional.Size = new System.Drawing.Size(262, 22);
            this.txtCorreoAdicional.TabIndex = 126;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(2, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 21);
            this.label4.TabIndex = 125;
            this.label4.Text = "Información solicitada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(646, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 21);
            this.label5.TabIndex = 124;
            this.label5.Text = "Correo adicional";
            // 
            // txtCorreoPrincipal
            // 
            this.txtCorreoPrincipal.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoPrincipal.Location = new System.Drawing.Point(294, 344);
            this.txtCorreoPrincipal.Name = "txtCorreoPrincipal";
            this.txtCorreoPrincipal.Size = new System.Drawing.Size(315, 22);
            this.txtCorreoPrincipal.TabIndex = 123;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(3, 342);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(260, 22);
            this.txtCelular.TabIndex = 122;
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress_1);
            // 
            // CorreoPrincipal
            // 
            this.CorreoPrincipal.AutoSize = true;
            this.CorreoPrincipal.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoPrincipal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CorreoPrincipal.Location = new System.Drawing.Point(301, 318);
            this.CorreoPrincipal.Name = "CorreoPrincipal";
            this.CorreoPrincipal.Size = new System.Drawing.Size(146, 21);
            this.CorreoPrincipal.TabIndex = 121;
            this.CorreoPrincipal.Text = "Correo Principal";
            // 
            // Celular
            // 
            this.Celular.AutoSize = true;
            this.Celular.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Celular.Location = new System.Drawing.Point(-1, 318);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(69, 21);
            this.Celular.TabIndex = 120;
            this.Celular.Text = "Celular";
            // 
            // txtTelefonoCasa
            // 
            this.txtTelefonoCasa.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoCasa.Location = new System.Drawing.Point(649, 279);
            this.txtTelefonoCasa.Name = "txtTelefonoCasa";
            this.txtTelefonoCasa.Size = new System.Drawing.Size(262, 22);
            this.txtTelefonoCasa.TabIndex = 119;
            this.txtTelefonoCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress_1);
            // 
            // TelefonoCasa
            // 
            this.TelefonoCasa.AutoSize = true;
            this.TelefonoCasa.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonoCasa.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TelefonoCasa.Location = new System.Drawing.Point(645, 252);
            this.TelefonoCasa.Name = "TelefonoCasa";
            this.TelefonoCasa.Size = new System.Drawing.Size(80, 21);
            this.TelefonoCasa.TabIndex = 118;
            this.TelefonoCasa.Text = "Teléfono";
            // 
            // txtCodigoPostal
            // 
            this.txtCodigoPostal.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPostal.Location = new System.Drawing.Point(294, 279);
            this.txtCodigoPostal.Name = "txtCodigoPostal";
            this.txtCodigoPostal.Size = new System.Drawing.Size(315, 22);
            this.txtCodigoPostal.TabIndex = 117;
            // 
            // CodigoPostal
            // 
            this.CodigoPostal.AutoSize = true;
            this.CodigoPostal.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodigoPostal.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CodigoPostal.Location = new System.Drawing.Point(289, 252);
            this.CodigoPostal.Name = "CodigoPostal";
            this.CodigoPostal.Size = new System.Drawing.Size(123, 21);
            this.CodigoPostal.TabIndex = 116;
            this.CodigoPostal.Text = "Código Postal";
            // 
            // boxEstado
            // 
            this.boxEstado.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxEstado.FormattingEnabled = true;
            this.boxEstado.Location = new System.Drawing.Point(2, 276);
            this.boxEstado.Name = "boxEstado";
            this.boxEstado.Size = new System.Drawing.Size(261, 25);
            this.boxEstado.TabIndex = 115;
            // 
            // EstadoRespuestaAyuda
            // 
            this.EstadoRespuestaAyuda.AutoSize = true;
            this.EstadoRespuestaAyuda.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EstadoRespuestaAyuda.ForeColor = System.Drawing.SystemColors.InfoText;
            this.EstadoRespuestaAyuda.Location = new System.Drawing.Point(2, 252);
            this.EstadoRespuestaAyuda.Name = "EstadoRespuestaAyuda";
            this.EstadoRespuestaAyuda.Size = new System.Drawing.Size(65, 21);
            this.EstadoRespuestaAyuda.TabIndex = 114;
            this.EstadoRespuestaAyuda.Text = "Estado";
            // 
            // txtCiudadRespuestaAyuda
            // 
            this.txtCiudadRespuestaAyuda.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudadRespuestaAyuda.Location = new System.Drawing.Point(649, 222);
            this.txtCiudadRespuestaAyuda.Name = "txtCiudadRespuestaAyuda";
            this.txtCiudadRespuestaAyuda.Size = new System.Drawing.Size(262, 22);
            this.txtCiudadRespuestaAyuda.TabIndex = 113;
            // 
            // CiudadRespuestaAyuda
            // 
            this.CiudadRespuestaAyuda.AutoSize = true;
            this.CiudadRespuestaAyuda.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiudadRespuestaAyuda.ForeColor = System.Drawing.SystemColors.InfoText;
            this.CiudadRespuestaAyuda.Location = new System.Drawing.Point(645, 198);
            this.CiudadRespuestaAyuda.Name = "CiudadRespuestaAyuda";
            this.CiudadRespuestaAyuda.Size = new System.Drawing.Size(67, 21);
            this.CiudadRespuestaAyuda.TabIndex = 112;
            this.CiudadRespuestaAyuda.Text = "Ciudad";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(352, 222);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(257, 22);
            this.txtColonia.TabIndex = 111;
            // 
            // Colonia
            // 
            this.Colonia.AutoSize = true;
            this.Colonia.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Colonia.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Colonia.Location = new System.Drawing.Point(348, 198);
            this.Colonia.Name = "Colonia";
            this.Colonia.Size = new System.Drawing.Size(72, 21);
            this.Colonia.TabIndex = 110;
            this.Colonia.Text = "Colonia";
            // 
            // txtNumeroInterior
            // 
            this.txtNumeroInterior.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroInterior.Location = new System.Drawing.Point(191, 222);
            this.txtNumeroInterior.Name = "txtNumeroInterior";
            this.txtNumeroInterior.Size = new System.Drawing.Size(140, 22);
            this.txtNumeroInterior.TabIndex = 109;
            // 
            // txtNumeroExterior
            // 
            this.txtNumeroExterior.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroExterior.Location = new System.Drawing.Point(3, 222);
            this.txtNumeroExterior.Name = "txtNumeroExterior";
            this.txtNumeroExterior.Size = new System.Drawing.Size(145, 22);
            this.txtNumeroExterior.TabIndex = 108;
            // 
            // NumeroExterior
            // 
            this.NumeroExterior.AutoSize = true;
            this.NumeroExterior.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroExterior.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NumeroExterior.Location = new System.Drawing.Point(2, 198);
            this.NumeroExterior.Name = "NumeroExterior";
            this.NumeroExterior.Size = new System.Drawing.Size(145, 21);
            this.NumeroExterior.TabIndex = 107;
            this.NumeroExterior.Text = "Número exterior";
            // 
            // NumeroInterior
            // 
            this.NumeroInterior.AutoSize = true;
            this.NumeroInterior.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroInterior.ForeColor = System.Drawing.SystemColors.InfoText;
            this.NumeroInterior.Location = new System.Drawing.Point(187, 198);
            this.NumeroInterior.Name = "NumeroInterior";
            this.NumeroInterior.Size = new System.Drawing.Size(143, 21);
            this.NumeroInterior.TabIndex = 106;
            this.NumeroInterior.Text = "Número interior";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(649, 155);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(262, 22);
            this.txtDireccion.TabIndex = 90;
            // 
            // txtRFC
            // 
            this.txtRFC.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFC.Location = new System.Drawing.Point(293, 155);
            this.txtRFC.Name = "txtRFC";
            this.txtRFC.Size = new System.Drawing.Size(316, 22);
            this.txtRFC.TabIndex = 89;
            // 
            // ApeidoMaterno
            // 
            this.ApeidoMaterno.AutoSize = true;
            this.ApeidoMaterno.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeidoMaterno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ApeidoMaterno.Location = new System.Drawing.Point(645, 75);
            this.ApeidoMaterno.Name = "ApeidoMaterno";
            this.ApeidoMaterno.Size = new System.Drawing.Size(148, 21);
            this.ApeidoMaterno.TabIndex = 88;
            this.ApeidoMaterno.Text = "Apellido Materno";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Nombre.Location = new System.Drawing.Point(2, 75);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(74, 21);
            this.Nombre.TabIndex = 87;
            this.Nombre.Text = "Nombre";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpresa.Location = new System.Drawing.Point(3, 155);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(262, 22);
            this.txtEmpresa.TabIndex = 86;
            // 
            // txtApeidoMaterno
            // 
            this.txtApeidoMaterno.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeidoMaterno.Location = new System.Drawing.Point(649, 99);
            this.txtApeidoMaterno.Name = "txtApeidoMaterno";
            this.txtApeidoMaterno.Size = new System.Drawing.Size(262, 22);
            this.txtApeidoMaterno.TabIndex = 83;
            // 
            // ApeidoPaterno
            // 
            this.ApeidoPaterno.AutoSize = true;
            this.ApeidoPaterno.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApeidoPaterno.ForeColor = System.Drawing.SystemColors.InfoText;
            this.ApeidoPaterno.Location = new System.Drawing.Point(289, 75);
            this.ApeidoPaterno.Name = "ApeidoPaterno";
            this.ApeidoPaterno.Size = new System.Drawing.Size(145, 21);
            this.ApeidoPaterno.TabIndex = 77;
            this.ApeidoPaterno.Text = "Apellido Paterno";
            // 
            // txtApeidoPaterno
            // 
            this.txtApeidoPaterno.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApeidoPaterno.Location = new System.Drawing.Point(293, 99);
            this.txtApeidoPaterno.Name = "txtApeidoPaterno";
            this.txtApeidoPaterno.Size = new System.Drawing.Size(316, 22);
            this.txtApeidoPaterno.TabIndex = 82;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(3, 99);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 22);
            this.txtNombre.TabIndex = 80;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(2, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 60;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(289, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 61;
            this.label2.Text = "RFC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(645, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Dirección";
            // 
            // CapturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 593);
            this.Controls.Add(this.DivicionInfo);
            this.Font = new System.Drawing.Font("Rockwell Extra Bold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CapturaForm";
            this.Text = "Captura";
            this.Load += new System.EventHandler(this.CapturaForm_Load);
            this.DivicionInfo.Panel1.ResumeLayout(false);
            this.DivicionInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DivicionInfo)).EndInit();
            this.DivicionInfo.ResumeLayout(false);
            this.info.ResumeLayout(false);
            this.Captura.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer DivicionInfo;
        private System.Windows.Forms.Panel info;
        private System.Windows.Forms.Panel Captura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApeidoPaterno;
        private System.Windows.Forms.Label ApeidoPaterno;
        private System.Windows.Forms.TextBox txtApeidoMaterno;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label ApeidoMaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRFC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNumeroInterior;
        private System.Windows.Forms.TextBox txtNumeroExterior;
        private System.Windows.Forms.Label NumeroExterior;
        private System.Windows.Forms.Label NumeroInterior;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label Colonia;
        private System.Windows.Forms.TextBox txtCiudadRespuestaAyuda;
        private System.Windows.Forms.Label CiudadRespuestaAyuda;
        private System.Windows.Forms.ComboBox boxEstado;
        private System.Windows.Forms.Label EstadoRespuestaAyuda;
        private System.Windows.Forms.TextBox txtCodigoPostal;
        private System.Windows.Forms.Label CodigoPostal;
        private System.Windows.Forms.TextBox txtTelefonoCasa;
        private System.Windows.Forms.Label TelefonoCasa;
        private System.Windows.Forms.TextBox txtCorreoPrincipal;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label CorreoPrincipal;
        private System.Windows.Forms.Label Celular;
        private System.Windows.Forms.ComboBox boxInformacionSolicitada;
        private System.Windows.Forms.TextBox txtCorreoAdicional;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox boxPersonalAtendio;
        private System.Windows.Forms.Label CiudadInteres;
        private System.Windows.Forms.Label PersonalAtendido;
        private System.Windows.Forms.ComboBox boxDondellegoMensaje;
        private System.Windows.Forms.ComboBox boxMontoInversion;
        private System.Windows.Forms.Label ComoLlegoMensaje;
        private System.Windows.Forms.Label MontoInvercion;
        private System.Windows.Forms.ComboBox boxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.TextBox txtCiudadInteres;
        public System.Windows.Forms.TextBox txtId;
    }
}

