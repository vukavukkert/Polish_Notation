using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace polishNotation
{
    public class Stack<T>
    {
        private Node<T>? _last; //создаем приватное поле last,  
                                //знак вопроса указывает что оно может иметь значение null
        public bool IsEmpty => _last is null; // создаем булевое поле
                                              //ключевое слово is проверяет если типы у первого и второго значения равны
                                              //если они равны то оно принимает значение true, если нет то false.

        public void Push(T? item) => _last = new Node<T>(item) { Link = _last };
        // создание нового узла типа Node<T> с переданным значением item, который становится последним узлом в стеке, 
        //и присваивание ссылки на него полю _last. При этом созданный узел связывается со старым последним узлом с помощью свойства Link.
        //вкратце добавляет элемент как последний узел в стеке

        public T? Pop()
        {
            if (_last is null) throw new InvalidOperationException("Стек является пустым."); //ошибка

            var res = _last!.Data; //если стек не пустой, метод Pop сохраняет данные последнего элемента в стек, после чего происходит
            _last = _last.Link; //изменение поля _last на предыдущий узел стека (узел, находящийся перед удаленным элементом)
            return res; //последний элемент возвращается
        }

        public T? Peek() => _last is null ? throw new InvalidOperationException("Стек является пустым.") : _last!.Data;
    }
}