namespace PersonalCollection.Application.DTOs.Item;
public  class ItemResponse
{
    public int Id { get; set; }
    public string name { get; set; }
    public string Tag { get; set; }
    public object? CustomField1 { get; set; }
    public object? CustomField2 { get; set; }
    public object? CustomField3 { get; set; }
}
