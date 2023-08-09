namespace Frends.MicrosoftDynamics.CreateRecord.Definitions;

/// <summary>
/// Task's result.
/// </summary>
public class Result
{
    /// <summary>
    /// Operation complete without errors.
    /// </summary>
    /// <example>true</example>
    public bool Success { get; private set; }

    /// <summary>
    /// New entity ID.
    /// </summary>
    /// <example>f47ac10b-58cc-4372-a567-0e02b2c3d479</example>
    public string EntityId { get; private set; }

    /// <summary>
    /// Error message.
    /// This value is generated when an exception occurs and Options.ThrowOnException = false.
    /// </summary>
    /// <example>An error occured...</example>
    public string ErrorMessage { get; private set; }

    internal Result(bool success, string entityId, string errorMessage)
    {
        Success = success;
        EntityId = entityId;
        ErrorMessage = errorMessage;
    }
}