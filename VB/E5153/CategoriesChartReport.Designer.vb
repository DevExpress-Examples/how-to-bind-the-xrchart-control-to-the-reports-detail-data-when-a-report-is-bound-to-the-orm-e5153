Imports Microsoft.VisualBasic
Imports System
Namespace E5153
	Partial Public Class CategoriesChartReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim series1 As New DevExpress.XtraCharts.Series()
			Dim series2 As New DevExpress.XtraCharts.Series()
			Dim series3 As New DevExpress.XtraCharts.Series()
			Me.lbCategoryName = New DevExpress.XtraReports.UI.XRLabel()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.lbDescription = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrChartProducts = New DevExpress.XtraReports.UI.XRChart()
			Me.bindingSourceProduct = New System.Windows.Forms.BindingSource(Me.components)
			Me.pbPicture = New DevExpress.XtraReports.UI.XRPictureBox()
			Me.bindingSourceCategory = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.xrChartProducts, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(series3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSourceProduct, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSourceCategory, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' lbCategoryName
			' 
			Me.lbCategoryName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CategoryName")})
			Me.lbCategoryName.Font = New System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold)
			Me.lbCategoryName.LocationFloat = New DevExpress.Utils.PointFloat(220F, 10.00001F)
			Me.lbCategoryName.Name = "lbCategoryName"
			Me.lbCategoryName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbCategoryName.SizeF = New System.Drawing.SizeF(430F, 32F)
			Me.lbCategoryName.StylePriority.UseFont = False
			Me.lbCategoryName.Text = "lbCategoryName"
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbDescription
			' 
			Me.lbDescription.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Description")})
			Me.lbDescription.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbDescription.LocationFloat = New DevExpress.Utils.PointFloat(220F, 53.08332F)
			Me.lbDescription.Multiline = True
			Me.lbDescription.Name = "lbDescription"
			Me.lbDescription.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbDescription.SizeF = New System.Drawing.SizeF(430F, 56.91668F)
			Me.lbDescription.StylePriority.UseFont = False
			Me.lbDescription.Text = "lbDescription"
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrChartProducts, Me.lbDescription, Me.pbPicture, Me.lbCategoryName})
			Me.Detail.HeightF = 900F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrChartProducts
			' 
			Me.xrChartProducts.BorderColor = System.Drawing.Color.Black
			Me.xrChartProducts.Borders = DevExpress.XtraPrinting.BorderSide.None
			Me.xrChartProducts.DataSource = Me.bindingSourceProduct
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.False
			xyDiagram1.Rotated = True
			Me.xrChartProducts.Diagram = xyDiagram1
			Me.xrChartProducts.LocationFloat = New DevExpress.Utils.PointFloat(0F, 123.9583F)
			Me.xrChartProducts.Name = "xrChartProducts"
			series1.ArgumentDataMember = "ProductName"
			series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series1.Name = "Unit Price"
			series1.ValueDataMembersSerializable = "UnitPrice"
			series2.ArgumentDataMember = "ProductName"
			series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series2.Name = "Units In Stock"
			series2.ValueDataMembersSerializable = "UnitsInStock"
			series3.ArgumentDataMember = "ProductName"
			series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
			series3.Name = "Units On Order"
			series3.ValueDataMembersSerializable = "UnitsOnOrder"
			Me.xrChartProducts.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
			Me.xrChartProducts.SizeF = New System.Drawing.SizeF(650F, 776.0417F)
'			Me.xrChartProducts.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrChartProducts_BeforePrint);
			' 
			' bindingSourceProduct
			' 
			Me.bindingSourceProduct.DataSource = GetType(E5153.Product)
			' 
			' pbPicture
			' 
			Me.pbPicture.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Image", Nothing, "Picture")})
			Me.pbPicture.LocationFloat = New DevExpress.Utils.PointFloat(0F, 10F)
			Me.pbPicture.Name = "pbPicture"
			Me.pbPicture.SizeF = New System.Drawing.SizeF(200F, 100F)
			Me.pbPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
			' 
			' bindingSourceCategory
			' 
			Me.bindingSourceCategory.DataSource = GetType(E5153.Category)
			' 
			' CategoriesChartReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataSource = Me.bindingSourceCategory
			Me.Version = "13.2"
'			Me.DataSourceDemanded += New System.EventHandler(Of System.EventArgs)(Me.CategoriesChartReport_DataSourceDemanded);
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(series3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xrChartProducts, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSourceProduct, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSourceCategory, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private lbCategoryName As DevExpress.XtraReports.UI.XRLabel
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private lbDescription As DevExpress.XtraReports.UI.XRLabel
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private WithEvents xrChartProducts As DevExpress.XtraReports.UI.XRChart
		Private pbPicture As DevExpress.XtraReports.UI.XRPictureBox
		Private bindingSourceCategory As System.Windows.Forms.BindingSource
		Private bindingSourceProduct As System.Windows.Forms.BindingSource

	End Class
End Namespace
