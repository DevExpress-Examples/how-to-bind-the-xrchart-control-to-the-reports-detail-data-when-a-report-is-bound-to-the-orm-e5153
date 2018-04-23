using System;
using System.Linq;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace E5153 {
    public partial class CategoriesChartReport : DevExpress.XtraReports.UI.XtraReport {
        NWindEntities db;

        public CategoriesChartReport() {            
            InitializeComponent();
            db = new NWindEntities();
        }

        private void CategoriesChartReport_DataSourceDemanded(object sender, EventArgs e) {
            this.DataSource = from product in db.Categories
                              select product;
        }

        private void xrChartProducts_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {         
            Category cat = this.GetCurrentRow() as Category;
            xrChartProducts.DataSource = cat.Products;
        }

    }
}
