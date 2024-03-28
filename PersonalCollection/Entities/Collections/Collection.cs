using PersonalCollection.Domain.Commons;
using PersonalCollection.Domain.Entities.Attachments;


namespace PersonalCollection.Domain.Entities.Collections;
public  class Collection : Auditable 
{
    public string CollectionName { get; set; }

    public string CollectionDescription { get; set; }
    public Attachment attachment { get; set; }
    public string CollectionCategory {  get; set; }
    public object Field1Name {  get; set; }
    public object Field2Name { get; set; }
    public object Field3Name { get; set; }

}
