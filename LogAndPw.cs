using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Ex
{
    internal class LogAndPw
    {
        public static bool CheckUser(string login, string password, string confirmPassword)
        {
            bool checkLogin = false;
            bool checkPassword = false;
            bool passwordAgreement = false;
            try
            {
                checkLogin = CheckerLogin(login);
                checkPassword = CheckerPassword(password);
                passwordAgreement = PasswordAgreement(password, confirmPassword);
            }
            catch (WrongLoginException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (WrongPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (checkLogin == true && checkPassword == true && passwordAgreement == true)
            {
                return true;
            }

            return false;
        }
        private static bool CheckerLogin(string login)
        {
            if (login.Length < 20)
            {
                return true;
            }
            else
            {
                throw new WrongLoginException("Кол-во символов в логине больше 20");
            }
        }

        private static bool CheckerPassword(string password)
        {
            bool Space = false;
            bool checkNumber = false;

            if (password.Length > 20)
            {
                throw new WrongPasswordException("Пароль имеет длину больше 20");
            }

            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == ' ')
                {
                    Space = true;
                    continue;
                }
                else if (char.IsDigit(password[i])) //Проверка на цифры
                {
                    checkNumber = true;
                }
            }

            if (checkNumber == false)
            {
                throw new WrongPasswordException("Пароль не имеет хотя бы одну цифру");
            }

            if (Space == true)
            {
                throw new WrongPasswordException("Пароль имеет пробел");
            }

            return true;
        }

        private static bool PasswordAgreement(string password, string confirmPassword)
        {

            if (password.Length > 20 || confirmPassword.Length > 20)
            {
                throw new WrongPasswordException("Пароль имеет больше длину чем символов 20");
            }
            else if (password.Length != confirmPassword.Length)
            {
                throw new WrongPasswordException("Пароли не совпадают");
            }
            else
            {
                for (int i = 0; i < password.Length; i++)
                {
                    if (password[i] != confirmPassword[i])
                    {
                        throw new WrongPasswordException("Длина пароля и подтверждения пароля не равна");
                    }
                }
            }

            return true;
        }
    }
}
