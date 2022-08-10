using System;
using System.Collections.Generic;
using System.Text;

namespace Kegiatan
{
    class OneDay
    {
        public class TodoList<T>
        {
            private List<T> todos;

            public TodoList()
            {
                this.todos = new List<T>();
            }

            public void AddTodo(T newTodos)
            {
                todos.Add(newTodos);
            }

            public void DeleteTodo(T todoToRemove)
            {
                todos.Remove(todoToRemove);
            }

            public void PrintToDo()
            {
                foreach (var todo in todos)
                {
                    Console.WriteLine(todo.ToString());
                }
            }
        }
    }
}