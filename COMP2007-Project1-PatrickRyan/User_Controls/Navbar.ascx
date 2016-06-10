<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Navbar.ascx.cs" Inherits="COMP2007_Project1_PatrickRyan.Navbar" %>
<!-- 
     Navbar.acsx
     Patrick Ross - Ryan Jameson
     COMP2007-Project1-PatrickRyan
     This is the Navbar user control
    -->
<nav class="navbar navbar-inverse" role="navigation">
    <div class="container-fluid">
        <!-- Brand and toggle get grouped for better mobile display -->
        <div class="navbar-header">
            <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>

            <a class="navbar-brand" href="Default.aspx">
                <img src='/Assets/android-chrome-48x48.png' class="pull-left" alt="NorthStar Logo"></a>
            <a class="pull-left" href="Default.aspx">
                <h3>NorthStar Game Tracking</h3>
            </a>

        </div>
        <!-- Collect the nav links, forms, and other content for toggling -->
        <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
            <ul class="nav navbar-nav navbar-right">
                <li id="home" runat="server"><a class="navbar-brand" href="Default.aspx"><i class="fa fa-home fa-lg"></i>Home</a></li>
                <li id="gameregister" runat="server"><a class="navbar-brand" href="GameRegister.aspx"><i class="fa fa-leanpub fa-lg"></i>Game Register</a></li>
                <li id="register" runat="server"><a class="navbar-brand" href="Register.aspx"><i class="fa fa-reddit-alien fa-lg"></i>Register</a></li>
                <li id="login" runat="server"><a class="navbar-brand" href="Login.aspx"><i class="fa fa-sign-in fa-lg"></i>Login</a></li>
                <li id="about" runat="server"><a class="navbar-brand" href="About.aspx"><i class="fa fa-user-secret fa-lg"></i>About</a></li>
                <li id="contact" runat="server"><a class="navbar-brand" href="Contact.aspx"><i class="fa fa-envelope fa-lg"></i>Contact</a></li>
            </ul>
        </div>
        <!-- /.navbar-collapse -->
    </div>
    <!-- /.container-fluid -->
</nav>
