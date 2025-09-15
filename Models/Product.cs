using System.ComponentModel;

namespace MVCAuthorization.Models
{
    public class Product
    {
        public int Id { get; set; }

        [DisplayName("產品編號")]
        public string ProductId { get; set; }

        [DisplayName("品名")]
        public string Name { get; set; }

        [DisplayName("單價")]
        public Nullable<int> Price { get; set; }

        [DisplayName("圖示")]
        public string Image { get; set; }

    }
}
