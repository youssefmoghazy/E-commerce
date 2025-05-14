using System.ComponentModel.DataAnnotations;

namespace Shared.SharedTransferObjects.Authentication;

public record RegisterRequest(string Email , string UserName , string Password , string DisplayName , string PhoneNumber);
