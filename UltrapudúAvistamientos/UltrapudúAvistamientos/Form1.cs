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

namespace UltrapudúAvistamientos
{
    public partial class FormularioAvistamientos : Form
    {
        public FormularioAvistamientos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private int idContador = 0001;

        private void FormularioAvistamientos_Load(object sender, EventArgs e)
        {
            try 
            { 
                //Crea el archivo si no existe
                if (!File.Exists("registro.txt"))
                {
                    using (StreamWriter archivo = new StreamWriter("registro.txt")) { }
                }
                //Si existe carga los datos
                else
                {
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            DataGridViewButtonColumn editarButton = new DataGridViewButtonColumn();
            editarButton.Name = "Editar";
            editarButton.Text = "Editar";
            editarButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(editarButton);

            DataGridViewButtonColumn eliminarButton = new DataGridViewButtonColumn();
            eliminarButton.Name = "Eliminar";
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(eliminarButton);
        }

        public void CargarDatos()
        {
            try
            {
                // Limpia las filas existentes 
                dataGridView1.Rows.Clear();

                int identificadorMaximo = 0;

                if (File.Exists("registro.txt"))
                {
                    using (StreamReader archivo = new StreamReader("registro.txt"))
                    {
                        while (!archivo.EndOfStream)
                        {
                            string linea = archivo.ReadLine();
                            string[] datos = linea.Split('-');

                            // Valida al menos 4 atributos en la linea
                            if (datos.Length >= 4)
                            {
                                // Agrega los datos al DataGridView
                                dataGridView1.Rows.Add(datos);

                                // Actualiza el identificador máximo
                                if (int.TryParse(datos[0], out int identificador))
                                {
                                    identificadorMaximo = Math.Max(identificadorMaximo, identificador);
                                }
                            }
                        }
                    }
                }

                // Retoma los identificadores
                idContador = identificadorMaximo + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarAvistamiento_Click(object sender, EventArgs e)
        {
            try
            {
                // Realizar validación de campos
                if (!ValidarCampos())
                {
                    return;
                }

                // Obtener la ruta de la imagen 
                string rutaImagen = labelRuta.Text;

                // Verificar si la ruta de la imagen es válida
                if (!string.IsNullOrEmpty(rutaImagen) && File.Exists(rutaImagen))
                {
                    // Copiar la imagen a la carpeta Imagenes
                    string carpetaImagenes = Path.Combine(Application.StartupPath, "Imagenes");
                    if (!Directory.Exists(carpetaImagenes))
                        Directory.CreateDirectory(carpetaImagenes);

                    // Generar un identificador único
                    string id = idContador.ToString();

                    string nombreImagen = $"{id}.jpg";
                    string nuevaRutaImagen = Path.Combine(carpetaImagenes, nombreImagen);
                    File.Copy(rutaImagen, nuevaRutaImagen, true);

                    // Agregar la información al archivo de registro
                    using (StreamWriter archivo = new StreamWriter("registro.txt", true))
                    {
                        archivo.WriteLine($"{idContador}-{txtEspecie.Text}-{txtUbicacion.Text}-{dateTimePickerFecha.Text}-{nuevaRutaImagen}");
                    }

                    // Mostrar la imagen en el DataGridView
                    Image imagen = Image.FromFile(nuevaRutaImagen);
                    dataGridView1.Rows.Add(idContador, txtEspecie.Text, txtUbicacion.Text, dateTimePickerFecha.Text, nuevaRutaImagen);

                    idContador++;
                }
                else
                {
                    // Agregar la información al archivo de registro (sin imagen)
                    using (StreamWriter archivo = new StreamWriter("registro.txt", true))
                    {
                        archivo.WriteLine($"{idContador},{txtEspecie.Text},{txtUbicacion.Text},{dateTimePickerFecha.Text}");
                    }

                    // Mostrar los datos en el DataGridView (sin imagen)
                    dataGridView1.Rows.Add(idContador, txtEspecie.Text, txtUbicacion.Text, dateTimePickerFecha.Text);

                    idContador++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al registrar avistamiento: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtEspecie.Text = "";
            txtUbicacion.Text = "";
            dateTimePickerFecha.Value = DateTime.Now; 
            labelRuta.Text = "";

            // Deseleccionar la fila en el DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.SelectedRows[0].Selected = false;
            }

            openFileDialog1.FileName = "";

        }

        private bool ValidarCampos()
        {
                    if (string.IsNullOrEmpty(txtEspecie.Text))
                    {
                        MessageBox.Show($"Por favor ingrese una especie válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (string.IsNullOrEmpty(txtUbicacion.Text))
                    {
                        MessageBox.Show($"Por favor ingrese una ubicación válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    if (dateTimePickerFecha.Value > DateTime.Now)
                    {
                        MessageBox.Show($"Por favor ingrese una fecha válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    return true;
                }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnSubirImagen_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                labelRuta.Text = openFileDialog1.FileName;
            }
        }

        private void labelRuta_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Eliminar la entrada y actualizar el archivo "registro.txt"
                EliminarEntrada(selectedRow);
            }
        }

        private void EliminarEntrada(DataGridViewRow row)
        {
            try
            {
                int id = Convert.ToInt32(row.Cells["ID"].Value);
                string registroFilePath = "registro.txt";

                // Leer todas las líneas del archivo
                List<string> lineas = File.ReadAllLines(registroFilePath).ToList();

                // Buscar la línea que corresponde a la entrada a eliminar
                string lineaAEliminar = lineas.FirstOrDefault(linea => linea.StartsWith($"{id}-"));

                // Si se encuentra la línea, eliminarla y escribir de nuevo el archivo
                if (lineaAEliminar != null)
                {
                    lineas.Remove(lineaAEliminar);
                    File.WriteAllLines(registroFilePath, lineas);
                }

                // Actualizar el DataGridView
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar entrada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Verifica si hay una fila seleccionada
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtén la fila seleccionada
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Verifica si la celda en la columna "Ruta" no es null
                DataGridViewCell rutaCell = selectedRow.Cells["cellRuta"];
                if (rutaCell.Value != null)
                {
                    // Obtén la ruta de la celda
                    string ruta = rutaCell.Value.ToString();

                    // Abrir el formulario de edición
                    FormEdicion formEdicion = new FormEdicion(ruta);
                    formEdicion.ShowDialog();
                }
                else
                {
                    string ruta = null;
                    FormEdicion formEdicion = new FormEdicion(ruta);
                    formEdicion.ShowDialog();
                }
            }
            else
            {
                // No hay fila seleccionada, maneja la situación según sea necesario
                MessageBox.Show("No se ha seleccionado ninguna fila para editar.");
            }

            // Actualizar el DataGridView después de la edición
            CargarDatos();
            }
            
        }
    }

