# Suby

[![Build status](https://ci.appveyor.com/api/projects/status/boxmp393o0u878kv?svg=true)](https://ci.appveyor.com/project/nklbdev/suby-csharp)
[![NuGet version](https://badge.fury.io/nu/suby.nklbdev.svg)](https://www.nuget.org/packages/suby.nklbdev)
[![CodeFactor](https://www.codefactor.io/repository/github/nklbdev/suby-csharp/badge)](https://www.codefactor.io/repository/github/nklbdev/suby-csharp)

Alternate events for C# (not yet thread-safe)

## The problems it solves

- Necessity of checking the event for null before raising
- Necessity to store a reference to the publishing object in the subscriber objects
- The problem of ownership of the event, or just subscription
- The problem of notifying some listeners after they have been unsubscribed, if the current notification cycle has not yet ended

Need help with development to add thread safety

## How to use

To create an event simply call one of default constructors:
```cs
var e0 = new Event();
var e1 = new Event<string>();
var e2 = new Event<string, int>();
```
... and so on

Then subscribe to the event:
```cs
var sub = e1.Subscribe(s =>
    Console.WriteLine($"You got new message: {s}"));
```

Then raise the event:
```cs
e1.Raise("Hello!");
```

You will have the console output:
```
You got new message: Hello!
```

Then dispose the subscription:
```cs
sub.Dispose()
```

Then raise the event:
```cs
e1.Raise("Good bye... oops!");
```

And you will have no console output

You can use the using statement for your subscriptions:
```cs
var handler = s => Console.WriteLine($"You got new message: {s}");
using (e1.Subscribe(handler))
{
    e1.Raise("Hello!");
}
e1.Raise("Good bye... oops!");
```

You can publish your event to subscribers as ISubscriptable without access to Raise method:

```cs
public class Publisher
{
    private readonly Event _somethingHappened = new Event();
    public ISubscriptable SomethingHappened => _somethingHappened;
}
```
And you can pass subscriptables to subscribers via their constructors or other methods:

```cs
public class Subscriber
{
    private readonly IDisposable _subscription;

    public Subscriber(ISubscriptable e)
    {
        _subscription = e.Subscribe(Handler);
    }

    public void Handler()
    {
        // without code
    }
}
```
