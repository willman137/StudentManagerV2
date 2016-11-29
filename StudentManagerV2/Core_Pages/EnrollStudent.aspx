<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" CodeBehind="EnrollStudent.aspx.cs" Inherits="StudentManager.EnrollStudent" Theme="Operation" %>
<asp:Content ID="ProgramFinder" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Enroll a Student</h2>
        Student ID <asp:TextBox runat="server" ID="Student_ID"></asp:TextBox>
        <br/>
        Firstname <asp:TextBox runat="server" ID="FirstName"></asp:TextBox>
        <br/>
        Lastname <asp:TextBox runat="server" ID="LastName"></asp:TextBox>
        <br/>
        Email <asp:TextBox runat="server" ID="Email"></asp:TextBox>
        <br/>
        Program Code <asp:TextBox runat="server" ID="Program_Code">
        </asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="submit_Click"/>

</asp:Content>
