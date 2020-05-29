<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>

<body style="background-color:#8537a7 ;">
    <img align="right" src="../../Content/ObedJassoPhotos/Merlin.jpg" width="600" height="350"/>
<meta name="viewport" content="width=device-width, initial-scale=1">
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdEmpleado
            </th>
            <th>
                Nombre
            </th>
            <th>
                Direccion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Edit", new { id=item.IdEmpleado }) %> |
                <%: Html.ActionLink("Ver Detalles", "Details", new {id=item.IdEmpleado })%> |
                <%: Html.ActionLink("Borrar", "Delete", new {id=item.IdEmpleado })%>
            </td>
            <td>
                <%: item.IdEmpleado %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Direccion %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
      <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
  <%: Html.ActionLink("Crear Nuevo Empleado", "Create") %>
  <style>
  a { color: Black; } /* CSS link color */
  </style> 
      <br />    
  <a href="/Home/Index">Regresar al inicio</a>
    </p>

</body>
</html>

