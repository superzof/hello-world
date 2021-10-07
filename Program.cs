using System;

namespace hello_world_cs
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("entre le nom du compte : ");

        string userName = Console.ReadLine();
        lgi :
        {
             Console.WriteLine("mot de pasee : ");
        
            string mdp = Console.ReadLine();
        }

        Random rd = new Random();

        int rand_num = rd.Next(1,5);
        {
            if (rand_num > 1)
            {
                goto lgi;
            }
            else{
             Console.WriteLine("sucessfully logged into the accont ");
            }
        }

        }
    }
}
