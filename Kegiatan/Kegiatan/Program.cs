using System;

namespace Kegiatan
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList<string> todosOfString = new TodoList<string>();
            todosOfString.AddTodo("Mandi");
            todosOfString.AddTodo("Sarapan");
            todosOfString.AddTodo("Kuliah");
            todosOfString.AddTodo("Makan Siang");
            todosOfString.AddTodo("Pulang");
            todosOfString.DeleteTodo("Pulang");
            todosOfString.AddTodo("Ngoding");

            todosOfString.PrintToDo();

        }

    }
}
