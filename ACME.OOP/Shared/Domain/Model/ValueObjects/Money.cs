namespace ACME.OOP.Shared.Domain.Model.ValueObjects;
/// <summary>
/// Represents a Money value object containing amount and international currency code (ISO 4217)
/// </summary>
public record Money
{
    /// <summary>
    /// Creates a new Instance of <see cref="Money"/>
    /// </summary>
    /// <param name="amount">The amount for the money value object.</param>
    /// <param name="currency">The international currency code (ISO 4217) for the money vale object. If given, it must be a valid 3-letter code.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided currency  code is null, empty, whtespace, or no valid 3-letter ISO code</exception>
    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = string.IsNullOrWhiteSpace(currency) || currency.Length != 3 
            ? throw new ArgumentNullException("Currency must be a valid 3-letter ISO code",nameof(currency))
            : currency;
    }
    /// <summary>
    /// Provides a string representation  for the <see cref="Money"/> value 
    /// </summary>
    /// <returns>A string in the format of "Amount Currency",e.g., "100.00 USD"</returns>
    public override string ToString() => $"{Amount} {Currency}";

    /// <summary>
    /// Adds two <see cref="Money"/> object to add. It can be null, in witch case the original <see cref="Money"/> object is reurned.</param>
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException">Thrown when the other <see cref="Money"/> object is provided</exception>
    public Money Add(Money? other)
    {
        if (other is not null && other.Currency != Currency)
            throw new ArgumentException("Cannot add more than one money");
        return other ==null ? this :   new Money(Amount + other.Amount, Currency);
    }
/// <summary>
/// Multiplies the amount of the <see cref="Money"/> object by a given multiplier. The currency remains unchanged.
/// </summary>
/// <param name="multiplier">The multiplier to apply to the amount. It can be any integer, includding negative values and </param>
/// <returns></returns>
    public Money Multiply(int multiplier) => new Money(Amount * multiplier, Currency);

    public decimal  Amount {get; init;}
    public  string  Currency {get; init;}
    

    
}