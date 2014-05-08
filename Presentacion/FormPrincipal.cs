using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using System.IO;

namespace Presentacion
{
    public partial class FormPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public FormPrincipal()
        {
            //Pongo al cursor en "modo carga" hasta que se termine de realizar toda la carga de componentes y/o datos 
            Cursor = Cursors.WaitCursor;

            InitializeComponent();

            DevExpress.UserSkins.OfficeSkins.Register();
            DevExpress.UserSkins.BonusSkins.Register();


          

            SkinHelper.InitSkinPopupMenu(SkinsLink);

            Cursor = Cursors.Default;
        }

        string privilegio;

        public string Privilegio
        {

            get { return privilegio; }
            set { privilegio = value; }

        }

      


        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            Clientes formCliente = new Clientes();
            formCliente.ShowDialog();
        }

        private void gallery_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.cargarLookAndFeel();
        }

        private void cargarLookAndFeel()
        {
            var gallery = new DevExpress.XtraBars.Ribbon.GalleryDropDown();
            gallery.Manager = barManager1;
            SkinHelper.InitSkinGalleryDropDown(gallery);
            gallery.ShowPopup(MousePosition);
        }

        private void guardarLookAndFeel()
        {
            defaultLookAndFeel1.LookAndFeel.SkinName = LookAndFeel.ActiveSkinName;
            Properties.Settings.Default.Skin = defaultLookAndFeel1.LookAndFeel.SkinName;
            Properties.Settings.Default.Save();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.guardarLookAndFeel();

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Help.ShowHelp(this, Path.Combine(Application.StartupPath, "Ayuda.chm"));
            //Help.ShowHelp(this, @"C:\Users\PC\Desktop\CuentaCorriente\Presentacion\Ayuda.chm",HelpNavigator.Topic,"Systemrequirement");
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            FrmABMusuarios frmUsuario = new FrmABMusuarios();
            frmUsuario.ShowDialog();

        }

        private void tileItem3_ItemClick(object sender, TileItemEventArgs e)
        {
            frmABMClientes frmClientes = new frmABMClientes();
            frmClientes.ShowDialog();
        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
            frmABMArticulos formArticulos = new frmABMArticulos();

            formArticulos.Privilegio = Privilegio;
            formArticulos.ShowDialog();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            FormABMTipoArticulo TipoArticulo = new FormABMTipoArticulo();
                
            TipoArticulo.ShowDialog();
        }

        private void tileItem4_ItemClick(object sender, TileItemEventArgs e)
        {
            FormReportes Reporte = new FormReportes();

            Reporte.Privilegio = Privilegio;

            Reporte.ShowDialog();
            
        }

        private void tileItem7_ItemClick(object sender, TileItemEventArgs e)
        {
            AbrirPantalladeNuevaVenta();
        }

        private void AbrirPantalladeNuevaVenta()
        {
            FormAMVenta PantVenta = new FormAMVenta();

            

            PantVenta.ShowDialog();

            
        }

        internal void CargarPrivilegios()
        {
            

            if (Privilegio != "Administrador")
            {
               
                tileItem2.Visible = false;
            
            }
        }

        private void tiMarcas_ItemClick(object sender, TileItemEventArgs e)
        {
            FormABMarca Marca = new FormABMarca();

            Marca.ShowDialog();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            GestionCaja CajaDiaria = new GestionCaja();


            CajaDiaria.Privilegio = privilegio;
            CajaDiaria.ShowDialog();
        }

        private void tileItem9_ItemClick(object sender, TileItemEventArgs e)
        {
            FormABMGastos Gasto = new FormABMGastos();
            Gasto.ShowDialog();

        }

        private void tileItem10_ItemClick(object sender, TileItemEventArgs e)
        {
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        }

       


     

        

       
    }
}