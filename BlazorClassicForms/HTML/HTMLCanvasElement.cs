using BlazorClassicForms.HTML.ES;
using System;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000008 RID: 8
	public class HTMLCanvasElement : HTMLElement
	{
		// Token: 0x0600000D RID: 13 RVA: 0x0000218A File Offset: 0x0000038A
		public HTMLCanvasElement() : base("canvas")
		{
		}

		public CanvasRenderingContext2D getContext(string context)
        {
			// TODO
			return null;
        }
	}

	public class CanvasRenderingContext2D
    {
		public string font;
		public TextMetrics measureText(string source)
        {
			return null;
        }

	}
}
