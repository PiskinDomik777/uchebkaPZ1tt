using System;
using System.Collections.Generic;

namespace uchebkaPZ1tt.Models;

public partial class InputDataComment
{
    public int CommentId { get; set; }

    public string? Message { get; set; }

    public int? MasterId { get; set; }

    public int? RequestId { get; set; }

    public virtual InputDataUser? Master { get; set; }

    public virtual InputDataRequest? Request { get; set; }
}
