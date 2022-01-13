<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-4" style="margin:auto">
            <div class="box-border box-padding-20">
                <br />
                <h2 style="text-transform: uppercase;text-align:center;">Login</h2>
                <br />
                <asp:Label ID="Mensagem" Font-Size="16px" ForeColor="Red" runat="server"></asp:Label>
                <label>NOME DE ACESSO</label>
                <asp:TextBox ID="NomeAcesso" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>
                <label>SENHA</label>
                <asp:TextBox ID="Senha" autocomplete="off" TextMode="Password" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Entrar" OnClick="Entrar_Click" Style="cursor: pointer" runat="server" Text="Entrar" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
