public class AllYourBaseTests
{
    [Fact]
    public void Single_bit_one_to_decimal()
    {
        int[] digits = [1];
        int[] expected = [1];
        Assert.Equal(expected, AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Binary_to_single_decimal()
    {
        int[] digits = [1, 0, 1];
        int[] expected = [5];
        Assert.Equal(expected, AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Single_decimal_to_binary()
    {
        int[] digits = [5];
        int[] expected = [1, 0, 1];
        Assert.Equal(expected, AllYourBase.Rebase(10, digits, 2));
    }

    [Fact]
    public void Binary_to_multiple_decimal()
    {
        int[] digits = [1, 0, 1, 0, 1, 0];
        int[] expected = [4, 2];
        Assert.Equal(expected, AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Decimal_to_binary()
    {
        int[] digits = [4, 2];
        int[] expected = [1, 0, 1, 0, 1, 0];
        Assert.Equal(expected, AllYourBase.Rebase(10, digits, 2));
    }

    [Fact]
    public void Trinary_to_hexadecimal()
    {
        int[] digits = [1, 1, 2, 0];
        int[] expected = [2, 10];
        Assert.Equal(expected, AllYourBase.Rebase(3, digits, 16));
    }

    [Fact]
    public void Hexadecimal_to_trinary()
    {
        int[] digits = [2, 10];
        int[] expected = [1, 1, 2, 0];
        Assert.Equal(expected, AllYourBase.Rebase(16, digits, 3));
    }

    [Fact]
    public void Fifteen_bit_integer()
    {
        int[] digits = [3, 46, 60];
        int[] expected = [6, 10, 45];
        Assert.Equal(expected, AllYourBase.Rebase(97, digits, 73));
    }

    [Fact]
    public void Empty_list()
    {
        int[] digits = [];
        int[] expected = [0];
        Assert.Equal(expected, AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Single_zero()
    {
        int[] digits = [0];
        int[] expected = [0];
        Assert.Equal(expected, AllYourBase.Rebase(10, digits, 2));
    }

    [Fact]
    public void Multiple_zeros()
    {
        int[] digits = [0, 0, 0];
        int[] expected = [0];
        Assert.Equal(expected, AllYourBase.Rebase(10, digits, 2));
    }

    [Fact]
    public void Leading_zeros()
    {
        int[] digits = [0, 6, 0];
        int[] expected = [4, 2];
        Assert.Equal(expected, AllYourBase.Rebase(7, digits, 10));
    }

    [Fact]
    public void Input_base_is_one()
    {
        int[] digits = [0];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(1, digits, 10));
    }

    [Fact]
    public void Input_base_is_zero()
    {
        int[] digits = [];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(0, digits, 10));
    }

    [Fact]
    public void Input_base_is_negative()
    {
        int[] digits = [1];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(-2, digits, 10));
    }

    [Fact]
    public void Negative_digit()
    {
        int[] digits = [1, -1, 1, 0, 1, 0];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Invalid_positive_digit()
    {
        int[] digits = [1, 2, 1, 0, 1, 0];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(2, digits, 10));
    }

    [Fact]
    public void Output_base_is_one()
    {
        int[] digits = [1, 0, 1, 0, 1, 0];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(2, digits, 1));
    }

    [Fact]
    public void Output_base_is_zero()
    {
        int[] digits = [7];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(10, digits, 0));
    }

    [Fact]
    public void Output_base_is_negative()
    {
        int[] digits = [1];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(2, digits, -7));
    }

    [Fact]
    public void Both_bases_are_negative()
    {
        int[] digits = [1];
        Assert.Throws<ArgumentException>(() => AllYourBase.Rebase(-2, digits, -7));
    }
}
