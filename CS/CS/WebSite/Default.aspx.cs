using System;
using System.IO;
using DevExpress.Web.ASPxUploadControl;

public partial class _Default : System.Web.UI.Page {
    protected void ASPxUploadControl1_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e) {
        e.CallbackData = SaveFile(e.UploadedFile);
    }
    protected string SaveFile(UploadedFile uploadedFile) {
        string fileName = string.Empty;
        if (uploadedFile.IsValid) {
            fileName = string.Format("{0}{1}", MapPath("~/"), uploadedFile.FileName);
            if (File.Exists(fileName))
                File.Delete(fileName);
            //uploadedFile.SaveAs(fileName); //uncomment this line
        }
        return uploadedFile.FileName;
    }
}
