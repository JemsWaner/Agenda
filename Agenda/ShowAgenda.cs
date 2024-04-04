using LayerBusiness;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Agenda
{
    public partial class ShowAgenda : Form
    {
        LayerBusiness.Crud crud;
        List<String> pagesList;
        int indexPage = 0;
        int actualId;
        public ShowAgenda()
        {
            InitializeComponent();
            showDataPages(indexPage);
        }

        private void showDataPages(int index)
        {
            crud = new LayerBusiness.Crud();
            crud.ObtainContact();
            pagesList = crud.getContact(index);

            idLabel.Text = pagesList[0];
            nameLabel.Text = pagesList[1];
            cellphoneLayer.Text = pagesList[2];
            emailLabel.Text = pagesList[3];
            actualId =Convert.ToInt32(pagesList[4]);
        }
        private void ShowAgenda_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void rightArrow_Click(object sender, EventArgs e)
        {

            if (indexPage < Crud.GetContacts().Count)
            {
                indexPage++;
                indexLabel.Text = indexPage.ToString();
                showDataPages(indexPage);
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {

            if (indexPage > 0)
            {
                indexPage--;
                indexLabel.Text = indexPage.ToString();
                showDataPages(indexPage);
            }

        }

        private void editContactButton_Click(object sender, EventArgs e)
        {
            Edition editionWindow = new Edition();
            editionWindow.idSheet = actualId;
            editionWindow.Visible = true;
            this.Visible = false;
        }
    }
}
