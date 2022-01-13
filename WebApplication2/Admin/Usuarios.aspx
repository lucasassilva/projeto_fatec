<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="WebApplication2.Admin.Usuarios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <div class="row margin-top-60">
        <div class="col-6">
            <div class="box-padding-20 box-border margin-right-20">
                <h2 style="text-transform: uppercase;text-align:center;">Cadastro de Usuários</h2>
                <br />
                <div style="width: 80px; background-color: #e2e2e2; padding: 8px; text-align: right; float: right;" class="box-border">
                    <asp:Label ID="Codigo" Font-Bold="true" Font-Size="20px" runat="server"></asp:Label>&nbsp 
                </div>
                <asp:Label ID="Erro" Font-Size="16px" ForeColor="Red" runat="server"></asp:Label>
                <br />
                <br />
                <label class="required">Nome Completo</label>
                <asp:TextBox ID="NomeCompleto" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>
                <label class="required">Email</label>
                <asp:TextBox ID="Email" autocomplete="off" TextMode="Email" MaxLength="255" runat="server"></asp:TextBox>

                <div style="margin-top: 20px; padding: 20px; border-radius: 5px; margin-bottom: 20px; background-color: #e2e2e2">
                    <h3>DADOS DE ACESSO</h3>
                    <label class="required">Nome de Acesso</label>
                    <asp:TextBox ID="NomeAcesso" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>

                    <label class="required">Senha</label>
                    <asp:TextBox ID="Senha" autocomplete="off" MaxLength="255" runat="server"></asp:TextBox>
                </div>
                <label>Anotações</label>
                <asp:TextBox ID="Anotacoes" autocomplete="off" MaxLength="255" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Salvar" OnClick="Salvar_Click" Style="cursor: pointer" runat="server" Text="Salvar" />
                <asp:Button ID="Excluir" Visible="false" OnClick="Excluir_Click" Style="margin-left: 25px; cursor: pointer" Text="Excluir" runat="server" />
                <br />
                <br />
            </div>
        </div>
        <div class="col-6">
            <div class="box-padding-20 box-border" style="height: 788px">
                <h2 style="text-transform: uppercase;text-align:center;">Usuários Cadastrados</h2>
                <br />
                <asp:TextBox ID="BuscarUsuario" autocomplete="off" Style="width: 350px; float:left;" runat="server"></asp:TextBox>
                <asp:Button ID="Buscar" Style="height: 39px; padding: 6px; cursor: pointer; margin-left: 10px;" OnClick="Buscar_Click" runat="server" Text="Buscar" />
                <asp:Button ID="Cancelar" Visible="false" Style="height: 39px; padding: 6px; cursor: pointer; margin-left: 4px;" OnClick="Cancelar_Click" runat="server" Text="X" />
                <br />
                <br />
                <asp:Panel ID="PanelUsuarios" Height="640px" ForeColor="White" ScrollBars="Auto" runat="server">
                    <asp:GridView ID="ViewUsuarios" CssClass="tabela01" Style="font-size: 15px; text-align: center;" Width="100%" AutoGenerateSelectButton="true" OnSelectedIndexChanged="ViewUsuarios_SelectedIndexChanged" AutoGenerateColumns="true" CellPadding="8" HeaderStyle-BackColor="#363636" BorderColor="#363636" runat="server">
                    </asp:GridView>
                </asp:Panel>
            </div>
        </div>
    </div>
</asp:Content>
