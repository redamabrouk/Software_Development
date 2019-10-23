using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProduct
{
   public class ProductStockReportBodyBuilder : IProductStockReportBuilder
{
       private ProductStockReport _productStockReport;
    private IEnumerable<Product> _products;

    public ProductStockReportBodyBuilder(IEnumerable<Product> products)
    {
        _products = products;
        _productStockReport = new ProductStockReport();
    }
 
    public void BuildHeader()
    {
    }
 
    public void BuildBody()
    {
        _productStockReport.BodyPart = string.Join(Environment.NewLine, _products.Select(p => string.Format("Product name: {0}, product price: {1}",p.Name,p.Price)));
    }
 
    public void BuildFooter()
    {
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
