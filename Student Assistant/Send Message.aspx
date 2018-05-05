<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Send Message.aspx.cs" Inherits="Student_Assistant.Send_Message" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>To:
                    <asp:TextBox runat="server" ID="reciever" placeholder="reciever email here..." />

        </label>
        <br />
       <br />
        
       <label>To:
                    <asp:TextBox runat="server" ID="senderr" placeholder="sender email here..." />

        </label>
        <br />

        <label>Subject:

        <asp:TextBox id="sub" TextMode="multiline" runat="server" />
              </label>
        <br />


        <br />
        <label>Message:

        <asp:TextBox id="msg" TextMode="multiline" runat="server" />
              </label>
        <br />
        <br />
        <asp:Button OnClick="SendMessage"  runat="server" Text="Send" ID="msgBtn" />
         <label id="eror" runat="server" />
    </div>
    </form>
</body>
</html>
