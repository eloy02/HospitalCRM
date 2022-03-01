namespace HospitalCRM.Core.Model;

public sealed class PacientParent : PersonBase
{
    public long Id { get; set; }
    public long PacientId { get; set; }
    public string PhoneNumber { get; set; }
}