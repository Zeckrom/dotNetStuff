using Injection.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Injection.Core.Repositories
{
    public class TodoRepository : ICRUDRepository<int, Todo>
    {
        public List<Todo> _todos = new List<Todo>();
        public void Add(Todo entity)
        {
            _todos.Add(entity);
        }

        public IEnumerable<Todo> GetAll()
        {
            return _todos;
        }

        public Todo GetById(int key)
        {
            return _todos[key];
        }

        public void Remove(int key)
        {
            _todos.RemoveAt(key);
        }
    }
}
