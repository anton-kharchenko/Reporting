using Microsoft.EntityFrameworkCore;
using Reporting.API;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<ApplicationDBContext>((serviceProvider, dbContext) =>
{
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    dbContext.UseNpgsql(connectionString);
});

builder.Services.AddGraphQLServer()
    .AddFiltering()
    .AddMutationConventions()
    .AddMutationType<Mutation>()
    .AddQueryType<Query>()
    .RegisterDbContext<ApplicationDBContext>();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
app.MapGraphQL();

if (app.Environment.IsDevelopment())
{
    using var scope = app.Services.CreateScope();
    await scope.ServiceProvider.GetRequiredService<ApplicationDBContext>().Database.MigrateAsync();
}

app.Run();