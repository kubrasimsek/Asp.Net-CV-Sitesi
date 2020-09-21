<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDeneyimler.aspx.cs" Inherits="BlogWeb.AdminDeneyimler" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
            <table class="table table-bordered">

                <tr>
                    <th>ID</th>
                    <th>BAŞLIK</th>
                    <th>ALTBAŞLIK</th>
                    <th>AÇIKLAMA</th>
                    <th>TARİH</th>
                    <th>İŞLEMLER</th>
                </tr>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th><%# Eval("ID") %></th>
                                <td><%# Eval("BASLIK") %></td>
                                <td><%# Eval("ALTBASLIK") %></td>
                                <td><%# Eval("ACIKLAMA") %></td>
                                <td><%# Eval("TARIH") %></td>
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "AdminDeneyimSil.aspx?ID="  + Eval("ID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "AdminDeneyimGuncelle.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        <asp:HyperLink NavigateUrl="~/AdminDeneyimEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Deneyim Ekle</asp:HyperLink>
    </form>


</asp:Content>
