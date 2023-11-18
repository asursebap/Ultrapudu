namespace UltrapudúAvistamientos
{
    partial class FormularioAvistamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAvistamientos));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEspecie = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.btnRegistrarAvistamiento = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSubirImagen = new System.Windows.Forms.Button();
            this.labelRuta = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cellID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellEspecie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellUbicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cellRuta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ubicación";
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Location = new System.Drawing.Point(192, 261);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFecha.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtEspecie
            // 
            this.txtEspecie.Location = new System.Drawing.Point(192, 185);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(200, 20);
            this.txtEspecie.TabIndex = 5;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(192, 230);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(200, 20);
            this.txtUbicacion.TabIndex = 6;
            // 
            // btnRegistrarAvistamiento
            // 
            this.btnRegistrarAvistamiento.Location = new System.Drawing.Point(58, 486);
            this.btnRegistrarAvistamiento.Name = "btnRegistrarAvistamiento";
            this.btnRegistrarAvistamiento.Size = new System.Drawing.Size(348, 23);
            this.btnRegistrarAvistamiento.TabIndex = 7;
            this.btnRegistrarAvistamiento.Text = "Registrar avistamiento";
            this.btnRegistrarAvistamiento.UseVisualStyleBackColor = true;
            this.btnRegistrarAvistamiento.Click += new System.EventHandler(this.btnRegistrarAvistamiento_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cellID,
            this.cellEspecie,
            this.cellUbicacion,
            this.cellFecha,
            this.cellRuta});
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 275);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnSubirImagen
            // 
            this.btnSubirImagen.Location = new System.Drawing.Point(16, 34);
            this.btnSubirImagen.Name = "btnSubirImagen";
            this.btnSubirImagen.Size = new System.Drawing.Size(318, 23);
            this.btnSubirImagen.TabIndex = 9;
            this.btnSubirImagen.Text = "Subir Imagen";
            this.btnSubirImagen.UseVisualStyleBackColor = true;
            this.btnSubirImagen.Click += new System.EventHandler(this.btnSubirImagen_Click);
            // 
            // labelRuta
            // 
            this.labelRuta.AutoSize = true;
            this.labelRuta.Location = new System.Drawing.Point(13, 73);
            this.labelRuta.Name = "labelRuta";
            this.labelRuta.Size = new System.Drawing.Size(10, 13);
            this.labelRuta.TabIndex = 10;
            this.labelRuta.Text = " ";
            this.labelRuta.Click += new System.EventHandler(this.labelRuta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(58, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 150);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Avistamiento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRuta);
            this.groupBox2.Controls.Add(this.btnSubirImagen);
            this.groupBox2.Location = new System.Drawing.Point(58, 333);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 127);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar imagen (Opcional)";
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(58, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(101, 121);
            this.logo.TabIndex = 15;
            this.logo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(457, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Registro avistamiento de fauna";
            this.label4.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "ONG ULTRAPUDÚ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEliminar);
            this.groupBox3.Controls.Add(this.btnEditar);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(534, 163);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(659, 357);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Historial";
            // 
            // cellID
            // 
            this.cellID.HeaderText = "ID Avistamiento";
            this.cellID.Name = "cellID";
            this.cellID.ReadOnly = true;
            // 
            // cellEspecie
            // 
            this.cellEspecie.HeaderText = "Especie";
            this.cellEspecie.Name = "cellEspecie";
            this.cellEspecie.ReadOnly = true;
            // 
            // cellUbicacion
            // 
            this.cellUbicacion.HeaderText = "Ubicación";
            this.cellUbicacion.Name = "cellUbicacion";
            this.cellUbicacion.ReadOnly = true;
            // 
            // cellFecha
            // 
            this.cellFecha.HeaderText = "Fecha";
            this.cellFecha.Name = "cellFecha";
            this.cellFecha.ReadOnly = true;
            // 
            // cellRuta
            // 
            this.cellRuta.HeaderText = "Ruta de imagen";
            this.cellRuta.Name = "cellRuta";
            this.cellRuta.ReadOnly = true;
            this.cellRuta.Width = 200;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(7, 323);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(186, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar registro";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(199, 323);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 23);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar registro";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormularioAvistamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 609);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnRegistrarAvistamiento);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormularioAvistamientos";
            this.Text = "FormularioAvistamientos";
            this.Load += new System.EventHandler(this.FormularioAvistamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEspecie;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Button btnRegistrarAvistamiento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSubirImagen;
        private System.Windows.Forms.Label labelRuta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellEspecie;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellUbicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cellRuta;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

