using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x0200000D RID: 13
	public class HTMLInputElement : HTMLElement
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00002A63 File Offset: 0x00000C63
		public HTMLInputElement() : base("input")
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002A70 File Offset: 0x00000C70
		// (set) Token: 0x0600003F RID: 63 RVA: 0x00002A93 File Offset: 0x00000C93
		public bool @checked
		{
			get
			{
				return dom.JSRuntime.Invoke<bool>("element_get", new object[]
				{
					this.uid,
					"checked"
				});
			}
			set
			{
				dom.JSRuntime.Invoke<bool>("element_set", new object[]
				{
					this.uid,
					"checked",
					value
				});
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000040 RID: 64 RVA: 0x00002AC0 File Offset: 0x00000CC0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x00002AE3 File Offset: 0x00000CE3
		public string type
		{
			get
			{
				return dom.JSRuntime.Invoke<string>("element_get", new object[]
				{
					this.uid,
					"type"
				});
			}
			set
			{
				dom.JSRuntime.Invoke<string>("element_set", new object[]
				{
					this.uid,
					"type",
					value
				});
			}
		}
	}
}
