using ML.Samples;
using Xunit;

namespace ML.EntityFrameworkCore.Domains;

[Collection(MLTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MLEntityFrameworkCoreTestModule>
{

}
