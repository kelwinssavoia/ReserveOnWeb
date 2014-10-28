<%@ Page Language="C#" Title="Home" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ReserveOnWeb._Default" EnableEventValidation="false" MasterPageFile="~/ReserveOn.Master" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="">
        <div class="content-wrapper">
            <hgroup class="title">
                <center><h2>O aplicativo para facilitar sua vida</h2></center>
            </hgroup>
            <p>
                    O nosso aplicativo foi pensado para facilitar e agilizar o processo de realizar reservas, pedidos e até mesmo o pagamento, 
                possibilitando que tudo seja feito a partir de seu SmartPhone através de nosso aplicativo. Para fazer o download clique <a href="#">aqui</a>.
            </p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Serviços disponibilizados:</h3>
    <ol class="round">
        <li class="one">
            <h5>Reserva</h5>
            <p>
                Será possivel realizar reservas a partir do nosso aplicativo, onde o usuário selecionará a data e a hora que deseja fazer a reserva 
            e serão exibidas as mesas disponiveis para reserve assim como suas localizações.<br />
                Na data e hora em que a reserva foi feita, o usuário deverá realizar o CheckIn pelo próprio aplicativo, digitando uma senha que o estabelecimento
            disponibilizara, efetivando assim sua reserva, caso contrário, após 15 minutos da data e hora em que a reserva foi marcada, a mesa será redisponibilizada
            para outros cliente.
            </p>
        </li>
        <li class="two">
            <h5>Pedido</h5>
            Descrição de Pedidos.
        </li>
        <li class="three">
            <h5>Pagamento</h5>
            Descrição de Pagamentos.
        </li>
    </ol>
</asp:Content>

