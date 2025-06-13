using Lucy_SalesManagement;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = @"server=ADMIN-PC;database=Lucy_SalesData;uid=sa;pwd=123";
Lucy_SalesDataDataContext context =
            new Lucy_SalesDataDataContext(connectionString);
//Câu 1: lấy chi tiết thông tin khách hàng khi biết mã:
int mkh = 1;
Customer cust = context.Customers.FirstOrDefault(c => c.CustomerID == mkh);
if (cust != null)
{
    Console.WriteLine(cust.CustomerID + "\t" + cust.ContactName);
}
//Câu 2: Lọc ra danh sách các hóa đơn của khách hàng tìm thấy:
if (cust != null)
{
    Console.WriteLine("Danh sách hóa đơn của khách hàng:");
    foreach (Order od in cust.Orders)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy"));
    }
}
//Câu 3: nâng cấp câu 2
//bổ sung thêm 1 cột hiển thị Trị giá của hóa đơn
if (cust != null)
{
    Console.WriteLine("Danh sách hóa đơn của khách hàng:");
    foreach (Order od in cust.Orders)
    {
        decimal money = od.Order_Details.Sum(odd => odd.Quantity * odd.UnitPrice - (decimal)odd.Discount * odd.Quantity * odd.UnitPrice);
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/MM/yyyy") + "\t" + money);
    }
}