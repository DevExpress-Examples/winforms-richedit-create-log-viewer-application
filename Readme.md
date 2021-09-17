<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609629/20.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4683)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to create a Log Viewer application


<p>This example illustrates how to use RichEditControl in a "Log Viewer"-like application. First, we adjust the default view settings in the form's constructor and default document settings in the <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.DocumentLoaded">RichEditControl.DocumentLoaded</a> / <a href="https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.EmptyDocumentCreated">RichEditControl.EmptyDocumentCreated</a> event handlers correspondingly. <p>To append a new message to the RichEditControl, use the <a href="https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.AppendText(System.String)">SubDocument.AppendText Method</a>. Note that though it is much easier to use the following logic instead:</p><p></p>

```cs
richEditControl1.Text += messageText;
```

<p></p><p>However, this code will cause the entire document to be reloaded. This will slow down your application and cause flickering. Thus, this approach is not the correct one.</p><p></p><p>Here is a screenshot that illustrates a sample application in action:</p><p></p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-log-viewer-application-e4683/14.2.3+/media/abc0f81d-10db-4fc5-aa3d-b58364e1f5d4.png"></p><p></p><p><strong>See Also:</strong></p><p><a href="https://www.devexpress.com/Support/Center/p/E2265">SubDocument essentials - simple examples</a></p>

<br/>


