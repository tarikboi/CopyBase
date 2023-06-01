using System.ComponentModel.DataAnnotations;

namespace CopyBase.Data_Layer.DataModel.EGT.mitDk
{
    internal class EGTTransmission
    {
        [Key]
        public int EGTTransmissionId { get; set; }
        public string TransmissionGUID { get; set; }
        public string HostFileName { get; set; }
        public string SentFileName { get; set; }
        public DateTime HostTimeStamp { get; set; }
        public string MitDkMailbox { get; set; }
        public int ExportedPayslips { get; set; }
        public int ImportedConversionReceipts { get; set; }
        public int ImportedBusinessReceipts { get; set; }
        public int ReceiptWarnings { get; set; }
        public int MissingBusinessReceipts { get; set; }
        public int FailedPayslips { get; set; }
        public int OKPayslips { get; set; }
        public string TechnicalReceiptStatus { get; set; }
        public DateTime TechnicalReceiptUpdateTimeStamp { get; set; }
        public string ConversionFileStatus { get; set; }
        public DateTime ConversionFileUpdateTimeStamp { get; set; }
        public bool AlertSent { get; set; }
    }
}