using Lesson12Ex;

Console.WriteLine("Введите логин:");
string login = Console.ReadLine();
Console.WriteLine("Введите пароль:");
string password = Console.ReadLine();
Console.WriteLine("Подтверждение пароля:");
string confirmPassword = Console.ReadLine();
bool logAndPw = LogAndPw.CheckUser(login, password, confirmPassword);
if(logAndPw == true)
{
    Console.WriteLine("Пользователь авторизовался");
}
