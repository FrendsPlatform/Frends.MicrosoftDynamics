using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.MicrosoftDynamics.CreateRecord.Definitions;

/// <summary>
/// Input parameters.
/// </summary>
public class Input
{
    /// <summary>
    /// Dataverse Connection String.
    /// </summary>
    /// <example>AuthType=Office365;Username=user;Password=passcode;Url=url</example>
    [PasswordPropertyText]
    [DisplayFormat(DataFormatString = "Text")]
    public string ConnectionString { get; set; }

    /// <summary>
    /// Entity logical name in Dynamics 365.
    /// </summary>
    /// <example>contacts</example>
    public string EntityLogicalName { get; set; }

    /// <summary>
    /// Entity parameters.
    /// </summary>
    /// <example>[
    /// { Name = "first_name", Value = "John" },
    /// { Name = "last_name", Value = "Doe" }
    /// ]</example>
    public EntityParameter[] Parameters { get; set; }
}

/// <summary>
/// Procedure parameter.
/// </summary>
public class EntityParameter
{
    /// <summary>
    /// The name of the parameter.
    /// </summary>
    /// <example>first_name</example>
    public string Name { get; set; }

    /// <summary>
    /// The value of the parameter.
    /// </summary>
    /// <example>FirstName</example>
    public string Value { get; set; }
}