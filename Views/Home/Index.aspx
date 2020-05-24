<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Inicio</title>
    <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
    background: #B82222;
    font-family:Arial ; 
    }
    a:link, a:visited{
    text-decoration: none;
    padding: 15px;
    font-family: Helvetica;
    text-transform: uppercase;
    padding-left: 10px;
    padding-right: 15px;
    font-weight: 200;
    font-size: 25px;
    color: black;
    width:270px;
    height:30px;
    text-align:center;
    display: inline-block;
    margin: 25px 50px 0 50px;
    background-color: #B82222;
    }
    a:hover{
    color: #4c5557;
    background-color: #dff2f7;
    text-decoration: none;
    }           
    </style>
</head>
<body>
    <hr />
    <center>
    <img src="../../Content/IrvingPhotos/pecados.png" width="400" height="200"/>
    </center>
    <h1><center>Bienvenido a la pagina oficial de los 7 pecados capitales </center>
     </h1>
    <center>
    <a href="//">EMPLEADO</a> 
        <br />
    <a href="/Curso/Index">CURSO</a> 
        <br />
    <a href="//">TEMA</a> 
        <br />
    <a href="/Curso_Tema/Index">CURSO_TEMA</a> 
        <br />
    <a href="//">CURSO_TEMA_VIDEO</a> 
        <br />
    <a href="/Video/Video">VIDEO</a> 
        <br />
    </center>
     
    <marquee> <img src="../../Content/IrvingPhotos/pecados.png" width="100" height="50"/></marquee>
</body>
</html>
