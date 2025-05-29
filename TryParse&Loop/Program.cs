/*Đề tài:
    * Nhập vào 1 số >=0, nếu nhập sai quy tắc
    * thì yêu cầu nhập lại khi nào đúng nội dung
    * Nếu nhập đúng thì tính giai thừa của số này
    */
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
int n = -1;//Giá trị nhập sai
while(n<=0)//bắt nhập lại cho tới khi nào n>=0
{
    Console.WriteLine("Nhập n>=0:");
    string input=Console.ReadLine();
    if(int .TryParse(input, out n) == true)
    {//Khi vào đây n là số, nhưng có thể <0
        //if (n < 0)
        //    continue;
        if (n >= 0)//nhập đúng
            break;//không bắt nhập nữa
        else
            Console.WriteLine("Tui đã nói là nhập >=0 mà");
    }
    else
    {
        Console.WriteLine("Lựu đạn quá cha,nhập số mà");
    }
}
int gt = 1;
for(int i = 1; i <= n; i++)
    gt=gt*i;
Console.WriteLine($"{n}!={gt}");