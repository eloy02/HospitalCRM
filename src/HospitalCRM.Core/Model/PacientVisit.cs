namespace HospitalCRM.Core.Model;

public sealed class PacientVisit
{
    public long Id { get; set; }
    public Pacient Pacient { get; set; }
    public Doctor Doctor { get; set; }
    public DateTimeOffset VisitDate { get; set; }
}