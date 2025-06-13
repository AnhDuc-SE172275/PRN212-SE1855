using DemoLINQ2Object2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

ListProduct lp = new ListProduct();
lp.gen_products();
//Câu 1: lọc ra các sản phẩm có giá từ a tới b
//sử dụng Method Syntax và Query Syntax
var result1 = lp.FilterProductsByPrice(200, 300);
Console.WriteLine("Danh sách sản phẩm có giá từ 200-300:");
result1.ForEach(x => Console.WriteLine(x));

//Câu 2: Sắp xếp các sản phẩm theo đơn giá giảm dần
//sử dụng Method Syntax và Query Syntax
var result2 = lp.SortProductByPriceDesc2();
Console.WriteLine("Danh sách sản phẩm sau khi sắp xếp");
result2.ForEach(x => Console.WriteLine(x));

//Câu 3: Tính tổng giá trị sản phẩm trong kho hàng
Console.WriteLine("Tổng giá trị = " + lp.SumOfValue());