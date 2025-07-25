// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration
{
    internal partial class KeyVaultRestClient
    {
        private static ResponseClassifier _pipelineMessageClassifier200;
        private static ResponseClassifier _pipelineMessageClassifier202;

        private static ResponseClassifier PipelineMessageClassifier200 => _pipelineMessageClassifier200 = new StatusCodeClassifier(stackalloc ushort[] { 200 });

        private static ResponseClassifier PipelineMessageClassifier202 => _pipelineMessageClassifier202 = new StatusCodeClassifier(stackalloc ushort[] { 202 });

        internal HttpMessage CreateFullBackupRequest(RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier202);
            Request request = message.Request;
            request.Method = RequestMethod.Post;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/backup", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePreFullBackupRequest(RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier202);
            Request request = message.Request;
            request.Method = RequestMethod.Post;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/prebackup", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateFullRestoreOperationRequest(RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier202);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/restore", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreatePreFullRestoreOperationRequest(RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier202);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/prerestore", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateFullBackupStatusRequest(string jobId, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/backup/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath("/pending", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateRestoreStatusRequest(string jobId, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/restore/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath("/pending", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateSelectiveKeyRestoreStatusRequest(string jobId, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/restore/", false);
            uri.AppendPath(jobId, true);
            uri.AppendPath("/pending", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateSelectiveKeyRestoreOperationRequest(string keyName, RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier202);
            Request request = message.Request;
            request.Method = RequestMethod.Put;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/keys/", false);
            uri.AppendPath(keyName, true);
            uri.AppendPath("/restore", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateUpdateSettingRequest(string settingName, RequestContent content, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Patch;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/settings/", false);
            uri.AppendPath(settingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Content-Type", "application/json");
            request.Headers.SetValue("Accept", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateGetSettingRequest(string settingName, RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/settings/", false);
            uri.AppendPath(settingName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }

        internal HttpMessage CreateGetSettingsRequest(RequestContext context)
        {
            HttpMessage message = Pipeline.CreateMessage(context, PipelineMessageClassifier200);
            Request request = message.Request;
            request.Method = RequestMethod.Get;
            RawRequestUriBuilder uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/settings", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.SetValue("Accept", "application/json");
            return message;
        }
    }
}
