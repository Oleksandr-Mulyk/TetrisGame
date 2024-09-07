namespace Cooconica.TetrisGame
{
    public struct Size(int width, int height)
    {
        public int Width { get; set; } = width;

        public int Height { get; set; } = height;
    }
}
