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
        clsNodo objNodo = new clsNodo();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            objNodo.Nombre = txtNombre.Text;
            objNodo.Codigo = Convert.ToInt32(txtCodigo.Text);
            objNodo.Tramite = txtTramite.Text;

            objCola.Agregar(objNodo);
            objCola.Recorrer(lbListado);
        }
    }
}
