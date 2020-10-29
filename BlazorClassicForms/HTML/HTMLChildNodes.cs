using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000006 RID: 6
	public class HTMLChildNodes
	{
		// Token: 0x06000007 RID: 7 RVA: 0x000020BA File Offset: 0x000002BA
		public HTMLChildNodes(HTMLElement _owner)
		{
			this.owner = _owner;
		}

		// Token: 0x17000001 RID: 1
		public HTMLElement this[int index]
		{
			get
			{
				return new HTMLElement
				{
					uid = dom.JSRuntime.InvokeAsync<string>("element_childnode", new object[]
					{
						this.owner.uid,
						index
					}).Result
				};
			}
		}

		public int length => dom.JSRuntime.InvokeAsync<int>("element_childnode_count", new object[] { this.owner.uid }).Result;

		// Token: 0x0400000B RID: 11
		private HTMLElement owner;
	}
}
