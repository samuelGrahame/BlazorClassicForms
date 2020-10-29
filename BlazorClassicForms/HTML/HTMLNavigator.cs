using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000010 RID: 16
	public class HTMLNavigator
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002B70 File Offset: 0x00000D70
		public HTMLNavigator()
		{
			this.uid = dom.JSRuntime.InvokeAsync<string>("_navigator", Array.Empty<object>()).Result;
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002B8D File Offset: 0x00000D8D
		public string userAgent
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"userAgent"
				}).Result;
			}
		}

		// Token: 0x04000012 RID: 18
		public string uid;
	}
}
