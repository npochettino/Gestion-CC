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
    public partial class FormReportePago : Form
    {
        public FormReportePago()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            
            EmitirReporte();
        }

        private void EmitirReporte()
        {
            //string ruta = Path.Combine(Application.StartupPath, "ReporteTurnos.rpt");
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(ruta);

            rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\CtaCteV1.01\Presentacion\ReporteSaldos.rpt");

            
            rpt.SetDatabaseLogon("saftec", "ana");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh(); 
        
        }

        private void FormReportePago_Load(object sender, EventArgs e)
        {

        }
    }
}
