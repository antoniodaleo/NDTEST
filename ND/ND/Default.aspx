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
     
           <div class="row" > 
              <ul class="nav nav-pills">
                <li><a href="#" class="active">Home</a></li>              
                <li><a href="#">Cadastro</a></li>                          
                <li><a href="#">Pesquisa</a></li>
                <li><a href="#">About me</a></li>
              </ul>
          </div>       
          <!--End Menu-->
          
          
          <div class="row">
              <p></p>
          </div>
           <!--End White Space-->

    
          
              <form id="form2" runat="server">
                <div class="form-row">       
                    <div class="form-group col-md-6">
                        <asp:Label ID="lblFirstNome" runat="server" Text="Nome"></asp:Label>
                        <asp:TextBox ID="txtFirstNome" runat="server" placeholder="O seu nome" CssClass="form-control" ></asp:TextBox>
                    </div> 
                    <div class="form-group col-md-6">
                        <asp:Label ID="lblSecondName" runat="server" Text="Apelido"></asp:Label>
                        <asp:TextBox ID="txtApelido" runat="server" placeholder="O seu apelido" CssClass="form-control"></asp:TextBox>
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
