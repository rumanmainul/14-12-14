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

namespace EmployeeSalaryApp
{
    public partial class EmployeeSalUI : Form
    {
        public EmployeeSalUI()
        {
            InitializeComponent();
        }

        int totalSalary = 0;
        int salary = 0;
        private string filePath = "E:\\Employee_Sal.txt";
        int employeeSalaryAmount = 0;
        private void saveDataButton_Click(object sender, EventArgs e)
        {
            string employeeName = employeeNameTextBox.Text;
            string employeeId = employeeIdTextBox.Text;
            string employeeSalary = salaryAmountTextBox.Text;
            FileStream aFileStream = new FileStream(filePath, FileMode.Append);
            StreamWriter aStreamWriter = new StreamWriter(aFileStream);
            aStreamWriter.Write(employeeName +";"+employeeId+";"+employeeSalary);
            aStreamWriter.WriteLine();
            aStreamWriter.Close();
            aFileStream.Close();
        }
        
        private void showAllButton_Click(object sender, EventArgs e)
        {
            
            FileStream aFileStream = new FileStream(filePath, FileMode.Open);
            StreamReader aStreamReader = new StreamReader(aFileStream);
            
            showListBox.Items.Clear();
            while (!aStreamReader.EndOfStream)
            {
                string employeeInfo = aStreamReader.ReadLine();
                showListBox.Items.Add(employeeInfo);
                string[] wordStrings = employeeInfo.Split(';');
                salary = Convert.ToInt32(wordStrings[2]);
                //MessageBox.Show(wordStrings[2]);
                employeeSalaryAmount = TotalAmountSum(salary);
                totalAmountTextBox.Text = employeeSalaryAmount.ToString();
            }
            showAllButton.Enabled = false;
            aStreamReader.Close();
            aFileStream.Close();
        }

        private int TotalAmountSum(int salary)
        {
            totalSalary = totalSalary + salary;
            return totalSalary;
        }
    }
}
