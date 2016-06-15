﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using COMP2007_Project1_PatrickRyan.Models;
using System.Web.ModelBinding;
using System.Linq.Dynamic;

namespace COMP2007_Project1_PatrickRyan
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if loading page for the first time, populate the grid
            if (!IsPostBack)
            {

                //get the games data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the games from the database
         * </summary>
         * @method GetGames
         * @return {void}
         * */
        protected void GetGames()
        {
            
            //connect to EF
            using (GameTrackerConnection db = new GameTrackerConnection())
            {
                DateTime date1 = new DateTime();
                DateTime date2 = new DateTime();
                date1 = Convert.ToDateTime(TrackingWeekDropDown.SelectedValue);
                date2 = Convert.ToDateTime(TrackingWeekDropDown.Items[TrackingWeekDropDown.SelectedIndex + 1].Value);

                //query the Games table using EF and LINQ
                var Games = (from allGames in db.Games
                             where allGames.Created >= date1.Date
                             && allGames.Created < date2.Date
                             select allGames);

                //bind results to gridview
                GamesGridView.DataSource = Games.AsQueryable().ToList();
                GamesGridView.DataBind();


                TrackingDateLabel.Text = date1.ToString("MMMM dd, yyyy") + " To " + date2.ToString("MMMM dd, yyyy");

            }
        }

        /**
         * <summary>
         * This event handler deletes a game from the databse using EF
         * </summary>
         * @method GamesGridView_RowDeleting
         * @param {object} sender
         * @param {GridViewDeleteEventArgs}
         * @returns {void}
         * */
        protected void GamesGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            //store which row was clicked
            int selectedRow = e.RowIndex;

            //get the selected gamename using the grids datakey collection
            int GameID = Convert.ToInt32(GamesGridView.DataKeys[selectedRow].Values["GameID"]);

            //use ef to find the slected game and delete it
            using (GameTrackerConnection db = new GameTrackerConnection())
            {
                //create object of the game class and store the query string inside of it
                Game deletedGame = (from gameRecords in db.Games
                                                where gameRecords.GameID == GameID
                                                select gameRecords).FirstOrDefault();

                //remove the selected game from the db
                db.Games.Remove(deletedGame);

                //save db changes
                db.SaveChanges();

                //refresh gridview
                this.GetGames();

            }
        }
        protected void TrackingWeekDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //connect to EF
            using (GameTrackerConnection db = new GameTrackerConnection())
            {
                DateTime date1 = new DateTime();
                DateTime date2 = new DateTime();
                date1 = Convert.ToDateTime(TrackingWeekDropDown.SelectedValue);
                date2 = Convert.ToDateTime(TrackingWeekDropDown.Items[TrackingWeekDropDown.SelectedIndex + 1].Value);

                //query the Games table using EF and LINQ
                var Games = (from allGames in db.Games
                             where allGames.Created >= date1.Date
                             && allGames.Created < date2.Date
                             select allGames);
                if (Games != null)
                {
                    //bind results to gridview
                    GamesGridView.DataSource = Games.AsQueryable().ToList();
                    GamesGridView.DataBind();
                }
                else
                {
                    GamesGridView.DataSource = null;
                    GamesGridView.DataBind();
                }
                TrackingDateLabel.Text = date1.ToString("MMMM dd, yyyy") + " To " + date2.ToString("MMMM dd, yyyy");
            }
        }
    }
}