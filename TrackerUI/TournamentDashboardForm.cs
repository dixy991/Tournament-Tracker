using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibraryOrg;
using TrackerLibraryOrg.Models;

namespace TrackerUI
{
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournamentAll();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            WireUpLists();
        }

        public void WireUpLists()
        {
            loadExistingTournamentDropDown.DataSource = tournaments;
            loadExistingTournamentDropDown.DisplayMember = "TournamentName";
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm tmForm = new CreateTournamentForm();
            tmForm.Show();
        }

        private void loadExistingTournamentButton_Click(object sender, EventArgs e)
        {
            TournamentModel tournament = (TournamentModel)loadExistingTournamentDropDown.SelectedItem;
            TournamentViewForm tvForm = new TournamentViewForm(tournament);
            tvForm.Show();
        }

        //ostalo textconnector + proba + 22
    }
}
