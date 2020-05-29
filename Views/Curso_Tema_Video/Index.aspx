<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Curso_Tema_Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<body style="background-color:#d2bbd7  ;">
    <center>
    
    <img align="right" src="../../Content/PacoYee6661Photos/Gowther.jpg" width="600" height="350"/>
    </center>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCTV
            </th>
            <th>
                IdCT
            </th>
            <th>
                IdVideo
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "CTVEdit", new { id = item.IdCTV })%> |
                <%: Html.ActionLink("Details", "CTVDetails", new { id = item.IdCTV })%> |
                <%: Html.ActionLink("Delete", "CTVDelete", new { id = item.IdCTV })%>
            </td>
            <td>
                <%: item.IdCTV %>
            </td>
            <td>
                <%: item.IdCT %>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Agregar nuevo registro", "CTVCreate") %>
    </p>

</body>
</html>

