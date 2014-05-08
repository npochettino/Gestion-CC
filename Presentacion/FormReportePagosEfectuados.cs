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
    public partial class FormReportePagosEfectuados : Form
    {
        public FormReportePagosEfectuados()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            
            
            //Esta es la linea de prueba de pushh
            
            EmitirReporte();
        }

        private void EmitirReporte()
        {

            string desde = dtpFechaDesde.Value.ToShortDateString();
            string hasta = dtpFechaHasta.Value.ToShortDateString();

            string ruta = Path.Combine(Application.StartupPath, "ReporteDePagosEfectuados.rpt");
            ReportDocument rpt = new ReportDocument();
            rpt.Load(ruta);

            //rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\CtaCteV2.3\Presentacion\ReporteDePagosEfectuados.rpt");



            /// Aca comparo con el primer DataPicker la fecha desde
            ParameterFieldDefinitions crParameterFieldDefinitions1;
            ParameterFieldDefinition crParameterFieldDefinition1;
            ParameterValues crParameterValues1 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();

            crParameterDiscreteValue1.Value = desde;
            crParameterFieldDefinitions1 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition1 = crParameterFieldDefinitions1["Desde"];

            crParameterValues1 = crParameterFieldDefinition1.CurrentValues;

            crParameterValues1.Clear();
            crParameterValues1.Add(crParameterDiscreteValue1);
            crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);

            ///Aca comparo el segundo datapicker con la fecha hasta
            ParameterFieldDefinitions crParameterFieldDefinitions2;
            ParameterFieldDefinition crParameterFieldDefinition2;
            ParameterValues crParameterValues2 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue2 = new ParameterDiscreteValue();

            crParameterDiscreteValue2.Value = hasta;
            crParameterFieldDefinitions2 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition2 = crParameterFieldDefinitions2["Hasta"];

            crParameterValues2 = crParameterFieldDefinition2.CurrentValues;

            crParameterValues2.Clear();
            crParameterValues2.Add(crParameterDiscreteValue2);
            crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2);








            
            rpt.SetDatabaseLogon("saftec", "ana");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh(); 
        
        }
    }
}
