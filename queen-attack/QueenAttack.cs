public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }

    public bool CanAttack(Queen other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        return Row == other.Row || Column == other.Column || Math.Abs(Row - other.Row) == Math.Abs(Column - other.Column);
    }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black) => white.CanAttack(black);

    public static Queen Create(int row, int column)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(row, 0, nameof(row));
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(row, 8, nameof(row));

        ArgumentOutOfRangeException.ThrowIfLessThan(column, 0, nameof(column));
        ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual(column, 8, nameof(column));
        return new Queen(row, column);
    }
}