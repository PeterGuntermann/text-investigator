namespace TextInvestigator
{
    using System;
    using OxyPlot;
    using OxyPlot.Series;

    public class MainViewModel
    {
        public MainViewModel()
        {
            TextToInvestigate = "Insert text here that needs to be investigated.";
            MyModel = new PlotModel {Title = "Text Investigator"};
            MyModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
        }

        public string TextToInvestigate { get; set; }
        public PlotModel MyModel { get; private set; }
    }
}