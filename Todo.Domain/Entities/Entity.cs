using System;

namespace Todo.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
    }
}