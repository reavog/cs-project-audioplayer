# cs-project-audioplayer
My attempt at learning C# by creating a simple audio player with C# and .NET, with a PostgreSQL database.

## Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- PostgreSQL

## Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/cs-project-audioplayer.git
   cd cs-project-audioplayer
   ```

2. Configure the database connection string in `appsettings.json`.

3. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

## Running the Application

```bash
dotnet run
```

The app will be available at `https://localhost:5001` (or `http://localhost:5000`).
