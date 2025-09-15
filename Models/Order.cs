using System.ComponentModel;

namespace MVCAuthorization.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DisplayName("訂單編號")]
        public string OrderGuid { get; set; }
        [DisplayName("會員帳號")]
        public string UserId { get; set; }
        [DisplayName("收件人姓名")]
        public string Receiver { get; set; }
        [DisplayName("收件人信箱")]
        public string Email { get; set; }
        [DisplayName("收件人地址")]
        public string Address { get; set; }
        [DisplayName("訂單日期")]
        public DateTime Date { get; set; }
    }
}
