namespace Core.Entities.Addresses;

public record Address(
    Country Country, State State,
    ZipCode ZipCode, City City,
    Street Street);
