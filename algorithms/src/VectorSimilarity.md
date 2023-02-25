> Algorithm
# Vector Similarity
[Cosine similarity](https://en.wikipedia.org/wiki/Cosine_similarity)[^1] is a measure of similarity between two vectors 
of **n** dimensions by finding the cosine of the angle between them, often used to compare documents in text mining. 
In addition, it is used to measure cohesion within clusters in the field of Data Mining[^1].

Given two **n**-dimensional vectors of attributes, **A** and **B**, the cosine similarity, cos(θ), is represented 
using a dot product and magnitude as: 
```math
$$\frac{A\cdot B}{mag(A) \times mag(B)}$$
```
The dot product of two vectors is the sum of the products of the corresponding entries of the two sequences of numbers.<br/>
The magnitude of a vector $x = [x_1, x_2, ..., x_n]$ is defined as
```math
\Vert x \Vert = \sqrt{x^2_1 + x^2_2 + ... + x^2_n}
```
In many applications, the elements of a vector have mostly zero values. Such a vector is said to be sparse. A way to 
represent a sparse vector, conserving space, is to store only the non-zero elements and their indexes, ordered by 
increasing index values. For example, the following vector: `{0, 0, 7, 0, 5, 12, 0, 0, 1}` can be stored as 
the following key-value pairs: `{(2,7), (4,5), (5,12), (8,1)}`.

Need to implement a function that computes the cosine similarity between two sparse vectors **a** and **b**. <br/>
Here is an example of the function signature in C#:
```csharp
double CosineSimilarity(List<int> aKeys, List<double> aValues, List<int> bKeys, List<double> bValues);
```
Note that the keys and values of each array are provided as separate arrays. 
For example, if **a** is `{(2,7), (4,5), (5,12), (8,1)}`, the corresponding inputs will be:
```
aKeys = [2, 4, 5, 8];
aValues = [7, 5, 12, 1];
```
The sparse vector keys (the elements of `aKeys` and `bKeys`) are non-negative integers. You can assume that each 
vector's keys are sorted, and that every key is unique within each vector, that the magnitude is greater than zero 
and finally that all values are finite non-zero floating point numbers (i.e. not Infinity nor NaN).

The implementation must have O(N) complexity, where N is the length of the union of the keys of **a** and **b**.

## Open source implementations
[@taki0112/Vector_Similarity](https://github.com/taki0112/Vector_Similarity):[^2] Python, Java implementation of TS-SS called from "A Hybrid Geometric Approach for Measuring Similarity Level Among Documents and Document Clustering".
- Implemented in Java: `Vector_Similarity.Cosine` function in [Vector_Similarity.java, Line 12](https://github.com/taki0112/Vector_Similarity/blob/master/java/TS_SS/src/Vector_Similarity.java#L12)
- Implemented in Python: `Cosine(vec1, vec2)` function in [Vector_Similarity.py, Line 3](https://github.com/taki0112/Vector_Similarity/blob/master/python/TS_SS/Vector_Similarity.py#L3)

### References
[^1]: Wikipedia: [Cosine similarity](https://en.wikipedia.org/wiki/Cosine_similarity)
[^2]: GitHub: [taki0112/Vector_Similarity](https://github.com/taki0112/Vector_Similarity) by [Junho Kim](https://github.com/taki0112)
