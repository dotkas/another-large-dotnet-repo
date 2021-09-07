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

using OneOf;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Snapshot
{
	public partial class CleanupRepositoryResponse : ResponseBase
	{
		[JsonPropertyName("results")]
		public Elastic.Clients.Elasticsearch.Snapshot.CleanupRepository.CleanupRepositoryResults Results
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class CloneResponse : AcknowledgedResponseBase
	{
	}

	public partial class CreateRepositoryResponse : AcknowledgedResponseBase
	{
	}

	public partial class CreateResponse : ResponseBase
	{
		[JsonPropertyName("accepted")]
		public bool? Accepted
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("snapshot")]
		public Elastic.Clients.Elasticsearch.Snapshot.SnapshotInfo Snapshot
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class DeleteRepositoryResponse : AcknowledgedResponseBase
	{
	}

	public partial class DeleteResponse : AcknowledgedResponseBase
	{
	}

	public partial class GetRepositoryResponse : DictionaryResponseBase<string, Elastic.Clients.Elasticsearch.Snapshot.Repository>
	{
	}

	public partial class GetResponse : ResponseBase
	{
		[JsonPropertyName("remaining")]
		public int Remaining
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("responses")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.Get.SnapshotResponseItem>? Responses
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("snapshots")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.SnapshotInfo>? Snapshots
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}

		[JsonPropertyName("total")]
		public int Total
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class RestoreResponse : ResponseBase
	{
		[JsonPropertyName("snapshot")]
		public Elastic.Clients.Elasticsearch.Snapshot.Restore.SnapshotRestore Snapshot
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class StatusResponse : ResponseBase
	{
		[JsonPropertyName("snapshots")]
		public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Snapshot.Status> Snapshots
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}

	public partial class VerifyRepositoryResponse : ResponseBase
	{
		[JsonPropertyName("nodes")]
		public Dictionary<string, Elastic.Clients.Elasticsearch.Snapshot.VerifyRepository.CompactNodeInfo> Nodes
		{
			get;
#if NET5_0_OR_GREATER
			init;
#else
			internal set;
#endif
		}
	}
}