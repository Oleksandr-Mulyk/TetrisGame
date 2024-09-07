﻿namespace Cooconica.TetrisGame.Figures
{
    public sealed class L90Figure : Figure
    {
        public L90Figure()
        {
            Coordinates = [new(2, 1), new(0, 2), new(1, 2), new(2, 2)];
        }

        protected override Figure Rotated => new L180Figure();
    }
}
