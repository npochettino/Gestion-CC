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
    public partial class FormReporteDetalleVenta : Form
    {
        string NombreCliente;
        string ApellidoCliente;
        int IdCliente;

        string privilegio;

        public string Privilegio
        {

            get { return privilegio; }
            set { privilegio = value; }

        }

        public FormReporteDetalleVenta()
        {
            InitializeComponent();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {

            EmitirReporte();
        }

        private void EmitirReporte()
        {

            ReportDocument rpt = new ReportDocument();

            string ruta = Path.Combine(Application.StartupPath, "ReporteDetalleVenta.rpt");




            rpt.Load(ruta);
            //rpt.Load(@"D:\Martin\Desarrollos\Propios\C#\GestionCC (TrabajoLocal)\CtaCteV2.3\Presentacion\ReporteDetalleVenta.rpt");            


            string desde = dtpDesde.Value.ToString();
            string hasta = dtpHasta.Value.ToString();





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
            crystalReportViewer2.ReportSource = rpt;
            crystalReportViewer2.Refresh();

        }






        internal void CargarSeleeccion(int IntId_Cliente, string strApellido, string strNombre)
        {
            Negocio.ParametrosCliente Parametro = new Negocio.ParametrosCliente();
            string StrApellidoCliente = Parametro.strApellidoCliente;
            string StrNombreCliente = Parametro.strNombreCliente;


            //txtClienteDesde.Text = StrApellidoCliente + " " + StrNombreCliente;

            //txtClienteDesde.Update();



            //txtClienteHasta.Text = StrApellidoCliente + " " + StrNombreCliente;
            // txtClienteHasta.Refresh();



        }





        internal void EnviarParametros(int IntId_Cliente, string strApellido, string strNombre)
        {
            IdCliente = IntId_Cliente;
            NombreCliente = strNombre;
            ApellidoCliente = strApellido;
        }


    }
}
