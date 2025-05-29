// See https://aka.ms/new-console-template for more information

using System.Text;
using System.Xml.Serialization;

void do_calculate(double a, double b, string op)
{
    switch (op)
    {
        case "+":
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            break;
    }
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("SIMPLE CALCULATION!!");
Console.WriteLine("Nhap so a");
double a = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap so b");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap phep toan(+,-,*,/)");
string op = Console.ReadLine();
do_calculate(a, b, op);
Console.ReadLine();
