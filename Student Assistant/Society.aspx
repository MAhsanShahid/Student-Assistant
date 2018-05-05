<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Society.aspx.cs" Inherits="Student_Assistant.Society" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <label>Society Name:
                    <asp:TextBox runat="server" ID="Societyname" placeholder="Society name here..." />

        </label>
        <br />
       <br />
        
       <label>Description:

        <asp:TextBox id="Desc" TextMode="multiline" runat="server" />
              </label>
        <br />


        <br />
        <label>Event/Post(if any):

        <asp:TextBox id="post" TextMode="multiline" runat="server" />
              </label>
        <br />


        <br />
        
       
        <asp:Button OnClick="AddSociety"  runat="server" Text="AddSociety" ID="SocietyBtn" />
        <asp:Button OnClick="ViewSociety"  runat="server" Text="ViewSociety" ID="ViewCrs" />

        <label id="eror" runat="server" />
    </div>
    </form>
</body>
</html>
