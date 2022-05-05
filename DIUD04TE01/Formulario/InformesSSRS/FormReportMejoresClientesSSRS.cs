using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIUD05TE01.Formulario.InformesSSRS
{
    public partial class FormReportMejoresClientesSSRS : Form
    {
        public FormReportMejoresClientesSSRS()
        {
            InitializeComponent();
        }

        private void FormReportMejoresClientesSSRS_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
