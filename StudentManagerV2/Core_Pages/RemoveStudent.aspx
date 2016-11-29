<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" Theme="Operation" CodeBehind="RemoveStudent.aspx.cs" Inherits="StudentManager.RemoveStudent" %>
<asp:Content ID="Remove_Student" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Remove a Student</h2>
        <asp:TextBox runat="server" ID="Student_ID">
        </asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="Remove_Click"/>
</asp:Content>