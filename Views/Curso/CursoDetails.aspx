<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>CursoDetails</title>
</head>
<body><body style="background-color:#B82222;">
<center> <h1> DETALLES DEL CURSO</h1></center>

  <center> <img align=right src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/> </center>
  
        
        
        <div class="display-label">IdCurso</div>
        <div class="display-field"><%: Model.IdCurso %></div>
    <br />

        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
    <br />
         
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
      
    
    <p>
        <br />
     <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
       <%: Html.ActionLink("EDITAR", "CursoEdit", new { id = Model.IdCurso})%> 
      <br />
        <%: Html.ActionLink("REGRESAR", "Index") %>
        </center>
        </style>
    </p>

</body>
</html>

