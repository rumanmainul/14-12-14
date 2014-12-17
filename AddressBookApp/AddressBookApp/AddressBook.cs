using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace AddressBookApp
{
    public partial class AddressBook : Form
    {
        public AddressBook()
        {
            InitializeComponent();
        }
        private string filePath = "E:\\contactinfo.csv";
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string number = numberTextBox.Text;
            string email = emailTextBox.Text;
            if (File.Exists(filePath))
            {

                FileStream aFileStream = new FileStream(filePath, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aContactBook = new List<string>();
                aContactBook.Add(name);
                aContactBook.Add(number);
                aContactBook.Add(email);
                aWriter.WriteRow(aContactBook);
                aFileStream.Close();
            }
            else
            {
                FileStream aFileStream = new FileStream(filePath, FileMode.Append);
                CsvFileWriter aWriter = new CsvFileWriter(aFileStream);
                List<string> aContactBook = new List<string>();
                aContactBook.Add(name);
                aContactBook.Add(number);
                aContactBook.Add(email);
                aWriter.WriteRow(aContactBook);
                aFileStream.Close();
            }

        }

        private void showAllbutton_Click(object sender, EventArgs e)
        {
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aContactbook = new List<string>();
            showAllListView.Items.Clear();
            while (aCsvFileReader.ReadRow(aContactbook))
            {
                string personName = aContactbook[0];
                string perosnNumber = aContactbook[1];
                string personEmail = aContactbook[2];
                showAllListView.Items.Add(personName+" "+perosnNumber+" "+personEmail);
            }
            aFileStream.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text.ToLower();
            string searchByName = SearchTextBox.Text.ToLower();
           
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            CsvFileReader aCsvFileReader = new CsvFileReader(aFileStream);
            List<string> aContactBook = new List<string>();
            showAllListView.Items.Clear();
            if (NameRadioButton.Checked)
            {
                while (aCsvFileReader.ReadRow(aContactBook))
                {
                    
                    string personName = aContactBook[0].ToLower();
                    int i = personName.IndexOf(searchByName);
                    if (i == -1)
                    {
                        
                        continue;
                    }
                    else
                    {
                        showAllListView.Items.Add(personName);
                    }
                    
                }
                aFileStream.Close();
            }
            if (numberRadioButton.Checked)
            {
                while (aCsvFileReader.ReadRow(aContactBook))
                {
                   
                    string personNumber = aContactBook[1];
                    //if (studentRegNo.Contains(searchByName))
                    //{
                    //    showAllListView.Items.Add(studentRegNo); 
                    //}
                    int i = personNumber.IndexOf(searchByName);
                    if (i == -1)
                    {

                        continue;
                    }
                    else
                    {
                        showAllListView.Items.Add(personNumber);
                    }

                }
                aFileStream.Close();
            }
            if (EmailRadioButton.Checked)
            {
                
                while (aCsvFileReader.ReadRow(aContactBook))
                {
                   
                    string personEmail = aContactBook[2];
                    int i = personEmail.IndexOf(searchByName);
                    if (i == -1)
                    {
                        
                        continue;
                    }
                    else
                    {
                        showAllListView.Items.Add(personEmail);
                    }

                }
                aFileStream.Close();
                
            }
           
        }

        private void NameRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
