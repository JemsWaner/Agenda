namespace Agenda
{
    partial class ShowAgenda
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorIndexLabel = new System.Windows.Forms.Label();
            this.indexLabel = new System.Windows.Forms.Label();
            this.leftArrow = new System.Windows.Forms.Button();
            this.rightArrow = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneLayer = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editContactButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editContactButton);
            this.panel1.Controls.Add(this.errorIndexLabel);
            this.panel1.Controls.Add(this.indexLabel);
            this.panel1.Controls.Add(this.leftArrow);
            this.panel1.Controls.Add(this.rightArrow);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.cellphoneLayer);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 375);
            this.panel1.TabIndex = 0;
            // 
            // errorIndexLabel
            // 
            this.errorIndexLabel.AutoSize = true;
            this.errorIndexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorIndexLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorIndexLabel.Location = new System.Drawing.Point(214, 350);
            this.errorIndexLabel.Name = "errorIndexLabel";
            this.errorIndexLabel.Size = new System.Drawing.Size(50, 16);
            this.errorIndexLabel.TabIndex = 12;
            this.errorIndexLabel.Text = "label5";
            this.errorIndexLabel.Visible = false;
            // 
            // indexLabel
            // 
            this.indexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indexLabel.Location = new System.Drawing.Point(225, 311);
            this.indexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.indexLabel.Name = "indexLabel";
            this.indexLabel.Size = new System.Drawing.Size(39, 24);
            this.indexLabel.TabIndex = 11;
            this.indexLabel.Text = "0";
            this.indexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // leftArrow
            // 
            this.leftArrow.Location = new System.Drawing.Point(152, 304);
            this.leftArrow.Margin = new System.Windows.Forms.Padding(2);
            this.leftArrow.Name = "leftArrow";
            this.leftArrow.Size = new System.Drawing.Size(58, 31);
            this.leftArrow.TabIndex = 10;
            this.leftArrow.Text = "<";
            this.leftArrow.UseVisualStyleBackColor = true;
            this.leftArrow.Click += new System.EventHandler(this.leftArrow_Click);
            // 
            // rightArrow
            // 
            this.rightArrow.Location = new System.Drawing.Point(279, 304);
            this.rightArrow.Margin = new System.Windows.Forms.Padding(2);
            this.rightArrow.Name = "rightArrow";
            this.rightArrow.Size = new System.Drawing.Size(58, 31);
            this.rightArrow.TabIndex = 9;
            this.rightArrow.Text = ">";
            this.rightArrow.UseVisualStyleBackColor = true;
            this.rightArrow.Click += new System.EventHandler(this.rightArrow_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Location = new System.Drawing.Point(66, 249);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(349, 32);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cellphoneLayer
            // 
            this.cellphoneLayer.Location = new System.Drawing.Point(66, 182);
            this.cellphoneLayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cellphoneLayer.Name = "cellphoneLayer";
            this.cellphoneLayer.Size = new System.Drawing.Size(349, 32);
            this.cellphoneLayer.TabIndex = 7;
            this.cellphoneLayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            this.nameLabel.Location = new System.Drawing.Point(59, 112);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(349, 32);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // idLabel
            // 
            this.idLabel.Location = new System.Drawing.Point(66, 45);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(349, 32);
            this.idLabel.TabIndex = 5;
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 222);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cellphone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // editContactButton
            // 
            this.editContactButton.BackColor = System.Drawing.Color.YellowGreen;
            this.editContactButton.Location = new System.Drawing.Point(380, 304);
            this.editContactButton.Name = "editContactButton";
            this.editContactButton.Size = new System.Drawing.Size(85, 31);
            this.editContactButton.TabIndex = 13;
            this.editContactButton.Text = "Edit Contact";
            this.editContactButton.UseVisualStyleBackColor = false;
            this.editContactButton.Click += new System.EventHandler(this.editContactButton_Click);
            // 
            // ShowAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 375);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowAgenda";
            this.Text = "ShowAgenda";
            this.Load += new System.EventHandler(this.ShowAgenda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label cellphoneLayer;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Button leftArrow;
        private System.Windows.Forms.Button rightArrow;
        private System.Windows.Forms.Label indexLabel;
        private System.Windows.Forms.Label errorIndexLabel;
        private System.Windows.Forms.Button editContactButton;
    }
}