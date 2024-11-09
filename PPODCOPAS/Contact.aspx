<%@ Page Title="Contactenos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="PPODCOPAS.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title"><%: Title %>.</h2>
        <h3>Contacto físico y Virtual</h3>
        <address>
            Bogotá - Colombia<br />
            Cl 67 s 65 45<br />
            <abbr title="Phone">P:</abbr>
            305 346 68 61
        </address>

        <address>
            <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
            <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
        </address>
    </main>
</asp:Content>
