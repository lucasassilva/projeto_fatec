<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrabalheConosco.aspx.cs" Inherits="WebApplication2.TrabalheConosco" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-6" style="margin: auto" id="form">
            <div class="box-border box-padding-20">
                <br />
                <h2 style="text-transform: uppercase; text-align: center;">Trabalhe Conosco</h2>
                <br />
                <span id="ErroData" runat="server"></span>
                <asp:Label ID="Erro" CssClass="Erro" Font-Size="16px" ForeColor="Red" runat="server"></asp:Label>
                <label class="required">Nome Completo</label>
                <asp:TextBox ID="NomeCompleto" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>
                <label class="required">Email</label>
                <asp:TextBox ID="Email" autocomplete="off" TextMode="Email" MaxLength="255" runat="server"></asp:TextBox>
                <label class="required">Cidade</label>
                <asp:TextBox ID="Cidade" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>
                <label class="required">Data Nascimento</label>

                <asp:TextBox ID="DataNascimento" CssClass="DataNascimento" autocomplete="off" placeholder="Ex.: dd/mm/aaaa" data-inputmask="'alias': 'dd/mm/yyyy'" data-mask="" runat="server"></asp:TextBox>
                <br />
                <asp:RadioButtonList ID="Sexo" runat="server" RepeatDirection="Horizontal" Style="margin-left: -6px">
                    <asp:ListItem Text="Feminino" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Masculino" Value="1"></asp:ListItem>
                </asp:RadioButtonList>
                <label class="required">Telefone</label>
                <asp:TextBox ID="Telefone" CssClass="Telefone" data-inputmask='"mask": "(99)9999-9999"' placeholder="Ex.: (00)0000-0000" data-mask autocomplete="off" runat="server"></asp:TextBox>
                <label>Descrição</label>
                <asp:TextBox ID="Descricao" autocomplete="off" MaxLength="255" TextMode="MultiLine" Rows="3" runat="server"></asp:TextBox>
                <label class="required">Interesse</label>
                <asp:DropDownList ID="Interesse" runat="server">
                    <asp:ListItem Text="Selecione um interesse" Value="" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Programador" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Teste de Software" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Analista de Sistemas" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Projeto de Software" Value="3"></asp:ListItem>
                    <asp:ListItem Text="Banco de Dados" Value="4"></asp:ListItem>
                    <asp:ListItem Text="Segurança" Value="5"></asp:ListItem>
                    <asp:ListItem Text="Suporte" Value="6"></asp:ListItem>
                </asp:DropDownList>
                <label class="required" style="margin-bottom: 6px">Curriculo</label>
                <div id="file-upload">
                    <input type="file" id="myFile" class="myFile" name="myFile" accept="application/pdf,application/msword,
  application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                        runat="server" />
                    <button onclick="document.querySelector('.myFile').click();" style="margin-top: 40px;" type="button"><i style="font-size: 22px; margin-top: -4px" class="fa fa-upload"></i>&nbsp Adicionar Curriculo </button>
                    <div style="margin-top: 12px;" id='filename'></div>
                </div>
                <br />
                <br />
                <asp:Button ID="Enviar" CssClass="Enviar" OnClick="Enviar_Click"  Style="cursor: pointer; width: 120px; height: 50px;" runat="server" Text="Enviar" />
                <br />
                <br />
            </div>
        </div>
    </div>
</asp:Content>
