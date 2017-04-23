namespace vHostEditor
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtDocumentRoot = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDocRoot = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerAlias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnDir = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDocumentRoot
            // 
            this.txtDocumentRoot.Enabled = false;
            this.txtDocumentRoot.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.txtDocumentRoot.Location = new System.Drawing.Point(210, 62);
            this.txtDocumentRoot.Name = "txtDocumentRoot";
            this.txtDocumentRoot.Size = new System.Drawing.Size(228, 26);
            this.txtDocumentRoot.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label1.Location = new System.Drawing.Point(206, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Document Root";
            // 
            // btnDocRoot
            // 
            this.btnDocRoot.Enabled = false;
            this.btnDocRoot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDocRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocRoot.Location = new System.Drawing.Point(444, 62);
            this.btnDocRoot.Name = "btnDocRoot";
            this.btnDocRoot.Size = new System.Drawing.Size(25, 25);
            this.btnDocRoot.TabIndex = 3;
            this.btnDocRoot.Text = "...";
            this.btnDocRoot.UseVisualStyleBackColor = true;
            this.btnDocRoot.Click += new System.EventHandler(this.btnDocRoot_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Enabled = false;
            this.txtServerName.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.txtServerName.Location = new System.Drawing.Point(210, 112);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(259, 26);
            this.txtServerName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label2.Location = new System.Drawing.Point(206, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label3.Location = new System.Drawing.Point(206, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server Alias";
            // 
            // txtServerAlias
            // 
            this.txtServerAlias.Enabled = false;
            this.txtServerAlias.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.txtServerAlias.Location = new System.Drawing.Point(210, 162);
            this.txtServerAlias.Name = "txtServerAlias";
            this.txtServerAlias.Size = new System.Drawing.Size(259, 26);
            this.txtServerAlias.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label4.Location = new System.Drawing.Point(206, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Directory";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Enabled = false;
            this.txtDirectory.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.txtDirectory.Location = new System.Drawing.Point(210, 212);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(228, 26);
            this.txtDirectory.TabIndex = 8;
            // 
            // btnDir
            // 
            this.btnDir.Enabled = false;
            this.btnDir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDir.Location = new System.Drawing.Point(444, 212);
            this.btnDir.Name = "btnDir";
            this.btnDir.Size = new System.Drawing.Size(25, 25);
            this.btnDir.TabIndex = 10;
            this.btnDir.Text = "...";
            this.btnDir.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(12, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 232);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.listBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressedOnForm);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(210, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(259, 25);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::vHostEditor.Properties.Resources.file_26;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Location = new System.Drawing.Point(105, 7);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(28, 28);
            this.btnNew.TabIndex = 16;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::vHostEditor.Properties.Resources.edit_26;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(139, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(28, 28);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::vHostEditor.Properties.Resources.delete_26;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(172, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(28, 28);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = global::vHostEditor.Properties.Resources.cancel_26;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(441, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(28, 28);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 285);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtServerAlias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.btnDocRoot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDocumentRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 323);
            this.MinimumSize = new System.Drawing.Size(497, 323);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vHost Editor";
            this.Load += new System.EventHandler(this.Load_Event);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressedOnForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDocumentRoot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDocRoot;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerAlias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Button btnDir;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnCancel;
    }
}

