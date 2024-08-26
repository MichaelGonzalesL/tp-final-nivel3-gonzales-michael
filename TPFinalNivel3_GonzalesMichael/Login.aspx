<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TPFinalNivel3_GonzalesMichael.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>LOGIN</h1>

    <div class="row">
        <div class="col-6">
            <div class="mb-3 was-validated">
                <label for="txtEmail" class="form-label">Email</label>
                <asp:TextBox runat="server" ID="txtEmail" CssClass="form-control" REQUIRED />
                <div class="invalid-feedback">
                    Por favor ingrese su email
                </div>
                <%--   <asp:RequiredFieldValidator ErrorMessage="Ingrese el email" ControlToValidate="txtEmail" runat="server" />
            <asp:RegularExpressionValidator ErrorMessage="Ingrese el email" ControlToValidate="txtEmail" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" runat="server" />
                --%>
            </div>
            <div class="mb-3 was-validated">
                <label for="txtPass" class="form-label">Pass</label>
                <asp:TextBox runat="server" ID="txtPass" CssClass="form-control" REQUIRED />
                <div class="invalid-feedback">
                    Por favor ingrese la contraseña
                </div>
            </div>
            <div class="mb-3">
                <asp:Button Text="Ingresar" ID="btnLogin" runat="server" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                <a href="Default.aspx" class="btn btn-primary">Cancelar</a>
                <%--<asp:Button Text="Cancelar" runat="server" CssClass="btn btn-primary" ID="btnCancelar" />--%>
            </div>

        </div>


    </div>



</asp:Content>
