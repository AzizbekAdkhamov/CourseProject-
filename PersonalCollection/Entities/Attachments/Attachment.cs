using PersonalCollection.Domain.Commons;
using System.Security.Cryptography.X509Certificates;

namespace PersonalCollection.Domain.Entities.Attachments;
public class Attachment : Auditable
{
    public string Path { get; set; }
    public string Name { get; set; }
}
