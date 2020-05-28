<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>TemaEdit</title>
</head>
<body><body style="background-color:#B82222 ;"> 
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <center> 
      
    <h1> EDITAR UN TEMA</h1></center>
            
  <center> <img align=left src="../../Content/Francisco420Photos/Leon.jpg"width="600" height="350"/> </center>
                  
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
              </center>

    <% } %>

   <div>
     <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
        <%: Html.ActionLink("Regresar", "Index") %>
        </style>
      </center>
    </div>

</body>
</html>

