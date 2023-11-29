namespace Patterns.Adapter.V2;

internal interface IUpToDateService
{
    Task<HandleResult> HandleEvent<TSender, TArgs>(TSender sender, TArgs args);

    Task<ICollection<User>> Filter(IEnumerable<User> users, UserFilter userFilter);
}

class HandleResult
{
    public bool IsSuccess { get; set; }
    public string? ErrorMessage { get; set; }
}

class User { }

class UserFilter
{
    public int MinAge { get; set; }
    public int MaxAge { get; set; }
}
