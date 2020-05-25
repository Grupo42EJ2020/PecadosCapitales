<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>CursoDelete</title>
</head>
<body><body style="background-color:#B82222 ;">
<center> <img align=right src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/> </center>
    <fieldset>
    <h3>¿SEGURO QUE QUIERES ELIMINARLO?</h3>
   
        
    <br />
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
    <br />
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
      
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
