using Core.Entities.Students;
using System.Diagnostics.CodeAnalysis;

namespace Core.Abstractions;

public class Result
{
    protected Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None)
        {
            throw new InvalidOperationException();
        }

        if (!isSuccess && error == Error.None)
        {
            throw new InvalidOperationException();
        }

        ISuccess = isSuccess;
        Error = error;

    }
    public bool ISuccess { get; }
    public bool IsFailure => !ISuccess;
    public Error Error { get; }

    public static Result Success()
        => new(true, Error.None);

    public static Result Failure(Error error)
        => new(false, error);

    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);
    public static Result<TValue> Failure<TValue>(Error error) => new(default, false, error);

    public static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>(Error.None);
}

public class Result<TValue> : Result
{
    private readonly TValue? _value;

    protected internal Result(TValue? value, bool isSuccess, Error error) : base(isSuccess, error)
    {
        _value = value;
    }

    [NotNull]
    public TValue Value => ISuccess
        ? _value!
        : throw new InvalidOperationException("The value of a failure can not be accessed");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);

    public static explicit operator Result<TValue>(Result<List<Student>> v)
    {
        throw new NotImplementedException();
    }
}