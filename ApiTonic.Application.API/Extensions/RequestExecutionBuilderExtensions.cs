using ApiTonic.Application.API.Models;
using HotChocolate.Execution.Configuration;
using StackExchange.Redis;

namespace ApiTonic.Application.API.Extensions
{
    public static class RequestExecutionBuilderExtensions
    {
        public static IRequestExecutorBuilder PublishSchemaDefinitionToRedis(this IRequestExecutorBuilder builder,
            GraphQLSettings graphQLSettings)
        {
            builder.PublishSchemaDefinition(c => c
                    .SetName(graphQLSettings.ProjectName)
                    .PublishToRedis(graphQLSettings.GatewayName,
                        sp => sp.GetRequiredService<ConnectionMultiplexer>()));

            return builder;
        }
    }
}
