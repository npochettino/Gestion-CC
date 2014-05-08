using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace Presentacion
{
    public partial class FormReporteDeSaldos : Form
    {
        public FormReporteDeSaldos()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            
            EmitirReporte();
        }

        private void EmitirReporte()
        {
            string ruta = Path.Combine(Application.StartupPath, "ReporteSaldos.rpt");
            ReportDocument rpt = new ReportDocument();
            rpt.Load(ruta);

            //rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\CtaCteV1.05\Presentacion\ReporteSaldos.rpt");

            
            rpt.SetDatabaseLogon("saftec", "ana");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
 
           
        
        }
    }
}
