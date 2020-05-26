<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Tema>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Tema</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                Número del tema
            </th>
            <th>
                Nombre
            </th>
        </tr>
        <br/>
    <% foreach (var item in Model) { %>
    
        <tr>
             <td>
                <%: Html.ActionLink("Editar", "TemaEdit", new { id = item.IdTema })%> |
                
                <%: Html.ActionLink("Detalles", "TemaDetails", new { id = item.IdTema })%> |

                <%: Html.ActionLink("Borrar", "TemaDelete", new { id = item.IdTema })%>
            </td>
            <td>
            <center>
                <%: item.IdTema %>
                 </center>
            </td>
            <td>
             </center>
                <%: item.Nombre %>
                 </center>
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
        <%: Html.ActionLink("AGREGAR", "TemaCreate")%>
         <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
     <a href="/Home/Index">REGRESAR A LA LISTA</a> </center>
    </style>
    </p>

</body>
</html>

