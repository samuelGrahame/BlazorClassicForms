using System;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000007 RID: 7
	public class HTMLClassList
	{
		// Token: 0x06000009 RID: 9 RVA: 0x0000210D File Offset: 0x0000030D
		public HTMLClassList(HTMLElement _owner)
		{
			this.owner = _owner;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000211C File Offset: 0x0000031C
		public bool contains(string value)
		{
			return dom.JSRuntime.Invoke<bool>("classList_contains", new object[]
			{
				this.owner.uid,
				value
			});
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002140 File Offset: 0x00000340
		public void remove(string value)
		{
			dom.JSRuntime.Invoke<bool>("classList_remove", new object[]
			{
				this.owner.uid,
				value
			});
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002165 File Offset: 0x00000365
		public void add(string value)
		{
			dom.JSRuntime.Invoke<bool>("classList_add", new object[]
			{
				this.owner.uid,
				value
			});
		}

		// Token: 0x0400000C RID: 12
		private HTMLElement owner;
	}
}
