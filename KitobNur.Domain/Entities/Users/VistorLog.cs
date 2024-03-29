using KitobNur.Domain.Comon;
using KitobNur.Domain.Users;
namespace KitobNur.Domain.Entities.Users;
public class VistorLog : Auditable<long>
{
    public int VisitorLogId { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
}
