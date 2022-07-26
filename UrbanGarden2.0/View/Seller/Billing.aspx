<%@ Page Title="Billing" Language="C#" MasterPageFile="~/View/Seller/SellerMaster.Master" AutoEventWireup="true" CodeBehind="Billing.aspx.cs" Inherits="UrbanGarden2._0.View.Seller.Billing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function PrintPanel() {
            var Pgrid() = document.getElementById('<%=BillGV.ClientID %>');
            Pgrid.border = 0;
            var Pwin = window.open('', 'PrintGrid', 'left=100,top=100,width=1024,height=768,tollbar=0,scrollbars=1,status=0,resizable=1');
            Pwin.document.write(Pgrid.outerHTML);
            Pwin.document.close();
            Pwin.focus();
            Pwin.print();
            Pwin.close();
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Mybody" runat="server">
    <div class="container-fluid">
         <div class="row">
            <div class="col-md-5 ">
                <div class="row">
                    <div class="col">
                        <br />
                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Product Name</label>
                        <input type="text" class="form-control" id="PNameTb" runat="server" required="required">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Product Price</label>
                        <input type="text" class="form-control" id="PrPriceTb" runat="server" required="required">
                        </div>

                        <div class="mb-3">
                        <label for="exampleInputEmail1" class="form-label">Product Qty</label>
                        <input type="text" class="form-control" id="PrQtyTb" runat="server" required="required">
                        </div>
                    </div>
                    <div class="col">
                        <%--<br /><img src="../../Asset/Images/hand_holding_seedling.png" alt="error showing image" style="position:relative;z-index:10;width: 30%;height: 30%;border-radius: 90px" />--%>
                        <br /><br /><br /><br /><br /><label id="ErrMsg" runat="server" class="text-danger"></label>
                        <br /><br />

                        <asp:Button text="   Add to Bill   " class="btn btn-success" runat="server" ID="AddtoBillBtn" OnClick="AddtoBillBtn_Click"/>
                        <%--<asp:Button text="      Reset      " class="btn btn-success" runat="server" ID="ResetBtn"/>--%>
                        
                    </div>
                </div>
                
                <div class="row">
                    <div class="col">
                        <asp:GridView runat="server" class="table table-hover" ID="ProductGV" AutoGenerateSelectButton="True" OnSelectedIndexChanged="ProductGV_SelectedIndexChanged" >

                        </asp:GridView>
                    </div>
                </div>
            </div>
            
            <div class="col-md-7 ">
                <div class="row">
                    <div class="col-3"></div>
                    <div class="col"><h1 class="pl-2">Billing</h1></div>


                    
                </div>
                <div class="row">
                    <asp:GridView ID="BillGV" runat="server" class="table" >

                    </asp:GridView>
                </div>
                <div class="row">
                    <div class="col"></div>
                    <div class="col"><h3 id ="GrdTotTb" class="text-dark" runat="server"></h3></div>
                    <div class="col d-grid"><asp:Button text=" Print Bill " class="btn btn-dark btn-block" runat="server" ID="PrintBtn" OnClientClick="PrintPanel()" OnClick="PrintBtn_Click"/></div>
                </div>
            </div>
            
         </div>
    </div>
</asp:Content>
