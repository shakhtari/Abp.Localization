using ML.Samples;
using Xunit;

namespace ML.EntityFrameworkCore.Applications;

[Collection(MLTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MLEntityFrameworkCoreTestModule>
{

}
