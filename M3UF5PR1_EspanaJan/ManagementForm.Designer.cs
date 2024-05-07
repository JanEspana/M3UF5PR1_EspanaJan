namespace M3UF5PR1_EspanaJan
{
    partial class ManagementForm
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            insertSuperfamily = new ComboBox();
            insertWeight = new TextBox();
            insertSpecies = new TextBox();
            insertName = new TextBox();
            insertId = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            updateId = new ComboBox();
            label11 = new Label();
            updateSuperfamily = new ComboBox();
            label10 = new Label();
            updateWeight = new TextBox();
            label9 = new Label();
            updateSpecies = new TextBox();
            label8 = new Label();
            updateName = new TextBox();
            label7 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            deleteId = new ComboBox();
            label6 = new Label();
            errorName = new ErrorProvider(components);
            errorComboBox = new ErrorProvider(components);
            errorWeight = new ErrorProvider(components);
            button4 = new Button();
            errorSpecies = new ErrorProvider(components);
            errorId = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorComboBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorSpecies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorId).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(insertSuperfamily);
            groupBox1.Controls.Add(insertWeight);
            groupBox1.Controls.Add(insertSpecies);
            groupBox1.Controls.Add(insertName);
            groupBox1.Controls.Add(insertId);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(372, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "INSERT";
            // 
            // button1
            // 
            button1.Location = new Point(111, 363);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 10;
            button1.Text = "INSERT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // insertSuperfamily
            // 
            insertSuperfamily.FormattingEnabled = true;
            insertSuperfamily.Location = new Point(158, 172);
            insertSuperfamily.Name = "insertSuperfamily";
            insertSuperfamily.Size = new Size(125, 28);
            insertSuperfamily.TabIndex = 9;
            // 
            // insertWeight
            // 
            insertWeight.Location = new Point(158, 297);
            insertWeight.Name = "insertWeight";
            insertWeight.Size = new Size(125, 27);
            insertWeight.TabIndex = 8;
            // 
            // insertSpecies
            // 
            insertSpecies.Location = new Point(158, 232);
            insertSpecies.Name = "insertSpecies";
            insertSpecies.Size = new Size(125, 27);
            insertSpecies.TabIndex = 7;
            // 
            // insertName
            // 
            insertName.Location = new Point(158, 112);
            insertName.Name = "insertName";
            insertName.Size = new Size(125, 27);
            insertName.TabIndex = 6;
            // 
            // insertId
            // 
            insertId.AutoSize = true;
            insertId.Location = new Point(158, 55);
            insertId.Name = "insertId";
            insertId.Size = new Size(13, 20);
            insertId.TabIndex = 5;
            insertId.Text = " ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 300);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 4;
            label5.Text = "Weight:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 235);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 3;
            label3.Text = "Species:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 175);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 2;
            label4.Text = "Superfamily:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 115);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 55);
            label1.Name = "label1";
            label1.Size = new Size(27, 20);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(updateId);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(updateSuperfamily);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(updateWeight);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(updateSpecies);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(updateName);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(390, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 294);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "UPDATE";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button3
            // 
            button3.Location = new Point(141, 244);
            button3.Name = "button3";
            button3.Size = new Size(107, 44);
            button3.TabIndex = 20;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // updateId
            // 
            updateId.FormattingEnabled = true;
            updateId.Location = new Point(158, 29);
            updateId.Name = "updateId";
            updateId.Size = new Size(125, 28);
            updateId.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 32);
            label11.Name = "label11";
            label11.Size = new Size(27, 20);
            label11.TabIndex = 11;
            label11.Text = "ID:";
            // 
            // updateSuperfamily
            // 
            updateSuperfamily.FormattingEnabled = true;
            updateSuperfamily.Location = new Point(158, 115);
            updateSuperfamily.Name = "updateSuperfamily";
            updateSuperfamily.Size = new Size(125, 28);
            updateSuperfamily.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 74);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 11;
            label10.Text = "Name:";
            // 
            // updateWeight
            // 
            updateWeight.Location = new Point(158, 199);
            updateWeight.Name = "updateWeight";
            updateWeight.Size = new Size(125, 27);
            updateWeight.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 118);
            label9.Name = "label9";
            label9.Size = new Size(91, 20);
            label9.TabIndex = 12;
            label9.Text = "Superfamily:";
            // 
            // updateSpecies
            // 
            updateSpecies.Location = new Point(158, 157);
            updateSpecies.Name = "updateSpecies";
            updateSpecies.Size = new Size(125, 27);
            updateSpecies.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 160);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 13;
            label8.Text = "Species:";
            // 
            // updateName
            // 
            updateName.Location = new Point(158, 71);
            updateName.Name = "updateName";
            updateName.Size = new Size(125, 27);
            updateName.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 202);
            label7.Name = "label7";
            label7.Size = new Size(59, 20);
            label7.TabIndex = 14;
            label7.Text = "Weight:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(deleteId);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(390, 312);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 126);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "DELETE";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(272, 91);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "DELETE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // deleteId
            // 
            deleteId.FormattingEnabled = true;
            deleteId.Location = new Point(141, 51);
            deleteId.Name = "deleteId";
            deleteId.Size = new Size(107, 28);
            deleteId.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 54);
            label6.Name = "label6";
            label6.Size = new Size(27, 20);
            label6.TabIndex = 0;
            label6.Text = "ID:";
            // 
            // errorName
            // 
            errorName.ContainerControl = this;
            // 
            // errorComboBox
            // 
            errorComboBox.ContainerControl = this;
            // 
            // errorWeight
            // 
            errorWeight.ContainerControl = this;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(325, 453);
            button4.Name = "button4";
            button4.Size = new Size(130, 64);
            button4.TabIndex = 4;
            button4.Text = "GO BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // errorSpecies
            // 
            errorSpecies.ContainerControl = this;
            // 
            // errorId
            // 
            errorId.ContainerControl = this;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 529);
            Controls.Add(button4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ManagementForm";
            Text = "Management";
            Load += ManagementForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorComboBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorSpecies).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorId).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label insertId;
        private Label label5;
        private Button button1;
        private ComboBox insertSuperfamily;
        private TextBox insertWeight;
        private TextBox insertSpecies;
        private TextBox insertName;
        private Button button2;
        private ComboBox deleteId;
        private Label label6;
        private ComboBox updateSuperfamily;
        private Label label10;
        private TextBox updateWeight;
        private Label label9;
        private TextBox updateSpecies;
        private Label label8;
        private TextBox updateName;
        private Label label7;
        private Button button3;
        private ComboBox updateId;
        private Label label11;
        private ErrorProvider errorName;
        private ErrorProvider errorComboBox;
        private ErrorProvider errorWeight;
        private Button button4;
        private ErrorProvider errorSpecies;
        private ErrorProvider errorId;
    }
}