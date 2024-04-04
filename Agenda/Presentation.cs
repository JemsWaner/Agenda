using LayerBusiness;
using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Presentation : Form
    {
        Contact contact;
        Crud crud;
        public Presentation()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowAgenda showAgenda = new ShowAgenda();
            showAgenda.Visible = true;
            this.Visible = false;
        }

        private void addPageButton_Click(object sender, EventArgs e)
        {
            crud = new Crud();
            try
            {
                contact = new Contact();
                contact.ID_contacto = idBox.Text;
                contact.Nombre = nameBox.Text;
                contact.Telefono = phoneBox.Text;
                contact.Email = emailBox.Text;

                crud.AddContact(contact);
                MessageBox.Show("Data sent successfully");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Presentation_Load(object sender, EventArgs e)
        {

        }
    }
}
