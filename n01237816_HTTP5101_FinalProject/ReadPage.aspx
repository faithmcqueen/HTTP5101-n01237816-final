<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReadPage.aspx.cs" Inherits="n01237816_HTTP5101_FinalProject.ReadPage" %>
<asp:Content ID="post_pg" ContentPlaceHolderID="body" runat="server">
    <div class="post_nav">
        <!-- View All Posts -->
        <a class="float-l" href="ListPosts.aspx">View All Posts</a>
         <!-- Edit Post -->
        <a class="float-r" href="EditPage.aspx?pageid=<%=Request.QueryString["page_id"] %>">Edit</a>
        <!-- Delete Post -->
        <ASP:Button OnClientClick="if(!confirm('Are you sure you want to delete this?')) return false;" OnClick="Delete_Post" CssClass="right spaced" Text="Delete" runat="server"/> 

    </div>

    <div id="post" runat="server">
        <span id="posttitle" runat="server"></span>
        <span id="postbody" runat="server"></span>
    </div>
</asp:Content>
