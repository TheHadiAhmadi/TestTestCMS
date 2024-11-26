namespace TestTestCMS.Repositories.EFCore;

public class PluginDefinitionRepository(TestTestCMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : AuditableEntityRepository<PluginDefinition, PluginDefinitionModel>(dbContext, mapper, apiExecutionContext), IPluginDefinitionRepository;
