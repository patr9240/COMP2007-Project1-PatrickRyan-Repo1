<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="COMP2007_Project1_PatrickRyan._default" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- 
     Default.aspx
     Patrick Ross - Ryan Jameson
     COMP2007-Project1-PatrickRyan
     This is the home page for NorthStar Tracking
    -->
    <bs3:Jumbotron runat="server" ID="Jumbotron1">
        <BodyContent>
            <div class="container">
                <div class="row">
                    <div class="col-md-offset-2 col-md-8">
                        <h3>Games June 12th to June 18th</h3>
                        <a href="GameRegister.aspx" class="btn btn-success btn-sm"><i class="fa fa-plus"></i>Add a Game</a>

                        <asp:GridView ID="GamesGridView" runat="server" CssClass="table table-bordered table-striped table-hover"
                            AutoGenerateColumns="false" DataKeyNames="GameID" OnRowDeleting="GamesGridView_RowDeleting">
                            <Columns>
                                <asp:BoundField DataField="GameID" Visible="false" />
                                <asp:BoundField DataField="GameName" HeaderText="Game Name" Visible="true" />
                                <asp:BoundField DataField="Description" HeaderText="Description" Visible="true" />
                                <asp:BoundField DataField="Runs" HeaderText="Runs" Visible="true" />
                                <asp:BoundField DataField="Spectators" HeaderText="Spectators" Visible="true" />
                                <asp:BoundField DataField="Team1" HeaderText="First Team" Visible="true" />
                                <asp:BoundField DataField="Team2" HeaderText="Second Team" Visible="true" />
                                <asp:BoundField DataField="WinningTeam" HeaderText="Winner" Visible="true" />
                                <asp:BoundField DataField="Created" HeaderText="Current Date" DataFormatString="{0:d}" Visible="true" />

                                <asp:CommandField HeaderText="Delete" DeleteText="<i class='fa fa-trash-o fa-lg'></i> Delete" ShowDeleteButton="true" ButtonType="Link"
                                    ControlStyle-CssClass="btn btn-danger btn-sm" />
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </BodyContent>
    </bs3:Jumbotron>
</asp:Content>
