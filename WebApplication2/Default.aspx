<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="flexslider-container">
        <div class="flexslider">
            <ul class="slides">
                <li>
                    <img src="Images/photo4.jpg" />
                </li>
                <li>
                    <img src="Images/photo1.png" />
                </li>
                <li>
                    <img src="Images/photo3.jpg" />
                </li>
            </ul>
        </div>
    </div>

    <!-- LINHA -->
    <div class="row margin-top-60">
        <!-- coluna 1 -->
        <div class="col-5">
            <img src="Images/figura1.jpg" width="500" />
        </div>
        <div class="col-7">
            <h1>Perfil do Profissional</h1>
            <hr />
            <p style="text-align: justify; font-family: 'Segoe UI'; font-size: 18px;">O Tecnólogo em <b>Análise e Desenvolvimento de Sistemas </b>analisa, projeta, documenta, especifica, testa, implanta e mantém sistemas computacionais de informação.</p>
            <button style="width: 150px; height: 50px; cursor: pointer" class="button" onclick="location.href='Sobre.aspx'" type="button">Ver mais</button>
        </div>
        <div class="col-5 margin-top-60">
            <img src="Images/figura2.jpg" width="500" />
        </div>
        <div class="col-7 margin-top-60">
            <h1>Áreas de Atuação</h1>
            <hr />
            <p style="text-align: justify; font-family: 'Segoe UI'; font-size: 18px;">O profissional de <b>Análise e Desenvolvimento de Sistemas de Informação</b> pode atuar em empresas de assessoria e consultoria tecnológica.</p>
            <button style="width: 150px; height: 50px; cursor: pointer" class="button" onclick="location.href='Sobre.aspx'" type="button">Ver mais</button>
        </div>
        <div class="col-5 margin-top-60">
            <img src="Images/figura4.jpg" width="500" />
        </div>
        <div class="col-7 margin-top-60">
            <h1>Objetivo Geral</h1>
            <hr />
            <p style="text-align: justify; font-family: 'Segoe UI'; font-size: 18px;">Formar profissionais que projetem, implementem e coordenem infraestruturas.</p>
            <button style="width: 150px; height: 50px; cursor: pointer" class="button" onclick="location.href='Sobre.aspx'" type="button">Ver mais</button>
        </div>
    </div>
    <br />
    <br />
    <br />
</asp:Content>
