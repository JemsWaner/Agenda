using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using LayerData;

namespace LayerBusiness
{
    public class Crud
    {
        public Connection conn;
        public static List<Contact> contacts = new List<Contact>();

        public Crud()
        {
            conn = new Connection();
        }

        public void ObtainContact()
        {
            string consult = "SELECT ID_contacto, ID, Nombre, Telefono, Email FROM Contactos";

            using (MySqlCommand command = new MySqlCommand(consult, conn.conn))
            {
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Contact contacto = new Contact
                        {                 
                            ID_contacto= reader.GetString("ID_contacto"),
                            Nombre = reader.GetString("Nombre"),
                            Telefono = reader.GetString("Telefono"),
                            Email = reader.GetString("Email"),
                            ID = reader.GetInt32("ID")
                        };
                        contacts.Add(contacto);
                    }
                }
            }
        }
        public List<String> getContact(int index) {
            List<String> newList = new List<String>();
            Contact searchedIndex= contacts[index];

            newList.Add(searchedIndex.ID_contacto);
            newList.Add(searchedIndex.Nombre);
           newList.Add(searchedIndex.Telefono);
           newList.Add(searchedIndex.Email);
            newList.Add(searchedIndex.ID.ToString());

            return newList;
        }

        public static List<Contact> GetContacts()
        {
            return contacts;
        }

        public void AddContact(Contact contacto)
        {
            string consulta = "INSERT INTO Contactos (ID_contacto, Nombre, Telefono, Email) VALUES (@ID_contacto, @Nombre, @Telefono, @Email)";

            using (MySqlCommand comand = new MySqlCommand(consulta, conn.conn))
            {
                comand.Parameters.AddWithValue("@ID_contacto", contacto.ID_contacto);
                comand.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comand.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                comand.Parameters.AddWithValue("@Email", contacto.Email);
              
                comand.ExecuteNonQuery();
            }
        }

        public void UpdateContact(Contact contacto)
        {
            string consulta = "UPDATE Contactos SET ID_contacto= @ID_contacto, Nombre = @Nombre, Telefono = @Telefono, Email = @Email WHERE ID = @ID";

            using (MySqlCommand comand = new MySqlCommand(consulta, conn.conn))
            {
                comand.Parameters.AddWithValue("@ID_contacto", contacto.ID_contacto);
                comand.Parameters.AddWithValue("@Nombre", contacto.Nombre);
                comand.Parameters.AddWithValue("@Telefono", contacto.Telefono);
                comand.Parameters.AddWithValue("@Email", contacto.Email);
                comand.Parameters.AddWithValue("@ID", contacto.ID);

                comand.ExecuteNonQuery();
            }
        }
    }
}