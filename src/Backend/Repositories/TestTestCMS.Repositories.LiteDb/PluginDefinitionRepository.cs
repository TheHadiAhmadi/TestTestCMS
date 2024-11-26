namespace TestTestCMS.Repositories.LiteDb;

public class PluginDefinitionRepository(ILiteDBContext liteDbContext, IApiExecutionContext apiExecutionContext) : AuditableEntityRepository<PluginDefinition>(liteDbContext, apiExecutionContext), IPluginDefinitionRepository;
