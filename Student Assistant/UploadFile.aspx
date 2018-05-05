<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadFile.aspx.cs" Inherits="Student_Assistant.UploadFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" method="post" enctype="multipart/form-data" runat="server">
        

			
    <div>
    <INPUT type="file" id="File1" name="File1" runat="server" />
<br>
<input type="submit" id="Submit1" value="Upload" runat="server" />
    </div>
    </form>
</body>
</html>
