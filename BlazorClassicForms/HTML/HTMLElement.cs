using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x0200000B RID: 11
	public class HTMLElement
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002242 File Offset: 0x00000442
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002265 File Offset: 0x00000465
		public string value
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"value"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"value",
					value
				});
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000016 RID: 22 RVA: 0x0000228D File Offset: 0x0000048D
		// (set) Token: 0x06000017 RID: 23 RVA: 0x000022B0 File Offset: 0x000004B0
		public string innerText
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"innerText"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"innerText",
					value
				});
			}
		}

		// Token: 0x17000006 RID: 6
		// (set) Token: 0x06000018 RID: 24 RVA: 0x000022D8 File Offset: 0x000004D8
		public Action<MouseEvent> onmousedown
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onmousedown", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000007 RID: 7
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002324 File Offset: 0x00000524
		public Action<MouseEvent> ondblclick
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("ondblclick", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000008 RID: 8
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002370 File Offset: 0x00000570
		public Action<Event> onchange
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onchange", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000009 RID: 9
		// (set) Token: 0x0600001B RID: 27 RVA: 0x000023BC File Offset: 0x000005BC
		public Action<Event> onpaste
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onpaste", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000A RID: 10
		// (set) Token: 0x0600001C RID: 28 RVA: 0x00002408 File Offset: 0x00000608
		public Action<Event> onkeydown
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onkeydown", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000B RID: 11
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002454 File Offset: 0x00000654
		public Action<Event> onkeyup
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onkeyup", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000C RID: 12
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000024A0 File Offset: 0x000006A0
		public Action<Event> onclick
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onclick", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000D RID: 13
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000024EC File Offset: 0x000006EC
		public Action<Event> onblur
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onblur", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000E RID: 14
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002538 File Offset: 0x00000738
		public Action<MouseEvent> onmouseenter
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onmouseenter", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x1700000F RID: 15
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00002584 File Offset: 0x00000784
		public Action<MouseEvent> onmouseleave
		{
			set
			{
				string text = Guid.NewGuid().ToString();
				dom.normalMouseEvent.Add(text, value);
				dom.JSRuntime.InvokeAsync<object>("onmouseleave", new object[]
				{
					this.uid,
					text
				});
			}
		}

		// Token: 0x17000010 RID: 16
		// (set) Token: 0x06000022 RID: 34 RVA: 0x000025D0 File Offset: 0x000007D0
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

		// Token: 0x17000011 RID: 17
		// (set) Token: 0x06000023 RID: 35 RVA: 0x0000261C File Offset: 0x0000081C
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

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002668 File Offset: 0x00000868
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000026A5 File Offset: 0x000008A5
		public HTMLElement parentElement
		{
			get
			{
				string value = dom.JSRuntime.InvokeAsync<string>("element_parentElement_get", new object[]
				{
					this.uid
				}).Result;
				if (string.IsNullOrWhiteSpace(value))
				{
					return null;
				}
				return new HTMLElement
				{
					uid = value
				};
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_parentElement_set", new object[]
				{
					this.uid,
					value
				});
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000026C5 File Offset: 0x000008C5
		public HTMLElement(string tag) : this()
		{
			this.uid = dom.JSRuntime.InvokeAsync<string>("createElement", new object[]
			{
				tag
			}).Result;
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000026E7 File Offset: 0x000008E7
		// (set) Token: 0x06000028 RID: 40 RVA: 0x0000270A File Offset: 0x0000090A
		public int tabIndex
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<int>("element_get", new object[]
				{
					this.uid,
					"tabIndex"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<int>("element_set", new object[]
				{
					this.uid,
					"tabIndex",
					value
				});
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002737 File Offset: 0x00000937
		// (set) Token: 0x0600002A RID: 42 RVA: 0x0000275A File Offset: 0x0000095A
		public string textContent
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"textContent"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"textContent",
					value
				});
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002782 File Offset: 0x00000982
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000027A5 File Offset: 0x000009A5
		public string id
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"id"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"id",
					value
				});
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000027CD File Offset: 0x000009CD
		public HTMLElement()
		{
			this.style = new HTMLStyleCollection(this);
			this.classList = new HTMLClassList(this);
			this.childNodes = new HTMLChildNodes(this);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000027F9 File Offset: 0x000009F9
		public void appendChild(HTMLElement child)
		{
			dom.JSRuntime.InvokeAsync<object>("appendChild", new object[]
			{
				this.uid,
				child.uid
			});
		}

		// Token: 0x0600002F RID: 47 RVA: 0x0000281E File Offset: 0x00000A1E
		public void removeChild(HTMLElement child)
		{
			dom.JSRuntime.InvokeAsync<object>("removeChild", new object[]
			{
				this.uid,
				child.uid
			});
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002843 File Offset: 0x00000A43
		public T As<T>() where T : HTMLElement
		{
			return (T)((object)this);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000284B File Offset: 0x00000A4B
		public void insertBefore(HTMLElement child, HTMLElement child2)
		{
			dom.JSRuntime.InvokeAsync<object>("insertBefore", new object[]
			{
				this.uid,
				child.uid,
				child2.uid
			});
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000032 RID: 50 RVA: 0x00002879 File Offset: 0x00000A79
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00002894 File Offset: 0x00000A94
		public string innerHTML
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("innerHTML_get", new object[]
				{
					this.uid
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("innerHTML_set", new object[]
				{
					this.uid,
					value
				});
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000028B4 File Offset: 0x00000AB4
		// (set) Token: 0x06000035 RID: 53 RVA: 0x000028D7 File Offset: 0x00000AD7
		public string className
		{
			get
			{
				return dom.JSRuntime.InvokeAsync<string>("element_get", new object[]
				{
					this.uid,
					"className"
				}).Result;
			}
			set
			{
				dom.JSRuntime.InvokeAsync<string>("element_set", new object[]
				{
					this.uid,
					"className",
					value
				});
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002900 File Offset: 0x00000B00
		public DOMRect getBoundingClientRect()
		{
			string[] array = dom.JSRuntime.InvokeAsync<string>("getBoundingClientRect", new object[]
			{
				this.uid
			}).Result.Split(new char[]
			{
				','
			});
			return new DOMRect
			{
				left = Convert.ToDouble(array[0]),
				top = Convert.ToDouble(array[1]),
				right = Convert.ToDouble(array[2]),
				bottom = Convert.ToDouble(array[3]),
				x = Convert.ToDouble(array[4]),
				y = Convert.ToDouble(array[5]),
				width = Convert.ToDouble(array[6]),
				height = Convert.ToDouble(array[7])
			};
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000029AC File Offset: 0x00000BAC
		public void focus()
		{
			dom.JSRuntime.InvokeAsync<string>("element_call", new object[]
			{
				this.uid,
				"focus"
			});
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000029D0 File Offset: 0x00000BD0
		public void blur()
		{
			dom.JSRuntime.InvokeAsync<string>("element_call", new object[]
			{
				this.uid,
				"blur"
			});
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000029F4 File Offset: 0x00000BF4
		public string getAttribute(string name)
		{
			return dom.JSRuntime.InvokeAsync<string>("getAttribute", new object[]
			{
				this.uid,
				name
			}).Result;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002A13 File Offset: 0x00000C13
		public string removeAttribute(string name)
		{
			return dom.JSRuntime.InvokeAsync<string>("removeAttribute", new object[]
			{
				this.uid,
				name
			}).Result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002A32 File Offset: 0x00000C32
		public void setAttribute(string name, string value)
		{
			dom.JSRuntime.InvokeAsync<string>("setAttribute", new object[]
			{
				this.uid,
				name,
				value
			});
		}

		// Token: 0x0400000E RID: 14
		public string uid;

		// Token: 0x0400000F RID: 15
		public HTMLStyleCollection style;

		// Token: 0x04000010 RID: 16
		public HTMLClassList classList;

		// Token: 0x04000011 RID: 17
		public HTMLChildNodes childNodes;
	}
}
