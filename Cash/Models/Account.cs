using System;

namespace Cash.Models
{
    /// <summary>
    /// Счёт.
    /// </summary>
    public class Account : Entity
    {
        public virtual String Title { get; set; }
    }
}