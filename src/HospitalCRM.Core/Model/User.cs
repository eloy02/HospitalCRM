namespace HospitalCRM.Core.Model;

public sealed class User : IPersonBase
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PatronymicName { get; set; }
    public bool IsActive { get; set; }
    public UserType UserType { get; set; }
    public string Password { get; set; }
    public string FullName => $"{LastName} {FirstName} {PatronymicName}";
}

public enum UserType : byte
{
    Hospital,
    RehabilitationCenter
}