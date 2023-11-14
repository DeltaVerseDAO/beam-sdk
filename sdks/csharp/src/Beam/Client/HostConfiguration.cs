/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using Beam.Api;
using Beam.Model;

namespace Beam.Client
{
    /// <summary>
    /// Provides hosting configuration for Beam
    /// </summary>
    public class HostConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions();

        internal bool HttpClientsAdded { get; private set; }

        /// <summary>
        /// Instantiates the class 
        /// </summary>
        /// <param name="services"></param>
        public HostConfiguration(IServiceCollection services)
        {
            _services = services;
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());
            _jsonOptions.Converters.Add(new DateTimeJsonConverter());
            _jsonOptions.Converters.Add(new DateTimeNullableJsonConverter());
            _jsonOptions.Converters.Add(new AcceptAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AcceptOfferResponseJsonConverter());
            _jsonOptions.Converters.Add(new AddContractRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AddContractRequestInputAbiInnerJsonConverter());
            _jsonOptions.Converters.Add(new AddContractRequestInputAbiInnerInputsInnerJsonConverter());
            _jsonOptions.Converters.Add(new AddContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new AddPolicyRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new AddPolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new BuyAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new BuyAssetResponseJsonConverter());
            _jsonOptions.Converters.Add(new CancelAssetListingRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CancelAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CancelOfferResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseJsonConverter());
            _jsonOptions.Converters.Add(new Check200ResponseInfoValueJsonConverter());
            _jsonOptions.Converters.Add(new Check503ResponseJsonConverter());
            _jsonOptions.Converters.Add(new ConvertTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new ConvertTokenResponseJsonConverter());
            _jsonOptions.Converters.Add(new CreateAssetOfferRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CreateOfferResponseJsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new CreateProfileResponseWalletsInnerJsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionRequestInputInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new CreateTransactionResponseJsonConverter());
            _jsonOptions.Converters.Add(new GenerateLinkCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new GenerateLinkCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new GenerateSignInCodeRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new GenerateSignInCodeResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseDataInnerDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseDataInnerDataInnerPeriodsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseDataInnerDataInnerPolicyJsonConverter());
            _jsonOptions.Converters.Add(new GetAllGasUsageResponseDataInnerSummaryJsonConverter());
            _jsonOptions.Converters.Add(new GetAllProfilesResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAllProfilesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetListingsResponseDataInnerNftJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetOffersResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetOffersResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseContractJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseContractAvatarJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseContractHeaderJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseContractHeaderBackgroundJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseListingJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseOwnershipByAddressesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseOwnershipByAddressesInnerUserJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetResponseOwnershipByAddressesInnerUserProfileJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsBodyInputJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsBodyInputFilterJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsBodyInputSortJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsResponseDataInnerAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsResponseDataInnerOwnersInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetAssetsResponsePaginationJsonConverter());
            _jsonOptions.Converters.Add(new GetChainCurrenciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetChainCurrenciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetChainResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetChainResponseNativeCurrencyJsonConverter());
            _jsonOptions.Converters.Add(new GetEstimateResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponseContractsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetGameResponsePoliciesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetGasUsageResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileAssetsForGameFilterParameterJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileAssetsForGameFilterParameterAttributesInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileAssetsForGameSortParameterJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileCurrenciesResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileCurrenciesResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileNativeCurrencyResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileNativeCurrencyResponseNativeTokenBalanceJsonConverter());
            _jsonOptions.Converters.Add(new GetProfileResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetQuoteResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseDataInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseDataInnerInteractionsInnerJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseDataInnerResponseJsonConverter());
            _jsonOptions.Converters.Add(new GetTransactionsResponseDataInnerResponseLogsInnerJsonConverter());
            _jsonOptions.Converters.Add(new RegenerateGameApiKeysResponseJsonConverter());
            _jsonOptions.Converters.Add(new RegenerateGameApiKeysResponseApiKeysInnerJsonConverter());
            _jsonOptions.Converters.Add(new RemoveContractResponseJsonConverter());
            _jsonOptions.Converters.Add(new RemovePolicyResponseJsonConverter());
            _jsonOptions.Converters.Add(new SellAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new SellAssetResponseJsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetRequestInputAssetsInnerJsonConverter());
            _jsonOptions.Converters.Add(new TransferAssetResponseJsonConverter());
            _jsonOptions.Converters.Add(new TransferNativeTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new TransferTokenRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new TransferTokenResponseJsonConverter());
            _jsonOptions.Converters.Add(new UpdateGameRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new UpdateGameResponseJsonConverter());
            _jsonOptions.Converters.Add(new UpdateProfileRequestInputJsonConverter());
            _jsonOptions.Converters.Add(new UpdateProfileResponseJsonConverter());
            JsonSerializerOptionsProvider jsonSerializerOptionsProvider = new(_jsonOptions);
            _services.AddSingleton(jsonSerializerOptionsProvider);
            _services.AddSingleton<IApiFactory, ApiFactory>();
            _services.AddSingleton<AssetsApiEvents>();
            _services.AddTransient<IAssetsApi, AssetsApi>();
            _services.AddSingleton<ChainApiEvents>();
            _services.AddTransient<IChainApi, ChainApi>();
            _services.AddSingleton<ExchangeApiEvents>();
            _services.AddTransient<IExchangeApi, ExchangeApi>();
            _services.AddSingleton<GameApiEvents>();
            _services.AddTransient<IGameApi, GameApi>();
            _services.AddSingleton<HealthApiEvents>();
            _services.AddTransient<IHealthApi, HealthApi>();
            _services.AddSingleton<MarketplaceApiEvents>();
            _services.AddTransient<IMarketplaceApi, MarketplaceApi>();
            _services.AddSingleton<PolicyApiEvents>();
            _services.AddTransient<IPolicyApi, PolicyApi>();
            _services.AddSingleton<ProfilesApiEvents>();
            _services.AddTransient<IProfilesApi, ProfilesApi>();
            _services.AddSingleton<ReportingApiEvents>();
            _services.AddTransient<IReportingApi, ReportingApi>();
            _services.AddSingleton<TransactionsApiEvents>();
            _services.AddTransient<ITransactionsApi, TransactionsApi>();
        }

        /// <summary>
        /// Configures the HttpClients.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        public HostConfiguration AddApiHttpClients
        (
            Action<HttpClient> client = null, Action<IHttpClientBuilder> builder = null)
        {
            if (client == null)
                client = c => c.BaseAddress = new Uri(ClientUtils.BASE_ADDRESS);

            List<IHttpClientBuilder> builders = new List<IHttpClientBuilder>();

            builders.Add(_services.AddHttpClient<IAssetsApi, AssetsApi>(client));
            builders.Add(_services.AddHttpClient<IChainApi, ChainApi>(client));
            builders.Add(_services.AddHttpClient<IExchangeApi, ExchangeApi>(client));
            builders.Add(_services.AddHttpClient<IGameApi, GameApi>(client));
            builders.Add(_services.AddHttpClient<IHealthApi, HealthApi>(client));
            builders.Add(_services.AddHttpClient<IMarketplaceApi, MarketplaceApi>(client));
            builders.Add(_services.AddHttpClient<IPolicyApi, PolicyApi>(client));
            builders.Add(_services.AddHttpClient<IProfilesApi, ProfilesApi>(client));
            builders.Add(_services.AddHttpClient<IReportingApi, ReportingApi>(client));
            builders.Add(_services.AddHttpClient<ITransactionsApi, TransactionsApi>(client));
            
            if (builder != null)
                foreach (IHttpClientBuilder instance in builders)
                    builder(instance);

            HttpClientsAdded = true;

            return this;
        }

        /// <summary>
        /// Configures the JsonSerializerSettings
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public HostConfiguration ConfigureJsonOptions(Action<JsonSerializerOptions> options)
        {
            options(_jsonOptions);

            return this;
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="token"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(TTokenBase token) where TTokenBase : TokenBase
        {
            return AddTokens(new TTokenBase[]{ token });
        }

        /// <summary>
        /// Adds tokens to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <param name="tokens"></param>
        /// <returns></returns>
        public HostConfiguration AddTokens<TTokenBase>(IEnumerable<TTokenBase> tokens) where TTokenBase : TokenBase
        {
            TokenContainer<TTokenBase> container = new TokenContainer<TTokenBase>(tokens);
            _services.AddSingleton(services => container);

            return this;
        }

        /// <summary>
        /// Adds a token provider to your IServiceCollection
        /// </summary>
        /// <typeparam name="TTokenProvider"></typeparam>
        /// <typeparam name="TTokenBase"></typeparam>
        /// <returns></returns>
        public HostConfiguration UseProvider<TTokenProvider, TTokenBase>() 
            where TTokenProvider : TokenProvider<TTokenBase>
            where TTokenBase : TokenBase
        {
            _services.AddSingleton<TTokenProvider>();
            _services.AddSingleton<TokenProvider<TTokenBase>>(services => services.GetRequiredService<TTokenProvider>());

            return this;
        }
    }
}
