using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x0200001A RID: 26
	public class HTMLWindow
	{
		// Token: 0x0600009A RID: 154 RVA: 0x00003260 File Offset: 0x00001460
		public HTMLWindow()
		{
			this.uid = dom.JSRuntime.InvokeAsync<string>("_window", Array.Empty<object>()).Result;
			this._nav = new HTMLNavigator();
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003288 File Offset: 0x00001488
		public HTMLNavigator navigator
		{
			get
			{
				return this._nav;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003290 File Offset: 0x00001490
		// (set) Token: 0x0600009D RID: 157 RVA: 0x000032A2 File Offset: 0x000014A2
		public double innerHeight
		{
			get
			{
				return Convert.ToDouble(this.Get("innerHeight"));
			}
			set
			{
				this.Set("innerHeight", (long)value);
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600009E RID: 158 RVA: 0x000032B1 File Offset: 0x000014B1
		// (set) Token: 0x0600009F RID: 159 RVA: 0x000032C3 File Offset: 0x000014C3
		public double innerWidth
		{
			get
			{
				return Convert.ToDouble(this.Get("innerWidth"));
			}
			set
			{
				this.Set("innerWidth", (long)value);
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000032D2 File Offset: 0x000014D2
		private void Set(string name, long value)
		{
			dom.JSRuntime.InvokeAsync<object>("element_set", new object[]
			{
				this.uid,
				name,
				value
			});
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000032FB File Offset: 0x000014FB
		private long Get(string name)
		{
			return dom.JSRuntime.InvokeAsync<long>("element_get", new object[]
			{
				this.uid,
				name
			}).Result;
		}

		// Token: 0x17000040 RID: 64
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000331C File Offset: 0x0000151C
		public Action<MouseEvent> onmousemove
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onmousemove", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000041 RID: 65
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00003368 File Offset: 0x00001568
		public Action<MouseEvent> onmouseup
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onmouseup", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000042 RID: 66
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000033B4 File Offset: 0x000015B4
		public Action<Event> onresize
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onresize", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x04000018 RID: 24
		public string uid;

		// Token: 0x04000019 RID: 25
		private HTMLNavigator _nav;
	}
}
