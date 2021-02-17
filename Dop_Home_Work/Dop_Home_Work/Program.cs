using System;

namespace Dop_Home_Work
{

    class Program
    {
        static string Newpass()
        {
            string dublePasschek = null;
            bool chek = false;
            while (!chek)
            {

                char chekDooble = 'a';
                string passchek = "";
                Console.WriteLine("Введите пароль длинной 4-6 символов. Используя только цифры");
                passchek = Console.ReadLine();
                    try
                    {
                        int newpass = int.Parse(passchek);
                    chek = true;
                    }
                        catch (Exception)
                        {
                    Console.Clear();
                    Console.WriteLine("пароль должен состоять только и цифр, попробуйте еще раз");
                    
                        }
                if (passchek.Length > 6 || passchek.Length < 4 && chek)
                {
                    Console.Clear();
                    Console.WriteLine("длинна пароля должна быть от 4 до 6 символов, попробуйте еще раз");
                    chek = false;
                }

                    for (int i = 0; i < passchek.Length && chek; i++)
                    {
                        char a = passchek[i];
                    if (chekDooble == a)
                    {
                        Console.Clear();
                        Console.WriteLine("Цифры не должны повторяться друг за другом, попробуйте еще раз");
                        chek = false;
                    }
                    else
                        chekDooble = a;
                    }
                

                if (chek)
                {
                    Console.Clear();
                    Console.WriteLine("Повторите пароль");
                    dublePasschek = Console.ReadLine();
                }
                if (dublePasschek != passchek && chek)
                {
                    Console.Clear();
                    Console.WriteLine("Пароли не совпадают, попробуйте еще раз.");
                    chek = false;
                }

                if (dublePasschek == passchek && chek)
                {
                    Console.Clear();
                    Console.WriteLine("Пароль создан");
                }


            }
            return dublePasschek;
        }
        static void Main(string[] args)
        {
            
            string newUserPass = Newpass();

        }
    }
}
