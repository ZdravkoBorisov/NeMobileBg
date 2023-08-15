namespace NeMobileBg.Common;

public class Result<T>
{
    public bool Succeeded { get; private set; }

    public bool Failure => !Succeeded;

    public string Error { get; private set; } = default!;

    public T Data { get; private set; } = default!;

    public static implicit operator Result<T>(Exception errors)
        => new()
        {
            Succeeded = false,
            Error = errors.ToString(),
        };


    public static implicit operator Result<T>(T result)
        => new()
        {
            Succeeded = true,
            Data = result
        };
}
