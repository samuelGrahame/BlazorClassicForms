using System;
using Microsoft.JSInterop;

namespace BlazorClassicForms.HTML
{
	// Token: 0x02000015 RID: 21
	public class HTMLStyleCollection
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00002E0C File Offset: 0x0000100C
		public HTMLStyleCollection(HTMLElement _owner)
		{
			this.owner = _owner;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002E1B File Offset: 0x0000101B
		private void Set(string name, string value)
		{
			dom.JSRuntime.InvokeAsync<object>("element_style_set", new object[]
			{
				this.owner.uid,
				name,
				value
			});
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002E44 File Offset: 0x00001044
		private string Get(string name)
		{
			return dom.JSRuntime.InvokeAsync<string>("element_style_get", new object[]
			{
				this.owner.uid,
				name
			}).Result;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00002E68 File Offset: 0x00001068
		// (set) Token: 0x06000055 RID: 85 RVA: 0x00002E75 File Offset: 0x00001075
		public string overflow
		{
			get
			{
				return this.Get("overflow");
			}
			set
			{
				this.Set("overflow", value);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00002E83 File Offset: 0x00001083
		// (set) Token: 0x06000057 RID: 87 RVA: 0x00002E90 File Offset: 0x00001090
		public string position
		{
			get
			{
				return this.Get("position");
			}
			set
			{
				this.Set("position", value);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000058 RID: 88 RVA: 0x00002E9E File Offset: 0x0000109E
		// (set) Token: 0x06000059 RID: 89 RVA: 0x00002EAB File Offset: 0x000010AB
		public string boxSizing
		{
			get
			{
				return this.Get("boxSizing");
			}
			set
			{
				this.Set("boxSizing", value);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00002EB9 File Offset: 0x000010B9
		// (set) Token: 0x0600005B RID: 91 RVA: 0x00002EC6 File Offset: 0x000010C6
		public string padding
		{
			get
			{
				return this.Get("padding");
			}
			set
			{
				this.Set("padding", value);
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002ED4 File Offset: 0x000010D4
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00002EE1 File Offset: 0x000010E1
		public string fontSize
		{
			get
			{
				return this.Get("fontSize");
			}
			set
			{
				this.Set("fontSize", value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002EEF File Offset: 0x000010EF
		// (set) Token: 0x0600005F RID: 95 RVA: 0x00002EFC File Offset: 0x000010FC
		public string fontFamily
		{
			get
			{
				return this.Get("fontFamily");
			}
			set
			{
				this.Set("fontFamily", value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002F0A File Offset: 0x0000110A
		// (set) Token: 0x06000061 RID: 97 RVA: 0x00002F17 File Offset: 0x00001117
		public string backgroundColor
		{
			get
			{
				return this.Get("backgroundColor");
			}
			set
			{
				this.Set("backgroundColor", value);
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002F25 File Offset: 0x00001125
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00002F32 File Offset: 0x00001132
		public string cssFloat
		{
			get
			{
				return this.Get("cssFloat");
			}
			set
			{
				this.Set("cssFloat", value);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002F40 File Offset: 0x00001140
		// (set) Token: 0x06000065 RID: 101 RVA: 0x00002F4D File Offset: 0x0000114D
		public string wordWrap
		{
			get
			{
				return this.Get("wordWrap");
			}
			set
			{
				this.Set("wordWrap", value);
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002F5B File Offset: 0x0000115B
		// (set) Token: 0x06000067 RID: 103 RVA: 0x00002F68 File Offset: 0x00001168
		public string border
		{
			get
			{
				return this.Get("border");
			}
			set
			{
				this.Set("border", value);
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002F76 File Offset: 0x00001176
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00002F83 File Offset: 0x00001183
		public string borderStyle
		{
			get
			{
				return this.Get("borderStyle");
			}
			set
			{
				this.Set("borderStyle", value);
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002F91 File Offset: 0x00001191
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002F9E File Offset: 0x0000119E
		public string borderTopWidth
		{
			get
			{
				return this.Get("borderTopWidth");
			}
			set
			{
				this.Set("borderTopWidth", value);
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600006C RID: 108 RVA: 0x00002FAC File Offset: 0x000011AC
		// (set) Token: 0x0600006D RID: 109 RVA: 0x00002FB9 File Offset: 0x000011B9
		public string borderBottomWidth
		{
			get
			{
				return this.Get("borderBottomWidth");
			}
			set
			{
				this.Set("borderBottomWidth", value);
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00002FC7 File Offset: 0x000011C7
		// (set) Token: 0x0600006F RID: 111 RVA: 0x00002FD4 File Offset: 0x000011D4
		public string borderLeftWidth
		{
			get
			{
				return this.Get("borderLeftWidth");
			}
			set
			{
				this.Set("borderLeftWidth", value);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00002FE2 File Offset: 0x000011E2
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00002FEF File Offset: 0x000011EF
		public string borderRightWidth
		{
			get
			{
				return this.Get("borderRightWidth");
			}
			set
			{
				this.Set("borderRightWidth", value);
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002FFD File Offset: 0x000011FD
		// (set) Token: 0x06000073 RID: 115 RVA: 0x0000300A File Offset: 0x0000120A
		public string cursor
		{
			get
			{
				return this.Get("cursor");
			}
			set
			{
				this.Set("cursor", value);
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x06000075 RID: 117 RVA: 0x00003025 File Offset: 0x00001225
		public string width
		{
			get
			{
				return this.Get("width");
			}
			set
			{
				this.Set("width", value);
			}
		}

		public string direction
		{
			get
			{
				return this.Get("direction");
			}
			set
			{
				this.Set("direction", value);
			}
		}

		public string textAlign
		{
			get
			{
				return this.Get("textAlign");
			}
			set
			{
				this.Set("textAlign", value);
			}
		}
		//direction

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003033 File Offset: 0x00001233
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00003040 File Offset: 0x00001240
		public string height
		{
			get
			{
				return this.Get("height");
			}
			set
			{
				this.Set("height", value);
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000078 RID: 120 RVA: 0x0000304E File Offset: 0x0000124E
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000305B File Offset: 0x0000125B
		public string left
		{
			get
			{
				return this.Get("left");
			}
			set
			{
				this.Set("left", value);
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003069 File Offset: 0x00001269
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00003076 File Offset: 0x00001276
		public string top
		{
			get
			{
				return this.Get("top");
			}
			set
			{
				this.Set("top", value);
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003084 File Offset: 0x00001284
		// (set) Token: 0x0600007D RID: 125 RVA: 0x00003091 File Offset: 0x00001291
		public string opacity
		{
			get
			{
				return this.Get("opacity");
			}
			set
			{
				this.Set("opacity", value);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000309F File Offset: 0x0000129F
		// (set) Token: 0x0600007F RID: 127 RVA: 0x000030AC File Offset: 0x000012AC
		public string visibility
		{
			get
			{
				return this.Get("visibility");
			}
			set
			{
				this.Set("visibility", value);
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000030BA File Offset: 0x000012BA
		// (set) Token: 0x06000081 RID: 129 RVA: 0x000030C7 File Offset: 0x000012C7
		public string zIndex
		{
			get
			{
				return this.Get("zIndex");
			}
			set
			{
				this.Set("zIndex", value);
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000030D5 File Offset: 0x000012D5
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000030E2 File Offset: 0x000012E2
		public string userSelect
		{
			get
			{
				return this.Get("userSelect");
			}
			set
			{
				this.Set("userSelect", value);
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000030F0 File Offset: 0x000012F0
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000030FD File Offset: 0x000012FD
		public string outline
		{
			get
			{
				return this.Get("outline");
			}
			set
			{
				this.Set("outline", value);
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000086 RID: 134 RVA: 0x0000310B File Offset: 0x0000130B
		// (set) Token: 0x06000087 RID: 135 RVA: 0x00003118 File Offset: 0x00001318
		public string margin
		{
			get
			{
				return this.Get("margin");
			}
			set
			{
				this.Set("margin", value);
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00003126 File Offset: 0x00001326
		// (set) Token: 0x06000089 RID: 137 RVA: 0x00003133 File Offset: 0x00001333
		public string marginRight
		{
			get
			{
				return this.Get("marginRight");
			}
			set
			{
				this.Set("marginRight", value);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00003141 File Offset: 0x00001341
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000314E File Offset: 0x0000134E
		public string borderBottom
		{
			get
			{
				return this.Get("borderBottom");
			}
			set
			{
				this.Set("borderBottom", value);
			}
		}

		public string backgroundSize
		{
			get
			{
				return this.Get("backgroundSize");
			}
			set
			{
				this.Set("backgroundSize", value);
			}
		}

		public string backgroundRepeat
		{
			get
			{
				return this.Get("backgroundRepeat");
			}
			set
			{
				this.Set("backgroundRepeat", value);
			}
		}

		public string backgroundPosition
		{
			get
			{
				return this.Get("backgroundPosition");
			}
			set
			{
				this.Set("backgroundPosition", value);
			}
		}
		
		public string backgroundImage
		{
			get
			{
				return this.Get("backgroundImage");
			}
			set
			{
				this.Set("backgroundImage", value);
			}
		}
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600008C RID: 140 RVA: 0x0000315C File Offset: 0x0000135C
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00003169 File Offset: 0x00001369
		public string display
		{
			get
			{
				return this.Get("display");
			}
			set
			{
				this.Set("display", value);
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00003177 File Offset: 0x00001377
		// (set) Token: 0x0600008F RID: 143 RVA: 0x00003184 File Offset: 0x00001384
		public string lineHeight
		{
			get
			{
				return this.Get("lineHeight");
			}
			set
			{
				this.Set("lineHeight", value);
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000090 RID: 144 RVA: 0x00003192 File Offset: 0x00001392
		// (set) Token: 0x06000091 RID: 145 RVA: 0x0000319F File Offset: 0x0000139F
		public string color
		{
			get
			{
				return this.Get("color");
			}
			set
			{
				this.Set("color", value);
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000031AD File Offset: 0x000013AD
		// (set) Token: 0x06000093 RID: 147 RVA: 0x000031BA File Offset: 0x000013BA
		public string transform
		{
			get
			{
				return this.Get("transform");
			}
			set
			{
				this.Set("transform", value);
			}
		}

		// Token: 0x04000017 RID: 23
		private HTMLElement owner;
	}
}
