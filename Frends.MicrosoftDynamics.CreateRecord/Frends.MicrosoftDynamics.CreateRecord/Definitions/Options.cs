using System.ComponentModel;

namespace Frends.MicrosoftDynamics.CreateRecord.Definitions;

/// <summary>
/// Optional parameters.
/// </summary>
public class Options
{
    /// <summary>
    /// (true) Throw an exception or (false) stop the Task and return result object containing Result.Success = false and Result.ErrorMessage = 'exception message'.
    /// </summary>
    /// <example>true</example>
    [DefaultValue(true)]
    public bool ThrowOnException { get; set; }

    /// <summary>
    /// Maximum number of times the client will attempt to retry a failed operation.
    /// </summary>
    /// <example>10</example>
    [DefaultValue(10)]
    public int MaxRetryCount { get; set; }

    /// <summary>
    /// Duration of time in seconds the client waits between retry attempts when encountering a transient error.
    /// </summary>
    /// <example>2</example>
    [DefaultValue(2)]
    public int RetryPauseTime { get; set; }
}