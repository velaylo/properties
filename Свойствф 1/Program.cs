using System;

namespace Свойства_и_индексаторы_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ (английский): ");
            char symbol = Convert.ToChar(Console.ReadLine());

            Symbol sym = new Symbol();

            sym.Symb = symbol;

            // char correctSymbol = sym.Symb;
            //Console.WriteLine(correctSymbol);

            Console.ReadKey();
        }
    }

    class Symbol
    {
        public char symbol_1 = ' ';

        public char Symb
        {
            get
            {
                return symbol_1;
            }

            set
            {
                if ((int)value <= (int)'Z' && (int)value >= (int)'A')
                {
                    symbol_1 = value;
                    Console.WriteLine($"Введённый символ {symbol_1} попадает в промежуток от А до Z включительно");
                }
                else
                {
                    Console.WriteLine("Введённый символ не попадает в промежуток от А до Z включительно");
                }
            }
        }
    }
}
