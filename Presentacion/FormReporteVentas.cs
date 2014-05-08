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
    public partial class FormReporteVentas : Form
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

        public FormReporteVentas()
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

            string ruta = Path.Combine(Application.StartupPath, "ReportedeVentas.rpt");
            string ruta2 = Path.Combine(Application.StartupPath, "ReportedeVentasOperador.rpt");
            

            if (Privilegio == "Administrador")
            {
                rpt.Load(ruta);
                //rpt.Load(@"C:\Users\PC\Desktop\CtaCteV1.05\Presentacion\ReportedeVentas.rpt");
            }
            else 
            {
                rpt.Load(ruta2);
                //rpt.Load(@"C:\Users\PC\Desktop\CtaCteV1.05\Presentacion\ReportedeVentasOperador.rpt");            
            }
            
            string desde = dtpDesde.Value.ToString();
            string hasta = dtpHasta.Value.ToString();
            string FormaPago = cbxTipoVenta.Text.ToString();

            if (FormaPago == "Todo")
            {
                FormaPago = "Efectivo,CtaCte,Tarjeta,Cheque";
            }
           

            

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


            ///Aca comparo el Combobox para filtrar por Cliente
            ParameterFieldDefinitions crParameterFieldDefinitions;
            ParameterFieldDefinition crParameterFieldDefinition;
            ParameterValues crParameterValues = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

            crParameterDiscreteValue.Value = IdCliente;
            crParameterFieldDefinitions = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition = crParameterFieldDefinitions["ClienteDesde"];
            crParameterValues = crParameterFieldDefinition.CurrentValues;

            crParameterValues.Clear();
            crParameterValues.Add(crParameterDiscreteValue);
            crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

            ///Aca comparo el Combobox para filtrar por Cliente
            ParameterFieldDefinitions crParameterFieldDefinitions4;
            ParameterFieldDefinition crParameterFieldDefinition4;
            ParameterValues crParameterValues4 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue4 = new ParameterDiscreteValue();

            crParameterDiscreteValue4.Value = IdCliente;
            crParameterFieldDefinitions4 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition4 = crParameterFieldDefinitions4["ClienteHasta"];
            crParameterValues4 = crParameterFieldDefinition4.CurrentValues;

            crParameterValues4.Clear();
            crParameterValues4.Add(crParameterDiscreteValue4);
            crParameterFieldDefinition4.ApplyCurrentValues(crParameterValues4);

            ///Aca comparo el Combobox para filtrar por FormaPago
            ParameterFieldDefinitions crParameterFieldDefinitions5;
            ParameterFieldDefinition crParameterFieldDefinition5;
            ParameterValues crParameterValues5 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue5 = new ParameterDiscreteValue();

            crParameterDiscreteValue5.Value = FormaPago;
            crParameterFieldDefinitions5 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition5 = crParameterFieldDefinitions5["FormaPago"];
            crParameterValues4 = crParameterFieldDefinition5.CurrentValues;

            crParameterValues5.Clear();
            crParameterValues5.Add(crParameterDiscreteValue5);
            crParameterFieldDefinition5.ApplyCurrentValues(crParameterValues5);


            
            rpt.SetDatabaseLogon("saftec","ana");
            crystalReportViewer2.ReportSource = rpt;
            crystalReportViewer2.Refresh(); 
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SeleccionarCliente();
        }

        private void SeleccionarCliente()
        {
            FormGrillaClientes GrillaCliente = new FormGrillaClientes();
            
            GrillaCliente.ShowDialog();
        }



        internal void CargarSeleeccion(int IntId_Cliente,string strApellido, string strNombre)
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

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            cbxTipoVenta.Text = "Todo";
        }
    }
}
