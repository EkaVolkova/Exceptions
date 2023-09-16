using System;

/// <summary>
/// 1. Создайте свой тип исключения.
/// 2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
/// Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
/// 3. В блоке catch выведите в консольном сообщении текст исключения.
/// </summary>
namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new IndexOutOfRangeException();
            exceptions[1] = new ArgumentException();
            exceptions[2] = new FormatException();
            exceptions[3] = new ArithmeticException();
            exceptions[4] = new MyException();
            foreach(var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
