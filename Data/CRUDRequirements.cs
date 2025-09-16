using Microsoft.AspNetCore.Authorization;

namespace MVCAuthorization.Data
{
    public class CRUDRequirements
    {
        // Member
        public class CreateMemberRequirement : IAuthorizationRequirement { }
        public class ReadMemberRequirement : IAuthorizationRequirement { }
        public class UpdateMemberRequirement : IAuthorizationRequirement { }
        public class DeleteMemberRequirement : IAuthorizationRequirement { }
        // Order
        public class CreateOrderRequirement : IAuthorizationRequirement { }
        public class ReadOrderRequirement : IAuthorizationRequirement { }
        public class UpdateOrderRequirement : IAuthorizationRequirement { }
        public class DeleteOrderRequirement : IAuthorizationRequirement { }
        // OrderDetail
        public class CreateOrderDetailRequirement : IAuthorizationRequirement { }
        public class ReadOrderDetailRequirement : IAuthorizationRequirement { }
        public class UpdateOrderDetailRequirement : IAuthorizationRequirement { }
        public class DeleteOrderDetailRequirement : IAuthorizationRequirement { }
        // Product
        public class CreateProductRequirement : IAuthorizationRequirement { }
        public class ReadProductRequirement : IAuthorizationRequirement { }
        public class UpdateProductRequirement : IAuthorizationRequirement { }
        public class DeleteProductRequirement : IAuthorizationRequirement { }
    }
}
