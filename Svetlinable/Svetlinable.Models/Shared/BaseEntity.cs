namespace Svetlinable.Models.Shared
{
    public abstract class BaseEntity<T>
    {
        public T Id { get; set; }
    }
}
