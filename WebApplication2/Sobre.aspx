<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Sobre.aspx.cs" Inherits="WebApplication2.Sobre" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <h1 style="text-align: center; font-family: Verdana; margin-top: 50px; text-transform: uppercase">Sobre</h1>
    <br />
    <div class="row">
        <div class="col-5 margin-top-60">
            <img src="Images/figura1.jpg" width="500" height="280" />
        </div>
        <div class="col-7 margin-top-60">
            <h2>Perfil do Profissional</h2>
            <hr />
            <p style="text-align: justify; text-indent: 1.2em; float: right; font-family: 'Segoe UI'; font-size: 18px;">
                O Tecnólogo em <b>Análise e Desenvolvimento de Sistemas </b>analisa, projeta, documenta, especifica, testa, implanta e mantém sistemas computacionais de informação. Esse profissional trabalha, 
                também, com ferramentas computacionais, equipamentos de informática e metodologia de projetos na produção de sistemas. Raciocínio lógico, emprego de linguagens de programação e de metodologias
                de construção de projetos, preocupação com a qualidade, usabilidade, robustez, integridade e segurança de programas computacionais são fundamentais à atuação desse profissional.
            </p>
        </div>
        <div class="col-5 margin-top-60">
            <img src="Images/figura2.jpg" width="500" />
        </div>
        <div class="col-7 margin-top-60">
            <h2>Áreas de Atuação</h2>
            <hr />
            <p class="lead" style="text-align: justify; text-indent: 1.2em; float: right; font-family: 'Segoe UI'; font-size: 18px;">
                O profissional de <b>Análise e Desenvolvimento de Sistemas de Informação</b> pode atuar em empresas de assessoria e consultoria tecnológica e de desenvolvimento de sistemas, assim como nos diversos setores da economia: indústria, comércio, prestação de serviços, instituições financeiras, órgãos públicos ou como empreendedor em informática. Este profissional estará apto a:<br />
                <br />
                <i class="fa fa-check" style="color: green"></i>Projetar e implementar sistemas de acordo com as necessidades institucionais.
                <br />
                <i class="fa fa-check" style="color: green"></i>Coordenar infraestrutura de tecnologia da informação.
                <br />
                <i class="fa fa-check" style="color: green"></i>Realizar consultoria em Sistemas de Informação.
                <br />
                <i class="fa fa-check" style="color: green"></i>Atuar em Centros de Pesquisa, de Ensino ou de desenvolvimento de software.
                <br />
                <i class="fa fa-check" style="color: green"></i>Empreender seu próprio negócio em informática.
            </p>
        </div>
        <div class="col-5 margin-top-60">
            <img src="Images/figura4.jpg" width="500" />
        </div>
        <div class="col-7 margin-top-60">
            <h2>Objetivo Geral</h2>
            <hr />
            <p class="lead" style="text-align: justify; text-indent: 1.2em; float: right; font-family: 'Segoe UI'; font-size: 18px;">
                Formar profissionais que projetem, implementem e coordenem infraestruturas de tecnologia da informação, atendendo a necessidade de mudanças provocadas pelas inovações tecnológicas nas empresas.
            </p>
        </div>
    </div>
</asp:Content>
