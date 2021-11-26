using AppCool.Project.DataBase.Autorization;
using System;
using System.Text.RegularExpressions;

namespace AppCool.Project.Registration
{
    public static class AutentificationValidator
    {
        public static bool IsValidAutorization(string login, string password)
        {
            var hasChars = new Regex(@"[a-z]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasSpecialSymbol = new Regex(@"[-]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var minimumChars = new Regex(@".{8,}");
            bool isValidatedLogin = hasNumber.IsMatch(login) && hasChars.IsMatch(login) && hasSpecialSymbol.IsMatch(login);
            bool isValidatedPassword = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && minimumChars.IsMatch(password) && hasChars.IsMatch(password);

            if (isValidatedLogin == true && isValidatedPassword == true)
            {
                return CallDataBaseAutentification.CallDataBase(login, password);
            }
            else if (isValidatedLogin == false)
                throw new Exception("\aLogin must consists of letters, student's number and (-) between these");
            else
                throw new Exception("\aPassword must consists of letters, upper letters, numbers and have minimum 8 symbols");
        }
    }
}
