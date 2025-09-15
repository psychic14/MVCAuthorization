using System.ComponentModel;

namespace MVCAuthorization.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }

        [DisplayName("會員帳號")]
        public string UserId { get; set; }

        [DisplayName("產品編號")]
        public string ProductId { get; set; }

        [DisplayName("品名")]
        public string Name { get; set; }

        [DisplayName("單價")]
        public Nullable<int> Price { get; set; }

        [DisplayName("訂購數量")]
        public Nullable<int> Quantity { get; set; }

        [DisplayName("是否形成訂單")]
        public string IsApproved { get; set; }
    }
}
