<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdatePost.aspx.cs" Inherits="n01237816_HTTP5101_FinalProject.UpdatePost" %>
<asp:Content ID="updatepost" ContentPlaceHolderID="body" runat="server">
    <div id="post" runat="server">
        <div class="postnav">
            <a class="left" href="ReadPost.aspx?pageid=<%=Request.QueryString["page_id"] %>">Cancel</a>
        </div>
        <h2>Updating Post: <span id="posttitle" runat="server"></span></h2>
        
        <div class="forminput">
            <label>Title</label>
            <asp:TextBox runat="server" ID="post_title"></asp:TextBox>
        </div>
        <div class="formtextarea">
            <label>Post Content</label>
            <asp:TextBox runat="server" ID="post_body"></asp:TextBox>
        </div>

        <asp:Button Text="Update Post" OnClick="Update_Post" runat="server" />
    </div>
</asp:Content>
