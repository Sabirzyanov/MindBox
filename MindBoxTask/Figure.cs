namespace MindBoxLib
{
    public abstract class Figure
    {
        private string _figureName;

        public string FigureName
        {
            get { return _figureName; }
        }
        public Figure(string figureName)
        {
            _figureName = figureName;
        }

        public abstract double CalculateFigureArea();

    }
}