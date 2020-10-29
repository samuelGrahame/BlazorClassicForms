using BlazorClassicForms.HTML.ES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public class UInt8Holder
    {
        public Uint8Array Array;
        private bool _hasCreated = false;
        private string _data = "";
        public string Data => _hasCreated ? _data : _data = getData();

        private string getData()
        {           
            var blob = new Blob(new[] { Array }, new BlobPropertyBag() { type = "image/png" });
            //return URL.createObjectURL(blob);
            return string.Empty;
            //TODO
        }
    }
}
