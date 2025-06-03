using OOP5_Dictionary;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Category c1=new Category();
c1.Id = 1;
c1.Name = "Nước ngọt";

Product p1= new Product();
p1.Id = 1;
p1.Name = "Coca";
p1.Quantity = 10;
p1.Price = 15;
c1.AddProduct(p1);

Product p2= new Product();
p2.Id = 2;
p2.Name = "Pepsi";
p2.Quantity = 30;
p2.Price = 15;
c1.AddProduct(p2);

Product p3 = new Product();
p3.Id = 3;
p3.Name = "Sting";
p3.Quantity = 7;
p3.Price = 20;
c1.AddProduct(p3);

Product p4 = new Product();
p4.Id = 4;
p4.Name = "RedBull";
p4.Quantity = 5;
p4.Price = 18;
c1.AddProduct(p4);

Product p5 = new Product();
p5.Id = 5;
p5.Name = "Sprite";
p5.Quantity = 8;
p5.Price = 20;
c1.AddProduct(p5);

//Xuất toàn bộ sản phẩm của danh mục:
Console.WriteLine("--Toàn bộ sản phẩm của nước ngọt--");
c1.PrintAllProduct();

Dictionary<int, Product> filters =
    c1.FilterProductByPrice(10, 20);
Console.WriteLine("--Các sản phẩm có giá trị từ 10->20--");
foreach(KeyValuePair<int, Product> kvp in filters)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_result = c1.SortProdcutByPrice();
Console.WriteLine("--Sản phẩm sau khi sắp xếp--");
foreach(KeyValuePair<int, Product> kvp in sort_result)
{
    Product p= kvp.Value; 
    Console.WriteLine(p);
}

Dictionary<int, Product> sort_complex = c1.ComplexSort();
Console.WriteLine("--Sản phẩm sau khi sắp xếp--");
foreach (KeyValuePair<int, Product> kvp in sort_result)
{
    Product p = kvp.Value;
    Console.WriteLine(p);
}

p1.Name = "Xá xị";
p1.Quantity = 30;
p1.Price = 28;
c1.UpdateProduct(p1);
Console.WriteLine("--Sản phẩm sau khi chỉnh sửa--");
c1.PrintAllProduct();

int id = 3;
bool ret=c1.RemoveProduct(id);
if (ret)
{
    Console.WriteLine($"--Đã xoá sản phẩm có mã {id} thành công");
    Console.WriteLine("--Sản phẩm sau khi xoá");
    c1.PrintAllProduct();
}
else
{
    Console.WriteLine($"--Ko tìm thấy sản phẩm có mã {id} để xoá");
}

Category c2=new Category();
c2.Id = 2;
c2.Name = "Bia";
c2.AddProduct(new Product() { Id = 6, Name = "Sài Gòn", Quantity = 10, Price = 300 });
c2.AddProduct(new Product() { Id = 7, Name = "333", Quantity = 15, Price = 400 });
c2.AddProduct(new Product() { Id = 8, Name = "Ken Ken", Quantity = 7, Price = 500 });

SortedSet<Category> ss=new SortedSet<Category>();   
ss.Add(c1);
ss.Add(c2);
Console.WriteLine("---Toàn bộ dữ liệu theo danh mục---");
foreach (Category c in ss)
{
    Console.WriteLine($"--{c.Name}--");
    Console.WriteLine("*************");
    c.PrintAllProduct();
    Console.WriteLine("*************");
}
