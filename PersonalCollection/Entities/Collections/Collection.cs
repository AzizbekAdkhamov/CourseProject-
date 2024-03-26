using PersonalCollection.Domain.Commons;

namespace PersonalCollection.Domain.Entities.Collections;
public  class Collection<T> : Auditable 
{
    public string CollectionName { get; set; }

    public string CollectionDescription { get; set; }

    public string CollectionImage {  get; set; }
    public string CollectionCategory {  get; set; }
    public T Field1Name {  get; set; }
    public T Field2Name { get; set; }
    public T Field3Name { get; set; }

}
