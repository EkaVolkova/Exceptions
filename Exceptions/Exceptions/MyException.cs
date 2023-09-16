using System;

/// <summary>
/// 1. Создайте свой тип исключения.
/// 2. Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. 
/// Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
/// 3. В блоке catch выведите в консольном сообщении текст исключения.
/// </summary>
namespace Exceptions
{
    class MyException : Exception
    {
        public MyException() : base("Мое исключение")
        { }

        public MyException(string message)
            : base(message)
        { }
    }
}
