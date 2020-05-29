<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Video>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Video</title>
</head>
<body style="background-color:#5a8d88 ;">
<meta name="viewport" content="width=device-width, initial-scale=1">
<img align="right" src="../../Content/ChendoPhotos/king.jpg" width="600" height="350"/>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdVideo
            </th>
            <th>
                Nombre
            </th>
            <th>
                Url
            </th>
            <th>
                FechaPublicacion
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "VideoEdit", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Detalles", "VideoDetails", new { id = item.IdVideo })%> |
                <%: Html.ActionLink("Eliminar", "VideoDelete", new { id = item.IdVideo })%>
            </td>
            <td>
                <%: item.IdVideo %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
            <td>
                <%: item.Url %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.FechaPublicacion) %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Crear Nuevo", "VideoCreate")%>
        <br />
        <a href="/Home/Index">Regresar</a>
    </p>

</body>
</html>

