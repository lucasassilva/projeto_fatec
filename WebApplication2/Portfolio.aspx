<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Portfolio.aspx.cs" Inherits="WebApplication2.Portfolio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <h1 style="text-align: center; font-family: Verdana; margin-top: 50px; text-transform: uppercase">Portfólio</h1>
    <br />
    <br />
    <div class="row box-padding-20" style="padding: 6px;">
        <br />
        <div class="col-4">
            <img id="image01" src="Images/cap1.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image02" src="Images/cap2.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image03" src="Images/cap3.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image04" src="Images/cap4.png" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image05" src="Images/cap5.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image06" src="Images/cap6.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image07" src="Images/cap7.jpg" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image08" src="Images/cap8.png" width="410" height="310">
        </div>
        <div class="col-4">
            <img id="image09" src="Images/cap9.jpg" width="410" height="310">
        </div>
    </div>

    <!-- The Modal -->
    <div id="myModal" class="modal">
        <span id="close" onclick="modal.style.display = 'none'" class="close">&times;</span>
        <img class="modal-content" id="image" />
        <div id="caption"></div>
    </div>
</asp:Content>
