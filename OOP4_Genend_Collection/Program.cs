using System.Text;
using OOP2;

Console.OutputEncoding = Encoding.UTF8;

/*Sử dung Generic List để quản lí nhân sự
 * thực hiện đầy đủ tính năng CRUD
 * C->Read/Retrieve-->Đọc:Truy vấn, tìm kiếm, sắp xếp...
 * U->Update-->Chỉnh sửa dữ liệu
 * D->Delete-->Xoá dữ liệu
 */
//Câu 1 - C(Create)
//Dùng List để tạo 5 Employee, trong đó 4 Employee là chính thức
//và 1 Employee là thời vụ
List<Employee> employees = new List<Employee>();
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Name 1";
e1.IdCard = "Card 1";
e1.Birthday = new DateTime(1990, 1, 1);
employees.Add(e1);

FulltimeEmployee e2= new FulltimeEmployee();
e2.Id = 2;
e2.Name = "Name 2";
e2.IdCard = "Card 2";
e2.Birthday = new DateTime(1993, 11, 29);
employees.Add(e2);

FulltimeEmployee e3 = new FulltimeEmployee();
e3.Id = 3;
e3.Name = "Name 3";
e3.IdCard = "Card 3";
e3.Birthday = new DateTime(1992, 7, 2);
employees.Add(e3);

FulltimeEmployee e4 = new FulltimeEmployee();
e4.Id = 4;
e4.Name = "Name 4";
e4.IdCard = "Card 4";
e4.Birthday = new DateTime(1993, 10, 11);
employees.Add(e4);

FulltimeEmployee e5 = new FulltimeEmployee();
e5.Id = 5;
e5.Name = "Name 5";
e5.IdCard = "Card 5";
e5.Birthday = new DateTime(1980,5, 3);
employees.Add(e5);

//Câu 2: R -> xuất toàn bộ nhân sự:
//Cách xuất 1:
Console.WriteLine("---Danh sách nhân sự - cách 1---");
employees.ForEach(e =>  Console.WriteLine(e));
Console.WriteLine("---Danh sách nhan sự - cách 2---");
foreach (var e in employees) 
    Console.WriteLine(e);

//Câu 3: R--> Lọc ra nhân sự chính thức và tính tổng lương
//Cách 1: Dùng các extension method của hệ thống:
List<FulltimeEmployee> fe_list = 
    employees.OfType<FulltimeEmployee>().ToList();
Console.WriteLine("---Danh sách nhân sư chính thức---");
fe_list.ForEach(e => Console.WriteLine(e));
//Cách 2: Dùng cách thông thường:
List<FulltimeEmployee> fe_list2 = new List<FulltimeEmployee>();
foreach(var e in employees)
{
    if( e is FulltimeEmployee)
        fe_list2.Add(e as FulltimeEmployee);
}
Console.WriteLine("---Danh sách nhân sự chính thức cách 2---");
fe_list2.ForEach(e => Console.WriteLine(e));

//Tổng lương:
double sum_salary = fe_list2.Sum(e => e.calSalary());
Console.WriteLine("Tổng lương = " + sum_salary);

//Câu 4: R--> Sắp xếp danh sách nhân sự theo ngày tháng năm sinh
for (int i = 0; i < employees.Count; i++)
{
    for (int j = 0; j <employees.Count ; j++)
    {
        Employee ei= employees[i];
        Employee ej = employees[j];
        if(ei.Birthday>ej.Birthday)
        {
            employees[i] = ei;
            employees[j] = ei;
        }
    }
}


// Hàm sửa thông tin nhân viên theo ID
void UpdateEmployeeById(List<Employee> employees, int id)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);
    if (employee == null)
    {
        Console.WriteLine($"Không tìm thấy nhân viên với ID = {id}");
        return;
    }

    Console.WriteLine($"Thông tin hiện tại: {employee}");

    Console.Write("Nhập tên mới: ");
    employee.Name = Console.ReadLine();

    Console.Write("Nhập số CCCD mới: ");
    employee.IdCard = Console.ReadLine();

    Console.Write("Nhập ngày sinh mới (yyyy-MM-dd): ");
    if (DateTime.TryParse(Console.ReadLine(), out DateTime newBirthday))
    {
        employee.Birthday = newBirthday;
    }
    else
    {
        Console.WriteLine("Ngày sinh không hợp lệ. Giữ nguyên.");
    }

    Console.WriteLine("Cập nhật thành công!");
}

// Hàm xoá nhân viên theo ID
void DeleteEmployeeById(List<Employee> employees, int id)
{
    var employee = employees.FirstOrDefault(e => e.Id == id);
    if (employee == null)
    {
        Console.WriteLine($"Không tìm thấy nhân viên với ID = {id}");
        return;
    }

    employees.Remove(employee);
    Console.WriteLine($"Đã xoá nhân viên có ID = {id}");
}

Console.WriteLine("---THỬ SỬA THÔNG TIN NHÂN VIÊN---");
Console.Write("Nhập ID nhân viên cần sửa: ");
int idUpdate = int.Parse(Console.ReadLine());
UpdateEmployeeById(employees, idUpdate);

Console.WriteLine("---THỬ XOÁ NHÂN VIÊN---");
Console.Write("Nhập ID nhân viên cần xoá: ");
int idDelete = int.Parse(Console.ReadLine());
DeleteEmployeeById(employees, idDelete);

// In lại danh sách nhân viên sau khi sửa/xoá
Console.WriteLine("---DANH SÁCH SAU SỬA/XOÁ---");
employees.ForEach(e => Console.WriteLine(e));
