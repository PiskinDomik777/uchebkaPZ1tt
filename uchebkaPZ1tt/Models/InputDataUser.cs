namespace uchebkaPZ1tt.Models;

public partial class InputDataUser
{
    public int UserId { get; set; }

    public string? Fio { get; set; }

    public long? Phone { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public string? Type { get; set; }

    public virtual ICollection<InputDataComment> InputDataComments { get; set; } = new List<InputDataComment>();

    public virtual ICollection<InputDataRequest> InputDataRequestClients { get; set; } = new List<InputDataRequest>();

    public virtual ICollection<InputDataRequest> InputDataRequestMasters { get; set; } = new List<InputDataRequest>();
}
