# Xamarin.Android.MuPDF

[![NuGet](https://img.shields.io/nuget/v/xamarin.android.mupdf.svg?maxAge=86400&style=flat)](https://www.nuget.org/packages/Xamarin.Android.MuPDF/)

A port of the MuPDF Android library for Xamarin Android. With this library, you will be able to read, write, modify PDF files as well as convert pages to images. 

From [mupdf.com](http://mupdf.com):

    MuPDF is a lightweight PDF, XPS, and E-book viewer.

    MuPDF consists of a software library, command line tools, and viewers for various platforms.

    The renderer in MuPDF is tailored for high quality anti-aliased graphics. It renders text with 
    metrics and spacing accurate to within fractions of a pixel for the highest fidelity in reproducing 
    the look of a printed page on screen.

    The viewer is small, fast, yet complete. It supports many document formats, such as PDF, XPS, 
    OpenXPS, CBZ, EPUB, and FictionBook 2. You can annotate PDF documents and fill out forms with 
    the mobile viewers (this feature is coming soon to the desktop viewer as well).

    The command line tools allow you to annotate, edit, and convert documents to other formats such as 
    HTML, SVG, PDF, and CBZ. You can also write scripts to manipulate documents using Javascript.

    The library is written modularly in portable C, so features can be added and removed by integrators 
    if they so desire. We also have a Java library using JNI that works on both Oracle's Java and Android.
    
## Installation
#### Nuget

> Install-Package Xamarin.Android.MuPDF -Version 1.15.1

#### Version 1.9.0
If you have previously used the binding [MuPDF-for-Xamarin-Android
](https://github.com/asimmon/MuPDF-for-Xamarin-Android) from [Anthony Simmon](https://github.com/asimmon) and you just need an update that supports 64-bit devices, you you should be good to go when you replace his nuget installation with [![v 1.9.0](https://img.shields.io/badge/nuget-v1.9.0-blue?style=flat)](https://www.nuget.org/packages/Xamarin.Android.MuPDF/1.9.0)


## Invoke the document viewer activity

You can open a document viewing activity by launching an intent, passing the URI of the document you wish to view. 

```c#
using Com.Artifex.Mupdf.Viewer;

public void StartMuPDFActivity(Uri documentUri)
{
    var intent = new Intent(this, typeof(DocumentActivity));
    intent.SetAction(Intent.ActionView);
    intent.SetData(documentUri);
    StartActivity(intent);
}
```        

The activity supports viewing both file and content scheme URIs.
For example, to open the PDF file in ~/Download/example.pdf: 

```c#
var dir = Environment.GetExternalStoragePublicDirectory(Environment.DirectoryDownloads);
var file = new File(dir, "example.pdf");
var uri = Uri.FromFile(file);
StartMuPDFActivity(uri);
```
## More documentation and samples

This project is just a Xamarin Android binding of the original MuPDF, so if you want to learn more about the MuPDF API, please look at:

* The [MuPDF Android SDK](https://mupdf.com/docs/android-sdk.html)
* The [MuPDF C project](http://mupdf.com/docs/)

## Licensing

MuPDF is GNU AGPL licenced.

© Copyright 2019 Artifex Software, Inc. 

I am not associated with either Artifex Software, Inc. or Xamarin Inc. All rights belong to their respective owners.

