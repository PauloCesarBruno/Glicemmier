using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao_Usuario
{
    public partial class frmImpressaoParametros : Form
    {
        public frmImpressaoParametros()
        {
            InitializeComponent();
        }

        private void frmImpressaoParametros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'Bd_GlicemiaDataSet.tbl_Correcao'. Você pode movê-la ou removê-la conforme necessário.
            this.tbl_CorrecaoTableAdapter.Fill(this.Bd_GlicemiaDataSet.tbl_Correcao);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
