namespace RepairRequestsApp
{
    public class RepairRequest
    {
        public int RequestID { get; set; }
        public DateTime StartDate { get; set; }
        public string ComputerTechType { get; set; }      // ← string!
        public string ComputerTechModel { get; set; }     // ← string!
        public string ProblemDescription { get; set; }    // ← string!
        public string RequestStatus { get; set; }         // ← string!
        public DateTime? CompletionDate { get; set; }
    }
}