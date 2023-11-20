using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace UltrapudúAvistamientos
{
    internal class FormEdicion : Form
    {
        private Label label1;
        private Label label2;
        private TextBox txtEspecieEdit;
        private TextBox txtUbicacionEdit;
        private Label label3;
        private DateTimePicker dateTimePickerFechaEdit;
        private Button btnGuardarEdicion;
        private Button btnCancelarEdicion;
        private Label labelRutaEdit;
        private Button btnResubir;
        private OpenFileDialog openFileDialog2;
        private DataGridViewRow _selectedRow;
        private string ruta;
        private DataGridViewRow selectedRow;

        public FormEdicion(DataGridViewRow selectedRow, string rutaImagen)
        {
            InitializeComponent();
            _selectedRow = selectedRow;
        }

        public FormEdicion(string ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            
        }

        public FormEdicion(DataGridViewRow selectedRow)
        {
            this.selectedRow = selectedRow;

        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEspecieEdit = new System.Windows.Forms.TextBox();
            this.txtUbicacionEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEdit = new System.Windows.Forms.DateTimePicker();
            this.btnGuardarEdicion = new System.Windows.Forms.Button();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            this.labelRutaEdit = new System.Windows.Forms.Label();
            this.btnResubir = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar especie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Editar Ubicación";
            // 
            // txtEspecieEdit
            // 
            this.txtEspecieEdit.Location = new System.Drawing.Point(153, 41);
            this.txtEspecieEdit.Name = "txtEspecieEdit";
            this.txtEspecieEdit.Size = new System.Drawing.Size(200, 20);
            this.txtEspecieEdit.TabIndex = 2;
            // 
            // txtUbicacionEdit
            // 
            this.txtUbicacionEdit.Location = new System.Drawing.Point(153, 83);
            this.txtUbicacionEdit.Name = "txtUbicacionEdit";
            this.txtUbicacionEdit.Size = new System.Drawing.Size(200, 20);
            this.txtUbicacionEdit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Editar fecha";
            // 
            // dateTimePickerFechaEdit
            // 
            this.dateTimePickerFechaEdit.Location = new System.Drawing.Point(153, 138);
            this.dateTimePickerFechaEdit.Name = "dateTimePickerFechaEdit";
            this.dateTimePickerFechaEdit.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaEdit.TabIndex = 5;
            // 
            // btnGuardarEdicion
            // 
            this.btnGuardarEdicion.Location = new System.Drawing.Point(48, 288);
            this.btnGuardarEdicion.Name = "btnGuardarEdicion";
            this.btnGuardarEdicion.Size = new System.Drawing.Size(200, 23);
            this.btnGuardarEdicion.TabIndex = 6;
            this.btnGuardarEdicion.Text = "Guardar edición";
            this.btnGuardarEdicion.UseVisualStyleBackColor = true;
            this.btnGuardarEdicion.Click += new System.EventHandler(this.btnGuardarEdicion_Click);
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelarEdicion.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(278, 288);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEdicion.TabIndex = 7;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            // 
            // labelRutaEdit
            // 
            this.labelRutaEdit.AutoSize = true;
            this.labelRutaEdit.Location = new System.Drawing.Point(150, 233);
            this.labelRutaEdit.Name = "labelRutaEdit";
            this.labelRutaEdit.Size = new System.Drawing.Size(30, 13);
            this.labelRutaEdit.TabIndex = 8;
            this.labelRutaEdit.Text = "Ruta";
            // 
            // btnResubir
            // 
            this.btnResubir.Location = new System.Drawing.Point(153, 185);
            this.btnResubir.Name = "btnResubir";
            this.btnResubir.Size = new System.Drawing.Size(200, 23);
            this.btnResubir.TabIndex = 9;
            this.btnResubir.Text = "Sobreescribir imagen";
            this.btnResubir.UseVisualStyleBackColor = true;
            this.btnResubir.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // FormEdicion
            // 
            this.ClientSize = new System.Drawing.Size(409, 359);
            this.Controls.Add(this.btnResubir);
            this.Controls.Add(this.labelRutaEdit);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.btnGuardarEdicion);
            this.Controls.Add(this.dateTimePickerFechaEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUbicacionEdit);
            this.Controls.Add(this.txtEspecieEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEdicion";
            this.Load += new System.EventHandler(this.FormEdicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FormEdicion_Load(object sender, EventArgs e)
        {
            if (_selectedRow != null)
            {
                if (_selectedRow.Cells["cellEspecie"].Value != null)
                {
                    txtEspecieEdit.Text = _selectedRow.Cells["cellEspecie"].Value.ToString();
                }

                if (_selectedRow.Cells["cellUbicacion"].Value != null)
                {
                    txtUbicacionEdit.Text = _selectedRow.Cells["cellUbicacion"].Value.ToString();
                }

                if (_selectedRow.Cells["cellFecha"].Value != null &&
                    DateTime.TryParse(_selectedRow.Cells["cellFecha"].Value.ToString(), out DateTime fecha))
                {
                    dateTimePickerFechaEdit.Value = fecha;
                }
            }
        }

        private void btnGuardarEdicion_Click(object sender, EventArgs e)
        {
            try
            {
                // Nuevos valores del formulario de edición
                string nuevaEspecie = txtEspecieEdit.Text;
                string nuevaUbicacion = txtUbicacionEdit.Text;
                string nuevaFecha = dateTimePickerFechaEdit.Text;
                string nuevaRutaImagen = labelRutaEdit.Text;


                // Obtener el ID de la fila 
                int id = Convert.ToInt32(_selectedRow.Cells["ID"].Value);

                 // Actualizar el registro.txt y la ruta de la imagen si se carga una nueva imagen
                 ActualizarRegistro(id, nuevaEspecie, nuevaUbicacion, nuevaFecha, nuevaRutaImagen);

                // Actualizar el DataGridView en el formulario principal
                if (Owner is FormularioAvistamientos formularioPrincipal)
                {
                    formularioPrincipal.CargarDatos();
                }

                // Cerrar el formulario de edición
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la edición: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarRegistro(int id, string nuevaEspecie, string nuevaUbicacion, string nuevaFecha, string nuevaRutaImagen)
        {
            try
            {
                string registroFilePath = "registro.txt";
                List<string> lineas = File.ReadAllLines(registroFilePath).ToList();

                // Buscar la línea a editar
                string lineaAEditar = lineas.FirstOrDefault(linea => linea.StartsWith($"{id}-"));

                // Si se encuentra la línea, editarla y escribir de nuevo el archivo
                if (lineaAEditar != null)
                {
                    // Construir la nueva línea con la ruta de la imagen
                    string nuevaLinea;
                    if (!string.IsNullOrEmpty(nuevaRutaImagen))
                    {
                        nuevaLinea = $"{id}-{nuevaEspecie}-{nuevaUbicacion}-{nuevaFecha}-{nuevaRutaImagen}";
                    }
                    else
                    {
                        // Si no hay ruta de imagen, omitirla
                        nuevaLinea = $"{id}-{nuevaEspecie}-{nuevaUbicacion}-{nuevaFecha}";
                    }

                    // Reemplazar la línea antigua con la nueva
                    int indice = lineas.IndexOf(lineaAEditar);
                    lineas[indice] = nuevaLinea;

                    // Escribir de nuevo el archivo
                    File.WriteAllLines(registroFilePath, lineas);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el registro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                labelRutaEdit.Text = openFileDialog2.FileName;
                
            }
        }
    }
}