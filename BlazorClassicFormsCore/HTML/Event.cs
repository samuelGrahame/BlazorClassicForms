using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000003 RID: 3
	public class Event
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public void stopPropagation()
		{
			dom.JSRuntime.Invoke<object>("stopPropagation", new object[]
			{
				this.uid
			});
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002074 File Offset: 0x00000274
		public void preventDefault()
		{
			dom.JSRuntime.Invoke<object>("element_call", new object[]
			{
				this.uid,
				"preventDefault"
			});
		}

		// Token: 0x04000009 RID: 9
		public HTMLElement currentTarget;

		// Token: 0x0400000A RID: 10
		public string uid;
	}
}
