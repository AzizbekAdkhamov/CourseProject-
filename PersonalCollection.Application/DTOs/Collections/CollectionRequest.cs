using System.ComponentModel.DataAnnotations;

namespace PersonalCollection.Application.DTOs.Collections;
public class CollectionRequest
{
    [MinLength(4), Required]
    public string CollectionName { get; set; }

    public string CollectionDescription { get; set; }

    public string CollectionCategory { get; set; }

    public 
}
