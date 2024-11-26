namespace TestTestCMS.Repositories.EFCore;

public class BlockRepository(TestTestCMSDbContext dbContext, IMapper mapper, IApiExecutionContext apiExecutionContext) : SiteAssociatedRepository<Block, BlockModel>(dbContext, mapper, apiExecutionContext), IBlockRepository
{
}
