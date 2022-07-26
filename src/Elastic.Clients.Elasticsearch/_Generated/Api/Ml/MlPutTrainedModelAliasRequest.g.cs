// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed class MlPutTrainedModelAliasRequestParameters : RequestParameters<MlPutTrainedModelAliasRequestParameters>
	{
		[JsonIgnore]
		public bool? Reassign { get => Q<bool?>("reassign"); set => Q("reassign", value); }
	}

	public sealed partial class MlPutTrainedModelAliasRequest : PlainRequestBase<MlPutTrainedModelAliasRequestParameters>
	{
		public MlPutTrainedModelAliasRequest(Elastic.Clients.Elasticsearch.Id model_id, Elastic.Clients.Elasticsearch.Name model_alias) : base(r => r.Required("model_id", model_id).Required("model_alias", model_alias))
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningPutTrainedModelAlias;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		[JsonIgnore]
		public bool? Reassign { get => Q<bool?>("reassign"); set => Q("reassign", value); }
	}

	public sealed partial class MlPutTrainedModelAliasRequestDescriptor : RequestDescriptorBase<MlPutTrainedModelAliasRequestDescriptor, MlPutTrainedModelAliasRequestParameters>
	{
		internal MlPutTrainedModelAliasRequestDescriptor(Action<MlPutTrainedModelAliasRequestDescriptor> configure) => configure.Invoke(this);
		public MlPutTrainedModelAliasRequestDescriptor(Elastic.Clients.Elasticsearch.Id model_id, Elastic.Clients.Elasticsearch.Name model_alias) : base(r => r.Required("model_id", model_id).Required("model_alias", model_alias))
		{
		}

		internal MlPutTrainedModelAliasRequestDescriptor()
		{
		}

		internal override ApiUrls ApiUrls => ApiUrlsLookups.MachineLearningPutTrainedModelAlias;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => false;
		public MlPutTrainedModelAliasRequestDescriptor Reassign(bool? reassign = true) => Qs("reassign", reassign);
		public MlPutTrainedModelAliasRequestDescriptor ModelAlias(Elastic.Clients.Elasticsearch.Name model_alias)
		{
			RouteValues.Required("model_alias", model_alias);
			return Self;
		}

		public MlPutTrainedModelAliasRequestDescriptor ModelId(Elastic.Clients.Elasticsearch.Id model_id)
		{
			RouteValues.Required("model_id", model_id);
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
		}
	}
}