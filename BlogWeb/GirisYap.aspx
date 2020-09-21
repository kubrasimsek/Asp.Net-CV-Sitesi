<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GirisYap.aspx.cs" Inherits="BlogWeb.GirisYap" %>

<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

<!DOCTYPE html>
<html>
<head>
	<title>Login Page</title>
   
	<!--Bootsrap 4 CDN-->
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
    
    <!--Fontawesome CDN-->
	<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.3.1/css/all.css" integrity="sha384-mzrmE5qonljUremFsqc01SB46JvROS7bZs3IO2EmfFsd15uHvIt+Y8vEf7N7fWAU" crossorigin="anonymous">

	<!--Custom styles-->
	<link href="GirisCss.css" rel="stylesheet" />
</head>
<body>
<div class="container">
	<div class="d-flex justify-content-center h-100">
		<div class="card">
			<div class="card-header">
				<h3>Oturum Aç</h3>
				<div class="d-flex justify-content-end social_icon">
					<span><i class="fab fa-facebook-square"></i></span>
					<span><i class="fab fa-twitter-square"></i></span>
					<span><i class="fab fa-youtube-square"></i></span>
					<span><i class="fab fa-instagram"></i></span>
				</div>
			</div>
			<div class="card-body">
				<form runat="server" >
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-user"></i></span>
						</div>
                        <%--<input type="text" class="form-control" placeholder="username">--%>
						<asp:TextBox ID="txtKullanici" runat="server" CssClass="form-control"
							PlaceHolder="Kullanıcı Adı"></asp:TextBox>
						
					</div>
					<div class="input-group form-group">
						<div class="input-group-prepend">
							<span class="input-group-text"><i class="fas fa-key"></i></span>
						</div>
                        <%--<input type="password" class="form-control" placeholder="password">--%>
						<asp:TextBox ID="txtSifre" runat="server" CssClass="form-control"
							PlaceHolder="Şifre" TextMode="Password"></asp:TextBox>

					</div>
					<div class="row align-items-center remember">
						<input type="checkbox">Beni Hatırla
					</div>
					<div class="form-group">
                        <%--<input type="submit" value="Giriş Yap" class="btn float-right login_btn">--%>
					<asp:Button ID="btnGirisYap" runat="server" Text="Giriş Yap" CssClass="btn float-right login_btn" OnClick="btnGirisYap_Click"/>
					</div>
				</form>
			</div>
			<div class="card-footer">
				<div class="d-flex justify-content-center links">
					Hesabın Var Mı?<a href="#">Kayıt Ol</a>
				</div>
				<div class="d-flex justify-content-center">
					<a href="#">Şifremi Unuttum?</a>
				</div>
			</div>
		</div>
	</div>
</div>
</body>
</html>
