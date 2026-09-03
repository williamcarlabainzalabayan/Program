# 3-Month C# Learning Plan

**Format:** ~5 araw/linggo, 1-2 oras kada araw (adjustable depende sa schedule mo)
**Tools:** Visual Studio Community (libre) o VS Code + .NET SDK

---

## 📅 MONTH 1 — Foundations

### Week 1: Setup & Basics
- Mag-install ng .NET SDK at Visual Studio Community / VS Code + C# extension
- Anatomy ng isang C# program (`Main` method, namespaces, `using`)
- Variables at data types (`int`, `double`, `string`, `bool`, `char`, `var`)
- Type conversion (implicit/explicit, `Convert.ToInt32`, etc.)
- Basic input/output (`Console.WriteLine`, `Console.ReadLine`)
- **Practice:** Simple calculator, temperature converter

### Week 2: Control Flow
- Operators (arithmetic, comparison, logical, assignment)
- Conditional statements (`if`, `else if`, `else`, `switch`)
- Loops (`for`, `while`, `do-while`, `foreach`)
- `break` at `continue`
- **Practice:** Number guessing game, FizzBuzz, simple grade checker

### Week 3: Methods & Arrays
- Paano gumawa ng methods (parameters, return types, overloading)
- Arrays (1D at 2D arrays)
- `List<T>` basics
- Debugging gamit ang breakpoints
- **Practice:** To-do list console app, grade average calculator gamit ang array

### Week 4: Strings & Mini Project
- String manipulation (`Substring`, `Split`, `Trim`, `Contains`, string interpolation)
- Exception basics (`try`, `catch`, `finally`)
- **Mini Project (end of month):** Console-based "Student Grade Management System" — mag-input ng students, compute average, magbigay ng remarks

---

## 📅 MONTH 2 — Object-Oriented Programming

### Week 5: Intro to OOP
- Classes at objects
- Fields, properties (get/set), constructors
- `this` keyword
- Access modifiers (`public`, `private`, `protected`)
- **Practice:** Gumawa ng `Car`, `Student`, o `BankAccount` class

### Week 6: Inheritance & Polymorphism
- Inheritance (`base` keyword)
- Method overriding (`virtual`, `override`)
- Polymorphism
- Abstract classes at interfaces
- **Practice:** Animal hierarchy (Dog, Cat inherits Animal), Shape calculator (interface `IShape`)

### Week 7: Collections, Exceptions, & LINQ Basics
- `Dictionary<TKey, TValue>`
- Exception handling (custom exceptions, multiple catch blocks)
- Intro sa LINQ (`Where`, `Select`, `OrderBy`)
- **Practice:** Inventory system gamit ang Dictionary, simple query gamit LINQ

### Week 8: File Handling & Mini Project
- Read/write files (`System.IO`, `StreamReader`, `StreamWriter`)
- Generics basics (`List<T>`, custom generic methods)
- **Mini Project (end of month):** "Library Management System" — OOP-based, may save/load sa text file

---

## 📅 MONTH 3 — Real-World Application

### Week 9: Async Programming & Advanced LINQ
- `async` / `await` basics
- Advanced LINQ (`GroupBy`, `Join`, aggregate functions)
- Delegates at events (basic understanding)
- **Practice:** Simple file downloader simulation gamit async

### Week 10: Choose Your Path (pumili base sa interest)
- **Option A — Web:** Intro sa ASP.NET Core (Minimal API, mag-build ng simpleng REST API)
- **Option B — Desktop:** Intro sa WPF o WinForms (gumawa ng simpleng GUI app)
- **Option C — Console pa rin pero mas advanced:** CLI tools, working with JSON (`System.Text.Json`)

### Week 11: Database Integration
- Intro sa Entity Framework Core
- Connect sa SQLite o SQL Server
- Basic CRUD operations (Create, Read, Update, Delete)
- **Practice:** I-connect ang Library o Student system sa database imbes na text file

### Week 12: Final Project & Review
- **Final Project:** Buuin ang isang kumpletong app na pinagsama ang natutunan mo — halimbawa:
  - "Simple Inventory/POS System" na may database, OOP structure, at (kung web/desktop path) may UI
- I-review ang buong journey: refactor old projects gamit ang bagong natutunan
- I-push sa GitHub para may portfolio ka na

---

## 💡 Tips
- Mag-code araw-araw kahit 30 mins lang — consistency > cramming
- Gumawa ng sariling mini-projects bukod sa nasa plan para lumalim ang understanding
- Gamitin ang [Microsoft Learn C# path](https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/) bilang reference
- Sumali sa mga forums/Discord (r/csharp, r/dotnet) kung may tanong

---

## 📌 Suggested Weekly Structure
| Araw | Activity |
|------|----------|
| Mon-Thu | Aral ng konsepto + maliliit na exercises |
| Fri | Apply sa mas malaking practice problem |
| Sat | Continue/finish weekly mini-project |
| Sun | Rest o review lang ng natutunan |