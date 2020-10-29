using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorClassicForms.HTML.ES
{
    public class Blob
    {
        public Uint8Array[] array;
        BlobPropertyBag blobPropertyBag;

        public Blob(Uint8Array[] _array, BlobPropertyBag _blobPropertyBag)
        {
            array = _array;
            blobPropertyBag = _blobPropertyBag;
        }
    }
}
