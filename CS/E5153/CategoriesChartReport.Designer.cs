namespace E5153 {
    partial class CategoriesChartReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            this.lbCategoryName = new DevExpress.XtraReports.UI.XRLabel();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.lbDescription = new DevExpress.XtraReports.UI.XRLabel();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrChartProducts = new DevExpress.XtraReports.UI.XRChart();
            this.bindingSourceProduct = new System.Windows.Forms.BindingSource(this.components);
            this.pbPicture = new DevExpress.XtraReports.UI.XRPictureBox();
            this.bindingSourceCategory = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xrChartProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // lbCategoryName
            // 
            this.lbCategoryName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "CategoryName")});
            this.lbCategoryName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lbCategoryName.LocationFloat = new DevExpress.Utils.PointFloat(220F, 10.00001F);
            this.lbCategoryName.Name = "lbCategoryName";
            this.lbCategoryName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbCategoryName.SizeF = new System.Drawing.SizeF(430F, 32F);
            this.lbCategoryName.StylePriority.UseFont = false;
            this.lbCategoryName.Text = "lbCategoryName";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbDescription
            // 
            this.lbDescription.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Description")});
            this.lbDescription.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbDescription.LocationFloat = new DevExpress.Utils.PointFloat(220F, 53.08332F);
            this.lbDescription.Multiline = true;
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbDescription.SizeF = new System.Drawing.SizeF(430F, 56.91668F);
            this.lbDescription.StylePriority.UseFont = false;
            this.lbDescription.Text = "lbDescription";
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChartProducts,
            this.lbDescription,
            this.pbPicture,
            this.lbCategoryName});
            this.Detail.HeightF = 900F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand;
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrChartProducts
            // 
            this.xrChartProducts.BorderColor = System.Drawing.Color.Black;
            this.xrChartProducts.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrChartProducts.DataSource = this.bindingSourceProduct;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False;
            xyDiagram1.Rotated = true;
            this.xrChartProducts.Diagram = xyDiagram1;
            this.xrChartProducts.LocationFloat = new DevExpress.Utils.PointFloat(0F, 123.9583F);
            this.xrChartProducts.Name = "xrChartProducts";
            series1.ArgumentDataMember = "ProductName";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.Name = "Unit Price";
            series1.ValueDataMembersSerializable = "UnitPrice";
            series2.ArgumentDataMember = "ProductName";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series2.Name = "Units In Stock";
            series2.ValueDataMembersSerializable = "UnitsInStock";
            series3.ArgumentDataMember = "ProductName";
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series3.Name = "Units On Order";
            series3.ValueDataMembersSerializable = "UnitsOnOrder";
            this.xrChartProducts.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.xrChartProducts.SizeF = new System.Drawing.SizeF(650F, 776.0417F);
            this.xrChartProducts.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrChartProducts_BeforePrint);
            // 
            // bindingSourceProduct
            // 
            this.bindingSourceProduct.DataSource = typeof(E5153.Product);
            // 
            // pbPicture
            // 
            this.pbPicture.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Image", null, "Picture")});
            this.pbPicture.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10F);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.SizeF = new System.Drawing.SizeF(200F, 100F);
            this.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // bindingSourceCategory
            // 
            this.bindingSourceCategory.DataSource = typeof(E5153.Category);
            // 
            // CategoriesChartReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.DataSource = this.bindingSourceCategory;
            this.Version = "13.2";
            this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CategoriesChartReport_DataSourceDemanded);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrChartProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRLabel lbCategoryName;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRLabel lbDescription;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRChart xrChartProducts;
        private DevExpress.XtraReports.UI.XRPictureBox pbPicture;
        private System.Windows.Forms.BindingSource bindingSourceCategory;
        private System.Windows.Forms.BindingSource bindingSourceProduct;

    }
}
