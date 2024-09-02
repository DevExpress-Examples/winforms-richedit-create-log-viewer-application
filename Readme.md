<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609629/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4683)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Rich Text Editor for WinForms - How to Create a Log Viewer Application


This example illustrates how to use RichEditControl in a "Log Viewer"-like application. 

![image](./media/abc0f81d-10db-4fc5-aa3d-b58364e1f5d4.png)

## Implementation Details

First, adjust the default view settings in the form's constructor and default document settings in the [RichEditControl.DocumentLoaded](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.DocumentLoaded)  / [RichEditControl.EmptyDocumentCreated](https://docs.devexpress.com/WindowsForms/DevExpress.XtraRichEdit.RichEditControl.EmptyDocumentCreated) event handlers, correspondingly. 

Then, use the [SubDocument.AppendText](https://docs.devexpress.com/OfficeFileAPI/DevExpress.XtraRichEdit.API.Native.SubDocument.AppendText(System.String))  method to append a new message to the RichEditControl.

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-create-log-viewer-application&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-create-log-viewer-application&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
