<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.RepositorioCurso_Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Curso_Tema</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCT
            </th>
        </tr>
    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Curso_TemaEdit", new { id = item.IdCT})%> |
                <%: Html.ActionLink("Detalles", "Curso_TemaDetails", new { id = item.IdCT })%> |
                <%: Html.ActionLink("Borrar", "Curso_TemaDelete", new { id = item.IdCT })%>
            </td>
            
            <td>
                <%: item.IdCT %>
            </td>
            
        </tr>
    
    <% } %>

    </table>

   <p>
        <%: Html.ActionLink("Agregar", "Curso_TemaCreate")%>
         <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
     <a href="/Home/Index">Regresar a la lista</a> </center>
    </style>
    </p>

</body>
</html>

