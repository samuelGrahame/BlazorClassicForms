using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000014 RID: 20
	public static class dom
	{
		[Inject]
		public static IJSRuntime JSRuntime { get; set; }

		// Token: 0x0600004D RID: 77 RVA: 0x00002C27 File Offset: 0x00000E27
		static dom()
		{
			dom.document = new HTMLDocumentElement();
			dom.window = new HTMLWindow();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002C54 File Offset: 0x00000E54
		public static string ToHtml(this Color color)
		{
			if (color.A != 255)
			{
				return string.Format("rgba({1},{2},{3},{0})", new object[]
				{
					color.A,
					color.R,
					color.G,
					color.B
				});
			}
			return string.Format("rgb({0},{1},{2})", color.R, color.G, color.B);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002CEC File Offset: 0x00000EEC
		public static void InvokeEvent(string uid, string ev)
		{
			try
			{
				dom.normalEvent[uid](new Event
				{
					uid = ev
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002D2C File Offset: 0x00000F2C
		public static void InvokeMouseEvent(string uid, string ev)
		{
			try
			{
				MouseEvent obj = null;
				try
				{
					string[] array = ev.Split(new char[]
					{
						'\n'
					});
					obj = new MouseEvent
					{
						x = Convert.ToDouble(array[0]),
						y = Convert.ToDouble(array[1]),
						clientX = Convert.ToDouble(array[2]),
						clientY = Convert.ToDouble(array[3]),
						layerX = Convert.ToDouble(array[4]),
						layerY = Convert.ToDouble(array[5]),
						currentTarget = new HTMLElement
						{
							uid = array[6]
						},
						button = Convert.ToDouble(array[7]),
						uid = array[8]
					};
				}
				catch (Exception)
				{
				}
				dom.normalMouseEvent[uid](obj);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000013 RID: 19
		public static HTMLDocumentElement document;

		// Token: 0x04000014 RID: 20
		public static HTMLWindow window;

		// Token: 0x04000015 RID: 21
		public static Dictionary<string, Action<Event>> normalEvent = new Dictionary<string, Action<Event>>();

		// Token: 0x04000016 RID: 22
		public static Dictionary<string, Action<MouseEvent>> normalMouseEvent = new Dictionary<string, Action<MouseEvent>>();
	}
}
