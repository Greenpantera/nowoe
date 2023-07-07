Console.WriteLine("Введите имя ползователя");
string username = Console.ReadLine();

if (username.ToLower() == "марина")
{
    Console.Write("Ура, это же Марина!");
}
else
{
     Console.Write("Привет, ");
     Console.WriteLine(username);
}
