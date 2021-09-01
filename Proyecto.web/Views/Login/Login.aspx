<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto.web.Views.Login.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta charset="utf-8" />
        <meta http-equiv="X-UA-Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
        <meta name="description" content="" />
        <meta name="author" content="" />
        <title>Login</title>
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
                            <div class="col-lg-5">
                                <div class="card shadow-lg border-0 rounded-lg mt-5">
                                    <div class="card-header"><h3 class="text-center font-weight-light my-4">Login</h3></div>
                                    <div class="card-body">
                                        <form runat="server">
                                            <div class="form-floating mb-3">
                                                
                                                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" type="email" placeholder="name@example.com"></asp:TextBox>
                                                <asp:Label ID="lblEmail" runat="server" Text="Email address" for="inputEmail"></asp:Label>
                                            </div>
                                            <div class="form-floating mb-3">
                                                <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" type="password"></asp:TextBox>
                                                <asp:Label ID="lblPassword" runat="server" Text="Password" for="txtPassword"></asp:Label>
                                            </div>
                                            <div class="form-check mb-3">
                                                <asp:CheckBox ID="chkRecordar" runat="server" CssClass="" />
                                                
                                                <label class="form-check-label" for="chkRecordar">Recordar Usuario</label>
                                            </div>
                                            <div class="d-flex align-items-center justify-content-between mt-4 mb-0">
                                                <a class="small" href="#">Olvidó Password?</a>
                                                
                                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="btn btn-primary btn-block" OnClick="btnAceptar_Click" />
                                            </div>
                                        </form>
                                    </div>
                                    <div class="card-footer text-center py-3">
                                        <div class="small"><a href="../Register/Register.aspx">Necesita una cuenta?</a></div>
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
