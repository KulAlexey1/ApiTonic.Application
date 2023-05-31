using ApiTonic.Application.API.Extensions;
using ApiTonic.Application.API.Models;
using ApiTonic.Application.API.Queries;
using ApiTonic.Application.DataTransfer;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

var graphQLSettings = builder.Configuration.GetSection("ApiTonic:GraphQL").Get<GraphQLSettings>();

var services = builder.Services;

services.AddCors();
services
    .AddSingleton(ConnectionMultiplexer.Connect(graphQLSettings.RedisAddress))
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .InitializeOnStartup()
    .PublishSchemaDefinitionToRedis(graphQLSettings);
services.AddDataTransferServices();

var app = builder.Build();

app.MapGraphQL();

app.UseCors(x => x
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials()
    .SetIsOriginAllowed(origin => true)
);

app.Run();
