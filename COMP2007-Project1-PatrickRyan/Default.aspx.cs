using System;
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

                //get the Department data
                this.GetGames();
            }
        }

        /**
         * <summary>
         * This method gets the gamesa from the database
         * </summary>
         * @method GetGames
         * @return {void}
         * */
        protected void GetGames()
        {
            //connect to EF
            using (GameTrackerConnection db = new GameTrackerConnection())
            {
                //query the Games table using EF and LINQ
                var Games = (from allGames in db.Games select allGames);

                //bind results to gridview
                GamesGridView.DataSource = Games.AsQueryable().ToList();
                GamesGridView.DataBind();
            }
        }
    }
}