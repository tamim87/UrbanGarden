<%@ Page Title="Dashboard" Language="C#" MasterPageFile="~/View/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="UrbanGarden2._0.View.Admin.Dashboard" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <%--comment--%>
    <br /><br /><div class="container-fluid">
        <div class="row" style="height:70px">
            <div class="col-md-2"></div>
            <div class="col-md-8">
                <div class="row">
                    <div class="col-2"></div>
                    <div class="col-1"><img src="../../Asset/Images/flatpack_unlocked-icon.png" alt="no image" style="height:40px;width:40px" class="rounded"/></div>
                    <div class="col-9"><h2 class="text-dark">Store Dashboard</h2></div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
        <div class="row">
            <div class="col-1"></div>
            <div class="col-10">
                <div class="row">
                    <div class="col-md-3 bg-dark features-col" id="features">
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/flatpack_star-icon.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                <br /><h3 class="text-white">Products</h3>
                                <h3 class="text-white" runat="server" id="PNumTb">Num</h3>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-1">
                        
                    </div>
                    <div class="col-md-3 bg-success features-col" id="features">
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/flatpack_stack-icon.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                <br /><h3 class="text-white">Categories</h3>
                                <h3 class="text-white" runat="server" id="CatNumTb">Num</h3>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-1">
                        
                    </div>
                    <div class="col-md-3 bg-danger features-col" id="features">
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/rocket.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                <br /><h3 class="text-white">Finance</h3>
                                <h3 class="text-white" runat="server" id="FinanceTb">Num</h3>
                            </div>
                        </div>
                    </div>
                        
                    <div class="col-md-1">     
                    </div>

                </div>
            </div>
            <div class="col-1"></div>
        </div>
        <div class="row mb-5 mt-5"></div>
        <div class="row">
            <div class="col-1"></div>
            <div class="col-10">
                <div class="row">
                            <div class="col">
                                <div class="mb-2" style="width:255px">
                    <asp:DropDownList ID="SellerCb" class="form-control" runat="server" CausesValidation="True" OnSelectedIndexChanged="SellerCb_SelectedIndexChanged" ></asp:DropDownList>
                </div>
                            </div>
                            <div class="col"></div>
                            <div class="col"></div>
                        </div>
                <div class="row">
                    <div class="col-md-3 bg-dark features-col" id="features">
                        
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/flatpack_star-icon.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                
                                <br /><h4 class="text-white">Category Amount</h4>
                                <%--<h3 class="text-white" runat="server" id="AmountCatTb">Num</h3>--%>
                            </div>
                        </div>
                    </div>

                    <div class="col-md-1">
                        
                    </div>
                    <div class="col-md-3 bg-success features-col" id="features">
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/flatpack_stack-icon.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                <br /><h3 class="text-white">Total Sells</h3>
                                <h3 class="text-white" runat="server" id="TotalTb">Num</h3>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-1">
                        
                    </div>
                    <div class="col-md-3 bg-danger features-col" id="features">
                        <div class="row">
                            <div class="col-md-2"><br /><img src="../../Asset/Images/rocket.png" alt="image missing" style="height:40px;width:40px"/></div>
                            <div class="col-md-10">
                                <br /><h3 class="text-white">Sellers</h3>
                                <h3 class="text-white" runat="server" id="SellNumTb">Num</h3>
                            </div>
                        </div>
                    </div>
                        
                    <div class="col-md-1">
                        
                    </div>

                </div>
            </div>
            <div class="col-1"></div>

        </div>
        
        <div class="row">
            <div class="col-4"></div>
            <div class="col-4">
                <img src="../../Asset/Images/tree-deciduous.png" alt="no image" style="opacity:0.01"/>
            </div>
            <div class="col-4"></div>
            
        </div>
    </div>
</asp:Content>
