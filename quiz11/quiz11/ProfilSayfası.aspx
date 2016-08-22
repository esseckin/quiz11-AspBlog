<%@ Page Title="" Language="C#" MasterPageFile="~/Anasayfa.Master" AutoEventWireup="true" CodeBehind="ProfilSayfası.aspx.cs" Inherits="quiz11.ProfilSayfası" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentplace" runat="server">
    <table border="1" class="profiltr" style="width: 550px; border: 1px solid #ffd800; color: #808080">
        <thead>
            <tr >
                <td>Ad</td>
                <td>Soyad</td>
                <td>Meslek</td>
                <td>Hakkında</td>
                <td>foto</td>
            </tr>
        </thead>
    </table>
    <asp:ListView ID="lstprofil" runat="server">
        <ItemTemplate>
            <div class="profildiv">
                <table border="1" style="width: 550px; border: 1px solid #ffd800; color: #ffffff">
                    <tbody>
                        <tr class="profiltr" >
                            <td>
                                <asp:Label Text='<%#Eval("isim")%>' runat="server" /></td>
                            <td>
                                <asp:Label Text='<%#Eval("meslek")%>' runat="server" /></td>
                            <td>
                                <asp:Label Text='<%#Eval("konum")%>' runat="server" /></td>
                            <td>
                                <asp:Image Class="profilresim" ImageUrl='<%#Eval("foto") %>' runat="server"/>
                            </td>
                        </tr>
                    </tbody>
                </table>

            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
