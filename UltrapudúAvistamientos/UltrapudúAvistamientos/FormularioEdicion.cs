using System.Windows.Forms;

namespace UltrapudúAvistamientos
{
    internal class FormularioEdicion :
    {
        public FormularioEdicion(DataGridViewRow selectedRow)
        {
            SelectedRow = selectedRow;
        }

        public DataGridViewRow SelectedRow { get; }
    }
}