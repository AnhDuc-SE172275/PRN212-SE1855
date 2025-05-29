using OOP1;
using System.ComponentModel.DataAnnotations;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tạo 1 đối tượng danh mục
Category c1 =new Category();
//Gán giá trị cho các thuộc tính
c1.Id = 1;
c1.Name = "Nước mắm";
//Gọi hàm xuất dữ liệu;
c1.PrintInfor();

//Khởi tạo 1 nhân viên
Employee e1= new Employee();

//Gọi hàm xuất thông tin
e1.PrintInfor();
//Ta có thể truy suất theo từng Property lấy giá trị của thuộc tính:
Console.WriteLine("---------");
Console.WriteLine("Id của e1="+e1.Id);//Gọi getter Property Id
Console.WriteLine($"Name của e1={ e1.Name}");//Gọi getter Property Name

//Ta cũng có thể khởi tạo đối tượng và các giá trị của thuộc tính như sau:
Employee e2= new Employee()
{
    Id = 2,
    Id_card = "0055",
    Name = "Tý",
    Email = "ty@gmail.com",
    phone = "0912345673"
};
Console.WriteLine("---E2---");
e2.PrintInfor();

Console.WriteLine("===============");
Employee e3 = new Employee(3, "0088", "Tám", "tam@gmail.com", "0912341524");
//Gọi hàm xuất thông tin:
e3.PrintInfor();
//Hoặc tự động gọi tostring() khi đối tượng được xuất ra màn hình:
Console.WriteLine(e3);//Tự động hàm ToString()

//Thử dùng Constructor mặc định (0 có đối số)
Employee e4 = new Employee();
Console.WriteLine(e4);

//Tạo đối tượng Customer
Customer cus1 = new Customer()
{
    Id = "CUS1",
    Name = "Nguyễn Thị Lung linh",
    phone = "0912121314",
    Address = "Số 1 Đinh Tiên Hoàng - Quận 1 - HCM"
};
cus1.PrintInfor();
cus1.Address="Số 2 Đinh Bộ Lĩnh - Bình Thạnh - HCM";
cus1.phone = "023534546";
Console.WriteLine("Thông tin customer sau khi chỉnh sửa:");
cus1.PrintInfor();
