Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это Маша-растеряша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}