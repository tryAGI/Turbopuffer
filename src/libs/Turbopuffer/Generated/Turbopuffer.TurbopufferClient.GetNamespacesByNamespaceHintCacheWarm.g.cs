
#nullable enable

namespace Turbopuffer
{
    public partial class TurbopufferClient
    {


        private static readonly global::Turbopuffer.EndPointSecurityRequirement s_GetNamespacesByNamespaceHintCacheWarmSecurityRequirement0 =
            new global::Turbopuffer.EndPointSecurityRequirement
            {
                Authorizations = new global::Turbopuffer.EndPointAuthorizationRequirement[]
                {                    new global::Turbopuffer.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Turbopuffer.EndPointSecurityRequirement[] s_GetNamespacesByNamespaceHintCacheWarmSecurityRequirements =
            new global::Turbopuffer.EndPointSecurityRequirement[]
            {                s_GetNamespacesByNamespaceHintCacheWarmSecurityRequirement0,
            };
        partial void PrepareGetNamespacesByNamespaceHintCacheWarmArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string @namespace);
        partial void PrepareGetNamespacesByNamespaceHintCacheWarmRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string @namespace);
        partial void ProcessGetNamespacesByNamespaceHintCacheWarmResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetNamespacesByNamespaceHintCacheWarmResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Signal turbopuffer to prepare for low-latency requests.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Turbopuffer.GetNamespacesHintCacheWarmResponse> GetNamespacesByNamespaceHintCacheWarmAsync(
            string @namespace,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await GetNamespacesByNamespaceHintCacheWarmAsResponseAsync(
                @namespace: @namespace,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Signal turbopuffer to prepare for low-latency requests.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Turbopuffer.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.GetNamespacesHintCacheWarmResponse>> GetNamespacesByNamespaceHintCacheWarmAsResponseAsync(
            string @namespace,
            global::Turbopuffer.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetNamespacesByNamespaceHintCacheWarmArguments(
                httpClient: HttpClient,
                @namespace: ref @namespace);


            var __authorizations = global::Turbopuffer.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetNamespacesByNamespaceHintCacheWarmSecurityRequirements,
                operationName: "GetNamespacesByNamespaceHintCacheWarmAsync");

            using var __timeoutCancellationTokenSource = global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Turbopuffer.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Turbopuffer.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Turbopuffer.PathBuilder(
                                path: $"/v1/namespaces/{@namespace}/hint_cache_warm",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Turbopuffer.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::Turbopuffer.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareGetNamespacesByNamespaceHintCacheWarmRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    @namespace: @namespace!);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Turbopuffer.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getNamespacesByNamespaceHintCacheWarm",
                                methodName: "GetNamespacesByNamespaceHintCacheWarmAsync",
                                pathTemplate: "$\"/v1/namespaces/{@namespace}/hint_cache_warm\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Turbopuffer.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Turbopuffer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getNamespacesByNamespaceHintCacheWarm",
                                methodName: "GetNamespacesByNamespaceHintCacheWarmAsync",
                                pathTemplate: "$\"/v1/namespaces/{@namespace}/hint_cache_warm\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Turbopuffer.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Turbopuffer.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Turbopuffer.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Turbopuffer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getNamespacesByNamespaceHintCacheWarm",
                                methodName: "GetNamespacesByNamespaceHintCacheWarmAsync",
                                pathTemplate: "$\"/v1/namespaces/{@namespace}/hint_cache_warm\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Turbopuffer.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessGetNamespacesByNamespaceHintCacheWarmResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Turbopuffer.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getNamespacesByNamespaceHintCacheWarm",
                                methodName: "GetNamespacesByNamespaceHintCacheWarmAsync",
                                pathTemplate: "$\"/v1/namespaces/{@namespace}/hint_cache_warm\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Turbopuffer.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Turbopuffer.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "getNamespacesByNamespaceHintCacheWarm",
                                methodName: "GetNamespacesByNamespaceHintCacheWarmAsync",
                                pathTemplate: "$\"/v1/namespaces/{@namespace}/hint_cache_warm\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // An error response.
                            if (!__response.IsSuccessStatusCode)
                            {
                                string? __content_default = null;
                                global::System.Exception? __exception_default = null;
                                global::Turbopuffer.ErrorResponse? __value_default = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_default = global::Turbopuffer.ErrorResponse.FromJson(__content_default, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_default = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_default = global::Turbopuffer.ErrorResponse.FromJson(__content_default, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_default = __ex;
                                }

                                throw new global::Turbopuffer.ApiException<global::Turbopuffer.ErrorResponse>(
                                    message: __content_default ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_default,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_default,
                                    ResponseObject = __value_default,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessGetNamespacesByNamespaceHintCacheWarmResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Turbopuffer.GetNamespacesHintCacheWarmResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.GetNamespacesHintCacheWarmResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Turbopuffer.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Turbopuffer.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Turbopuffer.GetNamespacesHintCacheWarmResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Turbopuffer.AutoSDKHttpResponse<global::Turbopuffer.GetNamespacesHintCacheWarmResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Turbopuffer.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Turbopuffer.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}