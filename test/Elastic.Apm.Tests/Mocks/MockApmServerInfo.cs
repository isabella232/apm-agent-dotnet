// Licensed to Elasticsearch B.V under
// one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using Elastic.Apm.ServerInfo;

namespace Elastic.Apm.Tests.Mocks
{
	internal class MockApmServerInfo : IApmServerInfo
	{
		public MockApmServerInfo()
			=> Version = new ElasticVersion(7, 10, 0, null);

		public MockApmServerInfo(ElasticVersion version) => Version = version;

		public ElasticVersion Version { get; set; }
	}
}
