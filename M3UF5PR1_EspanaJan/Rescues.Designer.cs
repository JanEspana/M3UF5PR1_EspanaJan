namespace M3UF5PR1_EspanaJan
{
    partial class Rescues
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
            button2 = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rescueNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rescueDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            animalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            locationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rescueDTOBindingSource = new BindingSource(components);
            groupBox2 = new GroupBox();
            comboBox1 = new ComboBox();
            location = new Label();
            GA = new Label();
            animalID = new Label();
            rescueDate = new Label();
            rescueNum = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorComboBox = new ErrorProvider(components);
            buttonSelect = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rescueDTOBindingSource).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorComboBox).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(377, 378);
            button2.Name = "button2";
            button2.Size = new Size(130, 64);
            button2.TabIndex = 5;
            button2.Text = "GO BACK";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(426, 360);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "ALL RESCUES";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, rescueNumberDataGridViewTextBoxColumn, rescueDateDataGridViewTextBoxColumn, animalDataGridViewTextBoxColumn, gADataGridViewTextBoxColumn, locationDataGridViewTextBoxColumn });
            dataGridView1.DataSource = rescueDTOBindingSource;
            dataGridView1.Location = new Point(6, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(414, 276);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // rescueNumberDataGridViewTextBoxColumn
            // 
            rescueNumberDataGridViewTextBoxColumn.DataPropertyName = "RescueNumber";
            rescueNumberDataGridViewTextBoxColumn.HeaderText = "RescueNumber";
            rescueNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            rescueNumberDataGridViewTextBoxColumn.Name = "rescueNumberDataGridViewTextBoxColumn";
            rescueNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // rescueDateDataGridViewTextBoxColumn
            // 
            rescueDateDataGridViewTextBoxColumn.DataPropertyName = "RescueDate";
            rescueDateDataGridViewTextBoxColumn.HeaderText = "RescueDate";
            rescueDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            rescueDateDataGridViewTextBoxColumn.Name = "rescueDateDataGridViewTextBoxColumn";
            rescueDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // animalDataGridViewTextBoxColumn
            // 
            animalDataGridViewTextBoxColumn.DataPropertyName = "Animal";
            animalDataGridViewTextBoxColumn.HeaderText = "Animal";
            animalDataGridViewTextBoxColumn.MinimumWidth = 6;
            animalDataGridViewTextBoxColumn.Name = "animalDataGridViewTextBoxColumn";
            animalDataGridViewTextBoxColumn.Width = 125;
            // 
            // gADataGridViewTextBoxColumn
            // 
            gADataGridViewTextBoxColumn.DataPropertyName = "GA";
            gADataGridViewTextBoxColumn.HeaderText = "GA";
            gADataGridViewTextBoxColumn.MinimumWidth = 6;
            gADataGridViewTextBoxColumn.Name = "gADataGridViewTextBoxColumn";
            gADataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            locationDataGridViewTextBoxColumn.HeaderText = "Location";
            locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // rescueDTOBindingSource
            // 
            rescueDTOBindingSource.DataSource = typeof(Models.DTOs.RescueDTO);
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonSelect);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Controls.Add(location);
            groupBox2.Controls.Add(GA);
            groupBox2.Controls.Add(animalID);
            groupBox2.Controls.Add(rescueDate);
            groupBox2.Controls.Add(rescueNum);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(454, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 360);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEARCH BY ID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(78, 28);
            comboBox1.TabIndex = 13;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // location
            // 
            location.AutoSize = true;
            location.Location = new Point(185, 274);
            location.Name = "location";
            location.Size = new Size(13, 20);
            location.TabIndex = 12;
            location.Text = " ";
            // 
            // GA
            // 
            GA.AutoSize = true;
            GA.Location = new Point(185, 230);
            GA.Name = "GA";
            GA.Size = new Size(13, 20);
            GA.TabIndex = 11;
            GA.Text = " ";
            // 
            // animalID
            // 
            animalID.AutoSize = true;
            animalID.Location = new Point(185, 190);
            animalID.Name = "animalID";
            animalID.Size = new Size(13, 20);
            animalID.TabIndex = 10;
            animalID.Text = " ";
            // 
            // rescueDate
            // 
            rescueDate.AutoSize = true;
            rescueDate.Location = new Point(185, 154);
            rescueDate.Name = "rescueDate";
            rescueDate.Size = new Size(13, 20);
            rescueDate.TabIndex = 9;
            rescueDate.Text = " ";
            // 
            // rescueNum
            // 
            rescueNum.AutoSize = true;
            rescueNum.Location = new Point(185, 117);
            rescueNum.Name = "rescueNum";
            rescueNum.Size = new Size(13, 20);
            rescueNum.TabIndex = 8;
            rescueNum.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 274);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 6;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 230);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 5;
            label6.Text = "Affectation degree:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 190);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 4;
            label3.Text = "Animal ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 154);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 3;
            label4.Text = "Rescue date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 2;
            label2.Text = "Rescue number:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 78);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // errorComboBox
            // 
            errorComboBox.ContainerControl = this;
            // 
            // buttonSelect
            // 
            buttonSelect.Location = new Point(318, 325);
            buttonSelect.Name = "buttonSelect";
            buttonSelect.Size = new Size(94, 29);
            buttonSelect.TabIndex = 14;
            buttonSelect.Text = "SELECT";
            buttonSelect.UseVisualStyleBackColor = true;
            buttonSelect.Click += buttonSelect_Click;
            // 
            // Rescues
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(887, 454);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Name = "Rescues";
            Text = "Rescues";
            Load += Rescues_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)rescueDTOBindingSource).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorComboBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rescueNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rescueDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private BindingSource rescueDTOBindingSource;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label location;
        private Label GA;
        private Label animalID;
        private Label rescueDate;
        private Label rescueNum;
        private Label label5;
        private Label label6;
        private ErrorProvider errorComboBox;
        private Button buttonSelect;
    }
}