using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polishNotation
{
    public class Node<T>
    {
        internal T? Data { get; } // ключевое слово internal создает класс который может быть использован только в текущей сборке
                                  //создаем объект data вида T?, значение которого можно только установить при создании объекта класса

        internal Node<T>? Link { get; set; }

        internal Node(T? data = default) => Data = data; //созадем метод node, который может принимать а может и не принимать data,
                                                         // так как если её нет он автоматически определяет её значение как default. далее поле объекта дата принимает значение дата
    }
}