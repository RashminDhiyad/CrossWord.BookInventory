using System.Collections.Generic;

namespace CrossWord.BookInventory.MultiLingualObjects
{
    public interface IMultiLingualObject<TTranslation>
    where TTranslation : class, IObjectTranslation
    {
        ICollection<TTranslation> Translations { get; set; }
    }
}
