using hm7;

Console.WriteLine("Введите число: ") ;
int userNumber = int.Parse(Console.ReadLine());
var test = new TestClass()
{
    I = userNumber
};
var data = test.ObjectToString(); // customFieldName = 10;

test.StringProperty =  "123";

var newObj = new TestClass();
newObj.StringToObject(data);
Console.WriteLine();
Console.WriteLine($"Вывод: {newObj.I}");