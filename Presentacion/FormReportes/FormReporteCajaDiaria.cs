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
    public partial class FormReporteCajaDiaria: Form
    {
        public FormReporteCajaDiaria()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            
            EmitirReporte();
        }

        private void EmitirReporte()
        {

            string FechaOperacion = dtpFecha.Value.ToShortDateString();

            string ruta = Path.Combine(Application.StartupPath, "ReporteDeCajaDiaria.rpt");
            ReportDocument rpt = new ReportDocument();
            
            rpt.Load(ruta);

            //rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\CtaCteV2.3\Presentacion\ReporteDeCajaDiaria.rpt");




            /// Aca comparo con el primer DataPicker la fecha desde
            ParameterFieldDefinitions crParameterFieldDefinitions1;
            ParameterFieldDefinition crParameterFieldDefinition1;
            ParameterValues crParameterValues1 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue1 = new ParameterDiscreteValue();

            crParameterDiscreteValue1.Value = FechaOperacion;
            crParameterFieldDefinitions1 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition1 = crParameterFieldDefinitions1["FechaOperacion"];

            crParameterValues1 = crParameterFieldDefinition1.CurrentValues;

            crParameterValues1.Clear();
            crParameterValues1.Add(crParameterDiscreteValue1);
            crParameterFieldDefinition1.ApplyCurrentValues(crParameterValues1);





            CrystalRules Conexion = new CrystalRules();
            //Se llama al metodo apply que configura todos los datos de conexion por medio del app.config
            rpt = Conexion.ApplyInfo(rpt);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh(); 
        
        }

        private void FormReportePago_Load(object sender, EventArgs e)
        {

        }
    }
}
