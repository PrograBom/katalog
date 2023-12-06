using KatalogLibrary.Helpers;
using KatalogLibrary.Models;
using KatalogLibrary.Views;
using KatalogLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid;

namespace Katalog;

public partial class KatalogForm : DevExpress.XtraEditors.XtraForm
{
    private List<Product>? products = new List<Product>();
    private List<ProductView> productViews = new();
    public KatalogForm()
    {
        InitializeComponent();
        GenerateData();
        WireProductListData();
    }

    private void WireProductListData()
    {
        productListGridControl.DataSource = productViews;
    }

    private void GenerateData()
    {
        products = GlobalConfig.Connection?.GetProduct_All();
        if (products != null && products.Count != 0)
        {
            ProductViewMapper mapper = new();
            productViews = mapper.MapList(products);
        }
    }

    private void ProductListGridControl_MouseDown(object sender, MouseEventArgs e)
    {

        GridControl gridControl = sender as GridControl;

        if (gridControl != null)
        {
            GridView view = gridControl.GetViewAt(e.Location) as GridView;

            if (view != null)
            {
                GridHitInfo hitInfo = view.CalcHitInfo(e.Location);

                if (hitInfo.RowHandle >= 0)
                {
                    var products = gridControl.DataSource as List<ProductView>;

                    if (products != null && products.Count > hitInfo.RowHandle)
                    {
                        var selectedProduct = products[hitInfo.RowHandle];

                        if (selectedProduct != null)
                        {
                            productDetailGridControl.DataSource = new List<ProductView> { selectedProduct };
                        }
                    }
                }
            }
        }
    }

    private void hideButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
        this.Close();
    }
}
