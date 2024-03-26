using Microsoft.VisualBasic;
using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.Items;
public class Item<T> : Auditable
{
    public int CollectionId { get; set; }
    public string Name { get; set; }
    public string Tag { get; set; }
    public T CustomField1 { get; set; }
    public T CustomField2 { get; set; }
    public T CustomField3 { get; set; }

}
