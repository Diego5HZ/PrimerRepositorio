<%@ Page Title="Administración de Track" Language="C#" MasterPageFile="~/MainMaster.Master" AutoEventWireup="true" CodeBehind="TrackEdit.aspx.cs" Inherits="App.UI.WebForms.Pages.Mantenimientos.Track.TrackEdit" %>

<asp:Content ID="Asp1" ContentPlaceHolderID="contentMain" runat="server">
    <form runat="server">

    <asp:ValidationSummary 
        ID="ValidationSummary1" 
        runat="server" 
        DisplayMode ="BulletList"
        />

    <table style="width:100%;">
        <tr>
            <td style="height: 26px">
                <asp:Label ID="Label1" runat="server" Text="Nombre(*): "></asp:Label>
            </td>
            <td style="height: 26px">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                    runat="server" ErrorMessage="El campo nombre es requerido"
                    ControlToValidate="txtNombre"
                    >*
                </asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Album: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlAlbum" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Medio: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlMedio" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Genero: "></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlGenero" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Compositor: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCompositor" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                    runat="server" ErrorMessage="El compositor es requerido"
                    ControlToValidate="txtCompositor">
                </asp:RequiredFieldValidator> 

            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Duración"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDuracion" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ErrorMessage="El campo duracion es requerido" ControlToValidate="txtDuracion"
                    Display="Dynamic"
                    ></asp:RequiredFieldValidator>

                <asp:RangeValidator ID="RangeValidator1" runat="server" 
                    ErrorMessage="Debe durar entre 1 y 10 minutos" ControlToValidate="txtDuracion"
                    MinimumValue="1" MaximumValue="10"
                    Type="Integer" Display="Dynamic"
                    ></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Peso: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPeso" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ErrorMessage="El campo peso es requerido" ControlToValidate="txtPeso"
                    Display="Dynamic"
                    ></asp:RequiredFieldValidator>

                <asp:RangeValidator ID="RangeValidator2" runat="server" 
                    ErrorMessage="Debe durar entre 1MB y 10MB" ControlToValidate="txtPeso"
                    MinimumValue="1" MaximumValue="10"
                    Type="Integer" Display="Dynamic"
                    ></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Precio: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ErrorMessage="El campo peso es requerido" ControlToValidate="txtPrecio"
                    Display="Dynamic"
                    ></asp:RequiredFieldValidator>

                <asp:RangeValidator ID="RangeValidator3" runat="server" 
                    ErrorMessage="Debe durar entre 1 y 35 soles" ControlToValidate="txtPrecio"
                    MinimumValue="1" MaximumValue="35"
                    Type="Double" Display="Dynamic"
                    ></asp:RangeValidator>
            </td>
        </tr>
        <tr> 
            <td>&nbsp;</td> 
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click"
                    CauseValidation="true"/>
            </td>
        </tr>
    </table>
        
    </form>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentHead" runat="server">
    <script>
        //SI
    </script>
</asp:Content>
