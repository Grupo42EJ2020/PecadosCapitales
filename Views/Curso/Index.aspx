<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Cursos</title>

</head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<body> 
<body style="background-color:#B82222 ;">
    <center>
    
    <img align="right" src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/>
    </center>
    <table>
        <tr>
            <th></th>
            <th>
                Numero del Curso
            </th>
            <th>
                Descripcion del Curso
            </th>
              <th>
                Numero del Empleado que lleva este Curso
            </th>
        </tr>
        <br />
    <% foreach (var item in Model) { %>
    
        <tr>
            <td> 
                <%: Html.ActionLink("Editar", "CursoEdit", new { id = item.IdCurso })%> |
                
                <%: Html.ActionLink("Detalles", "CursoDetails", new { id = item.IdCurso })%> |

                <%: Html.ActionLink("Borrar", "CursoDelete", new { id = item.IdCurso })%>
            </td>
            <td>
                <center>
                
                <%: item.IdCurso %>
                </center>
            </td>
            <td>
            <center>
                <%: item.Descripcion %>
                 </center>
            </td>
            <td>
            <center>
                <%: item.IdEmpleado %>
                 </center>
            </td>
        </tr>
            
        </tr>
    
    <% } %>

    </table>

    <p>
        <br />
    <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
        <%: Html.ActionLink("AGREGAR", "CursoCreate")%>
         <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
     <a href="/Home/Index">REGRESAR A LA LISTA</a> </center>
    </style>
    </p>

</body>
</html>


