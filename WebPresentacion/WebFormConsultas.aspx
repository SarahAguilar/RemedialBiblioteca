<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormConsultas.aspx.cs" Inherits="WebPresentacion.WebFormConsultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-10">
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
            <div class="col-2"></div>
        </div>
    </form>
</body>
</html>
