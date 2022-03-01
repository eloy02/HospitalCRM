namespace HospitalCRM.Core.Model;

public sealed class Doctor : IPersonBase
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PatronymicName { get; set; }
    public string Position { get; set; }
    public bool IsActive { get; set; }
    public string FullName { get; }
}
