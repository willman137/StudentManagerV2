<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Core.Master" AutoEventWireup="true" Theme="Operation" CodeBehind="ModifyStudent.aspx.cs" Inherits="StudentManager.MasterPages.ModifyStudent" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:panel runat="server" id="locator_panel">
        Student ID <asp:TextBox runat="server" class="form-control" ID="target_student"></asp:TextBox>
        <br/>
        <asp:Button runat="server" ID="Locator" Text="Find Student" OnClick="Locate_Student" />    
    </asp:panel>
    <br/>
    <asp:panel runat="server" id="details" visible="false">
        Student ID <asp:TextBox runat="server" ID="Student_ID" readonly="true"></asp:TextBox>
        <br/>
        Firstname <asp:TextBox runat="server" ID="FirstName"></asp:TextBox>
        <br/>
        Lastname <asp:TextBox runat="server" ID="LastName"></asp:TextBox>
        <br/>
        Email <asp:TextBox runat="server" ID="Email"></asp:TextBox>
        <br/>
    <asp:Button runat="server" ID="ModifySubmit" Text="Modify" OnClick="ModifySubmit_Click" />
    </asp:panel>

</asp:Content>