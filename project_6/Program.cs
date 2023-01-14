Console.WriteLine("Введите Ваше имя");
string username = Console.ReadLine();
if(username.ToLower() == "маша")
{
    Console.WriteLine("Привет, Маша! Мы тебя ждали!");
}
else
{
    Console.Write("Привет, ");
Console.WriteLine(username);
}