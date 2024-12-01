namespace WinSystem_Info_Tool
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxSystem = new ListBox();
            listBoxNetwork = new ListBox();
            listBoxHardware = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(36, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 348);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Infos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 275);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 2;
            label3.Text = "Hardware Informationen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 162);
            label2.Name = "label2";
            label2.Size = new Size(138, 15);
            label2.TabIndex = 1;
            label2.Text = "Netzwerk Informationen:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 46);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "System Informationen:";
            // 
            // listBoxSystem
            // 
            listBoxSystem.BorderStyle = BorderStyle.None;
            listBoxSystem.FormattingEnabled = true;
            listBoxSystem.ItemHeight = 15;
            listBoxSystem.Location = new Point(349, 85);
            listBoxSystem.Name = "listBoxSystem";
            listBoxSystem.Size = new Size(412, 105);
            listBoxSystem.TabIndex = 1;
            // 
            // listBoxNetwork
            // 
            listBoxNetwork.BorderStyle = BorderStyle.None;
            listBoxNetwork.FormattingEnabled = true;
            listBoxNetwork.ItemHeight = 15;
            listBoxNetwork.Location = new Point(349, 239);
            listBoxNetwork.Name = "listBoxNetwork";
            listBoxNetwork.Size = new Size(412, 60);
            listBoxNetwork.TabIndex = 2;
            // 
            // listBoxHardware
            // 
            listBoxHardware.BorderStyle = BorderStyle.None;
            listBoxHardware.FormattingEnabled = true;
            listBoxHardware.ItemHeight = 15;
            listBoxHardware.Location = new Point(349, 352);
            listBoxHardware.Name = "listBoxHardware";
            listBoxHardware.Size = new Size(412, 60);
            listBoxHardware.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxHardware);
            Controls.Add(listBoxNetwork);
            Controls.Add(listBoxSystem);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "WinSystem-Info";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ListBox listBoxSystem;
        private ListBox listBoxNetwork;
        private ListBox listBoxHardware;
    }
}
