using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClassicForms
{    
	public class Union<T1, T2, T3>
	{
		// Token: 0x06005581 RID: 21889
		protected Union()
        {

        }

		private Type _internalType;
		private int _slot;

		public T1 V1;
		public T2 V2;
		public T3 V3;

		// Token: 0x06005582 RID: 21890
		public static implicit operator Union<T1, T2, T3>(T1 t)
        {
			return new Union<T1, T2, T3>() { _internalType = typeof(T1), V1 = t, _slot = 0 };
        }

		// Token: 0x06005583 RID: 21891
		public static implicit operator Union<T1, T2, T3>(T2 t)
        {
			return new Union<T1, T2, T3>() { _internalType = typeof(T2), V2 = t, _slot = 1 };
		}

		// Token: 0x06005584 RID: 21892
		public static implicit operator Union<T1, T2, T3>(T3 t)
        {
			return new Union<T1, T2, T3>() { _internalType = typeof(T3), V3 = t, _slot = 2 };
		}

		// Token: 0x06005585 RID: 21893
		public static explicit operator T1(Union<T1, T2, T3> value)
        {
            switch (value._slot)
            {
				case 0:
					return value.V1;
				case 1:
					return (T1)Convert.ChangeType(value.V2, typeof(T1));
				case 2:
					return (T1)Convert.ChangeType(value.V3, typeof(T1));
				default:
                    break;
            }
			return default;
        }

		// Token: 0x06005586 RID: 21894
		public static explicit operator T2(Union<T1, T2, T3> value)
        {
			switch (value._slot)
			{
				case 0:
					return (T2)Convert.ChangeType(value.V1, typeof(T2));
				case 1:
					return value.V2;
				case 2:
					return (T2)Convert.ChangeType(value.V3, typeof(T2));
				default:
					break;
			}
			return default;
		}

		// Token: 0x06005587 RID: 21895
		public static explicit operator T3(Union<T1, T2, T3> value)
        {
			switch (value._slot)
			{
				case 0:
					return (T3)Convert.ChangeType(value.V1, typeof(T3));
				case 1:
					return (T3)Convert.ChangeType(value.V2, typeof(T3));
				case 2:
					return value.V3; 
				default:
					break;
			}
			return default;
		}
	}
}
