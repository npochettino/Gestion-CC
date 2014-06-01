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
    public partial class FormReporteDeGastos : Form
    {
        public FormReporteDeGastos()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {

            EmitirReporte();
        }

        private void EmitirReporte()
        {

            string desde = dtpFechaDesde.Value.ToShortDateString();
            string hasta = dtpFechaHasta.Value.ToShortDateString();

            //string ruta = Path.Combine(Application.StartupPath, "ReporteDeGastos.rpt");
            ReportDocument rpt = new ReportDocument();
            //rpt.Load(ruta);

            rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\Versiones Codigo\CtaCteV2.7.3\Presentacion\ReporteDeGastos.rpt");



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








            CrystalRules Conexion = new CrystalRules();
            //Se llama al metodo apply que configura todos los datos de conexion por medio del app.config
            rpt = Conexion.ApplyInfo(rpt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();

        }
    }
}
