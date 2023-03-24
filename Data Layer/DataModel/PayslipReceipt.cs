using System.ComponentModel.DataAnnotations;

namespace CopyBase.Data_Layer.DataModel
{
    internal class PayslipReceipt
    {
        [Key]
        public int PayslipReceiptId { get; set; }
        public int EGTTransmissionId { get; set; }
        public string MessageId { get; set; }
        

    }
}




//public int ServiceAgencyId { get; set; }
//public int EmployerId { get; set; }
//public int EmployeeId { get; set; }
//public string MessageUUID { get; set; }
//public string ErrorCode { get; set; }
//public string ErrorMessage { get; set; }
//public string WarningCode { get; set; }
//public string WarningMessage { get; set; }
//public string ReceiptStatus { get; set; }
//public DateTime CreationTimeStamp { get; set; }
//public DateTime ConversionReceiptUpdateTimeStamp { get; set; }
//public DateTime TechnicalReceiptUpdateTimeStamp { get; set; }