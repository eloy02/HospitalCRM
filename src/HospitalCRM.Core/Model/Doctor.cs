namespace HospitalCRM.Core.Model;

public sealed class Doctor : PersonBase
{
    public long Id { get; set; }
    public bool IsActive { get; set; }
    public string Position { get; set; }
}