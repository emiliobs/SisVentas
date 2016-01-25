namespace CapaPresentacion
{
    partial class frmArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulo));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataListadoGridView1 = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.EliminarcheckBox = new System.Windows.Forms.CheckBox();
            this.imprimirBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.buscarBoton = new System.Windows.Forms.Button();
            this.BuscarnombreTexto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.PresentacioncomboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BuscarCategoriabutton = new System.Windows.Forms.Button();
            this.NombreCAtegoriatextBox = new System.Windows.Forms.TextBox();
            this.IdCategoriatextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.limpiarImagenbutton = new System.Windows.Forms.Button();
            this.CargarImagrnbutton = new System.Windows.Forms.Button();
            this.ImagenpictureBox = new System.Windows.Forms.PictureBox();
            this.codigoVentastextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.IdArticulotextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TtMensajetoolTip = new System.Windows.Forms.ToolTip(this.components);
            this.ErrorIconoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIconoerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(51, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1240, 587);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataListadoGridView1);
            this.tabPage1.Controls.Add(this.TotalLabel);
            this.tabPage1.Controls.Add(this.EliminarcheckBox);
            this.tabPage1.Controls.Add(this.imprimirBoton);
            this.tabPage1.Controls.Add(this.EliminarBoton);
            this.tabPage1.Controls.Add(this.buscarBoton);
            this.tabPage1.Controls.Add(this.BuscarnombreTexto);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1232, 558);
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
            this.dataListadoGridView1.Size = new System.Drawing.Size(1011, 368);
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
            this.TotalLabel.Location = new System.Drawing.Point(701, 122);
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
            this.imprimirBoton.Location = new System.Drawing.Point(876, 41);
            this.imprimirBoton.Name = "imprimirBoton";
            this.imprimirBoton.Size = new System.Drawing.Size(162, 51);
            this.imprimirBoton.TabIndex = 4;
            this.imprimirBoton.Text = "Imprimir";
            this.imprimirBoton.UseVisualStyleBackColor = true;
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBoton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarBoton.Image")));
            this.EliminarBoton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarBoton.Location = new System.Drawing.Point(696, 41);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(162, 51);
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
            this.buscarBoton.Location = new System.Drawing.Point(516, 41);
            this.buscarBoton.Name = "buscarBoton";
            this.buscarBoton.Size = new System.Drawing.Size(162, 51);
            this.buscarBoton.TabIndex = 2;
            this.buscarBoton.Text = "Buscar";
            this.buscarBoton.UseVisualStyleBackColor = true;
            this.buscarBoton.Click += new System.EventHandler(this.buscarBoton_Click);
            // 
            // BuscarnombreTexto
            // 
            this.BuscarnombreTexto.Location = new System.Drawing.Point(108, 53);
            this.BuscarnombreTexto.Name = "BuscarnombreTexto";
            this.BuscarnombreTexto.Size = new System.Drawing.Size(354, 22);
            this.BuscarnombreTexto.TabIndex = 1;
            this.BuscarnombreTexto.TextChanged += new System.EventHandler(this.BuscarnombreTexto_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1232, 558);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.PresentacioncomboBox);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BuscarCategoriabutton);
            this.groupBox1.Controls.Add(this.NombreCAtegoriatextBox);
            this.groupBox1.Controls.Add(this.IdCategoriatextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.limpiarImagenbutton);
            this.groupBox1.Controls.Add(this.CargarImagrnbutton);
            this.groupBox1.Controls.Add(this.ImagenpictureBox);
            this.groupBox1.Controls.Add(this.codigoVentastextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Cancelarbutton);
            this.groupBox1.Controls.Add(this.Editarbutton);
            this.groupBox1.Controls.Add(this.Guardarbutton);
            this.groupBox1.Controls.Add(this.Nuevobutton);
            this.groupBox1.Controls.Add(this.DescripciontextBox);
            this.groupBox1.Controls.Add(this.NombretextBox);
            this.groupBox1.Controls.Add(this.IdArticulotextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 520);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulos";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(694, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Imagen:";
            // 
            // PresentacioncomboBox
            // 
            this.PresentacioncomboBox.FormattingEnabled = true;
            this.PresentacioncomboBox.Location = new System.Drawing.Point(831, 137);
            this.PresentacioncomboBox.Name = "PresentacioncomboBox";
            this.PresentacioncomboBox.Size = new System.Drawing.Size(247, 28);
            this.PresentacioncomboBox.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(689, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Presentación:";
            // 
            // BuscarCategoriabutton
            // 
            this.BuscarCategoriabutton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarCategoriabutton.Image")));
            this.BuscarCategoriabutton.Location = new System.Drawing.Point(1103, 77);
            this.BuscarCategoriabutton.Name = "BuscarCategoriabutton";
            this.BuscarCategoriabutton.Size = new System.Drawing.Size(58, 46);
            this.BuscarCategoriabutton.TabIndex = 18;
            this.BuscarCategoriabutton.UseVisualStyleBackColor = true;
            this.BuscarCategoriabutton.Click += new System.EventHandler(this.BuscarCategoriabutton_Click);
            // 
            // NombreCAtegoriatextBox
            // 
            this.NombreCAtegoriatextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NombreCAtegoriatextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreCAtegoriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreCAtegoriatextBox.ForeColor = System.Drawing.Color.Black;
            this.NombreCAtegoriatextBox.Location = new System.Drawing.Point(831, 88);
            this.NombreCAtegoriatextBox.Name = "NombreCAtegoriatextBox";
            this.NombreCAtegoriatextBox.Size = new System.Drawing.Size(247, 27);
            this.NombreCAtegoriatextBox.TabIndex = 17;
            // 
            // IdCategoriatextBox
            // 
            this.IdCategoriatextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IdCategoriatextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdCategoriatextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdCategoriatextBox.ForeColor = System.Drawing.Color.Black;
            this.IdCategoriatextBox.Location = new System.Drawing.Point(831, 41);
            this.IdCategoriatextBox.Name = "IdCategoriatextBox";
            this.IdCategoriatextBox.Size = new System.Drawing.Size(108, 27);
            this.IdCategoriatextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(691, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Categoría:";
            // 
            // limpiarImagenbutton
            // 
            this.limpiarImagenbutton.Image = ((System.Drawing.Image)(resources.GetObject("limpiarImagenbutton.Image")));
            this.limpiarImagenbutton.Location = new System.Drawing.Point(1022, 340);
            this.limpiarImagenbutton.Name = "limpiarImagenbutton";
            this.limpiarImagenbutton.Size = new System.Drawing.Size(102, 71);
            this.limpiarImagenbutton.TabIndex = 14;
            this.limpiarImagenbutton.UseVisualStyleBackColor = true;
            this.limpiarImagenbutton.Click += new System.EventHandler(this.limpiarImagenbutton_Click);
            // 
            // CargarImagrnbutton
            // 
            this.CargarImagrnbutton.Image = ((System.Drawing.Image)(resources.GetObject("CargarImagrnbutton.Image")));
            this.CargarImagrnbutton.Location = new System.Drawing.Point(1022, 208);
            this.CargarImagrnbutton.Name = "CargarImagrnbutton";
            this.CargarImagrnbutton.Size = new System.Drawing.Size(102, 71);
            this.CargarImagrnbutton.TabIndex = 13;
            this.CargarImagrnbutton.UseVisualStyleBackColor = true;
            this.CargarImagrnbutton.Click += new System.EventHandler(this.CargarImagrnbutton_Click);
            // 
            // ImagenpictureBox
            // 
            this.ImagenpictureBox.BackgroundImage = global::CapaPresentacion.Properties.Resources.fondoBlanco;
            this.ImagenpictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ImagenpictureBox.Location = new System.Drawing.Point(703, 208);
            this.ImagenpictureBox.Name = "ImagenpictureBox";
            this.ImagenpictureBox.Size = new System.Drawing.Size(262, 203);
            this.ImagenpictureBox.TabIndex = 12;
            this.ImagenpictureBox.TabStop = false;
            // 
            // codigoVentastextBox
            // 
            this.codigoVentastextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.codigoVentastextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codigoVentastextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoVentastextBox.ForeColor = System.Drawing.Color.Black;
            this.codigoVentastextBox.Location = new System.Drawing.Point(229, 133);
            this.codigoVentastextBox.Name = "codigoVentastextBox";
            this.codigoVentastextBox.Size = new System.Drawing.Size(436, 27);
            this.codigoVentastextBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Código De Ventas:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Cancelarbutton.Image")));
            this.Cancelarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancelarbutton.Location = new System.Drawing.Point(872, 457);
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
            this.Editarbutton.Location = new System.Drawing.Point(633, 457);
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
            this.Guardarbutton.Location = new System.Drawing.Point(394, 457);
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
            this.Nuevobutton.Location = new System.Drawing.Point(155, 457);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(187, 44);
            this.Nuevobutton.TabIndex = 6;
            this.Nuevobutton.Text = "&Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DescripciontextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescripciontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescripciontextBox.ForeColor = System.Drawing.Color.Black;
            this.DescripciontextBox.Location = new System.Drawing.Point(229, 274);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescripciontextBox.Size = new System.Drawing.Size(436, 137);
            this.DescripciontextBox.TabIndex = 5;
            // 
            // NombretextBox
            // 
            this.NombretextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NombretextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombretextBox.ForeColor = System.Drawing.Color.Black;
            this.NombretextBox.Location = new System.Drawing.Point(229, 197);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(436, 27);
            this.NombretextBox.TabIndex = 4;
            // 
            // IdArticulotextBox
            // 
            this.IdArticulotextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.IdArticulotextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdArticulotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdArticulotextBox.ForeColor = System.Drawing.Color.Black;
            this.IdArticulotextBox.Location = new System.Drawing.Point(229, 61);
            this.IdArticulotextBox.Name = "IdArticulotextBox";
            this.IdArticulotextBox.Size = new System.Drawing.Size(247, 27);
            this.IdArticulotextBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(45, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Articulos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // ErrorIconoerrorProvider
            // 
            this.ErrorIconoerrorProvider.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1303, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmArticulo";
            this.Text = ".:.Mantenimiento de Artículos.:.";
            this.Load += new System.EventHandler(this.frmArticulo_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIconoerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataListadoGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.CheckBox EliminarcheckBox;
        private System.Windows.Forms.Button imprimirBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button buscarBoton;
        private System.Windows.Forms.TextBox BuscarnombreTexto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox codigoVentastextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox IdArticulotextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip TtMensajetoolTip;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider ErrorIconoerrorProvider;
        private System.Windows.Forms.Button limpiarImagenbutton;
        private System.Windows.Forms.Button CargarImagrnbutton;
        private System.Windows.Forms.PictureBox ImagenpictureBox;
        private System.Windows.Forms.TextBox IdCategoriatextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NombreCAtegoriatextBox;
        private System.Windows.Forms.Button BuscarCategoriabutton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox PresentacioncomboBox;
        private System.Windows.Forms.Label label10;
    }
}