# Azure Functions C# sample snippets repository

This repository contains C# source code snippets used as `:::code` includes in [Azure Functions documentation](https://learn.microsoft.com/azure/azure-functions/). It is **not** intended as a standalone sample or project template.

## Contents

| Folder | Purpose |
|--------|---------|
| `http-trigger-isolated/` | HTTP trigger (isolated worker, ASP.NET Core integration) |
| `http-trigger-template/` | HTTP trigger from template |
| `functions-add-output-binding-storage-queue-isolated/` | HTTP trigger + Storage Queue output (isolated worker) |
| `functions-add-output-binding-storage-queue-cli/` | HTTP trigger + Storage Queue output (in-process, legacy) |
| `functions-add-output-binding-storage-queue-vs/` | HTTP trigger + Storage Queue output (Visual Studio) |
| `functions-add-output-binding-cosmos-db-isolated/` | HTTP trigger + Cosmos DB output (isolated worker) |
| `functions-add-output-binding-cosmos-db/` | HTTP trigger + Cosmos DB output (in-process, legacy) |

## Canonical scenario repositories

If you're looking for complete, deployable Azure Functions projects in C#, use these `azd`-compatible templates instead:

- [functions-quickstart-dotnet-azd](https://github.com/Azure-Samples/functions-quickstart-dotnet-azd) — HTTP trigger
- [functions-quickstart-dotnet-azd-timer](https://github.com/Azure-Samples/functions-quickstart-dotnet-azd-timer) — Timer trigger
- [functions-quickstart-dotnet-azd-cosmosdb](https://github.com/Azure-Samples/functions-quickstart-dotnet-azd-cosmosdb) — Azure Cosmos DB trigger
- [functions-quickstart-dotnet-azd-eventhub](https://github.com/Azure-Samples/functions-quickstart-dotnet-azd-eventhub) — Event Hubs trigger
- [functions-quickstart-dotnet-azd-sql](https://github.com/Azure-Samples/functions-quickstart-dotnet-azd-sql) — Azure SQL trigger
