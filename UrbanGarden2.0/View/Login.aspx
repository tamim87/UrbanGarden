 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UrbanGarden2._0.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="../Asset/Lib/Bootstrap/css/bootstrap.min.css"/>

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
                <img src="../Asset/Images/tree-deciduous.png" class="img-fluid"/>
            </div>
            <div class="col-md-4">
                <h1>Sign Up</h1>
                
                <form runat="server">
                    <div class="mb-3">
                    <label for="EmailId" class="form-label">Email address</label>
                    <input type="email" class="form-control" id="EmailId" runat="server" required="required">
                    </div>

                    <div class="mb-3">
                    <label for="UserPasswordTb" class="form-label">Password</label>
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
                        <asp:Button Text="  Login  " class="btn btn-danger btn-block" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click1" />
                
                    </div>

                </form>


            </div>

        </div>

    </div>

</body>
</html>
