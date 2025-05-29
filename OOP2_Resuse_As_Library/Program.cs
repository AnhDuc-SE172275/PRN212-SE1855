<<<<<<< HEAD
﻿using OOP2;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 11, 25)
};
Console.WriteLine("---Thông tin của Obama---");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine("Name="+obama.Name); 
Console.WriteLine("IdCard="+obama.IdCard);
Console.WriteLine("Năm sinh="+obama.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương Obama nhận = " + obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee();
trump.Id = 2;
trump.Name = "Donald Trump";
trump.IdCard= "456";
trump.Birthday = new DateTime(1959,11, 25);
trump.WorkingHour = 3;
Console.WriteLine("---Thông tin của Trump---");
Console.WriteLine($"Id={trump.Id}");
Console.WriteLine("Name=" + trump.Name);
Console.WriteLine("IdCard=" + trump.IdCard);
Console.WriteLine("Năm sinh=" + trump.Birthday.ToString("dd/MM/yyyy"));
Console.WriteLine("Mức lương Obama nhận = " + trump.calSalary());

Console.WriteLine("----Sử dụng toString()----");
Console.WriteLine(obama);
Console.WriteLine(trump);
=======
﻿using System.Text;
using OOP2;
using OOP2_Resuse_As_Library;

Console.OutputEncoding = Encoding.UTF8;

FulltimeEmployee e1=new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Teo";
e1.IdCard = "123";
e1.Birthday = new DateTime(1990, 12, 25);
Console.WriteLine("Thông tin của E1");
Console.WriteLine(e1);
Console.WriteLine("==>AGE=" + e1.TinhTuoi());
>>>>>>> b605471 (OOP2_Resuse_As_Library)
