<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Listado de articulos</h1>
    <div class="row row-cols-1 row-cols-md-3 g-4">
        <%foreach (Dominio.Articulos articulo in listArticulos)
            {%>
        <div class="col">

            <div class="card" <%--style="width: 18rem;"--%>>

                <img src="<%:articulo.Imagen %>" class="card-img-top" alt="no hay imagen"
                    onerror="this.onerror=null; this.src='https://us.123rf.com/450wm/tkacchuk/tkacchuk2004/tkacchuk200400017/143745488-no-hay-icono-de-imagen-vector-de-l%C3%ADnea-editable-no-hay-imagen-no-hay-foto-disponible-o-no-hay.jpg'">

                <div class="card-body">
                    <h5 class="card-title"><%:articulo.Nombre %></h5>
                    <p class="card-text"><%:articulo.Descripcion %></p>
                    <a href="#" class="btn btn-primary">Detalles</a>
                </div>
            </div>
        </div>

        <%	} %>
    </div>
</asp:Content>
