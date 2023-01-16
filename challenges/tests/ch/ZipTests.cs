namespace RamanM.DotNet.Challenges.Tests;

public class ZipTests
{
    [Fact]
    public void Compress_OneCharString_DoesNotCompress()
    {
        // Arrange
        var input = "A";
        var sut = new Zip();

        // Act
        var actual = sut.Compress(input);

        // Assert
        Assert.Equal("A", actual);
    }

    [Fact]
    public void Compress_TwoDifferentChars_DoesNotCompress()
    {
        // Arrange
        var input = "AB";
        var sut = new Zip();

        // Act
        var actual = sut.Compress(input);

        // Assert
        Assert.Equal("AB", actual);
    }

    [Fact]
    public void Compress_AtLeast2SameChars_CompressesData()
    {
        // Arrange
        var input = "AA";
        var sut = new Zip();

        // Act
        var actual = sut.Compress(input);

        // Assert
        Assert.Equal("2A", actual);
    }

    [Fact]
    public void Compress_RegularString_CompressesData()
    {
        // Arrange
        var input = "AzGGG jj UUUUUUUsTtTTTTT xbbbb 18 AAAaaAAAAaaaa zz.";
        var sut = new Zip();

        // Act
        var actual = sut.Compress(input);

        // Assert
        Assert.Equal("Az3G 2j 7UsTt5T x4b 18 3A2a4A4a 2z.", actual);
    }
}
