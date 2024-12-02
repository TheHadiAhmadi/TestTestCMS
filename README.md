# TestTestCMS

![GitHub last commit](https://img.shields.io/github/last-commit/TestTestCMS/TestTestCMS)
![GitHub commit activity](https://img.shields.io/github/commit-activity/y/TestTestCMS/TestTestCMS)
![GitHub License](https://img.shields.io/github/license/TestTestCMS/TestTestCMS)
![GitHub contributors](https://img.shields.io/github/contributors/TestTestCMS/TestTestCMS)
![Discord](https://img.shields.io/discord/1165300406902067280)

TestTestCMS is a modern Content Management System (CMS) built on the powerful ASP.NET Core and the innovative Blazor technology. TestTestCMS assists content writers in crafting content more efficiently. Designed to be fast, flexible, and user-friendly, it not only serves as a traditional content-based CMS but also excels as a headless CMS, making it perfect for a diverse range of digital applications.

![Demo Gif](./docs/resources/demo.gif)

TestTestCMS is an open-source project, and we welcome contributions from the community. If you're interested in helping us improve TestTestCMS, please read our [CONTRIBUTING.md](./CONTRIBUTING.md) guide.

## Features

- **Blazing Fast**: Built on top of Blazor components for client-side operations.
- **Extensible**: Easily extend with custom plugins and themes.
- **SEO Friendly**: Built-in SEO tools to optimize content for search engines.
- **Responsive**: Mobile-friendly out of the box.
- **Modern UI**: Sleek and intuitive dashboard for content management.
- **Headless Capabilities**: API-first design for decoupled applications.
- **Multi-Language Support**: Easily manage content in multiple languages.
- **Role-Based Access Control**: Granular control over user permissions.
- **Media Management**: Upload, organize, and manage media files.
- **Content Type Definition**: Define custom content types with various fields.
- **Content Management**: Create, edit, and manage content with ease.
- **User Management**: Manage users and roles with ease.
- **Role Management**: Create and manage roles with custom permissions.
- **Application Settings**: Configure application settings with ease.
- **Multiple Site Support**: Manage multiple sites from a single dashboard.
- **Page Management**: Create and manage pages with custom layouts.
- **Plugin Management**: Extend functionality with custom plugins.

## Supported Databases

- LiteDB
- MongoDB
- MySQL (coming soon)
- SQL Server (coming soon)
- SQLite (coming soon)
- PostgreSQL (coming soon)

## Getting Started

### Prerequisites

- .NET SDK 8.0 or higher

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/TestTestCMS/TestTestCMS.git
   ```

2. Navigate to the project directory:

   ```bash
   cd TestTestCMS/src/TestTestCMS/
   ```
3. Configure the Database

   TestTestCMS supports multiple databases. Configure the desired database by following these steps:

      * **Set the Database in `Program.cs`:** 
      Uncomment the database service you want to use and ensure others are commented out. For example, to use LiteDB:

         ```csharp
         services.AddLiteDbRepositories("LiteDb");
         ```

   * **Provide Connection Strings in `appsettings.json`:** 
      Add your connection string under "ConnectionStrings" in appsettings.json for the desired database:

      ```json
      "ConnectionStrings": {
         "LiteDb": "Filename=./TestTestCMS.db",
         "MongoDb": "mongodb://localhost:27017/TestTestCMS",
         "Sqlite": "Data Source=TestTestCMS.db",
         "SqlServer": "your_sql_server_connection_string",
         "MySql": "your_mysql_connection_string",
         "PostgreSQL": "your_postgresql_connection_string"
      }
      ```


4. Run the application:

   ```bash
   dotnet run
   ```

5. Visit `http://localhost:5000` in your browser.

## Documentation

For more information on how to use TestTestCMS, please refer to our [documentation](./docs/README.md). We are actively working on expanding our documentation to provide more detailed information.


## Contributing

We welcome contributions! If you're interested in improving TestTestCMS, please read our [CONTRIBUTING.md](./CONTRIBUTING.md) guide.

![Alt](https://repobeats.axiom.co/api/embed/908c321e4de115a715f2a3ed981c6e00bfbcea62.svg "Repobeats analytics image")

## License

This project is licensed under the MIT License - see the [LICENSE](./LICENSE) file for details.
