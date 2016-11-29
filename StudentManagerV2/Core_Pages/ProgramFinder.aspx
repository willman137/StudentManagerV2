<%@ Page Language="C#" Title="ProgramFinder" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" CodeBehind="ProgramFinder.aspx.cs" Inherits="StudentManager.ProgramFinder" Theme="Query" %>
<asp:Content ID="ProgramFinder" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Find a Program</h2>
        <asp:TextBox runat="server" ID="Program_Code">
        </asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="Find_Click"/>
                
</asp:Content>
