using System;

namespace Cash.Models
{
    /// <summary>
    /// Категория.
    /// </summary>
    public class Category: Entity
    {
        public virtual String Title { get; set; }
        public virtual Category ParentCategory { get; set; }
    }
}