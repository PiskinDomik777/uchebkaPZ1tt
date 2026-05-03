using System;
using System.Collections.Generic;

namespace uchebkaPZ1tt.Models;

public partial class InputDataRequest
{
    public int RequestId { get; set; }

    public string StartDate { get; set; } = null!;

    public string? ComputerTechType { get; set; }

    public string? ComputerTechModel { get; set; }

    public string? ProblemDescryption { get; set; }

    public string? RequestStatus { get; set; }

    public string? CompletionDate { get; set; }

    public string? RepairParts { get; set; }

    public int? MasterId { get; set; }

    public int ClientId { get; set; }

    public virtual InputDataUser Client { get; set; } = null!;

    public virtual ICollection<InputDataComment> InputDataComments { get; set; } = new List<InputDataComment>();

    public virtual InputDataUser? Master { get; set; }
}
