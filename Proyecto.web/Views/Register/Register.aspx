<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Proyecto.web.Views.Register.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Registro</title>
        <link href="../../css/styles.css" rel="stylesheet" />
        <script src="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/js/all.min.js" crossorigin="anonymous"></script>
        <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" crossorigin="anonymous"></script>
        <script src="../../js/scripts.js"></script>

        <link href="../../css/sweetalert.css" rel="stylesheet" />
        <script src="../../js/sweetalert.min.js" type="text/javascript"></script>

</head>
<body class="bg-primary">
        <div id="layoutAuthentication">
            <div id="layoutAuthentication_content">
                <main>
                    <div class="container">
                        <div class="row justify-content-center">
                            <div class="col-lg-7">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Crear Cuenta</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        
                                                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" type="text" placeholder="Enter your first name"></asp:TextBox>
                                                        <label for="txtNombre">Nombre</label>

                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-floating">
                                                        
                                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" type="text" placeholder="Enter your last name"></asp:TextBox>
                                                        <label for="txtApellido">Apellido</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="form-floating mb-3">
                                                
                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" type="email" placeholder="name@example.com"></asp:TextBox>
                                                <label for="txtEmail">Email</label>
                                            </div>
                                            <div class="row mb-3">
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        
                                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" type="password" placeholder="Create a password"></asp:TextBox>
                                                        <label for="txtPassword">Password</label>
                                                    </div>
                                                </div>
                                                <div class="col-md-6">
                                                    <div class="form-floating mb-3 mb-md-0">
                                                        
                                                        <asp:TextBox ID="txtConfrmPassword" runat="server" CssClass="form-control" type="password" placeholder="Confirm password"></asp:TextBox>
                                                        <label for="txtConfrmPassword">Confirmar Password</label>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="mt-4 mb-0">
                                                
                                                <div class="d-grid"><asp:Button ID="btnCreate" runat="server" Text="Crear Cuenta" href="../Login/Login.aspx" CssClass="btn btn-primary btn-block" OnClick="btnCreate_Click" /></div>
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="../Login/Login.aspx">Tiene una cuenta? Ingresar</a></div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </main>
            </div>
           
        </div>
        
    </body>
</html>
