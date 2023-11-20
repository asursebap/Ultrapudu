using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltrapudúAvistamientos
{
    internal partial class FormEdicion : Form
    {
        public FormEdicion(DataGridViewRow selectedRow)
        {
            SelectedRow = selectedRow;
        }

        public DataGridViewRow SelectedRow { get; }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FormEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
