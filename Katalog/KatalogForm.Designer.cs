namespace Katalog
{
    partial class KatalogForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KatalogForm));
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            menuBar = new DevExpress.XtraBars.Bar();
            hideButtonItem = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            productListGridControl = new DevExpress.XtraGrid.GridControl();
            productViewBindingSource = new System.Windows.Forms.BindingSource(components);
            ProductListgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colISBN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colAvailableQuantity1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colPublicationDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colAuthors1 = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategoryName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            productDetailGridControl = new DevExpress.XtraGrid.GridControl();
            productDetailGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            colISBN = new DevExpress.XtraGrid.Columns.GridColumn();
            colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colAvailableQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colPublicationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colAuthors = new DevExpress.XtraGrid.Columns.GridColumn();
            colCategoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            productListViewBindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).BeginInit();
            splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).BeginInit();
            splitContainerControl1.Panel2.SuspendLayout();
            splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productListGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productViewBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductListgridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productListViewBindingSource).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { menuBar, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { hideButtonItem });
            barManager1.MainMenu = menuBar;
            barManager1.MaxItemId = 1;
            barManager1.StatusBar = bar3;
            // 
            // menuBar
            // 
            menuBar.BarName = "Main menu";
            menuBar.DockCol = 0;
            menuBar.DockRow = 0;
            menuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            menuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(hideButtonItem) });
            menuBar.OptionsBar.MultiLine = true;
            menuBar.OptionsBar.UseWholeRow = true;
            menuBar.Text = "Main menu";
            // 
            // hideButtonItem
            // 
            hideButtonItem.ActAsDropDown = true;
            hideButtonItem.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            hideButtonItem.Caption = "Ukonči Katalóg";
            hideButtonItem.Id = 0;
            hideButtonItem.Name = "hideButtonItem";
            hideButtonItem.ItemClick += hideButtonItem_ItemClick;
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new System.Drawing.Size(1136, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 576);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new System.Drawing.Size(1136, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new System.Drawing.Size(0, 556);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1136, 20);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new System.Drawing.Size(0, 556);
            // 
            // splitContainerControl1
            // 
            splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainerControl1.Horizontal = false;
            splitContainerControl1.Location = new System.Drawing.Point(0, 20);
            splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            splitContainerControl1.Panel1.Controls.Add(productListGridControl);
            splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            splitContainerControl1.Panel2.Controls.Add(productDetailGridControl);
            splitContainerControl1.Panel2.Text = "Panel2";
            splitContainerControl1.Size = new System.Drawing.Size(1136, 556);
            splitContainerControl1.SplitterPosition = 192;
            splitContainerControl1.TabIndex = 4;
            // 
            // productListGridControl
            // 
            productListGridControl.DataSource = productViewBindingSource;
            productListGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            productListGridControl.Location = new System.Drawing.Point(0, 0);
            productListGridControl.MainView = ProductListgridView;
            productListGridControl.MenuManager = barManager1;
            productListGridControl.Name = "productListGridControl";
            productListGridControl.Size = new System.Drawing.Size(1136, 192);
            productListGridControl.TabIndex = 0;
            productListGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { ProductListgridView });
            productListGridControl.MouseClick += ProductListGridControl_MouseDown;
            // 
            // productViewBindingSource
            // 
            productViewBindingSource.DataSource = typeof(KatalogLibrary.Views.ProductView);
            // 
            // ProductListgridView
            // 
            ProductListgridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ProductListgridView.Appearance.FocusedRow.Options.UseFont = true;
            ProductListgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId1, colTitle1, colISBN1, colPrice1, colDescription1, colAvailableQuantity1, colPublicationDate1, colAuthors1, colCategoryName1 });
            ProductListgridView.GridControl = productListGridControl;
            ProductListgridView.Name = "ProductListgridView";
            ProductListgridView.OptionsBehavior.Editable = false;
            // 
            // colId1
            // 
            colId1.FieldName = "Id";
            colId1.Name = "colId1";
            // 
            // colTitle1
            // 
            colTitle1.FieldName = "Title";
            colTitle1.Name = "colTitle1";
            colTitle1.Visible = true;
            colTitle1.VisibleIndex = 0;
            // 
            // colISBN1
            // 
            colISBN1.FieldName = "ISBN";
            colISBN1.Name = "colISBN1";
            // 
            // colPrice1
            // 
            colPrice1.FieldName = "Price";
            colPrice1.Name = "colPrice1";
            colPrice1.Visible = true;
            colPrice1.VisibleIndex = 1;
            // 
            // colDescription1
            // 
            colDescription1.FieldName = "Description";
            colDescription1.Name = "colDescription1";
            colDescription1.Visible = true;
            colDescription1.VisibleIndex = 2;
            // 
            // colAvailableQuantity1
            // 
            colAvailableQuantity1.FieldName = "AvailableQuantity";
            colAvailableQuantity1.Name = "colAvailableQuantity1";
            colAvailableQuantity1.Visible = true;
            colAvailableQuantity1.VisibleIndex = 3;
            // 
            // colPublicationDate1
            // 
            colPublicationDate1.FieldName = "PublicationDate";
            colPublicationDate1.Name = "colPublicationDate1";
            // 
            // colAuthors1
            // 
            colAuthors1.FieldName = "Authors";
            colAuthors1.Name = "colAuthors1";
            colAuthors1.Visible = true;
            colAuthors1.VisibleIndex = 4;
            // 
            // colCategoryName1
            // 
            colCategoryName1.FieldName = "CategoryName";
            colCategoryName1.Name = "colCategoryName1";
            colCategoryName1.Visible = true;
            colCategoryName1.VisibleIndex = 5;
            // 
            // productDetailGridControl
            // 
            productDetailGridControl.DataSource = productViewBindingSource;
            productDetailGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            productDetailGridControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            productDetailGridControl.Location = new System.Drawing.Point(0, 0);
            productDetailGridControl.MainView = productDetailGridView;
            productDetailGridControl.MenuManager = barManager1;
            productDetailGridControl.Name = "productDetailGridControl";
            productDetailGridControl.Size = new System.Drawing.Size(1136, 354);
            productDetailGridControl.TabIndex = 0;
            productDetailGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { productDetailGridView });
            // 
            // productDetailGridView
            // 
            productDetailGridView.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            productDetailGridView.Appearance.FocusedRow.Options.UseFont = true;
            productDetailGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colTitle, colISBN, colPrice, colDescription, colAvailableQuantity, colPublicationDate, colAuthors, colCategoryName });
            productDetailGridView.GridControl = productDetailGridControl;
            productDetailGridView.Name = "productDetailGridView";
            productDetailGridView.OptionsBehavior.Editable = false;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // colTitle
            // 
            colTitle.FieldName = "Title";
            colTitle.Name = "colTitle";
            colTitle.Visible = true;
            colTitle.VisibleIndex = 1;
            // 
            // colISBN
            // 
            colISBN.FieldName = "ISBN";
            colISBN.Name = "colISBN";
            colISBN.Visible = true;
            colISBN.VisibleIndex = 2;
            // 
            // colPrice
            // 
            colPrice.FieldName = "Price";
            colPrice.Name = "colPrice";
            colPrice.Visible = true;
            colPrice.VisibleIndex = 3;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 4;
            // 
            // colAvailableQuantity
            // 
            colAvailableQuantity.FieldName = "AvailableQuantity";
            colAvailableQuantity.Name = "colAvailableQuantity";
            colAvailableQuantity.Visible = true;
            colAvailableQuantity.VisibleIndex = 5;
            // 
            // colPublicationDate
            // 
            colPublicationDate.FieldName = "PublicationDate";
            colPublicationDate.Name = "colPublicationDate";
            colPublicationDate.Visible = true;
            colPublicationDate.VisibleIndex = 6;
            // 
            // colAuthors
            // 
            colAuthors.FieldName = "Authors";
            colAuthors.Name = "colAuthors";
            colAuthors.Visible = true;
            colAuthors.VisibleIndex = 7;
            // 
            // colCategoryName
            // 
            colCategoryName.FieldName = "CategoryName";
            colCategoryName.Name = "colCategoryName";
            colCategoryName.Visible = true;
            colCategoryName.VisibleIndex = 8;
            // 
            // productListViewBindingSource
            // 
            productListViewBindingSource.DataSource = typeof(KatalogLibrary.Views.ProductListView);
            // 
            // KatalogForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1136, 596);
            Controls.Add(splitContainerControl1);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("KatalogForm.IconOptions.Icon");
            Name = "KatalogForm";
            Text = "Katalóg";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel1).EndInit();
            splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1.Panel2).EndInit();
            splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerControl1).EndInit();
            splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)productListGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)productViewBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductListgridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDetailGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)productListViewBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar menuBar;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem hideButtonItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl productListGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ProductListgridView;
        private DevExpress.XtraGrid.GridControl productDetailGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView productDetailGridView;
        private System.Windows.Forms.BindingSource productListViewBindingSource;
        private System.Windows.Forms.BindingSource productViewBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailableQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthors;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colId1;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colISBN1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice1;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription1;
        private DevExpress.XtraGrid.Columns.GridColumn colAvailableQuantity1;
        private DevExpress.XtraGrid.Columns.GridColumn colPublicationDate1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthors1;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryName1;
    }
}

