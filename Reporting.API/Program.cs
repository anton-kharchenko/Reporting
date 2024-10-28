using Reporting.API;
using Reporting.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddGraphQLServer()
    .AddMutationConventions()
    .AddMutationType<Mutation>()
    .AddQueryType<Query>()
    .RegisterService<BookService>();

builder.Services.AddSingleton<BookService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

app.Run();