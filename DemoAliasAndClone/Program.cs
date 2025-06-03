using System.Text;
using DemoAliasAndClone;

Console.OutputEncoding=Encoding.UTF8;

Student s1 = new Student();
s1.Id = 1;
s1.Name = "Trần Thị Tèo";

Student s2 = new Student();
s2.Id = 2;
s2.Name = "Nguyễn Văn Tũn";

//Lúc này trên thanh Ram sẽ cấp phát 2 ô nhớ
//Cho s1 và s2 quản lý
//==>s1 đổi giá trị ko liên quan gì tới s2 vì
//vì s1 và s2 đang quản lý 2 ô nhớ khác nhau
s1 = s2;
//ta viết lệnh: s1=s2
//Tuy nhiên về bản chất nó hoạt động như sau:
//s1 trỏ tới vùng nhớ mà s2 đang quản lý
//Chứ ko phải s1=s2
//có 2 tình huống xảy ra:
//(1) ô nhớ bên s2 có thêm s1 quản lý==>alias (>=2 đối tượng quản lý)
//      chỉ cần 1 đối tượng đổi thì các đối tượng khác đều bị đổi
s2.Name = "Nguyễn Thị Lung Linh";
Console.WriteLine("s2 đổi tên, vậy s1 có tên là gì?");  
Console.WriteLine(s1.Name);
//(2) ô nhớ lúc trước s1 đang quản lý, giờ ko còn đối tượng nào quản lý
//thì lúc này HĐH tự động thu hồi ô nhớ: Automatic Garbage Collection
//tức là ta ko thể truy xuất để lấy lại giá trị s1 có id=1, name Tèo