using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
        {
            new Product { Name = "Monitor", Price = 200.50 },
            new Product { Name = "Mouse", Price = 20.41 },
            new Product { Name = "Keyboard", Price = 30.15}
        };

            IProductStockReportBuilder builder = new ProductStockReportBuilder(products);
            ProductStockReportDirector director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            var report = builder.GetReport();
            Console.WriteLine(report);


            Console.ReadKey();
            builder = new ProductStockReportBodyBuilder(products);
            director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            report = builder.GetReport();
            Console.WriteLine(report);
            Console.ReadKey();

            builder = new ProductStockReportDecoratedBuilder(products);
            director = new ProductStockReportDirector(builder);
            director.BuildStockReport();

            report = builder.GetReport();
            Console.WriteLine(report);
            Console.ReadKey();
        }
    }
}
