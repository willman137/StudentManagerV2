<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPages/Core.Master" Theme="Operation" CodeBehind="AddProgram.aspx.cs" Inherits="StudentManager.AddProgram" %>
<asp:Content ID="ProgramFinder" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Add a Program</h2>
        Program Code: <asp:TextBox runat="server" ID="Program_Code">
        </asp:TextBox>
        <br/>
        Description: <asp:TextBox runat="server" ID="Description" Width="20em"></asp:TextBox>
        <br/>
        <asp:Button runat="server" id="submit" Text="Submit" onclick="submit_Click" />
</asp:Content>
