using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskMasterTutorial.Model;

namespace TaskMasterTutorial
{
    public partial class Form1 : Form
    {
        private TmDBContext tmContext;

        public Form1()
        {
            InitializeComponent();

            tmContext = new TmDBContext();

            var statuses = tmContext.Statuses.ToList();

            //taskCboStatus.Items.Insert(0, "Please Select...");
            foreach (Status s in statuses)
            {
                taskCboStatus.Items.Add(s);
            }
            RefreshData();

        }

        private void RefreshData()
        {
            BindingSource bi = new BindingSource();

            var query = from t in tmContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };

            bi.DataSource = query.ToList();

            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }

        private void taskCmdCreate_Click(object sender, EventArgs e)
        {
            if ((taskCboStatus.SelectedItem != null ) 
                && txtTask.Text != String.Empty)
            {
                var newTask = new Model.Task()
                {
                    Name = txtTask.Text,
                    StatusId = (taskCboStatus.SelectedItem as Model.Status).Id,
                    //StatusId = taskCboStatus.SelectedIndex,
                    DueDate = dateTimePicker1.Value
                };

                tmContext.Tasks.Add(newTask);

                tmContext.SaveChanges();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please make sure all data has been entered");
            }
        }

        private void taskCmdDelete_Click(object sender, EventArgs e)
        {
            var t = tmContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

            tmContext.Tasks.Remove(t);
            tmContext.SaveChanges();

            RefreshData();
        }

        private void taskCmdUpdate_Click(object sender, EventArgs e)
        {
            if(taskCmdUpdate.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach (Status s in taskCboStatus.Items)
                {
                    if(s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        taskCboStatus.SelectedItem = s;
                    }
                }
               taskCmdUpdate.Text = "Save";
                
            }
            else if (taskCmdUpdate.Text == "Save")
            {
               var t = tmContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

                t.Name = txtTask.Text;
                t.StatusId = (taskCboStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.Value;

                tmContext.SaveChanges();
                RefreshData();

                taskCmdUpdate.Text = "Update";
                txtTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                taskCboStatus.Text = "Please Select...";
            }

        }

        private void txtTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
