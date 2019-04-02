using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_Class_Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            //associates text input in forms with the contacts class objects
            Contacts contact = new Contacts();
            contact.Name = nameBox.Text;
            contact.Phone = phoneBox.Text;
            contact.Street = streetBox.Text;
            contact.City = cityBox.Text;
            contact.State = stateBox.Text;
            contact.Zip = zipBox.Text;

            //input goes to database with portal object when save button clicked
            Portal portal = new Portal();
            portal.Save(contact);

            MessageBox.Show("Contact information has been saved");

            nameBox.Text = "";
            phoneBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            zipBox.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void viewButt_Click(object sender, EventArgs e)
        {
            Contacts contact = new Contacts();
            Portal portal = new Portal();
            portal.Get(nameBox.Text);
            nameBox.Text = contact.Name.ToString();
            phoneBox.Text = contact.Phone.ToString();
            streetBox.Text = contact.Street.ToString();
            cityBox.Text = contact.City.ToString();
            stateBox.Text = contact.State.ToString();
            zipBox.Text = contact.Zip.ToString();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Contacts contact = new Contacts();
            contact.Name = nameBox.Text;
            contact.Phone = phoneBox.Text;
            contact.Street = streetBox.Text;
            contact.City = cityBox.Text;
            contact.State = stateBox.Text;
            contact.Zip = zipBox.Text;

            Portal portal = new Portal();
            portal.Update(contact);

            MessageBox.Show("Contact information has been updated");

            nameBox.Text = "";
            phoneBox.Text = "";
            streetBox.Text = "";
            cityBox.Text = "";
            stateBox.Text = "";
            zipBox.Text = "";
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Contacts contact = new Contacts();
            contact.Name = nameBox.Text;

            Portal portal = new Portal();
            portal.Delete(contact);
            MessageBox.Show("Contact has been deleted.");
        }
    }
}
