<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body style="background-color:#B82222 ;">
    <center>
    
    <img align="right" src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/>
    </center>
    <table>
        <tr>
            <th></th>
            <th>
               Numero del Curso_Tema
            </th>
            <th>
                Numero del Curso
            </th>
            <th>
                Numero del Tema
            </th>
        </tr>
        <br />
    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Curso_TemaEdit", new { id=item.IdCT }) %> |
                <%: Html.ActionLink("Details", "Curso_TemaDetails", new {id=item.IdCT})%> |
                <%: Html.ActionLink("Delete", "Curso_TemaDelete", new { id = item.IdCT })%>
            </td>
            <td>
                <%: item.IdCT %>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
        </tr>
    
    <% } %>

    </table>
    <p>
        <br />
    <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
        <%: Html.ActionLink("AGREGAR", "Curso_TemaCreate")%>
         <style>
    a { color: Black; } /* CSS link color */
  </style>
    <p>
        <%: Html.ActionLink("Create New", "Curso_TemaCreate") %>
        <a href="/Home/Index">REGRESAR A LA LISTA</a>
    </p>

</body>
</html>

