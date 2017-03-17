<!DOCTYPE HTML>
<script runat="server">

    Protected Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
</script>

<html>
	<head>
		<title>Test Glasses</title>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1" />
		<link rel="stylesheet" href="main.css" type="text/css"/>
	</head>
	<body>
        
       <!-- Header -->
	<header id="header">
		<div class="inner">
			<nav id="nav">
			    <a href="index.aspx">Home</a>
			    <a href="cadastro.aspx">Cadastro</a>
			    <a href="contato.aspx">Contato</a>
			</nav>
			<a href="#navPanel" class="navPanelToggle"><span class="fa fa-bars"></span></a>
		</div>
	</header>

        <!-- Cadastro -->
<!-- Footer -->
	<footer id="footer">
		<div class="login" style="
    background-color: rgb(141, 204, 169);
    margin-left: 10em;
    margin-right: 10em;">
			<h3>Login</h3>
			<img src="login.png"/>
            <form id="form1" runat="server">

        <table cellspacing="10">
            <tr>
            <td>
                <label for="user">* User</label>
            </td>
            <tr>
                
             <td align="left">
                <input type="text" name="user" value="User">
            </td>
            </tr>
            <tr>
              <td>
                <label for="email">* Email</label>
              </td>
                <tr>
              <td align="left">
                <input type="text" name="email" value="Email">
              </td>
            </tr>
            <tr>
                <td>
                <label for="senha">* Senha</label>
            </td>
            <tr>
            <td align="left">
                <input type="text" name="senha" value="Senha">
                   <br />
                <asp:Button ID="Button1" runat="server" Text="Pronto" />    
            </td>
            </tr>
            </tr>
            </tr>
         </table>
			</form>
			</div>
		</footer>
	</body>	
	</head>
</html>
