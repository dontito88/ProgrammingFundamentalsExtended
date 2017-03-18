namespace ex05.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogins
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var userDatabase = new Dictionary<string, string>();

            while (inputLine != "login")
            {
                var userInfo = inputLine.Split(' ');
                var userName = userInfo[0];
                var userPass = userInfo[userInfo.Length - 1];

                if (!userDatabase.ContainsKey(userName))
                {
                    userDatabase[userName] = userPass;
                }
                else if (userDatabase.ContainsKey(userName))
                {
                    userDatabase[userName] = userPass;
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();
            var failCounter = 0;
            var successfullyLogedIn = new Dictionary<string, string>();

            while (inputLine != "end")
            {
                var userInfo = inputLine.Split(' ');
                var userName = userInfo[0];
                var userPass = userInfo[userInfo.Length - 1];

                if (userDatabase.ContainsKey(userName))
                {
                    if (userDatabase[userName] != userPass)
                    {
                        successfullyLogedIn[userName] = "login failed";
                        failCounter++;
                    }
                    else
                    {
                        successfullyLogedIn[userName] = "logged in successfully";
                    }
                }
                inputLine = Console.ReadLine();
            }

            foreach (var item in successfullyLogedIn)
            {
                var userName = item.Key;
                var userResult = item.Value;
                Console.WriteLine($"{userName}: {userResult}");
            }
            Console.WriteLine($"unsuccessful login attempts: {failCounter}");
        }
    }
}
