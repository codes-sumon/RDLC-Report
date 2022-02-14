<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="itemDetails.aspx.cs" Inherits="Create_items.itemDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="assets/css/bootstrap.min.css" rel="stylesheet" />
    <link href="assets/css/font-awesome.min.css" rel="stylesheet" />
    <link href="assets/css/style.css" rel="stylesheet" />
    <link href="assets/css/responsive.css" rel="stylesheet" />
</head>

<body>
    <div class="section-padding">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="white-box">
                        <h3>Create A New Item</h3>
                        <div class="contact-form">

                            <form id="contactForm" runat="server">
                                <div class="row">
                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtItemCode" runat="server" placeholder="Item Code Will Auto Genarate" Enabled="true"></asp:TextBox>
                                    </div>

                                    <div class="col-md-12">
                                        <div class="row">
                                            <div class="col-md-8">
                                                <asp:TextBox ID="txtItemFullName" runat="server" placeholder="Item Full Name"></asp:TextBox>
                                            </div>
                                            <div class="col-md-4">
                                                <asp:Label ID="txtID" runat="server" Text="" Visible="False"></asp:Label>
                                                <asp:Label ID="Label1" runat="server" Text="" Visible="False"></asp:Label>
                                                <asp:RequiredFieldValidator ID="itemName" runat="server" ControlToValidate="txtItemFullName" ErrorMessage="Please Enter The Item Full Name" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="col-md-8">
                                        <asp:TextBox ID="txtItemShortName" runat="server" placeholder="Item Short Name"></asp:TextBox>
                                    </div>
                                </div>
                                <asp:Button ID="btnSubmit" runat="server" Text="Save Item" type="submit" value="Send Message" OnClick="btnSubmit_Click" />
                                <asp:Button ID="btnDelete" runat="server" Text="Delete Item" type="submit" value="Delete Item" OnClick="btnDelete_Click" />
                            </form>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>>

        <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/main.js"></script>
</body>
</html>
