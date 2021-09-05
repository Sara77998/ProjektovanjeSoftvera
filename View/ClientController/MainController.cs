using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.ClientController
{
    public class MainController
    {
        internal void OpenUCUcenik(FrmGlavna frmGlavna)
        {
            frmGlavna.SetPanel(new UCManufacturer(new Controller.ManufacturerController()));
        }

        internal void OpenUCProduct(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCProduct(new Controller.ProductController()));
        }

        internal void OpenUCAllManufacturers(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAllManufacturers(new Controller.ManufacturerController()));
        }

        internal void OpenUCDataGridViewManufacturer(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCDataGridViewManufacturer(new Controller.ManufacturerController()));
        }

        internal void OpenUCAddInvoice(FrmMain frmMain)
        {
            frmMain.SetPanel(new UCAddInvoice(new Controller.InvoiceController()));
        }
    }
}
