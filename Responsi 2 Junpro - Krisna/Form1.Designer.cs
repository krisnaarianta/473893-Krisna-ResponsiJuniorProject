namespace Responsi_2_Junpro___Krisna
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
            tbNama = new TextBox();
            dataGridView1 = new DataGridView();
            btnInsert = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnLoad = new Button();
            cbDep = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 45);
            label1.Name = "label1";
            label1.Size = new Size(58, 30);
            label1.TabIndex = 0;
            label1.Text = "logo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 139);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Karyawan :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 204);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Dep. Karyawan :";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(171, 136);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(277, 23);
            tbNama.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(51, 347);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(664, 150);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(51, 275);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(132, 41);
            btnInsert.TabIndex = 5;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 275);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 41);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(316, 275);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(132, 41);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(316, 525);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(132, 41);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // cbDep
            // 
            cbDep.FormattingEnabled = true;
            cbDep.Location = new Point(171, 201);
            cbDep.Name = "cbDep";
            cbDep.Size = new Size(277, 23);
            cbDep.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 601);
            Controls.Add(cbDep);
            Controls.Add(btnLoad);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(dataGridView1);
            Controls.Add(tbNama);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbNama;
        private DataGridView dataGridView1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnEdit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnLoad;
        private ComboBox cbDep;
    }
}