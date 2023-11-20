using System.Windows.Forms;

namespace UltrapudúAvistamientos
{
    internal class FormularioEdicion : Form
    {
        public FormularioEdicion(DataGridViewRow selectedRow)
        {
            SelectedRow = selectedRow;
        }

        public DataGridViewRow SelectedRow { get; }
    }
}