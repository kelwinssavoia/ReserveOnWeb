<%@ Page Language="C#" Title="Login" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ReserveOnWeb.Login" MasterPageFile="~/ReserveOn.Master" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <center>
    <div style="width: 350px; padding-top: 20px;">
        <fieldset>
            <legend>Login</legend>
            <asp:TextBox runat="server" ID="txtLogin" placeholder="Usuário" CssClass="TextUsuario" style="margin-top: 5px;" Height="50px" Width="300px"
                required="required"
                data-validation-required-message="Por favor entre com um Usuário." MaxLength="10">
            </asp:TextBox>
            <asp:TextBox runat="server" TextMode="Password" ID="txtSenha" placeholder="Senha" style="margin-top: 5px;" Height="50px" Width="300px"
                required="required"
                data-validation-required-message="Por favor entre com uma senha.">
            </asp:TextBox>
            <asp:Button runat="server" ID="btnEntrar" Text="Entrar" CssClass="buttonGradient" Width="100px" 
                style="margin-top: 5px; margin-right: 5px; float: right;" OnClick="btnEntrar_Click"/>
        </fieldset>
    </div>
        </center>
</asp:Content>
