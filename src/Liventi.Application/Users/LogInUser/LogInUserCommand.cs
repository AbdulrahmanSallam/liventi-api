using Liventi.Application.Abstractions.Messaging;

namespace Liventi.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;