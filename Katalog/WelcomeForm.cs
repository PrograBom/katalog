using DevExpress.XtraEditors;
using Katalog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KatalogUI
{
    public partial class WelcomeForm : XtraForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }


        private void katalogBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            KatalogForm katalogForm = new KatalogForm();
            katalogForm.Show();
        }

        private void katalogButton_Click(object sender, EventArgs e)
        {
            KatalogForm katalogForm = new KatalogForm();
            katalogForm.Show();
        }

        private void endButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}