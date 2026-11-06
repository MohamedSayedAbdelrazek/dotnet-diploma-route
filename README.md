# .NET Diploma — Route Academy

My assignments and tasks from the **.NET Diploma at Route Academy**, collected in one place and ordered the way the course
goes: C# fundamentals → object-oriented programming → advanced C# → LINQ → Entity Framework Core.

Each folder was its own repository while I worked on it. They were merged here with their **full commit history**,
so every original commit and date is kept.

**Stack:** C# · .NET · LINQ · Entity Framework Core · SQL Server

---

## 01 · C# Fundamentals

| Folder | Topics | Date |
| --- | --- | --- |
| [02-types-and-conversions](01-csharp-basics/02-types-and-conversions) | Storing values as `object`, implicit and explicit casts, `Convert`, `Parse` and `TryParse` | Jul 2026 |
| [03-control-flow-arrays-strings](01-csharp-basics/03-control-flow-arrays-strings) | `if` / `switch`, loops, arrays, string methods and `StringBuilder` | Jul 2026 |
| [04-methods-and-parameters](01-csharp-basics/04-methods-and-parameters) | Methods, passing by value and by reference, `ref`, `out`, `params` | Jul 2026 |
| [task-02-gym-membership](01-csharp-basics/task-02-gym-membership) | Console app: classes, enums and validated user input with `TryParse` loops | Jul 2026 |
| [05-classes-and-enums](01-csharp-basics/05-classes-and-enums) | Classes, enums and access modifiers | Jul 2026 |

## 02 · Object-Oriented Programming

A delivery and shipment system that grows from one assignment to the next.

| Folder | Topics | Date |
| --- | --- | --- |
| [01-encapsulation](02-oop/01-encapsulation) | Encapsulation: properties with validation instead of public fields | Aug 2026 |
| [02-inheritance](02-oop/02-inheritance) | Inheritance: standard, express and international shipments | Aug 2026 |
| [03-polymorphism](02-oop/03-polymorphism) | Polymorphism: `virtual`, `override`, `sealed` and `base` constructors | Aug 2026 |
| [task-03-payment-methods](02-oop/task-03-payment-methods) | Abstract classes and interfaces: cash and credit-card payments, `IRefundable` | Aug 2026 |
| [04-interfaces](02-oop/04-interfaces) | Interfaces: `ITrackable`, `IInsurable` and a delivery report | Aug 2026 |
| [05-static-partial-and-extensions](02-oop/05-static-partial-and-extensions) | Static classes, partial classes and extension methods | Aug 2026 |

## 03 · Advanced C#

| Folder | Topics | Date |
| --- | --- | --- |
| [01-generics](03-advanced-csharp/01-generics) | Generic classes, methods and interfaces: `Pair<TKey, TValue>`, `Swap<T>`, `IRepository<T>`, a cache | Aug 2026 |
| [02-delegates-and-lambdas](03-advanced-csharp/02-delegates-and-lambdas) | Delegates and lambdas (`Predicate`, `Action`, `Func`) to search, report and transform a product catalog | Aug 2026 |
| [03-collections](03-advanced-csharp/03-collections) | `List`, `Dictionary`, `SortedDictionary`, `HashSet`, `Queue` and `Stack` | Sep 2026 |

## 04 · LINQ

| Folder | Topics | Date |
| --- | --- | --- |
| [01-linq-queries](04-linq/01-linq-queries) | Filtering, ordering and projection over products, customers and orders | Oct 2026 |

## 05 · Entity Framework Core

| Folder | Topics | Date |
| --- | --- | --- |
| [01-bookstore](05-ef-core/01-bookstore) | `DbContext`, entities and relationships for a book store, code-first migrations | Oct 2026 |
| [02-eventhub](05-ef-core/02-eventhub) | Fluent API configurations, one-to-one and one-to-many relationships, value conversions | Oct 2026 |

---

## Running an assignment

Every folder is a standalone .NET console project. Open its solution (`.sln` / `.slnx`) in Visual Studio, or run it from
the project folder:

```bash
dotnet run
```

The EF Core assignments expect a local SQL Server instance (`Server=.`) with Windows authentication.

## Related

- **Learning Platform:** a larger EF Core and SQL Server project →
  [EFCoreSession03](https://github.com/MohamedSayedAbdelrazek/EFCoreSession03)
- Portfolio: [mohamedsayedabdelrazek.github.io](https://mohamedsayedabdelrazek.github.io/)
