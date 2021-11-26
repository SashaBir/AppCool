using System;
using System.Text.RegularExpressions;

namespace AppCool.Project.Registration
{
    public static class AutentificationValidator
    {
        public static bool IsValidLogin(string login)
        {
            var hasChars = new Regex(@"[a-z]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasSpecialSymbol = new Regex(@"[-]+");
            bool isValildated = hasNumber.IsMatch(login) && hasChars.IsMatch(login) && hasSpecialSymbol.IsMatch(login);

            if (isValildated == false)
            {
                throw new Exception("Login must consists of letters, student's number and "-" between these");
            }

            return isValildated;
        }

        public static bool IsValidPassword(string password)
        {
            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var minimumChars = new Regex(@".{8,}");
            var hasChars = new Regex(@"[a-z]+");
            bool isValildated = hasNumber.IsMatch(password) && hasUpperChar.IsMatch(password) && minimumChars.IsMatch(password) && hasChars.IsMatch(password);

            if (isValildated == false)
            {
                throw new Exception("Password must consists of letters, upper letters, numbers and have minimum 8 symbols");
            }

            return isValildated;
        }
    }
}
