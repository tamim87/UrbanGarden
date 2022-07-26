<%@ Page Title="Products" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="UrbanGarden2._0.View.Admin.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4"></div>
            <div class="col-md-8"><br /><img src="../../Asset/Images/seedling_solid.png" height="auto" width="80px"/><h3 class="text-primary">Manage Products</h3></div>
        </div>
        <div class="row">
            <div class="col-md-4">
                <h2 class="text-primary">Products Details</h2>
            
                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Name</label>
                    <input type="text" class="form-control" id="PNameTb" runat="server">
                </div>
                
                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Category</label>
                    <%--<input type="text" class="form-control" id="CategoryTb" runat="server">--%>
                    <asp:DropDownList ID="CategoryCb" class="form-control" runat="server" ></asp:DropDownList>
                </div>

                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Price</label>
                    <input type="text" class="form-control" id="PriceTb" runat="server">
                </div>

                <div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Product Quantity</label>
                    <input type="text" class="form-control" id="ProductQtyTb" runat="server">
                </div>

                <%--<div class="mb-3">
                    <label for="exampleInputEmail1" class="form-label">Expiration Date</label>
                    <input type="date" class="form-control" id="ExpDate">
                </div>--%>

                <label id="ErrMsg" runat="server" class="text-danger"></label>
                <br /><br />

                <asp:Button text="   Edit   " class="btn btn-dark" runat="server" ID="EditBtn" OnClick="EditBtn_Click"/>
                <asp:Button text="   Save   " class="btn btn-dark" runat="server" ID="SaveBtn" OnClick="SaveBtn_Click"/>
                <asp:Button text="   Delete   " class="btn btn-dark" runat="server" ID="DeleteBtn" OnClick="DeleteBtn_Click"/>
                <br /><br /><br />
            </div>

            <div class="col-md-8">
                <!--table start-->
                <asp:GridView runat="server" class="table table-hover" ID="ProductGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ProductGV_SelectedIndexChanged" >

                </asp:GridView>
            </div>
        
        </div>
    </div>        
</asp:Content>
