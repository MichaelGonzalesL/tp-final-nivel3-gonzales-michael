<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListadoDeArticulos.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.ListadoDeArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server" />

    <asp:GridView ID="dgvArticulos" CssClass="table" AutoGenerateColumns="false" runat="server"
        DataKeyNames="Id" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged"
        >

        <Columns>
            <asp:BoundField HeaderText="Codigo de articulo" DataField="CodArticulo"/>
            <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
            <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
            <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
            <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion"/>
            <asp:BoundField HeaderText="Precio" DataField="Precio"/>
            <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="♣" />
        </Columns>
    </asp:GridView>
        <a href="Detalles.aspx" class="btn btn-primary">Agregar</a>





</asp:Content>
