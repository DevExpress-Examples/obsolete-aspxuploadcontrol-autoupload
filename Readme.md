<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/WebSite/Default.aspx) (VB: [Default.aspx](./VB/WebSite/Default.aspx))
* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# OBSOLETE - How to force the ASPxUploadControl to upload a selected file(s) automatically
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2531)**
<!-- run online end -->


<p>Starting with version 14.2, it is possible to use the built-in functionality instead (set the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControl_AutoStartUploadtopic">ASPxUploadControl.AutoStartUpload</a> property to <strong>True</strong>).<br /><br />The following approach can be used to force the ASPxUploadControl to upload a selected file automatically:<br /> 1) Handle the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControlScriptsASPxClientUploadControl_TextChangedtopic">ASPxClientUploadControl.TextChanged</a> event, which is raised on the client side when the text within the control's edit box is changed while the control has focus;<br /> 2) Call the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxUploadControlScriptsASPxClientUploadControl_Uploadtopic">ASPxClientUploadControl.Upload</a> method to initiate uploading a specified file(s) to the web server's memory.</p>

<br/>


