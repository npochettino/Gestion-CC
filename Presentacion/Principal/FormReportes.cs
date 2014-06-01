using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Presentacion
{
    public partial class FormReportes : DevExpress.XtraEditors.XtraForm
    {
        public FormReportes()
        {
            InitializeComponent();
        }



        string privilegio;

        public string Privilegio
        {

            get { return privilegio; }
            set { privilegio = value; }

        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteDeSaldos frmReporteDeSaldos = new FormReporteDeSaldos();
            frmReporteDeSaldos.ShowDialog();
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteVentas frmReporteVentas = new FormReporteVentas();

            frmReporteVentas.Privilegio = Privilegio;
            frmReporteVentas.ShowDialog();
            
            
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteArticulos frmReporteArticulos = new FormReporteArticulos();
            frmReporteArticulos.ShowDialog();
            


        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReportePagosEfectuados frmReportePagosEfectuados = new FormReportePagosEfectuados();
            frmReportePagosEfectuados.ShowDialog();
        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteAuditoriaDeVentas frmReporteAuditoriaDeVentas = new FormReporteAuditoriaDeVentas();
            frmReporteAuditoriaDeVentas.ShowDialog();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteCajaDiaria CajaDiariaDetalle = new FormReporteCajaDiaria();

            CajaDiariaDetalle.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteDetalleVenta DetalleVenta = new FormReporteDetalleVenta();

            DetalleVenta.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReporteDeGastos RepGastos = new FormReporteDeGastos();
            RepGastos.ShowDialog();
        }

       
    }
}