<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" Theme="Query" CodeBehind="RemoveProgram.aspx.cs" Inherits="StudentManager.RemoveProgram" %>
<asp:Content ID="Content1" ContentPlaceHolderID="banner" runat="server">
</asp:Content>
<asp:Content ID="Remove_Program" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Remove a Program</h2>
        <asp:TextBox runat="server" ID="Program_Code">
        </asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="Remove_Click"/>
</asp:Content>
