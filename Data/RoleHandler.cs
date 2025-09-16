using Microsoft.AspNetCore.Authorization;

namespace MVCAuthorization.Data
{
    public class RoleHandler : AuthorizationHandler<RoleRequirement>
    {
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            RoleRequirement requirement)
        {
            // 先確認使用者角色
            if (!context.User.IsInRole(requirement.Role))
                return Task.CompletedTask;

            // 這裡可以用 Claim 或 DB 設定操作權限
            var allowedActions = context.User.FindAll("Permission")
                                             .Select(c => c.Value)
                                             .ToList();

            // 如果 JWT/Claims 裡有帶操作權限，直接比對
            if (allowedActions.Contains(requirement.Action))
            {
                context.Succeed(requirement);
            }
            else if (requirement.Role == "Admin")
            {
                // Admin 預設有全部權限
                context.Succeed(requirement);
            }
            else if (requirement.Role == "Member" && requirement.Table == "Product" && requirement.Action == "Read")
            {
                // Member 只能 Read Product
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
