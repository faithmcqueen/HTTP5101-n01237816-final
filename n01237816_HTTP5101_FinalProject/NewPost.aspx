<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPost.aspx.cs" Inherits="n01237816_HTTP5101_FinalProject.NewPost" %>
<asp:Content ID="new_post" ContentPlaceHolderID="body" runat="server">
    <h2>New Post</h2>
    <div class="forminput">
        <asp:label runat="server" for="page_title">Page Title:</asp:label>
        <asp:TextBox runat="server" id="page_title"></asp:TextBox>
    </div>
    <div class="formtextarea">
        <asp:label runat="server" for="page_body">Post body:
        </asp:label>
        <asp:TextBox runat="server" ID="page_body" TextMethod="multiline" Height="100"></asp:TextBox>
    </div>
    <asp:Button OnClick="AddPost" Text="Add Post" runat="server" />
</asp:Content>
