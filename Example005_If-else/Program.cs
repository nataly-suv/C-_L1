// приветствие любимчика
Console.WriteLine("Введите имя");
string username = Console.ReadLine();
if (username.ToLower() == "nataly")
{
    Console.WriteLine ("Ура, это Nataly!!!!");
}
else 
{
    Console.Write("Привет, ");
    Console.Write(username);
}