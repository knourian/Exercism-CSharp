public class QueenAttackTests
{
    [Fact]
    public void Queen_with_a_valid_position()
    {
        var queen = QueenAttack.Create(2, 2);
    }

    [Fact]
    public void Queen_must_have_positive_row()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => QueenAttack.Create(-2, 2));
    }

    [Fact]
    public void Queen_must_have_row_on_board()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => QueenAttack.Create(8, 4));
    }

    [Fact]
    public void Queen_must_have_positive_column()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => QueenAttack.Create(2, -2));
    }

    [Fact]
    public void Queen_must_have_column_on_board()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => QueenAttack.Create(4, 8));
    }

    [Fact]
    public void Cannot_attack()
    {
        var whiteQueen = QueenAttack.Create(2, 4);
        var blackQueen = QueenAttack.Create(6, 6);
        Assert.False(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_same_row()
    {
        var whiteQueen = QueenAttack.Create(2, 4);
        var blackQueen = QueenAttack.Create(2, 6);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_same_column()
    {
        var whiteQueen = QueenAttack.Create(4, 5);
        var blackQueen = QueenAttack.Create(2, 5);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_first_diagonal()
    {
        var whiteQueen = QueenAttack.Create(2, 2);
        var blackQueen = QueenAttack.Create(0, 4);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_second_diagonal()
    {
        var whiteQueen = QueenAttack.Create(2, 2);
        var blackQueen = QueenAttack.Create(3, 1);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_third_diagonal()
    {
        var whiteQueen = QueenAttack.Create(2, 2);
        var blackQueen = QueenAttack.Create(1, 1);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Can_attack_on_fourth_diagonal()
    {
        var whiteQueen = QueenAttack.Create(1, 7);
        var blackQueen = QueenAttack.Create(0, 6);
        Assert.True(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }

    [Fact]
    public void Cannot_attack_if_falling_diagonals_are_only_the_same_when_reflected_across_the_longest_falling_diagonal()
    {
        var whiteQueen = QueenAttack.Create(4, 1);
        var blackQueen = QueenAttack.Create(2, 5);
        Assert.False(QueenAttack.CanAttack(whiteQueen, blackQueen));
    }
}
