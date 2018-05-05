<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Events.aspx.cs" Inherits="Student_Assistant.Events" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>Event Title:
                    <asp:TextBox runat="server" ID="EventTitle" placeholder="Event Title here..." />

        </label>
        <br />
       <br />

        <label>Course Name:
                   <asp:DropDownList  runat="server" id="crs" >
            <asp:ListItem>Computer Programming</asp:ListItem>
            <asp:ListItem>Software Testing</asp:ListItem>
            
        </asp:DropDownList>
            </label>
        <br />

            <label>Course Section:
                   <asp:DropDownList runat="server" id="sec" >
            <asp:ListItem>A</asp:ListItem>
            <asp:ListItem>B</asp:ListItem>
            
        </asp:DropDownList>
</label>
        <br />

         <label>Event Description:

        <asp:TextBox id="Desc" TextMode="multiline" runat="server" />
              </label>
        <br />
<br />
        <label>Event Venue:

        <asp:TextBox id="ven" TextMode="multiline" runat="server" />
              </label>
        <br />
         <asp:Button OnClick="AddNewEvent"  runat="server" Text="AddEvent" ID="CourseBtn" />
        <asp:Button OnClick="ViewAllEvents"  runat="server" Text="ViewEvents" ID="ViewCrs" />

        <label id="eror" runat="server" />
         
    </div>
    </form>
</body>
</html>
