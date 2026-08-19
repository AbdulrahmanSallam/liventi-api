using Liventi.Application.Abstractions.Messaging;

namespace Liventi.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;