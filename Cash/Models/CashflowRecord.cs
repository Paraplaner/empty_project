using System;

namespace Cash.Models
{
    /// <summary>
    /// Запись.
    /// </summary>
    public class CashflowRecord : Entity
    {
        public virtual Account Account { get; set; }
        public virtual Category Category { get; set; }
        public virtual decimal Amount { get; set; }
        public virtual DateTime DateTime { get; set; }
        public virtual String Comments { get; set; }
    }
}