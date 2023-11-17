namespace Sensor.Domain.ValueObject; 

public class GraphRowId: Model.ValueObject {
    public required long Value { get; set; }
    internal override IEnumerable<object> GetEquality() {
        yield return Value;
    }
}