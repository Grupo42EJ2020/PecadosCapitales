<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Curso_TemaDelete</title>
</head>
<body><body style="background-color:#B82222 ;">
<center> <img align=right src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/> </center>
    <fieldset>
    <h3>¿Seguro que quieres eliminarlo?</h3>
        
     <br />
        <div class="display-label">IdCT</div>
        <div class="display-field"><%: Model.IdCT %></div>

     <br />
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso%></div>

      <br />
        
       <div class="display-label">IdTema</div>
        <div class="display-field"><%: Model.IdTema%></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
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
