<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>TemaDetails</title>
</head>
<body><body style="background-color:#B82222;">

<center> <h1> DETALLES DEL TEMA</h1></center>
 <center><img align=right src="../../Content/Francisco420Photos/Leon.jpg" width="600" height="350"/> </center>

        
       <div class="display-label">Numero del Tema</div>
        <div class="display-field"><%: Model.IdTema %></div>
    <br />

        <div class="display-label">Descripcion Del Tema</div>
        <div class="display-field"><%: Model.Nombre %></div>
    <br />

    <p>
     <br />
     <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
       <%: Html.ActionLink("EDITAR", "TemaEdit", new { id = Model.IdTema})%> 
      <br />
        <%: Html.ActionLink("REGRESAR", "Index") %>
        </center>
        </style>
   </p>

</body>
</html>

