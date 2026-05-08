namespace RepairRequestsApp
{
    public static class DataStore
    {
        public static List<RepairRequest> Requests = new List<RepairRequest>
        {
            new RepairRequest
            {
                RequestID = 1,
                StartDate = new DateTime(2023, 6, 6),
                ComputerTechType = "Компьютер",
                ComputerTechModel = "RDOR GAMING RAGE H290",
                ProblemDescription = "Выключается после 10 минут работы",
                RequestStatus = "В процессе ремонта",
                CompletionDate = null
            },
            new RepairRequest
            {
                RequestID = 2,
                StartDate = new DateTime(2023, 5, 5),
                ComputerTechType = "Ноутбук",
                ComputerTechModel = "ASUS VivoBook Pro 15 M6500QH-HN034 синий",
                ProblemDescription = "Сильно шумит и греется",
                RequestStatus = "В процессе ремонта",
                CompletionDate = null
            },
            new RepairRequest
            {
                RequestID = 3,
                StartDate = new DateTime(2022, 7, 7),
                ComputerTechType = "Мышка",
                ComputerTechModel = "ARDOR GAMING Phantom PRO",
                ProblemDescription = "Перестало работать колёсико",
                RequestStatus = "Готова к выдаче",
                CompletionDate = new DateTime(2023, 1, 1)
            },
            new RepairRequest
            {
                RequestID = 4,
                StartDate = new DateTime(2023, 8, 2),
                ComputerTechType = "Клавиатура",
                ComputerTechModel = "Dark Project KD83A",
                ProblemDescription = "Сломались некоторые клавиши",
                RequestStatus = "Новая заявка",
                CompletionDate = null
            },
            new RepairRequest
            {
                RequestID = 5,
                StartDate = new DateTime(2023, 8, 2),
                ComputerTechType = "Ноутбук",
                ComputerTechModel = "ASUS ROG Strix G15 G513RW-HQ177 серый",
                ProblemDescription = "Не загружается система",
                RequestStatus = "Новая заявка",
                CompletionDate = null
            }
        };
    }
}