<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128598751/13.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5153)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CategoriesChartReport.cs](./CS/E5153/CategoriesChartReport.cs) (VB: [CategoriesChartReport.vb](./VB/E5153/CategoriesChartReport.vb))**
* [Default.aspx](./CS/E5153/Default.aspx) (VB: [Default.aspx](./VB/E5153/Default.aspx))
<!-- default file list end -->
# How to bind the XRChart control to the report's detail data when a report is bound to the ORM(Entity Framework) data source 
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e5153/)**
<!-- run online end -->


<p>This example demonstrates how to bind the report's <a href="https://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRCharttopic"><u>XRChart</u></a> control to detail data when a report is bound to the collection of data classes. The Entity Framework ORM is used in this example as a report's data source.</p><br />
<p>The BindingSource controls are used in this example to provide a data class shema to the XtraReport and XRChart control at design time. To provide data to the report at runtime, the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXtraReportBase_DataSourceDemandedtopic"><u>DataSourceDemanded</u></a> event handler is used. The <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIXRControl_BeforePrinttopic"><u>XRChart.BeforePrint</u></a> event handler is used to get a data object corresponding to the current row and bind the XRChart control to the data.</p><br />
<p>Note that this example is built on the ASP.NET WebForms technology. However, our XtraReports suite is a cross-platform product, so you can use the same approach in other .NET applications.</p>

<br/>


