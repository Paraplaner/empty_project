namespace Cash.Models
{
    /// <summary>
    /// Сущность. Абстрактный класс, базовый для всех моделей.
    /// </summary>
    public abstract class Entity
    {
        public virtual long Id { get; protected set; }
    }
}