using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000016 RID: 22
	public class HTMLTableElement : HTMLElement
	{
		// Token: 0x06000094 RID: 148 RVA: 0x000031C8 File Offset: 0x000013C8
		public HTMLTableElement() : base("table")
		{
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000031D8 File Offset: 0x000013D8
		public HTMLTableSectionElement createTBody()
		{
			return new HTMLTableSectionElement
			{
				uid = dom.JSRuntime.Invoke<string>("createElement", new object[]
				{
					"tbody"
				})
			};
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000320C File Offset: 0x0000140C
		public HTMLTableSectionElement createTHead()
		{
			return new HTMLTableSectionElement
			{
				uid = dom.JSRuntime.Invoke<string>("createElement", new object[]
				{
					"thead"
				})
			};
		}
	}
}
