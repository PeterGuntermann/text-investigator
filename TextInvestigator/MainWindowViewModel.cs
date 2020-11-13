namespace TextInvestigator
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            TextToInvestigate = "Insert text here that needs to be investigated.";
        }

        public string TextToInvestigate { get; set; }
    }
}