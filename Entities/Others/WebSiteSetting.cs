namespace Entities.Others
{
    public class WebSiteSetting : BaseEntity<long>
    {
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public string CartNumber { get; set; }
        public string OrderDescription { get; set; }
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
        public string SMSAccountUrl { get; set; }
        public string SMSAccountUserName { get; set; }
        public string SMSAccountPassword { get; set; }
    }
}
