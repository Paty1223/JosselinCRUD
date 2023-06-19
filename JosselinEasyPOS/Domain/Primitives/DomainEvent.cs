using  MediatR;
using MediatR.Extensions;

namespace Domain.primitives;

public record DomainEvent(Guid Id) : INotification;