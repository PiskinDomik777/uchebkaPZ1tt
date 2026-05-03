using System;

namespace RepairRequestsApp
{
    public class RepairRequest
    {
        public int RequestID { get; set; }
        public DateTime StartDate { get; set; }
        public string ComputerTechType { get; set; }
        public string ComputerTechModel { get; set; }
        public string ProblemDescription { get; set; }
        public string RequestStatus { get; set; }
        public DateTime? CompletionDate { get; set; }
    }
}