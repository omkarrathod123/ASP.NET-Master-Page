<%@ Page Title="" Language="C#" MasterPageFile="~/MasterSample.Master" AutoEventWireup="true" CodeBehind="Time.aspx.cs" Inherits="Master_Pages.Web_Pages.Time" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Current Time:</h1>
        <asp:Label ID="Curtimelbl" runat="server">Return Time</asp:Label>
        <br />
        <asp:Button ID="Timebtn" runat="server" OnClick="Timebtn_Click" Text="Current Time" />
    </div>
</asp:Content>
