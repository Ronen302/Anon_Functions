using System;

namespace DelegatePredpTechnic
{
    public delegate int StrDelegate(string s);
    class Program
    {
        static void Main(string[] args)
        {
            StrDelegate sD = delegate (string str)
            {
                if (str == null)
                    throw new Exception("Строка отсутствует");
                else
                    return str.Length;
            };
            Console.WriteLine(sD(""));
            Console.ReadKey();
        }
    }
}
