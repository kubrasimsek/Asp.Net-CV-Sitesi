<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="OdulEkle.aspx.cs" Inherits="BlogWeb.OdulEkle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">
        <div class="form-group">
            <div>
                <asp:Label ID="Label1" runat="server" Text="ÖDÜL"></asp:Label>
                <asp:TextBox ID="txtOdul" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />                  
            <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" CssClass="btn btn-primary" OnClick="btnKaydet_Click"/>
        </div>
    </form>
</asp:Content>
