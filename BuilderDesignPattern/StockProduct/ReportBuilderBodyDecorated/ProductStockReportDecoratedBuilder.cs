using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProduct
{
   public class ProductStockReportDecoratedBuilder : IProductStockReportBuilder
{
       private ProductStockReport _productStockReport;
    private IEnumerable<Product> _products;

    public ProductStockReportDecoratedBuilder(IEnumerable<Product> products)
    {
        _products = products;
        _productStockReport = new ProductStockReport();
    }

    public void BuildHeader()
    {
        var sb = new StringBuilder();
        sb.AppendLine("*********************************************************");
        sb.AppendLine("*************** Decorated Products Report ******************");
        sb.AppendLine("*********************************************************");
        sb.AppendLine(string.Format("STOCK REPORT FOR ALL THE PRODUCTS ON DATE: {0}\n", DateTime.Now));
        _productStockReport.HeaderPart = sb.ToString();
    }

    public void BuildBody()
    {
        _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => string.Format("Product name: {0}, product price: {1}", p.Name, p.Price)));
    }

    public void BuildFooter()
    {
        _productStockReport.FooterPart = "\nReport provided by the IT_PRODUCTS company.";
    }

    public ProductStockReport GetReport()
    {
        var productStockReport = _productStockReport;
        Clear();
        return productStockReport;
    }

    private void Clear() { _productStockReport = new ProductStockReport(); }
}
}
