# dotnet_prep_2025

[![](https://img.shields.io/badge/ASP.NET-9.0.3-purple.svg)](https://learn.microsoft.com/en-us/aspnet/core/?view=aspnetcore-9.0)
[![](https://img.shields.io/badge/MSSQL-2022-blue.svg)](https://hub.docker.com/r/microsoft/mssql-server)
[![](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) 
[![](https://img.shields.io/badge/VisualStudio-2022-blue.svg)](https://visualstudio.microsoft.com/vs/community/) 
[![](https://img.shields.io/badge/PowerShell-17.14.16-blue.svg)](https://learn.microsoft.com/en-us/powershell/) 

## .NET Ecosystem 2025

1. **Application Server Pages** (**ASP**)
	* Used to build JavaScript, HTML, and CSS MVC Web apps using .NET backends.
	* Akin to Java JSP, Spring.
1. **.NET** 
	* This combines **.NET**, **.NET Core**, **.NET Framework** into one distribution (from **.NET 6** which is the "is the unification of .NET Core and the .NET Framework").
	* These include the core runtimes, build tools, and native API's for running C# apps.
	* Akin to core Java EE.
1. **Entity Framework**
	* SQL database connections.
	* Object Relation Mappings.
	* Akin to Java Entity JPA Hibernate.

### Visual Studio

**Visual Studio's** gotten much easier to configure and install over the years:
1. Open **Visual Studio Installer** and select **Modify**.
2. Key dependencies include:
   * `MSVC v143 ...`
   * `Windows 11 SDK...` (Node Gyp distributions sometimes require these)
   * `MSBuild`
   * `C# and Visual Basic`
   * `.NET 9.0 Runtime`
   * `.NET SDK`
   * `C# and Visual Basic Rosyln compilers`
   * `C++ core features`
   * `NuGet package manager`
   * `C++ CMake tools ...`
   * `C++/CLI support v143 build tools...`
   * etc.
3. Depicted:
   * ![](_screen_captures/visual_studio_installer_deps_1.png)
   * ![](_screen_captures/visual_studio_installer_deps_2.png)  
4. Not installing those may cause issues with various tools/dependencies from outside C# and Dotnet depending on various 3rd-party installation configurations:
   * C++
   * Git CLI 
   * Python
   * Node
   * Node-Gyp

#### Key Visual Studio Views

1. Obtain a PowerShell Terminal: 
	* **View** > **Terminal**
2. Main View I like to use: 
	* **View** > **Solution Explorer**
	* Select the **Show All Files** icon on the right (three papers) to see all Directories and Files (including empty ones).

To format code:
1. **Edit** > **Advanced** > **Format Document**.

In Visual Studio Code:
1. To create a new **Project**:
   * **Command Palette** > type `.NET: New Project`
2. To format code:
   * **Command Palette** > type `Format Document`

#### Use

The steps in the section below will setup and configure a new **Solution** from scratch.
1. One can open and navigate to the **Solution** file (`.sln`).
1. Then **Build** and **Run** the **Solution** from within **Visual Studio 2022**.

### CLI Commands

From within **Visual Studio** (using the steps above):

```shell
# Version
dotnet --version 
## 9.0.305

# Create new Solution File
## Don't append an extra .sln here 
## it will cause the Solution to break
dotnet new sln --name mysolution

# Create new project
cd src
dotnet new console --language "C#"
## This creates a Terminal Console app 
## that will open a Window when built and run

# Add Project to Solution
cd ../
dotnet sln add src
```

## Language Overview

### Checklist

- [x] Declarations
     - [x] const
     - [x] var
- [x] Structs
     - [x] init
- [x] string 
     - [x] Interning/Pool
     - [x] Interpolation
     - [x] relation to char, a sequence not Array
     - [x] immutable
- [x] Visual Studio, .NET Solutions, Projects
     - [x] Visual Studio
     - [x] .NET 9
     - [x] .sln
     - [x] .csproj
- [x] Interfaces, Abstraction
     - [x] Interface, implementation
     - [x] Abstract
- [x] Namespaces, Classes
     - [x] `: base()`
     - [x] Getter, Setter
     - [x] Generics
     - [x] :
- [x] Virtual
     - [x] implemented, can `override`
     - [x] vs. `abstract` - unimplemented, must `override`
- [x] System.Collections.Generic
     - [x] Stack
     - [x] PriorityQueue
     - [x] List
     - [x] HashSet
     - [x] LinkedList
     - [x] Dictionary
     - [x] sorting
- [x] Basic Types
     - [x] Arrays, sorting
     - [x] struct
     - [x] int, long, double, float
     - [x] bool
     - [x] char, string
- [x] Visibility and Access
     - [x] internal
     - [x] public
     - [x] private
     - [x] protected
     - [x] file
     - [x] private protected
     - [x] protected internal
- [x] Loops, Iterables
     - [x] foreach
     - [x] async loop - see: https://learn.microsoft.com/en-us/answers/questions/1046784/c-async-streams-when-to-use-await-before-foreach
     - [x] for
- [x] References
     - [x] ref on basic types
     - [x] delegate on methods
     - [x] String, object, no wrapper types
- [x] Exception Handling, Checked, Runtime
     - [x] throwing
     - [x] try, catch
     - [x] checked exceptions
     - [x] unchecked exceptions
- [ ] Algos
    - [x] Stack
    - [x] List
    - [ ] Arrays
- [x] Compilation, Common Language Runtime
     - [x] Compilation to MSIL through CLR
     - [x] Then JIT compilation at execution through CLR
- [x] Async
	 - [x] Task, Thread
	 - [x] Thread safety
	 - [x] Non-Blocking to Blocking, composition
- [x] Operators
     - [x] nullable (`?`, Elvis), null-conditional (`?.`), null-coalescing (`??`), appended.
     - [x] `is null`, null check
     - [x] `is string`, type comparions
- [x] Other Keyword
     - [x] Guards
     - [x] static
     - [x] ref
     - [x] virtual
     - [x] delegate
     - [x] volatile

### New(er) Features

**Top Level Statements** 

> New in .NET 9.

1. It must be within the entrypoint (`Main` **Method**, `Program.cs` **File** and **Class**).
2. Eliminates the ceremony of writing a `Program` Class or `Main` **Method**.	 
   * Cannot be used with `Main` **Method**.
   * Only one **File** containing these is allowed per **Project**.
3. `using` **Directives** must come first.
4. They cannot be imported/exported.

### Vs. Java

1. `virtual` and **Overloading**
	* In Java, **Methods** can be `@Overridden` by default.
	* In .NET C#, only `virtual` and `abstract` **Methods** can be.
2. `struct` vs `record`
	* `struct` can be deep or shallow.
	* `struct` can be `readonly`.
	* `struct` is **Pass by Value**.
3. `var` 
	* In Java, this is the default Variable declaration keyword.
	* In .NET C#, this is for a locally-scoped Variable declaration (akin to `let` in JavaScript).
	* It's also implicitly typed in .NET C# (omitting the need to explicitly state the type).
4. `const` vs. `var static final ...`
	* In Java, an immutable Variable is defined using the `final` keyword.
	* In .NET, `const` is used instead (like JavaScript).
5. Visibility
	* Java: `public`, `protected`, `package` (default), `private`. Also, `sealed`.
	* .NET C#: far more combinations for greater granularity and Access Control.
		* TODO
6. Pass by Value and Reference
	* Both use **Pass by Value** and **Pass by Reference**.
	* `ref` can be set on most types.
	* `delegate` is similar to `ref` but used for **Method**/**Function References**.
7. **String Pools** vs. **String Interning**
	* Java using the "flywheel" memoization pattern to automatically handle String deduplication under the hood.
	* .NET C# has a similar **String Interning** automatic system within the **Common Language Runtime**.
	* Both use respective `.intern()` Methods and can be called manually.
8. Compilation
	* Java compiles code into bytecode that's executed by the JRE.
	* .NET C# has several additional intermediate steps.
        * Code is compiled from a target .NET language (F#, C#, etc.) into MSIL.
		* This in turn is JIT executed on the **Common Language Runtime**.
9. Autoboxing
    * Unlike Java, `string` and `String` are the same. `string` is an alias for `System.String` and the behavior, properties, etc. of `String` are there defined.
    * `int` and `Integer` are distinct in Java but aren't in .NET. They are aliases to the same (specifically, `System.Int32`).
    * In .NET C# a `string` say can be "boxed" into an `object` and back but this isn't the same relationship as `int` to `Integer` in Java.
    * For example, neither `int` nor `System.Int32` are nullable in .NET without `?` appended.
10. Types
	* Value types (primitives, pass by **Pass by Value**)
	* Reference types include **Classes**, **Interfaces**, **Arrays**, etc.
	* Like Java, Strings aren't primitives (e.g. - "value types") in C#.
11. `extends` vs. `:`
	* .NET C# uses `:` (vs. `extends` in Java).
	* Also for `implements`.
12. **Abstract Classes** and **Interfaces**
    * Similar
13. Nullability
    * Value (primitive) types typically can't be set to null directly.
    * `?` can be appended to most type declarations to make it explicitly nullable (`int?`, `string?` will complain but not error since `string` is a Reference Type).
14. Array Sorting
    * Java `Arrays.sort()`.
    * .NET `Array.Sort()`.
15. Collections
    * Collections API in Java.
    * `System.Collections.Generic` in .NET C#.
16. Object
    * `object` is an alias for `System.Object`.
17. Sort
	* `(a, b) => a - b`
	* vs. ` (a,b) => a.CompareTo(b)` in .NET C#.
18. Length, Size, Count
    * `Length` is C# String and Array (akin to `.length`).
    * `Count` is used for C# Collections (not `.size()`).
19. Thread Safety
    * Unlike Java, there aren't Atomic Objects. Instead, one uses Mutex's and Locks to control access to a Variable by multiple Threads.
20. `&&` and `||`
    * Same "circuit breaker" conditional evaluation (left to right) in both.
21. `super` vs. `base`
     * `super()` in Java
     * `base()` in C# - this is typically called like so: `public SubClassConstructor(int i) : base(i) {}`
22. Default Sorting
     * mergesort, quicksort in Java
     * heapsort, quicksort in C#
		
### Key Concepts

1. `Program.cs` is the default **Main Method** file and entrypoint for `Console` **Project**. 
	* This will be created - expect it.
	* It doesn't have to have a **Class** definition.
2. Compilation is a bit more involved.
    * .NET C# involves multiple languages that compile from a target language (MSIL) down into JIT CLR at execution runtime.

## Resources and Links

### Interview Preparation

1. https://zerotomastery.io/blog/dot-NET-interview-questions/
1. https://beetroot.co/team/18-interview-questions-to-ask-a-senior-net-developer/

### Ecosystem

1. https://www.c-sharpcorner.com/article/net-ecosystem/

### Langauge Reference and Documentation

1. https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/top-level-statements
1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/
1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/readonly
1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/virtual
1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/const
1. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
1. https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties
1. https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/base
1. https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-9.0

### Supplemental

1. https://medium.com/@dmitrystadub/c-13-ref-struct-features-overview-e4b91a50afef
1. https://learn.microsoft.com/en-us/answers/questions/1046784/c-async-streams-when-to-use-await-before-foreach

### Code Samples

1. https://github.com/Thoughtscript/dotnet_2025/tree/main/csharp/src