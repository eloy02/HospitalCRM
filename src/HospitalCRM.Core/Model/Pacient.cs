namespace HospitalCRM.Core.Model;

public sealed class Pacient : PersonBase
{
    public long Id { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string BuildingNumber { get; set; }
    public string FlatNumber { get; set; }
    public string PhoneNumber { get; set; }
    public bool IsChild { get; set; }
    public List<PacientParent> Parents { get; set; }
    public List<PacientDocument> Documents { get; set; }
}