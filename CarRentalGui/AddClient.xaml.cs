using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PetAccessoryRentalGui {
    /// <summary>
    /// Logika interakcji dla klasy AddClient.xaml
    /// </summary>
    public partial class AddClient : Page {
        public AddClient() {
            InitializeComponent();
        }
        private void AddNewClient(object sender, EventArgs e) {

            PetAccessoryRentalCore.PetRentalContext
            string name = ClientName.Text;
            string surname = ClientSurname.Text;
            ClientDateofBirth.Text = name;

        }
    }
}
