# suby-csharp
Better events (not yet thread-safe)

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
