<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="OdulListesi.aspx.cs" Inherits="BlogWeb.OdulListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">
            <table class="table table-bordered">

                <tr>
                    <th>ID</th>
                    <th>ODUL</th>                    
                    <th>İŞLEMLER</th>
                </tr>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th><%# Eval("ID") %></th>
                                <td><%# Eval("ODUL") %></td>                              
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "OdulSil.aspx?ID="  + Eval("ID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "OdulGuncelle.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        <asp:HyperLink NavigateUrl="~/OdulEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Ödül Ekle</asp:HyperLink>
    </form>
</asp:Content>
