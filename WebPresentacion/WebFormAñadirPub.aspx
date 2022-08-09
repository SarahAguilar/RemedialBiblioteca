<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAñadirPub.aspx.cs" Inherits="WebPresentacion.WebFormAñadirPub" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-gH2yIJqKdNHPEq0n4Mqa/HGKIhSkIHeL5AyhkYV8i59U5AR6csBvApHHNl/vI1Bx" crossorigin="anonymous">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server" class="container">
        <div class="row">
            <div class="col-6">
                 <div class="mb-3 row">
                <asp:Label ID="Label2" runat="server" Text="Titulo:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxtitulo" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="Label3" runat="server" Text="Numero de ejemplar:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxEjemplar" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>


        </div>
            <div class="mb-3 row">
            <div class="col-2">
            </div>
            <div class="col-8">
                <asp:TextBox ID="TextBoxStatus" runat="server" disabled class="col-sm-12 mb-3"></asp:TextBox>
                <asp:Button ID="ButtonAgregar" runat="server" Text="A G R E G A R" class="btn btn-success col-sm-12" OnClick="ButtonAgregar_Click"/>

            </div>
            <div class="col-2">
            </div>
        </div>
    </form>
</body>
</html>
