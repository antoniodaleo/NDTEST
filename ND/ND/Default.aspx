<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ND.Default" %>

<!DOCTYPE html lang="pt-br">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>Agenda de Contatos - Desenvolvido por Antonio D'Aleo</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link href="Css/css/bootstrap.min.css" rel="stylesheet">
    <!--Simple Menu to insert<link href="Css/style.css" rel="stylesheet" />-->
</head>
<body>
    

      <div class="container">
          <div class="row">
              <!-- Image and text -->
                <nav class="navbar navbar-light bg-light">
                  <a class="navbar-brand" href="#">
                    <img src="Image/icona.png" width="30" height="30" class="d-inline-block align-top" alt="">
                    Agenda de Contatos® 
                  </a>
                </nav>
          </div> 
          
               
           <div class="row" style="margin-top:5px " > 
             <nav class="nav nav-pills nav-justified">
                  <a class="nav-item nav-link active" href="#">Home</a>
                  <a class="nav-item nav-link" href="#">Cadastro</a>
                  <a class="nav-item nav-link" href="#">Listar</a>
                  <a class="nav-item nav-link disabled" href="#">About me</a>
             </nav>
          </div>       
          <!--End Menu-->
          
          
          <div class="row" >
              
          </div>
           <!--End White Space-->

    
          
              <form id="form2" runat="server">
                <div class="form-row " style="margin-top:70px">       
                    <div class="form-group col-md-6">
                        <asp:Label ID="lblFirstNome" runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="txtFirstNome" runat="server" ToolTip="Preencha o campo" placeholder="O seu nome" CssClass="form-control" required autofocus></asp:TextBox>
                    </div> 
                    <div class="form-group col-md-6">
                        <asp:Label ID="lblEndereco" runat="server" Text="Endereco"></asp:Label>
                        <asp:TextBox ID="txtEndereco" runat="server" ToolTip="Preencha o campo" placeholder="Endereco" CssClass="form-control" required></asp:TextBox>
                    </div>      
                </div><!--End 1 row--> 
                <div class="row">
                   <div class="form-group col-md-4">
                       <asp:Label ID="lblLograduro" runat="server" Text="Lograduro"></asp:Label>
                       <asp:TextBox ID="txtLograduro" runat="server" placeholder="Lograduro" ToolTip="Preencha o campo" CssClass="form-control" required></asp:TextBox>
                   </div>     
                   <div class="form-group col-md-4">
                       <asp:Label ID="lblNumero" runat="server" Text="Numero"></asp:Label>
                       <asp:TextBox ID="txtNumero" runat="server" TextMode="Number" placeholder="N." CssClass="form-control"></asp:TextBox>
                   </div>     
                   <div class="form-group col-md-4">
                       <asp:Label ID="lblComplemento" runat="server" Text="Complemento"></asp:Label>
                       <asp:TextBox ID="txtComplemento" runat="server"  placeholder="Complemento" CssClass="form-control"></asp:TextBox>
                   </div>
                </div><!--End 2 row-->  
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblNum1" runat="server" Text="Fone"></asp:Label>
                        <asp:TextBox ID="TextNum1" runat="server" CssClass="form-control" placeholder="Fone" TextMode="Phone"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblNum2" runat="server" Text="Fone"></asp:Label>
                        <asp:TextBox ID="TextNum2" runat="server" CssClass="form-control" placeholder="Fone" TextMode="Phone"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblNum3" runat="server" Text="Fone"></asp:Label>
                        <asp:TextBox ID="TextNum3" runat="server" CssClass="form-control" placeholder="Fone" TextMode="Phone"></asp:TextBox>
                    </div>
                </div> <!--End 3 row-->   
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblResidencial" runat="server" Text="Residencial"></asp:Label>
                        <asp:TextBox ID="txtResidencial" runat="server" CssClass="form-control" placeholder="Recidencial" TextMode="Phone"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblCommercial" runat="server" Text="Fone"></asp:Label>
                        <asp:TextBox ID="txtCom1" runat="server" CssClass="form-control" placeholder="Comercial" TextMode="Phone"></asp:TextBox>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="Label3" runat="server" Text="Fone"></asp:Label>
                        <asp:TextBox ID="txtCom2" runat="server" CssClass="form-control" placeholder="Commercial" TextMode="Phone"></asp:TextBox>
                    </div>
                </div> <!--End 4 row--> 
                <div class="form-row">
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblDpBairro" runat="server" Text="Bairro"></asp:Label>
                        <asp:DropDownList ID="dpBairro" runat="server" CssClass="dropdown form-control" ></asp:DropDownList>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="lblDpGrupo" runat="server" Text="Grupo"></asp:Label>
                        <asp:DropDownList ID="dpGrupo" runat="server" CssClass="dropdown form-control" ></asp:DropDownList>
                    </div>
                    <div class="form-group col-md-4">
                        <asp:Label ID="lbl" runat="server" Text="Data de Cadastro"></asp:Label>
                        <asp:TextBox ID="txtData" runat="server" CssClass="form-control" TextMode="Date"></asp:TextBox>
                    </div>
                </div>  <!--End 5 row-->
                <div class="form-row">
                    <div class="form-group">
                        <asp:Button ID="btnCadastrar" type="button" data-toggle="tooltip"  runat="server"  data-placement="right" Text="Cadastra" CssClass="btn btn-secondary" title="Cliqua para cadastrar-se"/>
                    </div>

                </div>          
             </form> 
         
          <!--End Form-->  


          
          </div>


          
                    

        




      </div><!-- End Container Main-->

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
  </body>
</html>
