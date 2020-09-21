<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="YetenekListesi.aspx.cs" Inherits="BlogWeb.YetenekListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <form id="Form1" runat="server">
            <table class="table table-bordered">

                <tr>
                    <th>ID</th>
                    <th>YETENEK</th>                    
                    <th>İŞLEMLER</th>
                </tr>
                <tbody>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr>
                                <th><%# Eval("ID") %></th>
                                <td><%# Eval("YETENEK") %></td>                              
                                <td>
                                    <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "YetenekSil.aspx?ID="  + Eval("ID") %>' runat="server" CssClass="btn btn-danger">Sil</asp:HyperLink>
                                    <asp:HyperLink ID="HyperLink2" NavigateUrl='<%# "YetenekGuncelle.aspx?ID=" + Eval("ID") %>' runat="server" CssClass="btn btn-warning">Güncelle</asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </tbody>
            </table>
        <asp:HyperLink NavigateUrl="~/YetenekEkle.aspx" ID="HyperLink3" runat="server" CssClass="btn btn-info">Yetenek Ekle</asp:HyperLink>
    </form>
</asp:Content>
