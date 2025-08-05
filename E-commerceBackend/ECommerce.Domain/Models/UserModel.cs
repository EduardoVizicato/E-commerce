namespace ECommerce.Domain.Models;

using ECommerce.Domain.Models.ValueObjects;
using Microsoft.AspNetCore.Identity;
public class UserModel : IdentityUser<Guid>
{
    public UserModel()
    {
        
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public TaxIdVO TaxId { get; set; }
    public ICollection<OderModel> Orders { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

}