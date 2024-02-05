namespace DVLD
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managesApplicationTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.adadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.driverToolStripMenuItem,
            this.userToolStripMenuItem,
            this.asadsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managesApplicationTypeToolStripMenuItem});
            this.applicationToolStripMenuItem.Image = global::DVLD.Properties.Resources.Applications_64;
            this.applicationToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(170, 68);
            this.applicationToolStripMenuItem.Text = "Application";
            // 
            // managesApplicationTypeToolStripMenuItem
            // 
            this.managesApplicationTypeToolStripMenuItem.Image = global::DVLD.Properties.Resources.Application_Types_641;
            this.managesApplicationTypeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.managesApplicationTypeToolStripMenuItem.Name = "managesApplicationTypeToolStripMenuItem";
            this.managesApplicationTypeToolStripMenuItem.Size = new System.Drawing.Size(314, 70);
            this.managesApplicationTypeToolStripMenuItem.Text = "Manage Application Type";
            this.managesApplicationTypeToolStripMenuItem.Click += new System.EventHandler(this.managesApplicationTypeToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::DVLD.Properties.Resources.People_64;
            this.peopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(136, 68);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // driverToolStripMenuItem
            // 
            this.driverToolStripMenuItem.Name = "driverToolStripMenuItem";
            this.driverToolStripMenuItem.Size = new System.Drawing.Size(66, 68);
            this.driverToolStripMenuItem.Text = "Driver";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = global::DVLD.Properties.Resources.group_users64;
            this.userToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(126, 68);
            this.userToolStripMenuItem.Text = "Users";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // asadsToolStripMenuItem
            // 
            this.asadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaToolStripMenuItem,
            this.adadToolStripMenuItem,
            this.toolStripSeparator1,
            this.adadToolStripMenuItem1});
            this.asadsToolStripMenuItem.Image = global::DVLD.Properties.Resources.account_settings_64;
            this.asadsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.asadsToolStripMenuItem.Name = "asadsToolStripMenuItem";
            this.asadsToolStripMenuItem.Size = new System.Drawing.Size(211, 68);
            this.asadsToolStripMenuItem.Text = "Account Settings";
            // 
            // adaToolStripMenuItem
            // 
            this.adaToolStripMenuItem.Image = global::DVLD.Properties.Resources.PersonDetails_32;
            this.adaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adaToolStripMenuItem.Name = "adaToolStripMenuItem";
            this.adaToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.adaToolStripMenuItem.Text = "Current User Info";
            this.adaToolStripMenuItem.Click += new System.EventHandler(this.adaToolStripMenuItem_Click);
            // 
            // adadToolStripMenuItem
            // 
            this.adadToolStripMenuItem.Image = global::DVLD.Properties.Resources.padlock32;
            this.adadToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adadToolStripMenuItem.Name = "adadToolStripMenuItem";
            this.adadToolStripMenuItem.Size = new System.Drawing.Size(224, 38);
            this.adadToolStripMenuItem.Text = "Change Password";
            this.adadToolStripMenuItem.Click += new System.EventHandler(this.adadToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // adadToolStripMenuItem1
            // 
            this.adadToolStripMenuItem1.Image = global::DVLD.Properties.Resources.sign_out_32__2;
            this.adadToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.adadToolStripMenuItem1.Name = "adadToolStripMenuItem1";
            this.adadToolStripMenuItem1.Size = new System.Drawing.Size(224, 38);
            this.adadToolStripMenuItem1.Text = "Sign Out";
            this.adadToolStripMenuItem1.Click += new System.EventHandler(this.adadToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 487);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adadToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem adadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managesApplicationTypeToolStripMenuItem;
    }
}

