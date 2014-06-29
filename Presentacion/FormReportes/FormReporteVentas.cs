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
        string Filter;

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
            FilterString();
            EmitirReporte();

 
        }


        private string FilterString()
        {
            Filter = string.Empty;
            bool Flag = false;

            if (chkCheque.Checked)
            {
                Filter += "Cheque";
                Flag = true;
            }

            if (chkCtaCte.Checked)
            {
                if (Flag)
                    Filter += ", Cuenta Corriente";
                else
                {
                    Filter += "CuentaCorriente";
                    Flag = true;
                }
            }

            if (chkEfectivo.Checked)
                if (Flag)
                    Filter += ", Efectivo";
                else
                {
                    Filter += "Efectivo";
                    Flag = true;
                }

            if (chkTarjeta.Checked)
                if (Flag)
                    Filter += ", Tarjeta";
                else
                {
                    Filter += "Tarjeta";
                    Flag = true;
                }

            if (Filter.Equals(string.Empty))
                Filter = "-1";

            return Filter;
        }

       

        private void EmitirReporte()
        {

            ReportDocument rpt = new ReportDocument();

            string ruta = Path.Combine(Application.StartupPath, "ReporteVentas.rpt");
            string ruta2 = Path.Combine(Application.StartupPath, "ReportedeVentasOperador.rpt");


            if (Privilegio == "Administrador")
            {
                rpt.Load(ruta);
                //rpt.Load(@"C:\Users\marti_000\Documents\gits\SempaIT\GestionCC\gestioncc\Presentacion\Reportes\ReporteVentas.rpt");
            }
            else
            {
                rpt.Load(ruta2);
                //rpt.Load(@"C:\Users\marti_000\Documents\gits\SempaIT\GestionCC\gestioncc\Presentacion\Reportes\ReporteVentasOperador.rpt");
            }

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

            crParameterDiscreteValue2.Value = hasta; ;
            crParameterFieldDefinitions2 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition2 = crParameterFieldDefinitions2["Hasta"];

            crParameterValues2 = crParameterFieldDefinition2.CurrentValues;

            crParameterValues2.Clear();
            crParameterValues2.Add(crParameterDiscreteValue2);
            crParameterFieldDefinition2.ApplyCurrentValues(crParameterValues2);




            //Aca comparo el Combobox para filtrar por FormaPago
            ParameterFieldDefinitions crParameterFieldDefinitions5;
            ParameterFieldDefinition crParameterFieldDefinition5;
            ParameterValues crParameterValues5 = new ParameterValues();
            ParameterDiscreteValue crParameterDiscreteValue5 = new ParameterDiscreteValue();


            crParameterDiscreteValue5.Value = Filter;
            
            crParameterFieldDefinitions5 = rpt.DataDefinition.ParameterFields;
            crParameterFieldDefinition5 = crParameterFieldDefinitions5["FormaPago"];
            crParameterValues5 = crParameterFieldDefinition5.CurrentValues;

            crParameterValues5.Clear();
            crParameterValues5.Add(crParameterDiscreteValue5);
            crParameterFieldDefinition5.ApplyCurrentValues(crParameterValues5);


             //GestionCC datos  = ConsultaReporteVentas.ReporteVenta();


            CrystalRules Conexion = new CrystalRules();
            //Se llama al metodo apply que configura todos los datos de conexion por medio del app.config
            rpt = Conexion.ApplyInfo(rpt);
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

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            //    // TODO: esta línea de código carga datos en la tabla 'gestionCC.FormaPago' Puede moverla o quitarla según sea necesario.
            //    this.formaPagoTableAdapter.Fill(this.gestionCC.FormaPago);
            //    cbxTipoVenta.Text = "Todo";
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
