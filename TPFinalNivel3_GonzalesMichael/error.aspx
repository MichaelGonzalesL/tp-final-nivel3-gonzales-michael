<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="error.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <h1>Error</h1>

    <asp:Label  Text="no hay" ID="lblError" runat="server" />

    <asp:Button Text="Loguearse" Visible="false" runat="server" CssClass="btn btn-primary" ID="btnErrorLoguearse" OnClick="btnErrorLoguearse_Click" />
</asp:Content>
