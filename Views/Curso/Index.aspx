<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Cursos</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCurso
            </th>
            <th>
                Descripcion
            </th>
              <th>
                IdEmpleado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "CursoEdit", new { id = item.IdCurso })%> |
                <%: Html.ActionLink("Detalles", "CursoDetails", new { id = item.IdCurso })%> |
                <%: Html.ActionLink("Borrar", "CursoDelete", new { id = item.IdCurso })%>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.IdEmpleado %>
            </td>
        </tr>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar", "CursoCreate")%>
         <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
     <a href="/Home/Index">Regresar a la lista</a> </center>
    </style>
    </p>

</body>
</html>


