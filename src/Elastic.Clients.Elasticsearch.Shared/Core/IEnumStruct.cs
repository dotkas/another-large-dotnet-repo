// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

#if ELASTICSEARCH_SERVERLESS
namespace Elastic.Clients.Elasticsearch.Serverless.Core;
#else
namespace Elastic.Clients.Elasticsearch.Core;
#endif

internal interface IEnumStruct<TSelf> where TSelf : struct, IEnumStruct<TSelf>
{
	// TODO: Can be made static when targeting .NET 7 and higher
	TSelf Create(string value);
}