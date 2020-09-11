namespace TaskMasterTutorial
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskCmdCancel = new System.Windows.Forms.Button();
            this.taskCmdDelete = new System.Windows.Forms.Button();
            this.taskCmdUpdate = new System.Windows.Forms.Button();
            this.taskCmdCreate = new System.Windows.Forms.Button();
            this.taskCboStatus = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTask = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.taskCmdCancel);
            this.groupBox1.Controls.Add(this.taskCmdDelete);
            this.groupBox1.Controls.Add(this.taskCmdUpdate);
            this.groupBox1.Controls.Add(this.taskCmdCreate);
            this.groupBox1.Controls.Add(this.taskCboStatus);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtTask);
            this.groupBox1.Location = new System.Drawing.Point(15, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Due Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Task:";
            // 
            // taskCmdCancel
            // 
            this.taskCmdCancel.Location = new System.Drawing.Point(416, 97);
            this.taskCmdCancel.Name = "taskCmdCancel";
            this.taskCmdCancel.Size = new System.Drawing.Size(75, 23);
            this.taskCmdCancel.TabIndex = 6;
            this.taskCmdCancel.Text = "Cancel";
            this.taskCmdCancel.UseVisualStyleBackColor = true;
            // 
            // taskCmdDelete
            // 
            this.taskCmdDelete.Location = new System.Drawing.Point(257, 97);
            this.taskCmdDelete.Name = "taskCmdDelete";
            this.taskCmdDelete.Size = new System.Drawing.Size(75, 23);
            this.taskCmdDelete.TabIndex = 5;
            this.taskCmdDelete.Text = "Delete";
            this.taskCmdDelete.UseVisualStyleBackColor = true;
            this.taskCmdDelete.Click += new System.EventHandler(this.taskCmdDelete_Click);
            // 
            // taskCmdUpdate
            // 
            this.taskCmdUpdate.Location = new System.Drawing.Point(176, 97);
            this.taskCmdUpdate.Name = "taskCmdUpdate";
            this.taskCmdUpdate.Size = new System.Drawing.Size(75, 23);
            this.taskCmdUpdate.TabIndex = 4;
            this.taskCmdUpdate.Text = "Update";
            this.taskCmdUpdate.UseVisualStyleBackColor = true;
            this.taskCmdUpdate.Click += new System.EventHandler(this.taskCmdUpdate_Click);
            // 
            // taskCmdCreate
            // 
            this.taskCmdCreate.Location = new System.Drawing.Point(95, 97);
            this.taskCmdCreate.Name = "taskCmdCreate";
            this.taskCmdCreate.Size = new System.Drawing.Size(75, 23);
            this.taskCmdCreate.TabIndex = 3;
            this.taskCmdCreate.Text = "Create";
            this.taskCmdCreate.UseVisualStyleBackColor = true;
            this.taskCmdCreate.Click += new System.EventHandler(this.taskCmdCreate_Click);
            // 
            // taskCboStatus
            // 
            this.taskCboStatus.FormattingEnabled = true;
            this.taskCboStatus.Location = new System.Drawing.Point(95, 41);
            this.taskCboStatus.Name = "taskCboStatus";
            this.taskCboStatus.Size = new System.Drawing.Size(157, 21);
            this.taskCboStatus.TabIndex = 2;
            this.taskCboStatus.Text = "Please Select...";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(497, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // txtTask
            // 
            this.txtTask.Location = new System.Drawing.Point(95, 17);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(290, 20);
            this.txtTask.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(763, 430);
            this.MinimumSize = new System.Drawing.Size(597, 269);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Master";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button taskCmdCancel;
        private System.Windows.Forms.Button taskCmdDelete;
        private System.Windows.Forms.Button taskCmdUpdate;
        private System.Windows.Forms.Button taskCmdCreate;
        private System.Windows.Forms.ComboBox taskCboStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtTask;
    }
}

