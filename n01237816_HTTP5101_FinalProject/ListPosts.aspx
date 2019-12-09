<%@ Page Title="Posts" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListPosts.aspx.cs" Inherits="n01237816_HTTP5101_FinalProject.ListPosts" %>
<asp:Content ID="post_list" ContentPlaceHolderID="body" runat="server">
    <h1>All Posts</h1>
    <!-- search post information -->
    <div id="post_nav">
        <asp:label for="post_search" runat="server">Search:</asp:label>
        <asp:label ID="post_search" runat="server"></asp:label>
        <asp:Button runat="server" text="Submit" />
    </div>
    <!-- New Posts link -->
    <a href="NewPost.aspx">Create New Post</a>
    <!-- list of all posts in database -->
    <div class="full_list" runat="server">
        <div class="list_item">
            <div>PAGE TITLE</div>
            <!-- <div class="col4">AUTHOR</div>
            <div class="col4">PUBLISHED DATE</div> -->
        </div>
        <div id="posts_result" runat="server"></div>
    </div>

</asp:Content>
