using Microsoft.Maui.Controls.Shapes;

namespace DotNetEightUnderline
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AddPath();
        }
        void AddPath()
        {
            Line strikeOutLine = new Line();
            strikeOutLine.BackgroundColor = Colors.Red;
            strikeOutLine.StrokeThickness = 1;
            MainLayout.SetLayoutBounds(strikeOutLine, new Rect(30, 30, 900, 5));
            MainLayout.Add(strikeOutLine);
        }
    }

}
