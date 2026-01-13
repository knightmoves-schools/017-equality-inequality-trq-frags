namespace Tests;
using knightmoves;
using Xunit;

public class AutogradingTest
{
 
    [Fact]
    public void Should_Contain_A_Method_Named_PriceCheck_That_Takes_A_Price_That_Is_Of_Type_Double_And_Returns_The_String_Match_If_The_Price_Is_Equivalent_To_1_50(){
        var store = new Store();
        Assert.Equal("match", store.PriceCheck(1.50));
    }

    [Fact]
    public void Should_Return_An_Empty_String_When_1_00_Is_Passed_In_As_An_Argument_To_PriceCheck(){
        var store = new Store();
        Assert.Equal("", store.PriceCheck(1.00));
    }

    [Fact]
    public void Should_Contain_A_Method_Named_GuessNumber_That_Takes_A_Guess_That_Is_Of_Type_Int_And_Returns_The_String_Not_It_If_The_Number_Is_Not_Equivalent_To_25(){
        var store = new Store();
        Assert.Equal("not it", store.GuessNumber(10));
    }

    [Fact]
    public void Should_Return_An_Empty_String_When_The_Number_25_Is_Passed_In_As_An_Argument_To_GuessNumber(){
        var store = new Store();
        Assert.Equal("", store.GuessNumber(25));
    }
}