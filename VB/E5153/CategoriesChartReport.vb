Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace E5153
	Partial Public Class CategoriesChartReport
		Inherits DevExpress.XtraReports.UI.XtraReport
		Private db As NWindEntities

		Public Sub New()
			InitializeComponent()
			db = New NWindEntities()
		End Sub

		Private Sub CategoriesChartReport_DataSourceDemanded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DataSourceDemanded
			Me.DataSource = _
				From product In db.Categories _
				Select product
		End Sub

		Private Sub xrChartProducts_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrChartProducts.BeforePrint
			Dim cat As Category = TryCast(Me.GetCurrentRow(), Category)
			xrChartProducts.DataSource = cat.Products
		End Sub

	End Class
End Namespace
