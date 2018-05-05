<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registeration.aspx.cs" Inherits="Student_Assistant.Registeration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>First Name:
                    <asp:TextBox runat="server" ID="firstname" placeholder="first name here..." />

        </label>
        <br />
       <br />
        
        <label>Last Name: 
         <asp:TextBox runat="server" ID="lastname" placeholder="last name here..." />
            </label>
        <br />




        <br />
        <label>Gender: 
        
            <asp:RadioButtonList ID="rblist1" runat="server">

    <asp:ListItem Text ="Male" />
    <asp:ListItem Text ="Female" />

    </asp:RadioButtonList>
            </label>
        <br />
        <label>Email: 
        <asp:TextBox runat="server" ID="emailBox" />
            </label>
        <br />
        <label>Password: 
        <asp:TextBox runat="server" TextMode="Password" ID="PasswordBox" />
            </label>
        <br />
        <asp:Button OnClick="registerBtn_Click1"  runat="server" Text="Register" ID="registerBtn" />

        <label id="eror" runat="server" />
    </div>
    </form>
</body>
</html>
