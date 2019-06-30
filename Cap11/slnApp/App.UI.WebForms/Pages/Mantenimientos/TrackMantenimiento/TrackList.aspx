<%@ Page Title="" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TrackList.aspx.cs" Inherits="App.UI.WebForms.Pages.Mantenimientos.TrackMantenimiento.TrackList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contentHead" runat="server">
    <script>
        //Aqui esta eñ cpdogp javascript de la pagina TrackList
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentMain" runat="server">

    <form runat="server">
    <asp:GridView ID="grvListado" runat="server" CssClass="table" GridLines="None">


    </asp:GridView>

    <asp:Button ID="btnBuscar" Text="Buscar" runat="server"
        OnClick="btnBuscar_Click" />
    </form>
</asp:Content>
