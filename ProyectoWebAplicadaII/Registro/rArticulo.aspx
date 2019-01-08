<%@ Page Title="Articulo"  
     Language="C#"  
     MasterPageFile="~/Site.Master"  
     AutoEventWireup="true"  
     CodeBehind="rArticulo.aspx.cs"  
    Inherits="ProyectoWebAplicada.UI.Registros.rArticulo" %> 
 
 
 <asp:Content Id="Content1" ContentPlaceHolderID="MainContent" runat="server"> 
     <div class="panel panel-primary"> 
         <div 
             class="page-header text-center">
            <h1 style="font-size: x-large; font-family: 'Agency FB', Times, serif; font: bold;"><ins>Registro de Articulos</ins></h1>
            
             

         </div> 
 
 
         
 
         <div class="panel-footer"> 
             <div class="text-center"> 
                 <div class="form-group" style="display: inline-block"> 

 
                     <asp:Button Text="Nuevo" class="btn btn-warning btn-sm" runat="server" ID="NuevoButton" OnClick="NuevoButton_Click" /> 
                     <asp:Button Text="Guardar" class="btn btn-success btn-sm" runat="server" ID="GuadarButton" OnClick="GuadarButton_Click" /> 
                     <asp:Button Text="Eliminar" class="btn btn-danger btn-sm" runat="server" ID="EliminarButton" OnClick="EliminarButton_Click" /> 
 
 
                </div> 
            </div> 

 
         </div> 

      
 
 
</asp:Content> 
