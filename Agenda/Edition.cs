using LayerBusiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Agenda
{
    public partial class Edition : Form
    {
        public int idSheet;
        Crud crud;
        Contact contact;
        List<String> pagesList;
        public Edition()
        {
            InitializeComponent();
            crud = new Crud();
           pagesList= crud.getContact(idSheet);
            idTextBox.Text = pagesList[0];
            nameTextBox.Text = pagesList[1];
            phoneTextBox.Text = pagesList[2];
            emailTextBox.Text = pagesList[3];
            idSheet =Convert.ToInt32( pagesList[4]);

        }

        private void Edition_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            crud = new Crud();
            try
            {
                contact = new Contact();
                contact.ID_contacto = idBox.Text;
                contact.Nombre = nameBox.Text;
                contact.Telefono = phoneBox.Text;
                contact.Email = emailBox.Text;
                contact.ID = idSheet;

                crud.UpdateContact(contact);
                MessageBox.Show("Data edited successfully");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowAgenda agendaWindow = new ShowAgenda();
            agendaWindow.Visible = true;
            this.Visible = false;
        }
    }
}
