namespace ACME.OOP.Shared.Domain.Model.ValueObjects;

/// <summary>
/// Represents an international phisical address value object.
///  
/// </summary>
public record Address
{
    public string Street { get; init; }
    public string Number { get; init; }
    public string City { get; init; }
    public string? StateOrRegion {get; init;}
    public string PostalCode {get; init;}
    public string Country {get; init;}

    /// <summary>
    /// Create a new instance of <see cref="Address"/>
    /// </summary>
    /// <param name="street">The address street,which must not be null or blank.</param>
    /// <param name="number">The address number,which must not be null or blank.</param>
    /// <param name="city">The address city,which must not be null or blank.</param>
    /// <param name="stateOrRegion">The address state or region.</param>
    /// <param name="postalCode">The address postalCode,which must not be null or blank.</param>
    /// <param name="country">The address country,which must not be null or blank.</param>
    /// <exception cref="ArgumentNullException">thrown when any required parameter is null or blank</exception>
    public Address(string street, string number, string city, string? stateOrRegion, string postalCode, string country)
    {
        if(string.IsNullOrWhiteSpace(street)) throw new ArgumentNullException("Street cannot be null or empty", nameof(street));
        if(string.IsNullOrWhiteSpace(number)) throw new ArgumentNullException("Number cannot be null or empty", nameof(number));
        if(string.IsNullOrWhiteSpace(city)) throw new ArgumentNullException("City cannot be null or empty", nameof(city));
        if(string.IsNullOrWhiteSpace(postalCode)) throw new ArgumentNullException("Postal code cannot be null or empty", nameof(postalCode));
        if(string.IsNullOrWhiteSpace(country)) throw new ArgumentNullException("Country cannot be null or empty", nameof(country));
        
        Street = street;
        Number = number;
        City = city;
        StateOrRegion = stateOrRegion;
        PostalCode = postalCode;
        Country = country;
    }
    
    /// <summary>
    /// Provides a string representation for the address.
    /// </summary>
    /// <returns> a string with the format "Street, number, City, StateOrRegion, PostalCode, Country."</returns>
    public override string ToString()=> $"{Street}, {Number}, {City}, {StateOrRegion}, {PostalCode}, {Country}";
}