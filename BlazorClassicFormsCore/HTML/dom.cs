using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000014 RID: 20	
	public static class dom
	{		
		public static IJSInProcessRuntime JSRuntime { get; set; }

		public static void Setup(IJSInProcessRuntime _jsRuntime)
        {
			
			JSRuntime = _jsRuntime;
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
		[JSInvokable]
		public static void InvokeEvent(string[] source) // 
		{			
			try
			{
				dom.normalEvent[source[0]](new Event
				{
					uid = source[1]
				});
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002D2C File Offset: 0x00000F2C
		[JSInvokable]
		public static void InvokeMouseEvent(string[] source) // string uid, string ev
		{
			try
			{
				MouseEvent obj = null;
				try
				{
					string[] array = source[1].Split(new char[]
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
				dom.normalMouseEvent[source[0]](obj);
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
