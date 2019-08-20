using Android.Content;
using Android.Runtime;

namespace Artifex.MuPdf
{
    abstract partial class ReaderView
    {
        // We use GetAdapter(...) / SetAdapter created in Metadata.xml
        // instead of the missing Adapter { get; set; }
        protected override Java.Lang.Object RawAdapter
        {
            get {
                return this.Adapter().JavaCast<Java.Lang.Object>();
            }
            set
            {
                var adapter = value.JavaCast<global::Android.Widget.IAdapter>();
                this.Adapter(adapter);
            }
        }
    }
}