using HotChocolate.Data.Filters;

namespace Reporting.API;

public class BookTitleOperationFilterInputType : StringOperationFilterInputType
{
    protected override void Configure(IFilterInputTypeDescriptor descriptor)
    {
        descriptor.Operation(DefaultFilterOperations.Equals).Type<StringType>();
    }
}