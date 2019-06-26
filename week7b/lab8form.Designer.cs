namespace week7b
{
    partial class lab8form
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
            this.TitleLable = new System.Windows.Forms.Label();
            this.InfogroupBox = new System.Windows.Forms.GroupBox();
            this.Namelable = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.Agelabel = new System.Windows.Forms.Label();
            this.Submitbutton = new System.Windows.Forms.Button();
            this.InfogroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLable
            // 
            this.TitleLable.AutoSize = true;
            this.TitleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLable.Location = new System.Drawing.Point(12, 26);
            this.TitleLable.Name = "TitleLable";
            this.TitleLable.Size = new System.Drawing.Size(96, 37);
            this.TitleLable.TabIndex = 0;
            this.TitleLable.Text = "lab08";
            // 
            // InfogroupBox
            // 
            this.InfogroupBox.BackColor = System.Drawing.Color.White;
            this.InfogroupBox.Controls.Add(this.AgetextBox);
            this.InfogroupBox.Controls.Add(this.Agelabel);
            this.InfogroupBox.Controls.Add(this.NametextBox);
            this.InfogroupBox.Controls.Add(this.Namelable);
            this.InfogroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InfogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfogroupBox.Location = new System.Drawing.Point(19, 84);
            this.InfogroupBox.Name = "InfogroupBox";
            this.InfogroupBox.Size = new System.Drawing.Size(593, 200);
            this.InfogroupBox.TabIndex = 1;
            this.InfogroupBox.TabStop = false;
            this.InfogroupBox.Text = "Info";
            // 
            // Namelable
            // 
            this.Namelable.AutoSize = true;
            this.Namelable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelable.Location = new System.Drawing.Point(6, 46);
            this.Namelable.Name = "Namelable";
            this.Namelable.Size = new System.Drawing.Size(166, 31);
            this.Namelable.TabIndex = 0;
            this.Namelable.Text = "Enter Name:";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(178, 46);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(391, 38);
            this.NametextBox.TabIndex = 1;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(178, 91);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.Size = new System.Drawing.Size(391, 38);
            this.AgetextBox.TabIndex = 3;
            // 
            // Agelabel
            // 
            this.Agelabel.AutoSize = true;
            this.Agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agelabel.Location = new System.Drawing.Point(30, 91);
            this.Agelabel.Name = "Agelabel";
            this.Agelabel.Size = new System.Drawing.Size(142, 31);
            this.Agelabel.TabIndex = 2;
            this.Agelabel.Text = "Enter Age:";
            // 
            // Submitbutton
            // 
            this.Submitbutton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Submitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submitbutton.Location = new System.Drawing.Point(466, 343);
            this.Submitbutton.Name = "Submitbutton";
            this.Submitbutton.Size = new System.Drawing.Size(122, 43);
            this.Submitbutton.TabIndex = 2;
            this.Submitbutton.Text = "submit";
            this.Submitbutton.UseVisualStyleBackColor = false;
            // 
            // lab8form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.Submitbutton);
            this.Controls.Add(this.InfogroupBox);
            this.Controls.Add(this.TitleLable);
            this.Name = "lab8form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lab";
            this.InfogroupBox.ResumeLayout(false);
            this.InfogroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLable;
        private System.Windows.Forms.GroupBox InfogroupBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label Agelabel;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label Namelable;
        private System.Windows.Forms.Button Submitbutton;
    }
}

