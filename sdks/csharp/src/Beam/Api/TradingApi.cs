// <auto-generated>
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
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Beam.Client;
using Beam.Model;
using System.Diagnostics.CodeAnalysis;

namespace Beam.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface ITradingApi : IApi
    {
        /// <summary>
        /// The class containing the events
        /// </summary>
        TradingApiEvents Events { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITradeAssetsApiResponse"/>&gt;</returns>
        Task<ITradeAssetsApiResponse> TradeAssetsAsync(TradeTokensRequestInput tradeTokensRequestInput, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITradeAssetsApiResponse"/>&gt;</returns>
        Task<ITradeAssetsApiResponse> TradeAssetsOrDefaultAsync(TradeTokensRequestInput tradeTokensRequestInput, System.Threading.CancellationToken cancellationToken = default);
    }

    /// <summary>
    /// The <see cref="ITradeAssetsApiResponse"/>
    /// </summary>
    public interface ITradeAssetsApiResponse : Beam.Client.IApiResponse, IOk<Beam.Model.TradeTokensResponse>
    {
        /// <summary>
        /// Returns true if the response is 200 Ok
        /// </summary>
        /// <returns></returns>
        bool IsOk { get; }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TradingApiEvents
    {
        /// <summary>
        /// The event raised after the server response
        /// </summary>
        public event EventHandler<ApiResponseEventArgs> OnTradeAssets;

        /// <summary>
        /// The event raised after an error querying the server
        /// </summary>
        public event EventHandler<ExceptionEventArgs> OnErrorTradeAssets;

        internal void ExecuteOnTradeAssets(TradingApi.TradeAssetsApiResponse apiResponse)
        {
            OnTradeAssets?.Invoke(this, new ApiResponseEventArgs(apiResponse));
        }

        internal void ExecuteOnErrorTradeAssets(Exception exception)
        {
            OnErrorTradeAssets?.Invoke(this, new ExceptionEventArgs(exception));
        }
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class TradingApi : ITradingApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger factory
        /// </summary>
        public ILoggerFactory LoggerFactory { get; }

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<TradingApi> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The class containing the events
        /// </summary>
        public TradingApiEvents Events { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TradingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TradingApi(ILogger<TradingApi> logger, ILoggerFactory loggerFactory, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider, TradingApiEvents tradingApiEvents,
            TokenProvider<ApiKeyToken> apiKeyProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            LoggerFactory = loggerFactory;
            Logger = LoggerFactory.CreateLogger<TradingApi>();
            HttpClient = httpClient;
            Events = tradingApiEvents;
            ApiKeyProvider = apiKeyProvider;
        }

        partial void FormatTradeAssets(TradeTokensRequestInput tradeTokensRequestInput);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="tradeTokensRequestInput"></param>
        /// <returns></returns>
        private void ValidateTradeAssets(TradeTokensRequestInput tradeTokensRequestInput)
        {
            if (tradeTokensRequestInput == null)
                throw new ArgumentNullException(nameof(tradeTokensRequestInput));
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="tradeTokensRequestInput"></param>
        private void AfterTradeAssetsDefaultImplementation(ITradeAssetsApiResponse apiResponseLocalVar, TradeTokensRequestInput tradeTokensRequestInput)
        {
            bool suppressDefaultLog = false;
            AfterTradeAssets(ref suppressDefaultLog, apiResponseLocalVar, tradeTokensRequestInput);
            if (!suppressDefaultLog)
                Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="tradeTokensRequestInput"></param>
        partial void AfterTradeAssets(ref bool suppressDefaultLog, ITradeAssetsApiResponse apiResponseLocalVar, TradeTokensRequestInput tradeTokensRequestInput);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="tradeTokensRequestInput"></param>
        private void OnErrorTradeAssetsDefaultImplementation(Exception exception, string pathFormat, string path, TradeTokensRequestInput tradeTokensRequestInput)
        {
            bool suppressDefaultLog = false;
            OnErrorTradeAssets(ref suppressDefaultLog, exception, pathFormat, path, tradeTokensRequestInput);
            if (!suppressDefaultLog)
                Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="suppressDefaultLog"></param>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="tradeTokensRequestInput"></param>
        partial void OnErrorTradeAssets(ref bool suppressDefaultLog, Exception exception, string pathFormat, string path, TradeTokensRequestInput tradeTokensRequestInput);

        /// <summary>
        ///  
        /// </summary>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITradeAssetsApiResponse"/>&gt;</returns>
        public async Task<ITradeAssetsApiResponse> TradeAssetsOrDefaultAsync(TradeTokensRequestInput tradeTokensRequestInput, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await TradeAssetsAsync(tradeTokensRequestInput, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="tradeTokensRequestInput"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ITradeAssetsApiResponse"/>&gt;</returns>
        public async Task<ITradeAssetsApiResponse> TradeAssetsAsync(TradeTokensRequestInput tradeTokensRequestInput, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateTradeAssets(tradeTokensRequestInput);

                FormatTradeAssets(tradeTokensRequestInput);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/v1/trading/trade";

                    httpRequestMessageLocalVar.Content = (tradeTokensRequestInput as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(tradeTokensRequestInput, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();
                    ApiKeyToken apiKeyTokenLocalVar;
                    apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);
                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);
                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "x-api-key");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null && httpRequestMessageLocalVar.Content != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Post;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ILogger<TradeAssetsApiResponse> apiResponseLoggerLocalVar = LoggerFactory.CreateLogger<TradeAssetsApiResponse>();

                        TradeAssetsApiResponse apiResponseLocalVar = new(apiResponseLoggerLocalVar, httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/v1/trading/trade", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterTradeAssetsDefaultImplementation(apiResponseLocalVar, tradeTokensRequestInput);

                        Events.ExecuteOnTradeAssets(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorTradeAssetsDefaultImplementation(e, "/v1/trading/trade", uriBuilderLocalVar.Path, tradeTokensRequestInput);
                Events.ExecuteOnErrorTradeAssets(e);
                throw;
            }
        }

        /// <summary>
        /// The <see cref="TradeAssetsApiResponse"/>
        /// </summary>
        public partial class TradeAssetsApiResponse : Beam.Client.ApiResponse, ITradeAssetsApiResponse
        {
            /// <summary>
            /// The logger
            /// </summary>
            public ILogger<TradeAssetsApiResponse> Logger { get; }

            /// <summary>
            /// The <see cref="TradeAssetsApiResponse"/>
            /// </summary>
            /// <param name="logger"></param>
            /// <param name="httpRequestMessage"></param>
            /// <param name="httpResponseMessage"></param>
            /// <param name="rawContent"></param>
            /// <param name="path"></param>
            /// <param name="requestedAt"></param>
            /// <param name="jsonSerializerOptions"></param>
            public TradeAssetsApiResponse(ILogger<TradeAssetsApiResponse> logger, System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage, string rawContent, string path, DateTime requestedAt, System.Text.Json.JsonSerializerOptions jsonSerializerOptions) : base(httpRequestMessage, httpResponseMessage, rawContent, path, requestedAt, jsonSerializerOptions)
            {
                Logger = logger;
                OnCreated(httpRequestMessage, httpResponseMessage);
            }

            partial void OnCreated(System.Net.Http.HttpRequestMessage httpRequestMessage, System.Net.Http.HttpResponseMessage httpResponseMessage);

            /// <summary>
            /// Returns true if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public bool IsOk => 200 == (int)StatusCode;

            /// <summary>
            /// Deserializes the response if the response is 200 Ok
            /// </summary>
            /// <returns></returns>
            public Beam.Model.TradeTokensResponse Ok()
            {
                // This logic may be modified with the AsModel.mustache template
                return IsOk
                    ? System.Text.Json.JsonSerializer.Deserialize<Beam.Model.TradeTokensResponse>(RawContent, _jsonSerializerOptions)
                    : null;
            }

            /// <summary>
            /// Returns true if the response is 200 Ok and the deserialized response is not null
            /// </summary>
            /// <param name="result"></param>
            /// <returns></returns>
            public bool TryOk([NotNullWhen(true)]out Beam.Model.TradeTokensResponse result)
            {
                result = null;

                try
                {
                    result = Ok();
                } catch (Exception e)
                {
                    OnDeserializationErrorDefaultImplementation(e, (HttpStatusCode)200);
                }

                return result != null;
            }

            private void OnDeserializationErrorDefaultImplementation(Exception exception, HttpStatusCode httpStatusCode)
            {
                bool suppressDefaultLog = false;
                OnDeserializationError(ref suppressDefaultLog, exception, httpStatusCode);
                if (!suppressDefaultLog)
                    Logger.LogError(exception, "An error occurred while deserializing the {code} response.", httpStatusCode);
            }

            partial void OnDeserializationError(ref bool suppressDefaultLog, Exception exception, HttpStatusCode httpStatusCode);
        }
    }
}
