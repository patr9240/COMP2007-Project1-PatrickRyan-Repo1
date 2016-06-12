using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP2007_Project1_PatrickRyan.Models;
using System.Web.ModelBinding;
namespace COMP2007_Project1_PatrickRyan
{
    public partial class GameRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {

        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            // Use EF to connect to the server
            using (GameTrackerConnection db = new GameTrackerConnection())
            {
                // use the Games model to create a new Game object and save a new record
                Game newGame = new Game();

                int DepartmentID = 0;

                // add form data to the new games record
                newGame.GameName = GameNameTextBox.Text;
                newGame.Description = DescriptionTextBox.Text;
                newGame.Runs = Convert.ToInt32(RunsTextBox.Text);
                newGame.Spectators = Convert.ToInt32(SpectatorsTextBox.Text);
                newGame.Team1 = Team1TextBox.Text;
                newGame.Team2 = Team2TextBox.Text;
                newGame.WinningTeam = WinningTeamTextBox.Text;
                newGame.Created = DateTime.UtcNow.Date;// dateTime.ToString("dd/MM/yyyy")

                // use LINQ to ADO.NET to add / insert new department into the database

                if (DepartmentID == 0)
                {
                    db.Games.Add(newGame);
                }


                // save our changes - also updates and inserts
                db.SaveChanges();

                // Redirect back to the updated departments page
                Response.Redirect("~/Default.aspx");
            }
        }
    }
}