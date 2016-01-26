namespace CapaPresentacion
{
    partial class frmProveedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorIconoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListadoGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.EliminarcheckBox = new System.Windows.Forms.CheckBox();
            this.imprimirBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.buscarBoton = new System.Windows.Forms.Button();
            this.BuscarnombreTexto = new System.Windows.Forms.TextBox();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.RazonSocialtextBox = new System.Windows.Forms.TextBox();
            this.IdProveedortextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UrltextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TelefonotextBox = new System.Windows.Forms.TextBox();
            this.NumeroDocumentotextBox = new System.Windows.Forms.TextBox();
            this.TipoDocumentocomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SectorComercialcomboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DirecciontextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.TtMensajetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentocomboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIconoerrorProvider)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorIconoerrorProvider
            // 
            this.ErrorIconoerrorProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(118, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DocumentocomboBox1);
            this.tabPage1.Controls.Add(this.dataListadoGridView1);
            this.tabPage1.Controls.Add(this.TotalLabel);
            this.tabPage1.Controls.Add(this.EliminarcheckBox);
            this.tabPage1.Controls.Add(this.imprimirBoton);
            this.tabPage1.Controls.Add(this.EliminarBoton);
            this.tabPage1.Controls.Add(this.buscarBoton);
            this.tabPage1.Controls.Add(this.BuscarnombreTexto);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1279, 558);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataListadoGridView1
            // 
            this.dataListadoGridView1.AllowUserToAddRows = false;
            this.dataListadoGridView1.AllowUserToDeleteRows = false;
            this.dataListadoGridView1.AllowUserToOrderColumns = true;
            this.dataListadoGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListadoGridView1.Location = new System.Drawing.Point(31, 158);
            this.dataListadoGridView1.MultiSelect = false;
            this.dataListadoGridView1.Name = "dataListadoGridView1";
            this.dataListadoGridView1.ReadOnly = true;
            this.dataListadoGridView1.RowTemplate.Height = 24;
            this.dataListadoGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListadoGridView1.Size = new System.Drawing.Size(1213, 368);
            this.dataListadoGridView1.TabIndex = 7;
            this.dataListadoGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListadoGridView1_CellContentClick);
            this.dataListadoGridView1.DoubleClick += new System.EventHandler(this.dataListadoGridView1_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(1076, 135);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(57, 20);
            this.TotalLabel.TabIndex = 6;
            this.TotalLabel.Text = "Total:";
            // 
            // EliminarcheckBox
            // 
            this.EliminarcheckBox.AutoSize = true;
            this.EliminarcheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarcheckBox.Location = new System.Drawing.Point(31, 118);
            this.EliminarcheckBox.Name = "EliminarcheckBox";
            this.EliminarcheckBox.Size = new System.Drawing.Size(100, 24);
            this.EliminarcheckBox.TabIndex = 5;
            this.EliminarcheckBox.Text = "Eliminar";
            this.EliminarcheckBox.UseVisualStyleBackColor = true;
            this.EliminarcheckBox.CheckedChanged += new System.EventHandler(this.EliminarcheckBox_CheckedChanged);
            // 
            // imprimirBoton
            // 
            this.imprimirBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirBoton.Image = ((System.Drawing.Image)(resources.GetObject("imprimirBoton.Image")));
            this.imprimirBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.imprimirBoton.Location = new System.Drawing.Point(1080, 36);
            this.imprimirBoton.Name = "imprimirBoton";
            this.imprimirBoton.Size = new System.Drawing.Size(164, 55);
            this.imprimirBoton.TabIndex = 4;
            this.imprimirBoton.Text = "Imprimir";
            this.imprimirBoton.UseVisualStyleBackColor = true;
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBoton.Image")));
            this.EliminarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBoton.Location = new System.Drawing.Point(900, 36);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(164, 55);
            this.EliminarBoton.TabIndex = 3;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // buscarBoton
            // 
            this.buscarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscarBoton.Image = ((System.Drawing.Image)(resources.GetObject("buscarBoton.Image")));
            this.buscarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buscarBoton.Location = new System.Drawing.Point(720, 36);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(164, 55);
            this.buscarBoton.TabIndex = 2;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // BuscarnombreTexto
            // 
            this.BuscarnombreTexto.Location = new System.Drawing.Point(296, 51);
            this.BuscarnombreTexto.Name = "BuscarnombreTexto";
            this.BuscarnombreTexto.Size = new System.Drawing.Size(374, 22);
            this.BuscarnombreTexto.TabIndex = 1;
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.Image")));
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(929, 435);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(187, 44);
            this.Cancelarbutton.TabIndex = 9;
            this.Cancelarbutton.Text = "&Cancelar";
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // Editarbutton
            // 
            this.Editarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Editarbutton.Image")));
            this.Editarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Editarbutton.Location = new System.Drawing.Point(660, 435);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(187, 44);
            this.Editarbutton.TabIndex = 8;
            this.Editarbutton.Text = "E&ditar";
            this.Editarbutton.UseVisualStyleBackColor = true;
            this.Editarbutton.Click += new System.EventHandler(this.Editarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Guardarbutton.Location = new System.Drawing.Point(391, 435);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(187, 44);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "&Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nuevobutton.Location = new System.Drawing.Point(122, 435);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(187, 44);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "&Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // RazonSocialtextBox
            // 
            this.RazonSocialtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.RazonSocialtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RazonSocialtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RazonSocialtextBox.ForeColor = System.Drawing.Color.Black;
            this.RazonSocialtextBox.Location = new System.Drawing.Point(291, 101);
            this.RazonSocialtextBox.Name = "RazonSocialtextBox";
            this.RazonSocialtextBox.Size = new System.Drawing.Size(436, 27);
            this.RazonSocialtextBox.TabIndex = 4;
            // 
            // IdProveedortextBox
            // 
            this.IdProveedortextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IdProveedortextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdProveedortextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdProveedortextBox.ForeColor = System.Drawing.Color.Black;
            this.IdProveedortextBox.Location = new System.Drawing.Point(291, 43);
            this.IdProveedortextBox.Name = "IdProveedortextBox";
            this.IdProveedortextBox.Size = new System.Drawing.Size(247, 27);
            this.IdProveedortextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(112, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(124, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Razon Social:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UrltextBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.EmailtextBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TelefonotextBox);
            this.groupBox1.Controls.Add(this.NumeroDocumentotextBox);
            this.groupBox1.Controls.Add(this.TipoDocumentocomboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.SectorComercialcomboBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.DirecciontextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cancelarbutton);
            this.groupBox1.Controls.Add(this.Editarbutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.RazonSocialtextBox);
            this.groupBox1.Controls.Add(this.IdProveedortextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1232, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedores";
            // 
            // UrltextBox
            // 
            this.UrltextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.UrltextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UrltextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UrltextBox.ForeColor = System.Drawing.Color.Black;
            this.UrltextBox.Location = new System.Drawing.Point(291, 379);
            this.UrltextBox.Name = "UrltextBox";
            this.UrltextBox.Size = new System.Drawing.Size(387, 27);
            this.UrltextBox.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(118, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Url:";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.EmailtextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailtextBox.ForeColor = System.Drawing.Color.Black;
            this.EmailtextBox.Location = new System.Drawing.Point(667, 313);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(353, 27);
            this.EmailtextBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(561, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Email:";
            // 
            // TelefonotextBox
            // 
            this.TelefonotextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TelefonotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TelefonotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefonotextBox.ForeColor = System.Drawing.Color.Black;
            this.TelefonotextBox.Location = new System.Drawing.Point(285, 320);
            this.TelefonotextBox.Name = "TelefonotextBox";
            this.TelefonotextBox.Size = new System.Drawing.Size(247, 27);
            this.TelefonotextBox.TabIndex = 17;
            // 
            // NumeroDocumentotextBox
            // 
            this.NumeroDocumentotextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NumeroDocumentotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroDocumentotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroDocumentotextBox.ForeColor = System.Drawing.Color.Black;
            this.NumeroDocumentotextBox.Location = new System.Drawing.Point(795, 152);
            this.NumeroDocumentotextBox.Name = "NumeroDocumentotextBox";
            this.NumeroDocumentotextBox.Size = new System.Drawing.Size(339, 27);
            this.NumeroDocumentotextBox.TabIndex = 16;
            // 
            // TipoDocumentocomboBox
            // 
            this.TipoDocumentocomboBox.FormattingEnabled = true;
            this.TipoDocumentocomboBox.Items.AddRange(new object[] {
            "DNI",
            "RUC",
            "CEDULA",
            "NIE"});
            this.TipoDocumentocomboBox.Location = new System.Drawing.Point(291, 152);
            this.TipoDocumentocomboBox.Name = "TipoDocumentocomboBox";
            this.TipoDocumentocomboBox.Size = new System.Drawing.Size(222, 28);
            this.TipoDocumentocomboBox.TabIndex = 15;
            this.TipoDocumentocomboBox.Text = "NIE";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(124, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo Documento:";
            // 
            // SectorComercialcomboBox
            // 
            this.SectorComercialcomboBox.FormattingEnabled = true;
            this.SectorComercialcomboBox.Items.AddRange(new object[] {
            "Salud",
            "Alimento",
            "Tecnología",
            "Ropa",
            "Servicios"});
            this.SectorComercialcomboBox.Location = new System.Drawing.Point(942, 98);
            this.SectorComercialcomboBox.Name = "SectorComercialcomboBox";
            this.SectorComercialcomboBox.Size = new System.Drawing.Size(192, 28);
            this.SectorComercialcomboBox.TabIndex = 13;
            this.SectorComercialcomboBox.Text = "Alimentos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(118, 207);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Dirección:";
            // 
            // DirecciontextBox
            // 
            this.DirecciontextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DirecciontextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DirecciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DirecciontextBox.ForeColor = System.Drawing.Color.Black;
            this.DirecciontextBox.Location = new System.Drawing.Point(291, 200);
            this.DirecciontextBox.Multiline = true;
            this.DirecciontextBox.Name = "DirecciontextBox";
            this.DirecciontextBox.Size = new System.Drawing.Size(479, 94);
            this.DirecciontextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sector Comercial:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1279, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(32, 103);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1287, 587);
            this.tabControl1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(26, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proveedores:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // DocumentocomboBox1
            // 
            this.DocumentocomboBox1.FormattingEnabled = true;
            this.DocumentocomboBox1.Items.AddRange(new object[] {
            "Documento",
            "Razon Social"});
            this.DocumentocomboBox1.Location = new System.Drawing.Point(31, 51);
            this.DocumentocomboBox1.Name = "DocumentocomboBox1";
            this.DocumentocomboBox1.Size = new System.Drawing.Size(220, 24);
            this.DocumentocomboBox1.TabIndex = 9;
            this.DocumentocomboBox1.Text = "Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(534, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Número de Documento:";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1344, 710);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmProveedor";
            this.Text = ".:.Mantenimiento de proveedores.:.";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIconoerrorProvider)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip TtMensajetoolTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IdProveedortextBox;
        private System.Windows.Forms.TextBox RazonSocialtextBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox BuscarnombreTexto;
        private System.Windows.Forms.Button buscarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button imprimirBoton;
        private System.Windows.Forms.CheckBox EliminarcheckBox;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView dataListadoGridView1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ErrorProvider ErrorIconoerrorProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox SectorComercialcomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DirecciontextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TipoDocumentocomboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumeroDocumentotextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox UrltextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox DocumentocomboBox1;
        private System.Windows.Forms.Label label3;
    }
}