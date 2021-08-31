<%@ Page Title="" Language="C#" MasterPageFile="~/Recourses/Template/Template.Master" AutoEventWireup="true" CodeBehind="PosiblesClientes.aspx.cs" Inherits="Proyecto.web.Views.PosiblesClientes.PosiblesClientes" %>
<asp:Content ID="ContentHeader" ContentPlaceHolderID="header" runat="server">
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <link href="../../css/sweetalert.css" type="text/css" rel="stylesheet"/>


</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenedor" runat="server">
    <div class="mx-auto mt-5">
     <%--Primera seccion --%>
         
            <div class=" row">
                <div class="col-md-12">
                    <h1>
                        <b>Posibles Clientes</b><asp:Label ID="lblOpcion" runat="server" Text="" Visible="false"></asp:Label>

                    </h1>
                </div>
               
            </div>
   

            <div class="row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblIdentificacion" Text="Identificacion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtIdentificacion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblEmpresa" Text="Empresa"></asp:Label>
                    <asp:TextBox runat="server" ID="txtEmpresa" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerNombre" Text="Primer Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerNombre" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoNombre" Text="Segundo Nombre"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoNombre" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
        
        <%--Segunda Seccion--%>
        
            <div class="row">
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblPrimerApellido" Text="Primer Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtPrimerApellido" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblSegundoApellido" Text="Segundo Apellido"></asp:Label>
                    <asp:TextBox runat="server" ID="txtSegundoApellido" CssClass="form-control"></asp:TextBox>

                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblDireccion" Text="Direccion"></asp:Label>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="col-md-3">
                    <asp:Label runat="server" ID="lblTelefono" Text="Telefono"></asp:Label>
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
   

          <%--Tercera Seccion--%>
        
            <div class="row">
                <div class="col-md-12">
                    <asp:Label runat="server" ID="lblCorreo" Text="Correo"></asp:Label>
                    <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"></asp:TextBox>
                </div>
               
            </div>
      
         <%--Cuarta Seccion--%>
        
            <div class="row">
                <div class="col-md-12">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar"  CssClass="btn btn-primary" OnClick="btnGuardar_Click"/>
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  CssClass="btn btn-primary"/>
                </div>
               
            </div>
        

          <%--Quinta Seccion--%>
       
            <div class="row">
                <div class="col-md-12">
                     <h1>
                        <b>Resultados</b>

                    </h1>
                    
                </div>
               
            </div>
        
       
            <div class="row">
                <div class="col-md-12" style="overflow:auto">
                   <asp:GridView runat="server" ID="gvwDatos" 
                       Width="100%" 
                       AutoGenerateColumns="false"  
                       EmptyDataText="No se encontraron registros" 
                       OnRowCommand="gvwDatos_RowCommand">
                       <Columns>
                           
                           <asp:TemplateField HeaderText="Identificacion">
                               <ItemTemplate>
                                   <asp:Label runat="server" ID="lblIdentificacion" Text='<%# Bind("clieIdentificacion") %>'></asp:Label>
                               </ItemTemplate>
                               
                           </asp:TemplateField>
                           <asp:BoundField HeaderText="Empresa" DataField="clieEmpresa" />
                           <asp:BoundField HeaderText="Primer Nombre" DataField="cliePrimerNombre" />
                           <asp:BoundField HeaderText="Segundo Nombre" DataField="clieSegundoNombre" />
                           <asp:BoundField HeaderText="Primer Apellido" DataField="cliePrimerApellido" />
                           <asp:BoundField HeaderText="Segundo Apellido" DataField="clieSegundoApellido" />
                           <asp:BoundField HeaderText="Direccion" DataField="clieDireccion" />
                           <asp:BoundField HeaderText="Telefono" DataField="clieTelefono" />
                           <asp:BoundField HeaderText="Correo" DataField="clieCorreo" />
                           <%--EDITAR--%>

                            <asp:TemplateField HeaderText="Editar">
                               <ItemTemplate>
                                  <asp:ImageButton ID="IbEditar" runat="server" ImageUrl="~/Recourses/Images/edit.gif" CommandName="Editar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                  
                               </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                               
                           </asp:TemplateField>

                            <%--ELIMINAR--%>

                            <asp:TemplateField HeaderText="Eliminar">
                               <ItemTemplate>
                                  <asp:ImageButton ID="IbEliminar" runat="server" ImageUrl="~/Recourses/Images/remove.gif" CommandName="Eliminar" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" />
                                  
                               </ItemTemplate>
                                <ItemStyle HorizontalAlign="Center" />
                               
                           </asp:TemplateField>
                       </Columns>


                   </asp:GridView>
                </div>
               
            </div>
        
    </div>
</asp:Content>
