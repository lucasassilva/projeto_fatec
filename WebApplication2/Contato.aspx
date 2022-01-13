<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contato.aspx.cs" Inherits="WebApplication2.Contato" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <!-- FORMULÁRIO DE CONTATO -->
        <div class="col-6">
            <div class="box-padding-20 box-border margin-right-20 height-600">
                <br />
                <h2 style="text-transform: uppercase;text-align:center;">Fale Conosco</h2>
                <br />
                <asp:Label ID="Erro" Font-Size="16px" ForeColor="Red" runat="server"></asp:Label>
                <label class="required">Nome</label>
                <asp:TextBox ID="Nome" autocomplete="off" MaxLength="100" runat="server"></asp:TextBox>
                <label class="required">Email</label>
                <asp:TextBox ID="Email" autocomplete="off" TextMode="Email" MaxLength="255" runat="server"></asp:TextBox>
                <label class="required">Mensagem</label>
                <asp:TextBox ID="Mensagem" autocomplete="off" MaxLength="255" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Enviar" OnClick="Enviar_Click" Style="cursor: pointer" runat="server" Text="Enviar" />
            </div>
        </div>
        <!-- MAPA DO GOOGLE -->
        <div class="col-6">
            <div class="box-border height-600">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3679.689238352258!2d-47.35252258503734!3d-22.73978918509698!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94c89bea5cdb94f9%3A0xffb368bd91ea12ae!2sFatec%20Americana%20-%20Faculdade%20de%20Tecnologia%20de%20Americana!5e0!3m2!1spt-BR!2sbr!4v1599074416507!5m2!1spt-BR!2sbr" width="100%" height="100%" frameborder="0" style="border: 0;" allowfullscreen="" aria-hidden="false" tabindex="0"></iframe>
            </div>
        </div>
    </div>
</asp:Content>
