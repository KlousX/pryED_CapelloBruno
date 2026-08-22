using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryED_CapelloBruno
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola objCola = new clsCola();
        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo objNodo = new clsNodo();

            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;
            objNodo.siguiente = null;

            objCola.Agregar(objNodo);
            objCola.Recorrer(lbListado);
            objCola.RecorrerDGV(dgvListado);

            txtCodigo.Clear();
            txtTramite.Clear();
            txtNombre.Clear();
            txtCodigo.Focus();
        }
    }
}
