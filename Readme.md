<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to create a Log Viewer application


<p>This example illustrates how to use RichEditControl in a "Log Viewer"-like application. First, we adjust the default view settings in the form's constructor and default document settings in the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_DocumentLoadedtopic">RichEditControl.DocumentLoaded</a> / <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_EmptyDocumentCreatedtopic">RichEditControl.EmptyDocumentCreated</a> event handlers correspondingly. Note that we turn off word wrapping by using the approach provided in the <a href="https://www.devexpress.com/Support/Center/p/E3813">How to disable word wrapping in the Simple view</a> code example.</p><p></p><p>To append a new message to the RichEditControl, use the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeSubDocument_AppendTexttopic">SubDocument.AppendText Method</a>. Note that though it is much easier to use the following logic instead:</p><p></p>

```cs
richEditControl1.Text += messageText;
```

<p></p><p>However, this code will cause the entire document to be reloaded. This will slow down your application and cause flickering. Thus, this approach is not the correct one.</p><p></p><p>Here is a screenshot that illustrates a sample application in action:</p><p></p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-log-viewer-application-e4683/14.2.3+/media/abc0f81d-10db-4fc5-aa3d-b58364e1f5d4.png"></p><p></p><p><strong>See Also:</strong></p><p><a href="https://www.devexpress.com/Support/Center/p/E2265">SubDocument essentials - simple examples</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E1398">How to create a new document with the RichEdit control</a></p><p><a href="https://www.devexpress.com/Support/Center/p/E2757">Default font and paragraph formatting - an example of use</a></p>

<br/>


