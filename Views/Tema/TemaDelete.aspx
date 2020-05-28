<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>TemaDelete</title>
</head>
<body><body style="background-color:#B82222 ;">
<center> <img align=right src="../../Content/Francisco420Photos/Leon.jpg" /> width="600" height="350"/> </center>
<fieldset>
    <h3>¿SEGURO QUE QUIERES ELIMINARLO?</h3>
 
         <br />
        
        <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdTema %></div>
    <br />
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
    </fieldset>

     <% using (Html.BeginForm()) { %>
        <p>
            <br />
		    <input type="submit" value="Eliminar" /> |
             <style>
    a { color: Black; } /* CSS link color */
  </style>

		    <%: Html.ActionLink("Regresar", "Index") %>
     
      </style>
        </p>
    <% } %>

</body>
</html>

