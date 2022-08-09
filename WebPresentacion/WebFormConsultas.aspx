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
            <div class="col-6">
                 <div class="mb-3 row">
                <asp:Label ID="Label2" runat="server" Text="Nombre:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxNombre" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="Label3" runat="server" Text="Colonia:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxColonia" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="Label4" runat="server" Text="Numero:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxNumero" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>

            <div class="mb-3 row">
                <asp:Label ID="Label5" runat="server" Text="C.P:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxCP" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="mb-3 row">
                <asp:Label ID="Label1" runat="server" Text="Centro de trabajo:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxTrabajo" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
        <div class="mb-3 row">
                <asp:Label ID="Label6" runat="server" Text="Telefono:" class="col-sm-3 col-form-label"></asp:Label>
                <div class="col-sm-9">
                    <asp:TextBox ID="TextBoxTelefono" runat="server" class="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="col-6">

            </div>

        </div>
            <div class="mb-3 row">
            <div class="col-2">
            </div>
            <div class="col-8">
                <asp:TextBox ID="TextBoxStatus" runat="server" disabled class="col-sm-12 mb-3"></asp:TextBox>
                <asp:Button ID="ButtonAgregar" runat="server" Text="A G R E G A R" class="btn btn-success col-sm-12" OnClick="ButtonAgregar_Click"/>

            </div>
        </div>
            </div>
            <div class="col-2"></div>
        </div>
    </form>
</body>
</html>
