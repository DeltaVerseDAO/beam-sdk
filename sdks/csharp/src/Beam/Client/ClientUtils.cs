/*
 * Beam game development API
 *
 * The Beam game development API is a service to integrate your game with Beam
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using Beam.Model;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Beam.Test")]

namespace Beam.Client
{
    /// <summary>
    /// Utility functions providing some benefit to API client consumers.
    /// </summary>
    public static class ClientUtils
    {

        /// <summary>
        /// A delegate for events.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public delegate void EventHandler<T>(object sender, T e) where T : EventArgs;

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(string json, JsonSerializerOptions options, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(json, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Returns true when deserialization succeeds.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="reader"></param>
        /// <param name="options"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryDeserialize<T>(ref Utf8JsonReader reader, JsonSerializerOptions options, [System.Diagnostics.CodeAnalysis.NotNullWhen(true)] out T result)
        {
            try
            {
                result = JsonSerializer.Deserialize<T>(ref reader, options);
                return result != null;
            }
            catch (Exception)
            {
                result = default;
                return false;
            }
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");
            return match.Success ? match.Groups[1].Value : filename;
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <param name="format">The DateTime serialization format.</param>
        /// <returns>Formatted string.</returns>
        public static string ParameterToString(object obj, string format = ISO8601_DATETIME_FORMAT)
        {
            if (obj is DateTime dateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTime.ToString(format);
            if (obj is DateTimeOffset dateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return dateTimeOffset.ToString(format);
            if (obj is bool boolean)
                return boolean
                    ? "true"
                    : "false";
            if (obj is AddContractRequestInput.TypeEnum addContractRequestInputTypeEnum)
                return AddContractRequestInput.TypeEnumToJsonValue(addContractRequestInputTypeEnum);
            if (obj is AddContractResponse.TypeEnum addContractResponseTypeEnum)
                return AddContractResponse.TypeEnumToJsonValue(addContractResponseTypeEnum);
            if (obj is AddPolicyRequestInput.RateTypeEnum addPolicyRequestInputRateTypeEnum)
                return AddPolicyRequestInput.RateTypeEnumToJsonValue(addPolicyRequestInputRateTypeEnum);
            if (obj is AddPolicyResponse.RateTypeEnum addPolicyResponseRateTypeEnum)
                return AddPolicyResponse.RateTypeEnumToJsonValue(addPolicyResponseRateTypeEnum);
            if (obj is ConvertTokenResponse.StatusEnum convertTokenResponseStatusEnum)
                return ConvertTokenResponse.StatusEnumToJsonValue(convertTokenResponseStatusEnum);
            if (obj is ConvertTokenResponse.TypeEnum convertTokenResponseTypeEnum)
                return ConvertTokenResponse.TypeEnumToJsonValue(convertTokenResponseTypeEnum);
            if (obj is CreateAssetOfferRequestInput.CurrencyEnum createAssetOfferRequestInputCurrencyEnum)
                return CreateAssetOfferRequestInput.CurrencyEnumToJsonValue(createAssetOfferRequestInputCurrencyEnum);
            if (obj is GetAllGasUsageResponseChainsInnerPoliciesInnerPolicy.ModelEnum getAllGasUsageResponseChainsInnerPoliciesInnerPolicyModelEnum)
                return GetAllGasUsageResponseChainsInnerPoliciesInnerPolicy.ModelEnumToJsonValue(getAllGasUsageResponseChainsInnerPoliciesInnerPolicyModelEnum);
            if (obj is GetAssetListingsResponseDataInnerNft.RarityEnum getAssetListingsResponseDataInnerNftRarityEnum)
                return GetAssetListingsResponseDataInnerNft.RarityEnumToJsonValue(getAssetListingsResponseDataInnerNftRarityEnum);
            if (obj is GetAssetOffersResponseDataInner.CurrencyEnum getAssetOffersResponseDataInnerCurrencyEnum)
                return GetAssetOffersResponseDataInner.CurrencyEnumToJsonValue(getAssetOffersResponseDataInnerCurrencyEnum);
            if (obj is GetAssetOffersResponseDataInner.KindEnum getAssetOffersResponseDataInnerKindEnum)
                return GetAssetOffersResponseDataInner.KindEnumToJsonValue(getAssetOffersResponseDataInnerKindEnum);
            if (obj is GetAssetResponse.NetworkEnum getAssetResponseNetworkEnum)
                return GetAssetResponse.NetworkEnumToJsonValue(getAssetResponseNetworkEnum);
            if (obj is GetAssetResponse.LastSoldTokenCurrencyEnum getAssetResponseLastSoldTokenCurrencyEnum)
                return GetAssetResponse.LastSoldTokenCurrencyEnumToJsonValue(getAssetResponseLastSoldTokenCurrencyEnum);
            if (obj is GetAssetResponse.RarityEnum getAssetResponseRarityEnum)
                return GetAssetResponse.RarityEnumToJsonValue(getAssetResponseRarityEnum);
            if (obj is GetAssetResponseContract.NetworkEnum getAssetResponseContractNetworkEnum)
                return GetAssetResponseContract.NetworkEnumToJsonValue(getAssetResponseContractNetworkEnum);
            if (obj is GetAssetResponseContract.SymbolEnum getAssetResponseContractSymbolEnum)
                return GetAssetResponseContract.SymbolEnumToJsonValue(getAssetResponseContractSymbolEnum);
            if (obj is GetAssetResponseContract.TypeEnum getAssetResponseContractTypeEnum)
                return GetAssetResponseContract.TypeEnumToJsonValue(getAssetResponseContractTypeEnum);
            if (obj is GetAssetResponseListing.CurrencyEnum getAssetResponseListingCurrencyEnum)
                return GetAssetResponseListing.CurrencyEnumToJsonValue(getAssetResponseListingCurrencyEnum);
            if (obj is GetAssetResponseListing.SellTypeEnum getAssetResponseListingSellTypeEnum)
                return GetAssetResponseListing.SellTypeEnumToJsonValue(getAssetResponseListingSellTypeEnum);
            if (obj is GetAssetsBodyInputFilter.SellTypesEnum getAssetsBodyInputFilterSellTypesEnum)
                return GetAssetsBodyInputFilter.SellTypesEnumToJsonValue(getAssetsBodyInputFilterSellTypesEnum);
            if (obj is GetAssetsBodyInputSort.CreatedAtEnum getAssetsBodyInputSortCreatedAtEnum)
                return GetAssetsBodyInputSort.CreatedAtEnumToJsonValue(getAssetsBodyInputSortCreatedAtEnum);
            if (obj is GetAssetsBodyInputSort.EndEnum getAssetsBodyInputSortEndEnum)
                return GetAssetsBodyInputSort.EndEnumToJsonValue(getAssetsBodyInputSortEndEnum);
            if (obj is GetAssetsBodyInputSort.EndPriceNumberEnum getAssetsBodyInputSortEndPriceNumberEnum)
                return GetAssetsBodyInputSort.EndPriceNumberEnumToJsonValue(getAssetsBodyInputSortEndPriceNumberEnum);
            if (obj is GetAssetsBodyInputSort.FixedPriceNumberEnum getAssetsBodyInputSortFixedPriceNumberEnum)
                return GetAssetsBodyInputSort.FixedPriceNumberEnumToJsonValue(getAssetsBodyInputSortFixedPriceNumberEnum);
            if (obj is GetAssetsBodyInputSort.RarityScoreEnum getAssetsBodyInputSortRarityScoreEnum)
                return GetAssetsBodyInputSort.RarityScoreEnumToJsonValue(getAssetsBodyInputSortRarityScoreEnum);
            if (obj is GetAssetsBodyInputSort.StartEnum getAssetsBodyInputSortStartEnum)
                return GetAssetsBodyInputSort.StartEnumToJsonValue(getAssetsBodyInputSortStartEnum);
            if (obj is GetAssetsBodyInputSort.StartPriceNumberEnum getAssetsBodyInputSortStartPriceNumberEnum)
                return GetAssetsBodyInputSort.StartPriceNumberEnumToJsonValue(getAssetsBodyInputSortStartPriceNumberEnum);
            if (obj is GetAssetsResponseDataInner.RarityEnum getAssetsResponseDataInnerRarityEnum)
                return GetAssetsResponseDataInner.RarityEnumToJsonValue(getAssetsResponseDataInnerRarityEnum);
            if (obj is GetChainCurrenciesResponseDataInner.CurrencyEnum getChainCurrenciesResponseDataInnerCurrencyEnum)
                return GetChainCurrenciesResponseDataInner.CurrencyEnumToJsonValue(getChainCurrenciesResponseDataInnerCurrencyEnum);
            if (obj is GetGameResponseContractsInner.TypeEnum getGameResponseContractsInnerTypeEnum)
                return GetGameResponseContractsInner.TypeEnumToJsonValue(getGameResponseContractsInnerTypeEnum);
            if (obj is GetGameResponsePoliciesInner.ModelEnum getGameResponsePoliciesInnerModelEnum)
                return GetGameResponsePoliciesInner.ModelEnumToJsonValue(getGameResponsePoliciesInnerModelEnum);
            if (obj is GetGameResponsePoliciesInner.TypeEnum getGameResponsePoliciesInnerTypeEnum)
                return GetGameResponsePoliciesInner.TypeEnumToJsonValue(getGameResponsePoliciesInnerTypeEnum);
            if (obj is GetGameResponsePoliciesInner.RateTypeEnum getGameResponsePoliciesInnerRateTypeEnum)
                return GetGameResponsePoliciesInner.RateTypeEnumToJsonValue(getGameResponsePoliciesInnerRateTypeEnum);
            if (obj is GetPoliciesResponseDataInner.RateTypeEnum getPoliciesResponseDataInnerRateTypeEnum)
                return GetPoliciesResponseDataInner.RateTypeEnumToJsonValue(getPoliciesResponseDataInnerRateTypeEnum);
            if (obj is GetProfileAssetsForGameFilterParameter.CurrenciesEnum getProfileAssetsForGameFilterParameterCurrenciesEnum)
                return GetProfileAssetsForGameFilterParameter.CurrenciesEnumToJsonValue(getProfileAssetsForGameFilterParameterCurrenciesEnum);
            if (obj is GetProfileAssetsForGameFilterParameter.RaritiesEnum getProfileAssetsForGameFilterParameterRaritiesEnum)
                return GetProfileAssetsForGameFilterParameter.RaritiesEnumToJsonValue(getProfileAssetsForGameFilterParameterRaritiesEnum);
            if (obj is GetProfileAssetsForGameFilterParameter.SellTypesEnum getProfileAssetsForGameFilterParameterSellTypesEnum)
                return GetProfileAssetsForGameFilterParameter.SellTypesEnumToJsonValue(getProfileAssetsForGameFilterParameterSellTypesEnum);
            if (obj is GetProfileAssetsForGameSortParameter.CreatedAtEnum getProfileAssetsForGameSortParameterCreatedAtEnum)
                return GetProfileAssetsForGameSortParameter.CreatedAtEnumToJsonValue(getProfileAssetsForGameSortParameterCreatedAtEnum);
            if (obj is GetProfileAssetsForGameSortParameter.EndEnum getProfileAssetsForGameSortParameterEndEnum)
                return GetProfileAssetsForGameSortParameter.EndEnumToJsonValue(getProfileAssetsForGameSortParameterEndEnum);
            if (obj is GetProfileAssetsForGameSortParameter.EndPriceNumberEnum getProfileAssetsForGameSortParameterEndPriceNumberEnum)
                return GetProfileAssetsForGameSortParameter.EndPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameterEndPriceNumberEnum);
            if (obj is GetProfileAssetsForGameSortParameter.FixedPriceNumberEnum getProfileAssetsForGameSortParameterFixedPriceNumberEnum)
                return GetProfileAssetsForGameSortParameter.FixedPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameterFixedPriceNumberEnum);
            if (obj is GetProfileAssetsForGameSortParameter.RarityScoreEnum getProfileAssetsForGameSortParameterRarityScoreEnum)
                return GetProfileAssetsForGameSortParameter.RarityScoreEnumToJsonValue(getProfileAssetsForGameSortParameterRarityScoreEnum);
            if (obj is GetProfileAssetsForGameSortParameter.StartEnum getProfileAssetsForGameSortParameterStartEnum)
                return GetProfileAssetsForGameSortParameter.StartEnumToJsonValue(getProfileAssetsForGameSortParameterStartEnum);
            if (obj is GetProfileAssetsForGameSortParameter.StartPriceNumberEnum getProfileAssetsForGameSortParameterStartPriceNumberEnum)
                return GetProfileAssetsForGameSortParameter.StartPriceNumberEnumToJsonValue(getProfileAssetsForGameSortParameterStartPriceNumberEnum);
            if (obj is RegenerateGameApiKeysResponseApiKeysInner.TypeEnum regenerateGameApiKeysResponseApiKeysInnerTypeEnum)
                return RegenerateGameApiKeysResponseApiKeysInner.TypeEnumToJsonValue(regenerateGameApiKeysResponseApiKeysInnerTypeEnum);
            if (obj is SellAssetRequestInput.SellTypeEnum sellAssetRequestInputSellTypeEnum)
                return SellAssetRequestInput.SellTypeEnumToJsonValue(sellAssetRequestInputSellTypeEnum);
            if (obj is SellAssetRequestInput.CurrencyEnum sellAssetRequestInputCurrencyEnum)
                return SellAssetRequestInput.CurrencyEnumToJsonValue(sellAssetRequestInputCurrencyEnum);
            if (obj is TradeTokensResponse.StatusEnum tradeTokensResponseStatusEnum)
                return TradeTokensResponse.StatusEnumToJsonValue(tradeTokensResponseStatusEnum);
            if (obj is TradeTokensResponse.TypeEnum tradeTokensResponseTypeEnum)
                return TradeTokensResponse.TypeEnumToJsonValue(tradeTokensResponseTypeEnum);
            if (obj is TransferAssetResponse.StatusEnum transferAssetResponseStatusEnum)
                return TransferAssetResponse.StatusEnumToJsonValue(transferAssetResponseStatusEnum);
            if (obj is TransferAssetResponse.TypeEnum transferAssetResponseTypeEnum)
                return TransferAssetResponse.TypeEnumToJsonValue(transferAssetResponseTypeEnum);
            if (obj is TransferTokenResponse.StatusEnum transferTokenResponseStatusEnum)
                return TransferTokenResponse.StatusEnumToJsonValue(transferTokenResponseStatusEnum);
            if (obj is TransferTokenResponse.TypeEnum transferTokenResponseTypeEnum)
                return TransferTokenResponse.TypeEnumToJsonValue(transferTokenResponseTypeEnum);
            if (obj is ICollection collection)
            {
                List<string> entries = new();
                foreach (var entry in collection)
                    entries.Add(ParameterToString(entry));
                return string.Join(",", entries);
            }

            return Convert.ToString(obj, System.Globalization.CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">string to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">string to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Convert stream to byte array
        /// </summary>
        /// <param name="inputStream">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream inputStream)
        {
            using (var ms = new MemoryStream())
            {
                inputStream.CopyTo(ms);
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON type exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public static string SelectHeaderContentType(string[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            foreach (var contentType in contentTypes)
            {
                if (IsJsonMime(contentType))
                    return contentType;
            }

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public static string SelectHeaderAccept(string[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return string.Join(",", accepts);
        }

        /// <summary>
        /// Provides a case-insensitive check that a provided content type is a known JSON-like content type.
        /// </summary>
        public static readonly Regex JsonRegex = new Regex("(?i)^(application/json|[^;/ \t]+/[^;/ \t]+[+]json)[ \t]*(;.*)?$");

        /// <summary>
        /// Check if the given MIME is a JSON MIME.
        /// JSON MIME examples:
        ///    application/json
        ///    application/json; charset=UTF8
        ///    APPLICATION/JSON
        ///    application/vnd.company+json
        /// </summary>
        /// <param name="mime">MIME</param>
        /// <returns>Returns True if MIME type is json.</returns>
        public static bool IsJsonMime(string mime)
        {
            if (string.IsNullOrWhiteSpace(mime)) return false;

            return JsonRegex.IsMatch(mime) || mime.Equals("application/json-patch+json");
        }

        /// <summary>
        /// The base path of the API
        /// </summary>
        public const string BASE_ADDRESS = "http://localhost";

        /// <summary>
        /// The scheme of the API
        /// </summary>
        public const string SCHEME = "http";

        /// <summary>
        /// The context path of the API
        /// </summary>
        public const string CONTEXT_PATH = "";

        /// <summary>
        /// The host of the API
        /// </summary>
        public const string HOST = "localhost";

        /// <summary>
        /// The format to use for DateTime serialization
        /// </summary>
        public const string ISO8601_DATETIME_FORMAT = "o";
    }
}
