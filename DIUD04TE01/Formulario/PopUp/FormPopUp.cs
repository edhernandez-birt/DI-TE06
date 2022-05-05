using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.Formulario.PopUp
{
    public partial class FormPopUp : Form
    {
        public FormPopUp()
        {
            InitializeComponent();
        }

        private void buttonVersion_Click(object sender, EventArgs e)
        {
            if (this.labelVersion.Visible)
            {
                this.labelVersion.Visible = false;
            }
            else
            {
                this.labelVersion.Visible = true;
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
