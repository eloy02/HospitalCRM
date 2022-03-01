namespace HospitalCRM.Core.Model;

public sealed class User : PersonBase
{
    public long Id { get; set; }
    public bool IsActive { get; set; }
    public UserType UserType { get; set; }
    public string Password { get; set; }
}

public enum UserType : byte
{
    Hospital,
    RehabilitationCenter
}