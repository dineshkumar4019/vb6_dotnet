# Architecture Notes (Legacy)
- Multiple languages: VB6-ish, VB.NET, C# (.NET 3.5), Classic ASP, Perl, Java 1.4
- Several anti-patterns intentionally included to simulate migration targets:
  * SQL built with string concatenation
  * Database connections not closed properly
  * Global state and static file-based logging
  * Scripts that expect Windows-only tooling (MSBuild, xcopy)
- Goals for migration exercises:
  * Identify dependency boundaries
  * Extract services and wrap legacy DB access in safe DAL with parameterized queries
  * Add unit tests and CI
