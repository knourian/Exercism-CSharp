public class RationalNumbersTests
{
    [Fact]
    public void Add_two_positive_rational_numbers()
    {
        Assert.Equal(new RationalNumber(7, 6), new RationalNumber(1, 2) + new RationalNumber(2, 3));
    }

    [Fact]
    public void Add_a_positive_rational_number_and_a_negative_rational_number()
    {
        Assert.Equal(new RationalNumber(-1, 6), new RationalNumber(1, 2) + new RationalNumber(-2, 3));
    }

    [Fact]
    public void Add_two_negative_rational_numbers()
    {
        Assert.Equal(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
    }

    [Fact]
    public void Add_a_rational_number_to_its_additive_inverse()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(1, 2) + new RationalNumber(-1, 2));
    }

    [Fact]
    public void Subtract_two_positive_rational_numbers()
    {
        Assert.Equal(new RationalNumber(-1, 6), new RationalNumber(1, 2) - new RationalNumber(2, 3));
    }

    [Fact]
    public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
    {
        Assert.Equal(new RationalNumber(7, 6), new RationalNumber(1, 2) - new RationalNumber(-2, 3));
    }

    [Fact]
    public void Subtract_two_negative_rational_numbers()
    {
        Assert.Equal(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
    }

    [Fact]
    public void Subtract_a_rational_number_from_itself()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(1, 2) - new RationalNumber(1, 2));
    }

    [Fact]
    public void Multiply_two_positive_rational_numbers()
    {
        Assert.Equal(new RationalNumber(1, 3), new RationalNumber(1, 2) * new RationalNumber(2, 3));
    }

    [Fact]
    public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
    {
        Assert.Equal(new RationalNumber(-1, 3), new RationalNumber(-1, 2) * new RationalNumber(2, 3));
    }

    [Fact]
    public void Multiply_two_negative_rational_numbers()
    {
        Assert.Equal(new RationalNumber(1, 3), new RationalNumber(-1, 2) * new RationalNumber(-2, 3));
    }

    [Fact]
    public void Multiply_a_rational_number_by_its_reciprocal()
    {
        Assert.Equal(new RationalNumber(1, 1), new RationalNumber(1, 2) * new RationalNumber(2, 1));
    }

    [Fact]
    public void Multiply_a_rational_number_by_1()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(1, 2) * new RationalNumber(1, 1));
    }

    [Fact]
    public void Multiply_a_rational_number_by_0()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 1));
    }

    [Fact]
    public void Divide_two_positive_rational_numbers()
    {
        Assert.Equal(new RationalNumber(3, 4), new RationalNumber(1, 2) / new RationalNumber(2, 3));
    }

    [Fact]
    public void Divide_a_positive_rational_number_by_a_negative_rational_number()
    {
        Assert.Equal(new RationalNumber(-3, 4), new RationalNumber(1, 2) / new RationalNumber(-2, 3));
    }

    [Fact]
    public void Divide_two_negative_rational_numbers()
    {
        Assert.Equal(new RationalNumber(3, 4), new RationalNumber(-1, 2) / new RationalNumber(-2, 3));
    }

    [Fact]
    public void Divide_a_rational_number_by_1()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(1, 2) / new RationalNumber(1, 1));
    }

    [Fact]
    public void Absolute_value_of_a_positive_rational_number()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(1, 2).Abs());
    }

    [Fact]
    public void Absolute_value_of_a_positive_rational_number_with_negative_numerator_and_denominator()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(-1, -2).Abs());
    }

    [Fact]
    public void Absolute_value_of_a_negative_rational_number()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(-1, 2).Abs());
    }

    [Fact]
    public void Absolute_value_of_a_negative_rational_number_with_negative_denominator()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(1, -2).Abs());
    }

    [Fact]
    public void Absolute_value_of_zero()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(0, 1).Abs());
    }

    [Fact]
    public void Absolute_value_of_a_rational_number_is_reduced_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(2, 4).Abs());
    }

    [Fact]
    public void Raise_a_positive_rational_number_to_a_positive_integer_power()
    {
        Assert.Equal(new RationalNumber(1, 8), new RationalNumber(1, 2).Exprational(3));
    }

    [Fact]
    public void Raise_a_negative_rational_number_to_a_positive_integer_power()
    {
        Assert.Equal(new RationalNumber(-1, 8), new RationalNumber(-1, 2).Exprational(3));
    }

    [Fact]
    public void Raise_a_positive_rational_number_to_a_negative_integer_power()
    {
        Assert.Equal(new RationalNumber(25, 9), new RationalNumber(3, 5).Exprational(-2));
    }

    [Fact]
    public void Raise_a_negative_rational_number_to_an_even_negative_integer_power()
    {
        Assert.Equal(new RationalNumber(25, 9), new RationalNumber(-3, 5).Exprational(-2));
    }

    [Fact]
    public void Raise_a_negative_rational_number_to_an_odd_negative_integer_power()
    {
        Assert.Equal(new RationalNumber(-125, 27), new RationalNumber(-3, 5).Exprational(-3));
    }

    [Fact]
    public void Raise_zero_to_an_integer_power()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(0, 1).Exprational(5));
    }

    [Fact]
    public void Raise_one_to_an_integer_power()
    {
        Assert.Equal(new RationalNumber(1, 1), new RationalNumber(1, 1).Exprational(4));
    }

    [Fact]
    public void Raise_a_positive_rational_number_to_the_power_of_zero()
    {
        Assert.Equal(new RationalNumber(1, 1), new RationalNumber(1, 2).Exprational(0));
    }

    [Fact]
    public void Raise_a_negative_rational_number_to_the_power_of_zero()
    {
        Assert.Equal(new RationalNumber(1, 1), new RationalNumber(-1, 2).Exprational(0));
    }

    [Fact]
    public void Raise_a_real_number_to_a_positive_rational_number()
    {
        Assert.Equal(16.0, 8.Expreal(new RationalNumber(4, 3)), precision: 7);
    }

    [Fact]
    public void Raise_a_real_number_to_a_negative_rational_number()
    {
        Assert.Equal(0.3333333333333333, 9.Expreal(new RationalNumber(-1, 2)), precision: 7);
    }

    [Fact]
    public void Raise_a_real_number_to_a_zero_rational_number()
    {
        Assert.Equal(1.0, 2.Expreal(new RationalNumber(0, 1)), precision: 7);
    }

    [Fact]
    public void Reduce_a_positive_rational_number_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce());
    }

    [Fact]
    public void Reduce_places_the_minus_sign_on_the_numerator()
    {
        Assert.Equal(new RationalNumber(-3, 4), new RationalNumber(3, -4).Reduce());
    }

    [Fact]
    public void Reduce_a_negative_rational_number_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(-2, 3), new RationalNumber(-4, 6).Reduce());
    }

    [Fact]
    public void Reduce_a_rational_number_with_a_negative_denominator_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(-1, 3), new RationalNumber(3, -9).Reduce());
    }

    [Fact]
    public void Reduce_zero_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(0, 1), new RationalNumber(0, 6).Reduce());
    }

    [Fact]
    public void Reduce_an_integer_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(-2, 1), new RationalNumber(-14, 7).Reduce());
    }

    [Fact]
    public void Reduce_one_to_lowest_terms()
    {
        Assert.Equal(new RationalNumber(1, 1), new RationalNumber(13, 13).Reduce());
    }
}
