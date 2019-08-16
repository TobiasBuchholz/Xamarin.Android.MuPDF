using System;
using Android.Runtime;
using Android.Widget;

namespace Com.Artifex.Mupdf.Viewer
{
    partial class ReaderView : AdapterView
    {
        protected override Java.Lang.Object RawAdapter
        {
            get => this.Adapter().JavaCast<Java.Lang.Object>();
            set {
                var adapter = value.JavaCast<IAdapter>();
                this.Adapter(adapter);
            }
        }
    }
}