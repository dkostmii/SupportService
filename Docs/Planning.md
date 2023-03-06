# Project development planning

The project is rapidly developed.
The goal is to achieve minimal working state which provides sufficient level of functionality.

Planning is not listed in any stage/tasks,
so we can easily update timeline based on project deadline,
changing platform, techstack etc.

## Project development timeline

Project development timeline is split into two iterations:

|Iteration|Explanation|
|---------|-----------|
|Intial|Create all mandatory components for the project|
|Next|Update or add components to make development more efficient/scalable|

Each iteration consists of stages.
We can't predict how long each stage will take,
unless we have some equivalent data from previous projects.

This project is the first project, where we timeline is tracked,
so we just complete each stage as fast as possible with correctly working outcome.

## Initial iteration

|Stage|
|-----|
|Write requirements specification|
|Create code-first DB|
|Create support service|
|Create auth service|
|Link support and auth services|
|Create JS frontend|
|Link frontend with services|
|Add support for Docker containers|
|Deploy containers to provider|

Tasks are atomic blocks of work, we can specify here toolset we work with and
get to know with workflow specific for that toolset.

For example, write Models for DAL on Entity Framework Core or migrate models
from Auth service and SupportService to single SQL Server instance.

New tasks may dependend on previous tasks.

|Tasks|Elapsed|
|-----|-------|
|Write functional requirements|01:16:38|
|Write non-functional requirements|01:22:33|
|Create simple use case of ASP.Net identity|15:16:44|
|~~Specify password hashing algo in NFR~~ (using default impl)|--:--:--|
|Write EF Core models in Shared.DAL library|01:29:00|
|Create specs for communication between AuthService and SupportService ([result](./CommunicationSpecs.md))|--:--:--|
|Create AuthService and SupportService ASP.Net WebAPI projects|--:--:--|
|Add AuthDBContext and SupportDBContext to appropriate projects|--:--:--|
|Migrate to same MSSQL Express DB instance|--:--:--|
|`// TODO: Write stage tasks`|--:--:--|

## Next iteration

```JS
// TODO: Write next iteration stages.
```

## Tools for tracking stage length

Git and GitHub issues, branches and commits already have that functionality.
You can create issue, and start tracking how long
it will take to comlete before PR.
