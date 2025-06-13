using DemoLINQ2SQL;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = "Server=ADMIN-PC;database=MyStore;uid=sa;pwd=123";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Câu1: Truy vấn toàn bộ danh mục
var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sách danh mục:");
dsdm.ForEach(x => Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));

//Câu2: Dùng query để lọc ra toàn bộ sản phẩm
var dsp = from p in context.Products
          select p;
Console.WriteLine("Danh sách sản phẩm");
foreach(var p in dsp)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}

//Câu3: Tìm danh mục khi viết mã danh mục
int dmd = 3;
Category cate = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if(cate==null)
{
    Console.WriteLine("Không tìm thấy danh mục có mã="+dmd);
}
else
{
    Console.WriteLine("Đã tìm thấy danh mục có mã ="+dmd);
    Console.WriteLine(cate.CategoryID+"\t"+cate.CategoryName);
}

//Câu4: Lọc ra TOP 3 sản phẩm có giá lớn nhất
var dssptop3 = context.Products.OrderByDescending(p => p.UnitPrice).Take(3);
Console.WriteLine("Danh sách 3 sản phẩm đắt nhất");
foreach(var p in dssptop3)

    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);

//Câu5: Thêm mới 1 danh mục
/*Category c1 = new Category();
c1.CategoryName = "Hàng điện tử hahahahahaha";
context.Categories.InsertOnSubmit(c1);
context.SubmitChanges();*/

//Câu6: Sửa tên danh mục
//Bước1: Tìm danh mục
//Bước2: Tìm thấy thì sửa
Category c13=context.Categories.FirstOrDefault(c=>c.CategoryID == 13);
if(c13!=null)
{
    c13.CategoryName = "Hàng gia dụng";
    context.SubmitChanges();
}

//Câu7: Xoá danh mục khi viết mã danh mục
Category c12= context.Categories.FirstOrDefault(c => c.CategoryID == 12);
if(c12!=null)
{
    context.Categories.DeleteOnSubmit(c12);
    context.SubmitChanges();
}

//Câu8: Xoá tất cả danh mục chưa có bất kì sản phẩm nào
var dssp_emty_product = context.Categories.Where(c => c.Products.Count() == 0).ToList();
context.Categories.DeleteAllOnSubmit(dssp_emty_product);
context.SubmitChanges();

//Câu9: Thêm nhiều danh mục cùng 1 lúc
List<Category> dsdm_new=new List<Category>();
dsdm_new.Add(new Category() { CategoryName = "Hàng điện tử" });
dsdm_new.Add(new Category() { CategoryName = "Hàng hoá chất" });
dsdm_new.Add(new Category() { CategoryName = "Hàng gia dụng" });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();