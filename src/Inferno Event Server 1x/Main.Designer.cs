namespace Inferno_Event_Server_1x
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
            this.pass = new System.Windows.Forms.TextBox();
            this.zsLabel = new System.Windows.Forms.Label();
            this.userid = new System.Windows.Forms.TextBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.footerLabel = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(140, 124);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(167, 20);
            this.pass.TabIndex = 45;
            this.pass.Text = "ley";
            this.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zsLabel
            // 
            this.zsLabel.AutoSize = true;
            this.zsLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zsLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.zsLabel.Location = new System.Drawing.Point(1, 115);
            this.zsLabel.Name = "zsLabel";
            this.zsLabel.Size = new System.Drawing.Size(133, 33);
            this.zsLabel.TabIndex = 43;
            this.zsLabel.Text = "Password :";
            // 
            // userid
            // 
            this.userid.Location = new System.Drawing.Point(140, 91);
            this.userid.Name = "userid";
            this.userid.Size = new System.Drawing.Size(167, 20);
            this.userid.TabIndex = 42;
            this.userid.Text = "sa";
            this.userid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.msLabel.Location = new System.Drawing.Point(26, 82);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(108, 33);
            this.msLabel.TabIndex = 41;
            this.msLabel.Text = "User ID :";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.Olive;
            this.headLabel.Location = new System.Drawing.Point(20, 9);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(287, 33);
            this.headLabel.TabIndex = 40;
            this.headLabel.Text = "Inferno Event Server 1x";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(169, 160);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(143, 38);
            this.stopButton.TabIndex = 39;
            this.stopButton.Text = "Stop Server";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.StopButtonClick);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Blue;
            this.startButton.Location = new System.Drawing.Point(7, 160);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 37);
            this.startButton.TabIndex = 38;
            this.startButton.Text = "Start Server";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.footerLabel.Location = new System.Drawing.Point(80, 210);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(162, 20);
            this.footerLabel.TabIndex = 37;
            this.footerLabel.Text = "~ Made by Karthik P ~";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.hostLabel.Location = new System.Drawing.Point(34, 49);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(100, 33);
            this.hostLabel.TabIndex = 46;
            this.hostLabel.Text = "Server :";
            // 
            // hostName
            // 
            this.hostName.Location = new System.Drawing.Point(140, 58);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(167, 20);
            this.hostName.TabIndex = 47;
            this.hostName.Text = "localhost";
            this.hostName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 234);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.hostLabel);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.zsLabel);
            this.Controls.Add(this.userid);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.footerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(340, 272);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inferno Event Server 1x";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label zsLabel;
        private System.Windows.Forms.TextBox userid;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Label headLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.TextBox hostName;
    }
}

