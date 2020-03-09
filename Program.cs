using System;

namespace AppInterfaces_ComputronComputing
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            tdl.Add("Party1");


            PasswordManager pm = new PasswordManager("Squirrel", false);

            tdl.Display();
            tdl.Add("Party2");
            tdl.Display();
        }
    }
}
