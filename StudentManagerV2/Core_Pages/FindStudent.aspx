<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" Theme="Query" CodeBehind="FindStudent.aspx.cs" Inherits="StudentManager.FindStudent" %>

<asp:Content ID="Remove_Student" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Remove a Student</h2>
        <asp:TextBox runat="server" ID="Student_ID">
        </asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="Find_Click"/>
        <br/>
        <asp:Table runat="server" ID="results">
        </asp:Table>
</asp:Content>