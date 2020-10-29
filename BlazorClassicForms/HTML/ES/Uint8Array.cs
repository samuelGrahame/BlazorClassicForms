using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Transactions;

namespace BlazorClassicForms.HTML.ES
{
    public class Uint8Array
    {
        public byte[] InnerArray;
        public Uint8Array()
        {
            InnerArray = new byte[] { };
        }
        public Uint8Array(uint length)
        {
            InnerArray = new byte[length];
        }
        public byte this[uint index]
        {
            // get and set accessors
            set
            {
                InnerArray[index] = value;
            }
            get
            {
                return InnerArray[index];
            }
        }
    }
}
