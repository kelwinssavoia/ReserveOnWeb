<%@ Page Language="C#" Title="Cadastro" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ReserveOnWeb.Cadastro" MasterPageFile="~/ReserveOn.Master" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <center>
    <div style="width: 1000px; padding-top: 20px;">
        <fieldset>
            <legend>Cadastro</legend>
            <table>
                <tr>
                    <td>
                        <label>Nome: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtNome" CssClass="TextUsuario" style="margin-top: 5px;" Height="50px" Width="300px"
                            required="required" data-validation-required-message="Por favor entre com um Nome." MaxLength="30">
                        </asp:TextBox>
                    </td>
                    <td>
                        <label>CPF: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtCpf" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com o CPF." MaxLength="11"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>RG: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtRg" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com o RG." MaxLength="9"></asp:TextBox>
                    </td>
                    <td>
                        <label>Telefone: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtTelefone" style="margin-top: 5px;" Height="50px" Width="300px" 
                            required="required" data-validation-required-message="Por favor entre com o telefone." MaxLength="15"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Usuário: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtUsuario" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com o Usuário." MaxLength="10"></asp:TextBox>
                    </td>
                    <td>
                        <label>Email: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtEmail" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com o Email." MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Senha: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" TextMode="Password" ID="txtSenha" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com a Senha." MaxLength="50"></asp:TextBox>
                    </td>
                    <td>
                        <label>Confirme a Senha: </label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" TextMode="Password" ID="txtConfSenha" style="margin-top: 5px;" Height="50px" Width="300px"
                        required="required" data-validation-required-message="Por favor entre com a confirmação da Senha." MaxLength="50"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <asp:Button runat="server" ID="btnCadastrar" Text="Cadastrar" CssClass="buttonGradient" Width="100px" 
                        style="margin-top: 5px; margin-right: 5px; float: right;" OnClick="btnCadastrar_Click"/>
                    </td>
                </tr>
            </table>
        </fieldset>
    </div>
        </center>
</asp:Content>

