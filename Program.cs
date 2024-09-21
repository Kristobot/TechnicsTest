using TechnicsTest.GraphQL.Bases;
using TechnicsTest.GraphQL.Persistence;
using TechnicsTest.GraphQL.Resolvers;
using TechnicsTest.GraphQL.Services;
using TechnicsTest.GraphQL.Types;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSqlServer<LibraryDbContext>(builder.Configuration.GetConnectionString("default"));
builder.Services.AddScoped<BookService>();

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<LibraryDbContext>(DbContextKind.Resolver)
    .AddInMemorySubscriptions()
    .AddType<AuthorType>()
    .AddType<BookType>()
    .AddType<GenreType>()
    .AddType<RoleType>()
    .AddType<UserType>()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .AddSubscriptionType<Subscriptions>()
    .AddTypeExtension<BookQuery>()
    .AddTypeExtension<GenreQuery>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseAuthentication();
//app.UseAuthorization();
app.UseRouting();
app.UseWebSockets();
app.MapGraphQL();

app.Run();

