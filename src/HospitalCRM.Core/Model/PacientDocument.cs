namespace HospitalCRM.Core.Model;

public sealed class PacientDocument
{
    public long Id { get; set; }
    public long PacientId { get; set; }
    public byte[] Data { get; set; }
}