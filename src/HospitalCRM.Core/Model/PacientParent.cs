namespace HospitalCRM.Core.Model;

public sealed class PacientParent : IPersonBase
{
    public long Id { get; set; }
    
    public long PacientId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PatronymicName { get; set; }
    
    public string PhoneNumber { get; set; }

    public string FullName => $"{LastName} {FirstName} {PatronymicName}";

    public Pacient Pacient { get; set; }
}