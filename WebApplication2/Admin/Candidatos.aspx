<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Candidatos.aspx.cs" Inherits="WebApplication2.Candidatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
     <div class="row">
        <div class="col-12">
            <br />
            <br />
            <h2 style="text-transform: uppercase;text-align:center;margin-bottom:20px">Candidatos Cadastrados</h2>
            <asp:Label ID="Codigo" Visible="false" Font-Bold="true" Font-Size="20px" runat="server"></asp:Label>&nbsp 
             <asp:Panel ID="PanelCandidatos" ForeColor="White" BorderColor="#000" Height="640px" ScrollBars="Auto" runat="server">
                    <asp:GridView ID="ViewCandidatos" CssClass="tabela02" Style="font-size: 15px; text-align: center;" Width="100%" AutoGenerateSelectButton="true" OnSelectedIndexChanged="ViewCandidatos_SelectedIndexChanged"  AutoGenerateColumns="true" CellPadding="8" HeaderStyle-BackColor="#363636" BorderColor="#363636" runat="server">
                    </asp:GridView>
                </asp:Panel>
            </div>
         </div>
</asp:Content>
