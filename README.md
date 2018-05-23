# suby-csharp
Better events (not yet thread-safe)

To create an event simply call one of default constructors:
```cs
var e1 = new Event();
var e2 = new Event<string>();
var e3 = new Event<string, int>();
```
... and so on

Then subscribe to the event:
```cs
var sub = e2.Subscribe(s =>
    Console.WriteLine($"You got new message: {s}"));
```

Then raise the event:
```cs
e2.Raise("Hello!");
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
e2.Raise("Good bye... oops!");
```

And you will have no console output

You can use the using statement for your subscriptions:
```cs
var handler = s => Console.WriteLine($"You got new message: {s}");
using (e2.Subscribe(handler))
{
    e2.Raise("Hello!");
}
e2.Raise("Good bye... oops!");
```
