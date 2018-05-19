<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%@ Register Assembly="DevExpress.Web.v9.3, Version=9.3.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxUploadControl" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script language="javascript" type="text/javascript">
        function OnTextChanged(s, e) {
            s.Upload();
        }
        function OnFileUploadComplete(s, e) {
            alert('FileUploadComplete: ' + e.callbackData);
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxUploadControl ID="ASPxUploadControl1" runat="server" 
            ClientInstanceName="upload" 
            OnFileUploadComplete="ASPxUploadControl1_FileUploadComplete">
            <ClientSideEvents TextChanged="OnTextChanged" FileUploadComplete="OnFileUploadComplete" />
        </dx:ASPxUploadControl>
    </div>
    </form>
</body>
</html>