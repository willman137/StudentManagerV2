<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Core.Master" AutoEventWireup="true" Theme="Operation" CodeBehind="ModifyStudent.aspx.cs" Inherits="StudentManager.MasterPages.ModifyStudent" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        Student ID <asp:TextBox runat="server" ID="Student_ID"></asp:TextBox>
        <br/>
        Firstname <asp:TextBox runat="server" ID="FirstName"></asp:TextBox>
        <br/>
        Lastname <asp:TextBox runat="server" ID="LastName"></asp:TextBox>
        <br/>
        Email <asp:TextBox runat="server" ID="Email"></asp:TextBox>
        <br/>
    <asp:Button runat="server" ID="ModifySubmit" Text="Modify" OnClick="ModifySubmit_Click" />
</asp:Content>
