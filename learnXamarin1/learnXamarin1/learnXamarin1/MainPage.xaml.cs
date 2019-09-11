using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using learnXamarin1.Models;
using System.IO;
using static learnXamarin1.PersonRepsitoryCRUD;

namespace learnXamarin1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        void OnNewButtonClicked(Object sender, EventArgs e)
        {
            

            string dbPath = Path.Combine(Environment.GetFolderPath
                (Environment.SpecialFolder.LocalApplicationData), "dbPeople.db");

            PersonRepositoryCRUD personRepo = new PersonRepositoryCRUD(dbPath);
            string name = EntPersonName.Text;

            Person newPerson = new Person();
            newPerson.Name = name;
            personRepo.CreatePerson(newPerson);
            LblStatusMessage.Text = personRepo.StatusMessage;
        }
        void GetAllPeopleClicked(Object sender, EventArgs e)
        {

        }
    }
}
