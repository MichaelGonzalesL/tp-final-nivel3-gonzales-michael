<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="ListadoDeArticulos.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.ListadoDeArticulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager runat="server" />
    <asp:UpdatePanel runat="server">
        <ContentTemplate>
            <div class="row">
                <div class="col-6">
                    <div class="mb-3">
                        <label for="txtFiltro" class="form-label">Filtro</label>
                        <asp:TextBox runat="server" ID="txtFiltro" CssClass="form-control" OnTextChanged="txtFiltro_TextChanged" />
                    </div>

                </div>
                <div class="col-6" style="display: flex; flex-direction: column; justify-content: flex-end">
                    <div class="mb-3">
                        <asp:Label Text="Precio" runat="server" CssClass="form-label"/>
                        <asp:DropDownList runat="server" CssClass="form-select" ID="ddlPrecio" OnSelectedIndexChanged="ddlPrecio_SelectedIndexChanged" AutoPostBack="true">
                            <asp:ListItem Text="Predeterminado" />
                            <asp:ListItem Text="Mayor a menor" />
                            <asp:ListItem Text="Menor a mayor" />
                        </asp:DropDownList>
                    </div>

                </div>
            </div>

            <asp:GridView ID="dgvArticulos" CssClass="table" AutoGenerateColumns="false" runat="server"
                DataKeyNames="Id" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged">

                <Columns>
                    <asp:BoundField HeaderText="Codigo de articulo" DataField="CodArticulo" />
                    <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                    <asp:BoundField HeaderText="Descripción" DataField="Descripcion" />
                    <asp:BoundField HeaderText="Marca" DataField="Marca.Descripcion" />
                    <asp:BoundField HeaderText="Categoria" DataField="Categoria.Descripcion" />
                    <asp:BoundField HeaderText="Precio" DataField="Precio" />
                    <asp:CommandField HeaderText="Accion" ShowSelectButton="true" SelectText="♣" />
                </Columns>
            </asp:GridView>

            <a href="Detalles.aspx" class="btn btn-primary">Agregar</a>
        </ContentTemplate>
    </asp:UpdatePanel>





</asp:Content>
