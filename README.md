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

**Top Level Statements** 

> New in .NET 9.

1. It must be within the entrypoint (`Main` **Method**, `Program.cs` **File** and **Class**).
1. Eliminates the ceremony of writing a `Program` Class or `Main` **Method**.	 
   * Cannot be used with `Main` **Method**.
   * Only one **File** containing these is allowed per **Project**.
1. `using` **Directives** must come first.
1. They cannot be imported/exported.

### Vs. Java

1. `virtual` and **Overloading**
	* In Java, **Methods** can be `@Overridden` by default.
	* In .NET, only `virtual` **Methods** can be.
2. `struct` vs `record`
	* `struct` can be deep or shallow.
	* `struct` can be `readonly`
3. `var` 
	* In Java, this is the default Variable declaration keyword.
	* In .NET, this is for a locally-scoped Variable declaration (akin to `let` in JavaScript).
	* It's also implicitly typed in .NET (omitting the need to explicitly state the type).
4. `const` vs. `var static final ...`
	* In Java, an immutable Variable is defined using the `final` keyword.
	* In .NET, `const` is used instead (like JavaScript).
5. Visibility
	* Java: `public`, `protected`, `package` (default), `private`. Also, `sealed`.
	* .NET: far more combinations for greater granularity and Access Control.
		* TODO
6. Pass by Value and Reference
	* Both use **Pass by Value** and **Pass by Reference**.
7. **String Pools** vs. **String Interning**
	* Java using the "flywheel" memoization pattern to automatically handle String deduplication under the hood.
	* .NET has a similar **String Interning** automatic system within the **Common Language Runtime**.
	* Both use respective `.intern()` Methods and can be called manually.
8. Compilation
	* Java compiles code into bytecode that's executed by the JRE.
	* .NET has several additional intermediate steps.
		* *Code is compiled from a target .NET language (F#, C#, etc.).
		* This in turn is JIT executed on the **Common Language Runtime**.
			* TODO
9. Autoboxing
		
### Key Concepts

1. `Program.cs` is the default **Main Method** file and entrypoint for `Console` **Project**. 
	* This will be created - expect it.
	* It doesn't have to have a **Class** definition.

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

### Code Samples

1. https://github.com/Thoughtscript/dotnet_2025/tree/main/csharp/src