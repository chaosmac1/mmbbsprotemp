namespace Sensor.Domain.ValueObject;

public class UserToken: Model.ValueObject {
    public required string Value { get; set; }

    internal override IEnumerable<object> GetEquality() {
        yield return Value;
    }

    public static UserToken NewUserToken() => new() { Value = LamLibAllOver.RandomText.NextAZaz09(64) };
}