 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UrbanGarden2._0.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Urban Garden Login</title>
    <link rel="stylesheet" href="../Asset/Lib/Bootstrap/css/bootstrap.min.css"/>
    <style>
        html{
            scroll-behavior: smooth;
        }
        
        body{
            background-image: url("/Asset/Images/succulent_cropped.jpg");
            background-position: center;
            background-attachment: fixed;
            background-repeat: no-repeat;
            background-size: cover;
        }
        img{
            opacity:0.01;
            padding:0px, 0px, 90px, 0px;
            float:left;
        }
        
    </style>

</head>
<body>
    <%--<form id="form1" runat="server">
        <div>
        </div>
    </form>--%>
    <div class="container-fluid">
        <div class="row" style="height:90px"></div>
        <div class="row">
            <div class="col-md-2"></div>
            <div class="col-md-4">
                <img src="../Asset/Images/tree-deciduous.png" alt="no img"  class="img-fluid"/>
            </div>
            <%--<div class="col-1"></div>--%>
            <div class="col-md-4"><br /><br /><br /><br />
                <h1 class="text-danger">Sign In</h1>
                
                <form runat="server">
                    <div class="mb-3">
                    <label for="EmailId" class="form-label text-danger">Email address</label>
                    <input type="email" class="form-control" id="EmailId" runat="server" required="required">
                    </div>

                    <div class="mb-3">
                    <label for="UserPasswordTb" class="form-label text-danger">Password</label>
                    <input type="password" class="form-control" id="UserPasswordTb" runat="server" required="required">
                    </div>
                    
                    <div class="mb-3 form-group">
                    <input type="radio" class="form-check-input" id="SellerRadio" name="Role" runat="server">
                    <label class="form-check-label" for="exampleCheck1">Seller</label>
                    <input type="radio" class="form-check-input" id="AdminRadio" checked="true" name="Role" runat="server">
                    <label class="form-check-label" for="AdminRadio" >Admin</label>
                    </div>
                    
                    <div class="mb-3 d-grid">
                        <label id="infomsg" runat="server" class="text-danger"></label>
                        <asp:Button Text="  Login  " class="btn btn-dark btn-block" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click1" />
                
                    </div>

                </form>


            </div>

        </div>

    </div>

</body>
</html>
