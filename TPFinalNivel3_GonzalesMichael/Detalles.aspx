<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalles.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.Detalles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ScriptManager runat="server" />

    <div class="row">

        <div class="col-6">
            <div class="mb-3">
                <label for="txtId" class="form-label">Id</label>
                <asp:TextBox runat="server" ID="txtId" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtCodArticulo" class="form-label">Codigo de Articulo</label>
                <asp:TextBox runat="server" ID="txtCodArticulo" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="txtNombre" class="form-label">Nombre</label>
                <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <label for="ddlMarca" class="form-label">Marca</label>
                <asp:DropDownList CssClass="form-select" runat="server" ID="ddlMarca" />
            </div>
            <div class="mb-3">
                <label for="ddlCategoria" class="form-label">Categoria</label>
                <asp:DropDownList  ID="ddlCategoria" runat="server" CssClass="form-select"/>
            </div>
            <div class="mb-3">
                <label for="txtPrecio" class="form-label">Precio</label>
                <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
            </div>
            <div class="mb-3">
                <asp:Button Text="Agregar" ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" CssClass="btn btn-primary" />
                <%--<a href="/"  class="btn btn-primary"  >Cancelar</a>--%>
                <asp:Button Text="Cancelar" runat="server" CssClass="btn btn-primary" ID="btnCancelar" OnClick="btnCancelar_Click" />
            </div>
        </div>
        <div class="col-6">
            <div class="mb-3">
                <label for="txtDescripcion" class="form-label">Descripcion</label>
                <asp:TextBox runat="server" ID="txtDescripcion" CssClass="form-control" />
            </div>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <div class="mb-3">
                        <label for="txtImagen" class="form-label">UrlImagen</label>
                        <asp:TextBox runat="server" ID="txtImagen" CssClass="form-control"
                            AutoPostBack="true" OnTextChanged="txtImagen_TextChanged" />
                    </div>
                    <asp:Image ImageUrl="https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder.png"
                        Width="60%" ID="imgArticulos" runat="server" />
                    <%--onerror="this.onerror=null; this.src='https://us.123rf.com/450wm/tkacchuk/tkacchuk2004/tkacchuk200400017/143745488-no-hay-icono-de-imagen-vector-de-l%C3%ADnea-editable-no-hay-imagen-no-hay-foto-disponible-o-no-hay.jpg'"--%>
                    <%-- aJUSTAR CUANDO NO HAY IMAGEN EN EL REGISTRO DE ARTICULOS --%>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>


    </div>


</asp:Content>
