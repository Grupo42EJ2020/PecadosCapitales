<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AgregarVideos</title>
</head>
<body>
 <form id="form1" runat="server">
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fomulario</legend>  
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Url) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Url) %>
                <%: Html.ValidationMessageFor(model => model.Url) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.FechaPublicacion) %>
            </div>
            <div class="editor-field">
                <%: Html.EditorFor(model => model.FechaPublicacion, new { type = "text", id = "FechaPublicacion" })%>
                <%: Html.ValidationMessageFor(model => model.FechaPublicacion) %>
            </div> 
            <br />         
             <input type="submit" value="Agregar" class="button" />         
        </fieldset>
    <% } %>
    <div>
        <%: Html.ActionLink("Regresar", "ConsultarVideos") %>
    </div>
    </form>
</body>
</html>
