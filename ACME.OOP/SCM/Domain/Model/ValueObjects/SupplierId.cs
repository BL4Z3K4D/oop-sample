namespace oop_sample.SCM.Domain.Model.ValueObjects;
/// <summary>
/// Represents a supplier identifier value object in the Supply Chain Management (SCM) bounded context.
/// </summary>
public record SupplierId
{
    public string Identifier { get; init; }
    /// <summary>
    /// Creates a new instance of <see cref="SupplierId"/>
    /// </summary>
    /// <param name="identifier">The uniqye identifier for the supplier. Must not </param>
    /// <exception cref="ArgumentNullException">Thrown</exception>
    public SupplierId(string identifier)
    {
        if(string.IsNullOrWhiteSpace(identifier))
            throw new ArgumentNullException("SupplierId cannot be null or empty.",nameof(identifier));
        Identifier = identifier;
    }
    
}