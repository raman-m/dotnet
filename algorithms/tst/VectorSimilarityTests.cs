namespace RamanM.DotNet.Algorithms.Tests;

public class VectorSimilarityTests
{
    [Fact]
    public void CosineSimilarity_ProportionalVectors_ReturnsOne()
    {
        // Arrange
        var keys3D = new List<int> { 0, 1, 2 }; // A, B are 3D-vectors
        var A = new List<double> { 1, 2, 3 };
        var B = new List<double> { 2, 4, 6 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(keys3D, A, keys3D, B);

        // Assert
        Assert.Equal(1.0D, actual);
    }

    [Fact]
    public void CosineSimilarity_Orthogonal2DVectors_ReturnsZero()
    {
        // Arrange
        List<int> keys3D = new List<int> { 0, 1 }; // A, B are 2D-vectors
        List<double> A = new List<double> { 1, 2 };
        List<double> B = new List<double> { 2, -1 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(keys3D, A, keys3D, B);

        // Assert
        Assert.Equal(0.0D, actual);
    }

    [Fact]
    public void CosineSimilarity_Orthogonal3DVectors_ReturnsZero()
    {
        // Arrange
        List<int> keys3D = new List<int> { 0, 1, 2 }; // A, B are 3D-vectors
        List<double> A = new List<double> { 1, 2, 3 };
        List<double> B = new List<double> { 1, 4, -3 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(keys3D, A, keys3D, B);

        // Assert
        Assert.Equal(0.0D, actual);
    }

    [Fact]
    public void CosineSimilarity_OppositeVectors_ReturnsNegativeOne()
    {
        // Arrange
        List<int> keys3D = new List<int> { 0, 1, 2 }; // A, B are 3D-vectors
        List<double> A = new List<double> { 1, 2, 3 };
        List<double> B = new List<double> { -1, -2, -3 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(keys3D, A, keys3D, B);

        // Assert
        Assert.Equal(-1.0D, actual);
    }

    [Fact]
    public void CosineSimilarity_Example_ReturnsSimilarity()
    {
        // vector: { 0, 0, 7, 0, 5, 12, 0, 0, 1}

        // Arrange
        var keys = new List<int> { 2, 4, 5, 8 }; // A and B vectors have 4 non-zero coordinates
        var A = new List<double> { 7, 5, 12, 1 };
        var B = new List<double> { 1, 1, 1, 1 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(keys, A, keys, B);

        // Assert
        Assert.True(-1.0D <= actual && actual <= 1.0D);
        // 25 / (sqrt(219) * sqrt(4)) = 25 / (0.23650808243982008 * 2) = 0.8446717229993574
        Assert.Equal(0.8446717229993574D, actual, 15);
    }

    [Fact]
    public void CosineSimilarity_Sample_ReturnsSimilarity()
    {
        // Arrange
        var aKeys = new List<int> { 0, 1, 2, 3, 4 }; // A vector N is 5
        var A = new List<double> { 1, 2, 3, 4, 5 };

        var bKeys = new List<int> { 1, 3 }; // B vector N is 5. But non-zero values exist for 2nd and 4th coordinates
        var B = new List<double> { 2, 4 };

        // Act
        double actual = VectorSimilarity.CosineSimilarity(aKeys, A, bKeys, B);

        // Assert
        Assert.True(-1.0D <= actual && actual <= 1.0D);
        // 20 / (7.4161984870956629487113974408007 * 4.4721359549995793928183473374626)
        // = 20 / 33.166247903553998491149327366707 = 0.60302268915552724529362413394012
        Assert.Equal(0.60302268915552724529362413394012D, actual, 15);
    }
}
