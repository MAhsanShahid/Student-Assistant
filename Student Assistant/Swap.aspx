<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Swap.aspx.cs" Inherits="Student_Assistant.Swap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

        <label>Current Course Name:
                   <asp:DropDownList  runat="server" id="ccrs" >
            <asp:ListItem>Computer Programming</asp:ListItem>
            <asp:ListItem>Software Testing</asp:ListItem>
            
        </asp:DropDownList>
            </label>
        <br />

            <label>Current Course Section:
                   <asp:DropDownList runat="server" id="csec" >
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            
        </asp:DropDownList>
</label>
        <br />

            <label>Desired Course Name:
                   <asp:DropDownList  runat="server" id="dcrs" >
            <asp:ListItem>Computer Programming</asp:ListItem>
            <asp:ListItem>Software Testing</asp:ListItem>
            
        </asp:DropDownList>
            </label>
        <br />

            <label>Desired Course Section:
                   <asp:DropDownList runat="server" id="dsec" >
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            
        </asp:DropDownList>
</label>
        <br />

        
         <asp:Button OnClick="DoSwap"  runat="server" Text="Swap" ID="swap" />
        <asp:Button OnClick="ViewSwapList"  runat="server" Text="ViewSwapList" ID="swapList" />

        <label id="eror" runat="server" />
         
    </div>
    </form>
</body>
</html>
