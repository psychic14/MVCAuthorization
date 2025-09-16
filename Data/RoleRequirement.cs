using Microsoft.AspNetCore.Authorization;

namespace MVCAuthorization.Data
{
    public class RoleRequirement : IAuthorizationRequirement
    {
        public string Role { get; }
        public string Table { get; }
        public string Action { get; } // Create / Read / Update / Delete

        public RoleRequirement(string role, string table, string action)
        {
            Role = role;
            Table = table;
            Action = action;
        }
    }
}
