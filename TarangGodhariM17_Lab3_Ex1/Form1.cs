
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace TarangGodhariM17_Lab3_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private TarangDBEntities dbContext = null;
        private void RefreshContent()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }

            dbContext = new TarangDBEntities();
            dbContext.TarangTBs
                .OrderBy(entry => entry.learnerID)
                .ThenBy(entry => entry.learnerName)
                .Load();

            studentBindingSource.DataSource = dbContext.TarangTBs.Local;
            studentBindingSource.MoveFirst();
            findTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            studentBindingSource.EndEdit();

            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Saved");
            }
           catch (DbEntityValidationException)
            {
                MessageBox.Show("Columns Cannot be Empty.", "Entry Validation Exception");
            }

            RefreshContent();
            
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            var firstNameQuery =
                from student in dbContext.TarangTBs
                where student.learnerName.StartsWith(findTextBox.Text)
                orderby student.learnerName, student.learnerID
                select student;

            studentBindingSource.DataSource = firstNameQuery.ToList();
            studentBindingSource.MoveFirst();

            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void browseAllButton_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            RefreshContent();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Entry Deleted");
                RefreshContent();
            }
            catch (Exception)
            {
                MessageBox.Show("Unable To Delete Entry.");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                dbContext.SaveChanges();
                MessageBox.Show("Entry Updated");
                RefreshContent();
            }catch(Exception)
            {
                MessageBox.Show("Unable To Update Changes.");
            }
        }
    }
}
