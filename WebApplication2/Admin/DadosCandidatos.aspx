<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DadosCandidatos.aspx.cs" Inherits="WebApplication2.DadosCandidatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <br />
    <br />
    <div class="row" style="text-align: center">
        <div class="col-12">
            <h2 style="text-transform: uppercase; text-align: center;">Dados Candidatos</h2>
        </div>
        <br />
        <br />
        <div class="col-3">
            <label><b>Nome Completo</b></label>
            <asp:Label ID="NomeCompleto" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-3">
            <label><b>Email</b></label>
            <asp:Label ID="Email" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-3">
            <label><b>Telefone</b></label>
            <asp:Label ID="Telefone" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-3" style="margin-bottom: 30px">
            <label><b>Sexo</b></label>
            <asp:Label ID="Sexo" runat="server" Text="Label"></asp:Label>
        </div>
        <div class="col-12">
            <iframe style="width: 100%; height: 850px;" name="myIframe" id="myIframe" runat="server"></iframe>
        </div>
    </div>
    <script>
        const frame = document.getElementsByTagName("iframe")[0];

        window.onload = function () {
            const getFrame = frame.getAttribute('src').split('.');
            const ext = getFrame.pop();

            if (ext == "doc" || ext == "docx") {
                frame.srcdoc = "<p style='font-family:Segoe UI;font-size:20px;'>&nbsp Baixando curriculo, não conseguimos abrir o arquivo no formato <b>word</b></p>";
            }

        }
    </script>
</asp:Content>


