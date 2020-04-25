namespace SimpleLinkedList
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
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnEmptyList = new System.Windows.Forms.Button();
            this.btnItsEmpty = new System.Windows.Forms.Button();
            this.btnSearchList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.ItemHeight = 17;
            this.lstStudent.Location = new System.Drawing.Point(12, 12);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(148, 276);
            this.lstStudent.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(309, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(124, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(193, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(309, 67);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(124, 23);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnEmptyList
            // 
            this.btnEmptyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmptyList.Location = new System.Drawing.Point(309, 96);
            this.btnEmptyList.Name = "btnEmptyList";
            this.btnEmptyList.Size = new System.Drawing.Size(124, 23);
            this.btnEmptyList.TabIndex = 6;
            this.btnEmptyList.Text = "Empty list";
            this.btnEmptyList.UseVisualStyleBackColor = true;
            this.btnEmptyList.Click += new System.EventHandler(this.btnEmptyList_Click);
            // 
            // btnItsEmpty
            // 
            this.btnItsEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItsEmpty.Location = new System.Drawing.Point(309, 125);
            this.btnItsEmpty.Name = "btnItsEmpty";
            this.btnItsEmpty.Size = new System.Drawing.Size(124, 23);
            this.btnItsEmpty.TabIndex = 7;
            this.btnItsEmpty.Text = "It\'s empty?";
            this.btnItsEmpty.UseVisualStyleBackColor = true;
            this.btnItsEmpty.Click += new System.EventHandler(this.btnItsEmpty_Click);
            // 
            // btnSearchList
            // 
            this.btnSearchList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchList.Location = new System.Drawing.Point(309, 154);
            this.btnSearchList.Name = "btnSearchList";
            this.btnSearchList.Size = new System.Drawing.Size(124, 23);
            this.btnSearchList.TabIndex = 8;
            this.btnSearchList.Text = "Search node";
            this.btnSearchList.UseVisualStyleBackColor = true;
            this.btnSearchList.Click += new System.EventHandler(this.btnSearchList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 296);
            this.Controls.Add(this.btnSearchList);
            this.Controls.Add(this.btnItsEmpty);
            this.Controls.Add(this.btnEmptyList);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstStudent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple Listed Link";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnEmptyList;
        private System.Windows.Forms.Button btnItsEmpty;
        private System.Windows.Forms.Button btnSearchList;
    }
}

