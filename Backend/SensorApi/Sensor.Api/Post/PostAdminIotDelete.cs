using Sensor.Service.AttachmentService.Interface;
using Sensor.Service.Port.Interface;

namespace Sensor.Api.Post; 

public class PostAdminIotDelete: IInputAdminIotDelete, IInput {
    public required string IotId { get; init; }
}