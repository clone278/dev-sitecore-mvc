<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HomepageSublayout.ascx.cs" Inherits="dev.sitecore.mvc.Layouts.HomepageSublayout" %>


<div class="hero-unit">
  <h1>TITLE>>>>><%=Model.Title %></h1>
  <%=Model.MainBody %>
</div>