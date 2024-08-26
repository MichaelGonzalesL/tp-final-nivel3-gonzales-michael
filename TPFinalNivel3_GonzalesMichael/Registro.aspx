<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>REGISTRO</h1>

    <div class="row">
        <div class="col-6">
            <div class="mb-3">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtPass" class="form-label">Pass</label>
                <asp:TextBox runat="server" ID="txtPass" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Resgistrarse" ID="btnRegistro" runat="server" CssClass="btn btn-primary" OnClick="btnRegistro_Click" />
                <a href="Default.aspx" class="btn btn-primary">Cancelar</a>
                <%--<asp:Button Text="Cancelar" runat="server" CssClass="btn btn-primary" ID="btnCancelar" />--%>
            </div>

        </div>


    </div>





</asp:Content>
