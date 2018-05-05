<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Courses_Sections.aspx.cs" Inherits="Student_Assistant.Courses_Sections" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <label>Course Name:
                    <asp:TextBox runat="server" ID="Coursename" placeholder="course name here..." />

        </label>
        <br />
       <br />
        
        <label>Section(s): 
         <asp:TextBox runat="server" ID="section" placeholder="Enter section here..." />
            </label>
        <br />


        <br />
        <label>Department Name: 
        
            <asp:RadioButtonList ID="department" runat="server">

    <asp:ListItem Text ="BS(CS)" />
    <asp:ListItem Text ="BS(EE)" />

    </asp:RadioButtonList>
            </label>
        <br />
       
        <asp:Button OnClick="AddCourseWithSection"  runat="server" Text="AddCourse" ID="CourseBtn" />
        <asp:Button OnClick="ViewCourses"  runat="server" Text="ViewCourses" ID="ViewCrs" />

        <label id="eror" runat="server" />
    </div>
    </form>
</body>
</html>
