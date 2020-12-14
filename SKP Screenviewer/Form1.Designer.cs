namespace SKP_Screenviewer
{
    partial class SKPScreenViewer
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
            this.components = new System.ComponentModel.Container();
            this.connect = new System.Windows.Forms.Button();
            this.share = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.GroupBox();
            this.conId = new WindowsFormsApp4.TextBoxExControl();
            this.port = new WindowsFormsApp4.TextBoxExControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TeamViewer = new System.Windows.Forms.Label();
            this.waitText = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.connect.FlatAppearance.BorderSize = 3;
            this.connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect.ForeColor = System.Drawing.Color.Gainsboro;
            this.connect.Location = new System.Drawing.Point(3, 362);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(208, 30);
            this.connect.TabIndex = 0;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.ConnectionClickEvent);
            // 
            // share
            // 
            this.share.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.share.FlatAppearance.BorderSize = 3;
            this.share.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.share.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.share.ForeColor = System.Drawing.Color.Gainsboro;
            this.share.Location = new System.Drawing.Point(3, 392);
            this.share.Name = "share";
            this.share.Size = new System.Drawing.Size(208, 29);
            this.share.TabIndex = 1;
            this.share.Text = "Share Screen";
            this.share.UseVisualStyleBackColor = true;
            this.share.Click += new System.EventHandler(this.ShareScreenClickEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(7, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection String";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port Number";
            // 
            // SidePanel
            // 
            this.SidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.SidePanel.Controls.Add(this.conId);
            this.SidePanel.Controls.Add(this.port);
            this.SidePanel.Controls.Add(this.connect);
            this.SidePanel.Controls.Add(this.share);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.label1);
            this.SidePanel.Location = new System.Drawing.Point(-3, 69);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(214, 424);
            this.SidePanel.TabIndex = 6;
            this.SidePanel.TabStop = false;
            // 
            // conId
            // 
            this.conId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.conId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conId.ForeColor = System.Drawing.Color.Gainsboro;
            this.conId.Location = new System.Drawing.Point(6, 170);
            this.conId.Multiline = true;
            this.conId.Name = "conId";
            this.conId.Placeholder = "";
            this.conId.Size = new System.Drawing.Size(202, 37);
            this.conId.TabIndex = 7;
            // 
            // port
            // 
            this.port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.port.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port.ForeColor = System.Drawing.Color.Gainsboro;
            this.port.Location = new System.Drawing.Point(6, 97);
            this.port.Name = "port";
            this.port.Placeholder = "";
            this.port.Size = new System.Drawing.Size(202, 22);
            this.port.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.TeamViewer);
            this.panel1.Location = new System.Drawing.Point(-6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 76);
            this.panel1.TabIndex = 7;
            // 
            // TeamViewer
            // 
            this.TeamViewer.AutoSize = true;
            this.TeamViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamViewer.ForeColor = System.Drawing.Color.Gainsboro;
            this.TeamViewer.Location = new System.Drawing.Point(49, 25);
            this.TeamViewer.Name = "TeamViewer";
            this.TeamViewer.Size = new System.Drawing.Size(120, 24);
            this.TeamViewer.TabIndex = 0;
            this.TeamViewer.Text = "SKP Viewer";
            // 
            // waitText
            // 
            this.waitText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.waitText.AutoSize = true;
            this.waitText.BackColor = System.Drawing.Color.Silver;
            this.waitText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.waitText.Location = new System.Drawing.Point(396, 239);
            this.waitText.Name = "waitText";
            this.waitText.Size = new System.Drawing.Size(365, 37);
            this.waitText.TabIndex = 8;
            this.waitText.Text = "Waiting for Connection";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Location = new System.Drawing.Point(211, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 417);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 76);
            this.panel2.TabIndex = 10;
            // 
            // SKPScreenViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(929, 492);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.waitText);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SKPScreenViewer";
            this.Text = "SKPScreenViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button share;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox SidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label TeamViewer;
        private System.Windows.Forms.Label waitText;
        private WindowsFormsApp4.TextBoxExControl port;
        private WindowsFormsApp4.TextBoxExControl conId;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

