namespace HospitalCRM.Core.Model;

public interface IPersonBase
{
    /// <summary>
    ///     Имя
    /// </summary>
    public string FirstName { get; set; }

    /// <summary>
    ///     Фамилия
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    ///     Отчество
    /// </summary>
    public string PatronymicName { get; set; }
    
    /// <summary>
    ///     ФИО
    /// </summary>
    public string FullName { get; }
}