<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibeExcecoes.aspx.cs" Inherits="WebApplication2.ExibeExcecoes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-12">
            <h2 style="text-transform: uppercase">Exceções que ocorreram na aplicação</h2>
            <br />
            <br />
            <hr />
            <asp:Label ID="Excecoes" Style="font-size: 18px;text-align: justify;font-family: 'Segoe UI';" runat="server"></asp:Label>
            <br />
            <hr />
            <asp:Button ID="Excluir" OnClick="Excluir_Click" runat="server" Style="max-width: 100%; width: auto; cursor: pointer" Text="Excluir todas as exceções" />
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
