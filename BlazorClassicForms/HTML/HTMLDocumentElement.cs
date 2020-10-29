using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000009 RID: 9
	public class HTMLDocumentElement : HTMLElement
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002197 File Offset: 0x00000397
		public HTMLDocumentElement()
		{
			this.uid = dom.JSRuntime.InvokeAsync<string>("_document", Array.Empty<object>()).Result;
			this._body = new HTMLElement
			{
				uid = dom.JSRuntime.InvokeAsync<string>("_body", Array.Empty<object>()).Result
			};
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000021D4 File Offset: 0x000003D4
		public HTMLDocumentFragement createDocumentFragment()
		{
			return new HTMLDocumentFragement
			{
				uid = dom.JSRuntime.InvokeAsync<string>("createDocumentFragment", Array.Empty<object>()).Result
			};
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000021F0 File Offset: 0x000003F0
		public HTMLElement body
		{
			get
			{
				return this._body;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000021F8 File Offset: 0x000003F8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002214 File Offset: 0x00000414
		public HTMLElement activeElement
		{
			get
			{
				return new HTMLElement
				{
					uid = dom.JSRuntime.InvokeAsync<string>("document_activeElement_get", Array.Empty<object>()).Result
				};
			}
			set
			{
				dom.JSRuntime.InvokeAsync<object>("document_activeElement_set", new object[]
				{
					(value == null) ? string.Empty : value.uid
				});
			}
		}

		// Token: 0x0400000D RID: 13
		private HTMLElement _body;
	}
}
