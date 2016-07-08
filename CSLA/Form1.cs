using BusinessLibrary.Models;
using System;
using System.Windows.Forms;

namespace CSLA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();           
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var emloyeer = GetEmployeerIfValid();
            BusinessLibrary.Csla.EmployeerEdit.NewPersonEdit(emloyeer);
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            var employeer = BusinessLibrary.Csla.EmployeerEdit.GetPersonEdit(Convert.ToInt32(num_Id.Value));

            textBox_FirstName.Text = employeer.FirstName;
            textBox_LastName.Text = employeer.LastName;
            textBox_Email.Text = employeer.Email;                        
        }

        private Employeer GetEmployeerIfValid()
        {
            if (IsValidForm())
            {
                return GetEmployeerFromForm();
            }
            return null;
        }

        private Employeer GetEmployeerFromForm()
        {
            return new Employeer
            {
                FirstName = textBox_FirstName.Text,
                LastName = textBox_LastName.Text,
                Email = textBox_Email.Text
            };
        }

        private bool IsValidForm()
        {
            return 
                   !string.IsNullOrEmpty(textBox_FirstName.Text)
                && !string.IsNullOrEmpty(textBox_LastName.Text)
                && !string.IsNullOrEmpty(textBox_Email.Text);
        }
    }
}
