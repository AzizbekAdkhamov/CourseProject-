using Microsoft.VisualBasic;
using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.Items;
public class Item : Auditable
{
    public int CollectionId { get; set; }
    public string Name { get; set; }
    public string Tag { get; set; }
    public object CustomField1 { get; set; }
    public object CustomField2 { get; set; }
    public object CustomField3 { get; set; }

}
