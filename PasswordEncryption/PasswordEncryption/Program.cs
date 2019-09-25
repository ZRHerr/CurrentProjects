using PasswordEncryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordEncryption
{
    class Program
    {
        //1.	save a new password for a specific username,
        //2.	authenticate a specific username/password pair, or
        //3.	exit the application.
        //4.	On exit, all username/password pairs will be lost
              static void Main(string[] args)
        {
            List<User> users = new List<User>();
            int choice;
            do
            {

                Console.WriteLine("1. Establish an account");
                Console.WriteLine("2. Authenticate a user");
                Console.WriteLine("3. Exit the system");
                Console.WriteLine();
                Console.Write("Enter selection: ");
                string option = Console.ReadLine();
                choice = Int32.Parse(option);
                string username;
                string password;
                switch (choice)
                {
                    case 1:
                        
                        Console.Write("Enter Username: ");
                        username = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        password = Console.ReadLine();
                        bool unique = true;
                        if(users.Count>0)
                        {
                            for (int i = 0; i < users.Count; i++)
                            {
                                if (users[i].UserExist(username))
                                {
                                    Console.WriteLine("Username Already exist. Try Again");
                                    unique = false;
                                }
                            }
                            if (!unique)
                            {
                                User newuser = new User(username, password);
                                users.Add(newuser);
                            }
                        }
                        else
                        {
                            User newuser = new User(username, password);
                            users.Add(newuser);
                        }
                        break;
                    case 2:
                        Console.Write("Enter Username: ");
                        username = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        password = Console.ReadLine();
                        bool userexist = false;
                        for (int i = 0; i < users.Count; i++)
                        {
                            if (users[i].UserExist(username))
                            {
                                userexist = true;
                                if (users[i].Login(password))
                                {
                                    Console.WriteLine("Authenticated");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Not Authenticated");
                                    break;
                                }

                            }
                        }
                        if (!userexist)
                        {
                            Console.WriteLine("Username Does not exist");
                        }
                        break;
                    case 3:
                        Console.WriteLine("good bye!");
                        break;
                    default:
                        Console.WriteLine("enter valid option");
                        break;
                  }
                Console.WriteLine();
            } while (choice != 3);

        }
    }
}
