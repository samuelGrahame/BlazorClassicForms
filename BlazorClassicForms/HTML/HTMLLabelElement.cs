using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x0200000E RID: 14
	public class HTMLLabelElement : HTMLElement
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00002B0B File Offset: 0x00000D0B
		public HTMLLabelElement() : base("label")
		{
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00002B18 File Offset: 0x00000D18
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00002B3B File Offset: 0x00000D3B
		public string htmlFor
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"htmlFor"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"htmlFor",
					value
				});
			}
		}
	}
}
