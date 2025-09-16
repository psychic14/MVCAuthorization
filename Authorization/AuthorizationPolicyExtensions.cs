using Microsoft.AspNetCore.Authorization;
using MVCAuthorization.Data;

namespace MVCAuthorization.Authorization
{
    public static class AuthorizationPolicyExtensions
    {
        public static void AddRolePolicies(this AuthorizationOptions options)
        {
            var roles = new[] { "Admin", "Member" };
            var tables = new[] { "Member", "Product", "Order", "OrderDetail" };
            var actions = new[] { "Create", "Read", "Update", "Delete" };

            foreach (var role in roles)
            {
                foreach (var table in tables)
                {
                    foreach (var action in actions)
                    {
                        var policyName = $"{role}_{table}_{action}";
                        options.AddPolicy(policyName, policy =>
                        {
                            policy.Requirements.Add(new RoleRequirement(role, table, action));
                        });
                    }
                }
            }
        }
    }
}

