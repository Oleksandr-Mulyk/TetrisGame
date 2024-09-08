namespace Cooconica.TetrisGame
{
    public interface ITetrisGame
    {
        public event FigureMovedHandler? FigureMoved;

        public event GameOverHandler? GameOver;

        public event FigureChangedHandler? FigureChanged;

        public event ScoreChangedHandler? ScoreChanged;

        public event HiScoreChangedHandler? HiScoreChanged;

        public event SpeedChangedHandler? SpeedChanged;

        public event GlassLinesRemovedHandler? GlassLinesRemoved;

        public ITetrisGlass TetrisGlass { get; set; }

        public Size FigureSize { get; set; }

        public Figure CurrentFigure { get; set; }

        public Figure NextFigure { get; set; }

        public void CreateNewGame();

        public int Score { get; set; }

        public int HiScore { get; set; }

        public int Speed { get; set; }

        public int MaxSpeed { get; set; }

        public int SpeedStep { get; set; }

        public void MoveLeft();

        public void MoveRight();

        public void MoveDown();

        public void Rotate();
    }

    public delegate void FigureMovedHandler(List<Coordinate> oldCoordinates);

    public delegate void GameOverHandler();

    public delegate void FigureChangedHandler();

    public delegate void ScoreChangedHandler();

    public delegate void HiScoreChangedHandler();

    public delegate void SpeedChangedHandler();

    public delegate void GlassLinesRemovedHandler();
}
