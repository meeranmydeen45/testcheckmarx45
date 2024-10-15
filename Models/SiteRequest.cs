using System.ComponentModel.DataAnnotations;

namespace WebApplicationWebAppCheckMarx.Models
{
    public class SiteRequest
    {
        public long PlantId { get; set; }
        public int ApprovalRequestTypeId { get; set; }
        //public string Description { get; set; }
        public decimal? Freight { get; set; }
        public decimal? MarkupPercentage { get; set; }
       // public string PONumber { get; set; }
        public byte Status { get; set; }
        public List<SiteChildRequest> Items { get; set; }
    }

    public class SiteChildRequest
    {
        public long CartId { get; set; }
        public DateTime RequestDeliveryDate { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public long ShipToId { get; set; }
        public int SalesOrgId { get; set; }
        //public string Comment { get; set; }
        //public string DeliveryAddress { get; set; }
       // public string Supplier { get; set; }
       // public string VendorId { get; set; }
    }
}
