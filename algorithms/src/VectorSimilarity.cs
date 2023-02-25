namespace RamanM.DotNet.Algorithms;

public class VectorSimilarity
{
    public static double CosineSimilarity(List<int> aKeys, List<double> aValues, List<int> bKeys, List<double> bValues)
    {
        // (A dot B) / (mag(a) * mag(b))
        double dividend = Dot(aKeys, aValues, bKeys, bValues);
        double divisor = Magnitude(aValues) * Magnitude(bValues);
        return dividend / divisor;
    }

    public static double Dot(List<int> aKeys, List<double> aValues, List<int> bKeys, List<double> bValues)
    {
        List<double> products = new List<double>();
        List<int> indexes = aKeys.Union(bKeys)
            .Distinct().OrderBy(k => k)
            .ToList();
        foreach (int i in indexes)
        {
            if (aKeys.Contains(i) && bKeys.Contains(i)) // product will be non-zero
            {
                // Index pointers for O(union(a,b)) processing
                int iA = aKeys.IndexOf(i); // convert back the index to an index of A vector lists 
                int iB = bKeys.IndexOf(i); // convert back the index to an index of B vector lists

                // Make non-zero product for i-th coordinate
                var product = aValues[iA] * bValues[iB];
                products.Add(product);
            }
        }
        return products.Sum();
    }

    public static double Magnitude(List<double> coordinates)
    {
        double sum = coordinates.Select(x => x * x).Sum();
        return Math.Sqrt(sum);
    }
}
