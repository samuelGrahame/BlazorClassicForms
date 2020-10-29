using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000012 RID: 18
	public class HTMLSelectElement : HTMLElement
	{
		// Token: 0x06000049 RID: 73 RVA: 0x00002BBD File Offset: 0x00000DBD
		public HTMLSelectElement() : base("select")
		{
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002BCA File Offset: 0x00000DCA
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002BED File Offset: 0x00000DED
		public bool multiple
		{
			get
			{
				return  dom.JSRuntime.InvokeAsync<bool>("element_get", new object[]
				{
					this.uid,
					"multiple"
				}).Result;
			}
			set
			{				
				dom.JSRuntime.InvokeVoidAsync("element_set", new object[] { uid, "multiple", value });
			}
		}
	}
}
