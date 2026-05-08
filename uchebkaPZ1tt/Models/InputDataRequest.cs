namespace uchebkaPZ1tt.Models;

public partial class InputDataRequest
{
    public int RequestId { get; set; }

    public DateTime StartDate { get; set; }

    public string ComputerTechType { get; set; } = null!;

    public string ComputerTechModel { get; set; } = null!;

    public string ProblemDescryption { get; set; } = null!;

    public string RequestStatus { get; set; } = null!;

    public DateTime? CompletionDate { get; set; }

    public string? RepairParts { get; set; }

    public int? MasterId { get; set; }

    public int ClientId { get; set; }

    public virtual InputDataUser Client { get; set; } = null!;

    public virtual ICollection<InputDataComment> InputDataComments { get; set; } = new List<InputDataComment>();

    public virtual InputDataUser? Master { get; set; }
}