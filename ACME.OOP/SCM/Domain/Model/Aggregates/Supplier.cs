using ACME.OOP.SCM.Domain.Model.ValueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates;
/// <summary>
/// Represents a supplier aggregate in the Supply Chain Management (SCM) domain.
/// A supplier is a entity that provides good or services to the organization.
/// </summary>
/// <param name="identifier">The supplier's unique identifier. This is a required field and must not be a null</param>
/// <param name="name">The name of the supplier. This is a required field and must not be null</param>
/// <param name="address">The addres of the suplier </param>

public record Supplier(string identifier, string name, Address address)
{
    public SupplierId Id { get; } = string.IsNullOrWhiteSpace(identifier)
        ? throw new ArgumentNullException("Supplier identifier must be provided", nameof(identifier))
        : new SupplierId(identifier);
    public string Name {get;} = name ?? throw new ArgumentNullException("Supplier name must be provided", nameof(name));
    public Address Address { get; } = address ?? throw new ArgumentNullException(nameof(address));
}