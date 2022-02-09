<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RDLC-Report.aspx.cs" Inherits="Create_items.RDLC_Report" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Create New Items</title>

    <link href="assets/css/bootstrap.min.css" rel="stylesheet"/>
    <link href="assets/css/font-awesome.min.css" rel="stylesheet"/>
    <link href="assets/css/style.css" rel="stylesheet"/>
    <link href="assets/css/responsive.css" rel="stylesheet"/>
</head>

<body>
    <nav class="navbar navbar-inverse navbar-fixed-top">
      <div class="container">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
          <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
            <span class="sr-only">Toggle navigation</span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
            <span class="icon-bar"></span>
          </button>
          <a class="navbar-brand" href="#">
              <img class="logo" alt="Brand" src="assets/img/logo1.png" />
          </a>
        </div>

        <!-- Collect the nav links, forms, and other content for toggling  <span class="sr-only">(current)</span>-->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
          <ul class="nav navbar-nav">
            <li><a href="#">Home</a></li>
            <li><a href="CreateItems">Create Item</a></li>
            <li class="active"><a href="RDLC-Report">RDLC Report</a></li>
            <li class="dropdown">
              <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">Dropdown <span class="caret"></span></a>
              <ul class="dropdown-menu">
                <li><a href="#">Action</a></li>
                <li><a href="#">Another action</a></li>
                <li role="separator" class="divider"></li>
                <li><a href="#">Separated link</a></li>
                <li role="separator" class="divider"></li>
                <li><a href="#">One more separated link</a></li>
              </ul>
            </li>
          </ul>
          <form class="navbar-form navbar-right">
            <div class="form-group">
              <input type="text" class="form-control" placeholder="Search"/>
            </div>
            <button type="submit" class="btn btn-default">Submit</button>
          </form>
        </div><!-- /.navbar-collapse -->
      </div><!-- /.container-fluid -->
    </nav>

    <div class="section-padding">
            <div class="container">
                <div class="row">
                    <div class="col-md-12">
                        <div class="white-box">
                            <h3 style="padding: 15px; text-align: center; background-color: #9900FF; color: #FFFFFF;">RDLC Report</h3>
                            <div class="contact-form">
                                <form id="contactForm" runat="server">
                                    <asp:scriptmanager runat="server"></asp:scriptmanager>
                                    <div class="col-md-12"><asp:Button ID="btnLoadReport" runat="server" Text="Load Report" OnClick="btnLoadReport_Click" /></div>
                                    <div class="row">
                                        <div class="col-md-12" style="text-align: center;">
                                        <rsweb:ReportViewer ID="RDLCReportView" runat="server" Width="850px" Height="500px"></rsweb:ReportViewer>
                                    </div>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/js/bootstrap.min.js"></script>
    <script src="assets/js/main.js"></script>
</body>
</html>
