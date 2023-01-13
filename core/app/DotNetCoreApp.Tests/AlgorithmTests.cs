namespace DotNetCoreApp.Tests;

public class AlgorithmTests
{
    [Fact]
    public void TripleFibonacci_InitialConditions_ValueIsOne()
    {
        // Arrange
        var stepNumbers = new int[3] { 1, 2, 3 };
        var sut = new Algorithm();

        Assert.All(stepNumbers, (stepNo) =>
        {
            // Act
            var actual = sut.TripleFibonacci(stepNo);

            // Assert
            Assert.Equal(1, actual);
        });
    }

    [Fact]
    public void TripleFibonacci_ParamIsGreaterThan3_ValueIsCorrect()
    {
        // Arrange
        var expectedValues = new Dictionary<int, long>()
            {
                { 4, 3 },
                { 5, 5 },
                { 6, 9 },
                { 7, 17 },
                { 8, 31 },
                { 9, 57 }
            };
        var sut = new Algorithm();

        Assert.All(expectedValues, (pair) =>
        {
            // Act
            var actual = sut.TripleFibonacci(pair.Key);

            // Assert
            Assert.Equal(pair.Value, actual);
        });
    }
}
