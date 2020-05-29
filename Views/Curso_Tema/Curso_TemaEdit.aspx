<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Curso_Tema>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Curso_TemaEdit</title>
</head>
<body><body style="background-color:#B82222 ;"> 

    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        <center> 
      
    <h1> Editar un Curso_Tema</h1></center>

  <center> <img align=left src="../../Content/IrvingPhotos/pecados.png" width="600" height="350"/> </center>
            
           <center> 
            <div class="editor-label">
                <%: Html.LabelFor(model => model.IdCurso) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdCurso)%>
                <%: Html.ValidationMessageFor(model => model.IdCurso)%>
            </div>

             <div class="editor-label">
                <%: Html.LabelFor(model => model.IdTema) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.IdTema)%>
                <%: Html.ValidationMessageFor(model => model.IdTema)%>
            </div>

            <p>
                <input type="submit" value="Guardar" />
            </p>
        </center>

    <% } %>

    <div>
    <style>
    a { color: Black; } /* CSS link color */
  </style>
  <center> 
        <%: Html.ActionLink("Regresar", "Index") %>
        </style>
      </center>
    </div>

</body>
</html>
