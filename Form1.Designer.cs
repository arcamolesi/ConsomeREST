namespace ConsomeREST
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtNome = new TextBox();
            txtDisciplina = new TextBox();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 9);
            label1.Name = "label1";
            label1.Size = new Size(337, 40);
            label1.TabIndex = 0;
            label1.Text = "Consome API REST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F);
            label2.Location = new Point(260, 61);
            label2.Name = "label2";
            label2.Size = new Size(35, 27);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F);
            label3.Location = new Point(223, 107);
            label3.Name = "label3";
            label3.Size = new Size(72, 27);
            label3.TabIndex = 2;
            label3.Text = "Nome: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F);
            label4.Location = new Point(200, 153);
            label4.Name = "label4";
            label4.Size = new Size(95, 27);
            label4.TabIndex = 3;
            label4.Text = "Disciplina:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F);
            label5.Location = new Point(224, 196);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 4;
            label5.Text = "Nota 1:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F);
            label6.Location = new Point(224, 249);
            label6.Name = "label6";
            label6.Size = new Size(71, 27);
            label6.TabIndex = 5;
            label6.Text = "Nota 2:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial Narrow", 13.8F);
            txtID.Location = new Point(301, 54);
            txtID.Name = "txtID";
            txtID.Size = new Size(125, 34);
            txtID.TabIndex = 6;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Arial Narrow", 13.8F);
            txtNome.Location = new Point(301, 100);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(235, 34);
            txtNome.TabIndex = 7;
            // 
            // txtDisciplina
            // 
            txtDisciplina.Font = new Font("Arial Narrow", 13.8F);
            txtDisciplina.Location = new Point(301, 146);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(235, 34);
            txtDisciplina.TabIndex = 8;
            // 
            // txtNota1
            // 
            txtNota1.Font = new Font("Arial Narrow", 13.8F);
            txtNota1.Location = new Point(305, 193);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(157, 34);
            txtNota1.TabIndex = 9;
            // 
            // txtNota2
            // 
            txtNota2.Font = new Font("Arial Narrow", 13.8F);
            txtNota2.Location = new Point(301, 242);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(157, 34);
            txtNota2.TabIndex = 10;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 13.8F);
            button1.Location = new Point(631, 135);
            button1.Name = "button1";
            button1.Size = new Size(116, 45);
            button1.TabIndex = 11;
            button1.Text = "&Inserir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 13.8F);
            button2.Location = new Point(633, 66);
            button2.Name = "button2";
            button2.Size = new Size(114, 45);
            button2.TabIndex = 12;
            button2.Text = "&Listar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(224, 317);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(637, 188);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1083, 547);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(txtDisciplina);
            Controls.Add(txtNome);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtNome;
        private TextBox txtDisciplina;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
    }
}
