using M3UF5PR1_EspanaJan.Models.DTOs;

namespace M3UF5PR1_EspanaJan
{
    partial class Ranking
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            jobDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            xPDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personBindingSource = new BindingSource(components);
            label1 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, jobDataGridViewTextBoxColumn, xPDataGridViewTextBoxColumn });
            dataGridView1.DataSource = personBindingSource;
            dataGridView1.Location = new Point(12, 146);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(424, 197);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            jobDataGridViewTextBoxColumn.DataPropertyName = "Job";
            jobDataGridViewTextBoxColumn.HeaderText = "Job";
            jobDataGridViewTextBoxColumn.MinimumWidth = 6;
            jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            jobDataGridViewTextBoxColumn.Width = 125;
            // 
            // xPDataGridViewTextBoxColumn
            // 
            xPDataGridViewTextBoxColumn.DataPropertyName = "XP";
            xPDataGridViewTextBoxColumn.HeaderText = "XP";
            xPDataGridViewTextBoxColumn.MinimumWidth = 6;
            xPDataGridViewTextBoxColumn.Name = "xPDataGridViewTextBoxColumn";
            xPDataGridViewTextBoxColumn.Width = 125;
            // 
            // personBindingSource
            // 
            personBindingSource.DataSource = typeof(PersonDTO);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 61);
            label1.Name = "label1";
            label1.Size = new Size(191, 31);
            label1.TabIndex = 1;
            label1.Text = "GAME RANKING";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(163, 349);
            button2.Name = "button2";
            button2.Size = new Size(130, 64);
            button2.TabIndex = 4;
            button2.Text = "GO BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Ranking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 424);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Ranking";
            Text = "Ranking";
            Load += Ranking_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn xPDataGridViewTextBoxColumn;
        private BindingSource personBindingSource;
        private Label label1;
        private Button button2;
    }
}