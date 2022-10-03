namespace Kq1DosboxTas.GUI
{
    partial class KQ1TasPanel
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
            this.buttonSend7 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend8 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend9 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend4 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend6 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend1 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend2 = new Kq1DosboxTas.GUI.TasButton();
            this.buttonSend3 = new Kq1DosboxTas.GUI.TasButton();
            this.labelGameInfo = new System.Windows.Forms.Label();
            this.tasButton1 = new Kq1DosboxTas.GUI.TasButton();
            this.SuspendLayout();
            // 
            // buttonSend7
            // 
            this.buttonSend7.Location = new System.Drawing.Point(31, 25);
            this.buttonSend7.Name = "buttonSend7";
            this.buttonSend7.Size = new System.Drawing.Size(30, 30);
            this.buttonSend7.TabIndex = 30;
            this.buttonSend7.Text = "7";
            this.buttonSend7.UseVisualStyleBackColor = true;
            this.buttonSend7.Click += new System.EventHandler(this.sendKey7);
            // 
            // buttonSend8
            // 
            this.buttonSend8.Location = new System.Drawing.Point(61, 25);
            this.buttonSend8.Name = "buttonSend8";
            this.buttonSend8.Size = new System.Drawing.Size(30, 30);
            this.buttonSend8.TabIndex = 27;
            this.buttonSend8.Text = "8";
            this.buttonSend8.UseVisualStyleBackColor = true;
            this.buttonSend8.Click += new System.EventHandler(this.sendKey8);
            // 
            // buttonSend9
            // 
            this.buttonSend9.Location = new System.Drawing.Point(91, 25);
            this.buttonSend9.Name = "buttonSend9";
            this.buttonSend9.Size = new System.Drawing.Size(30, 30);
            this.buttonSend9.TabIndex = 32;
            this.buttonSend9.Text = "9";
            this.buttonSend9.UseVisualStyleBackColor = true;
            this.buttonSend9.Click += new System.EventHandler(this.sendKey9);
            // 
            // buttonSend4
            // 
            this.buttonSend4.Location = new System.Drawing.Point(31, 54);
            this.buttonSend4.Name = "buttonSend4";
            this.buttonSend4.Size = new System.Drawing.Size(30, 30);
            this.buttonSend4.TabIndex = 26;
            this.buttonSend4.Text = "4";
            this.buttonSend4.UseVisualStyleBackColor = true;
            this.buttonSend4.Click += new System.EventHandler(this.sendKey4);
            // 
            // buttonSend6
            // 
            this.buttonSend6.Location = new System.Drawing.Point(91, 54);
            this.buttonSend6.Name = "buttonSend6";
            this.buttonSend6.Size = new System.Drawing.Size(30, 30);
            this.buttonSend6.TabIndex = 29;
            this.buttonSend6.Text = "6";
            this.buttonSend6.UseVisualStyleBackColor = true;
            this.buttonSend6.Click += new System.EventHandler(this.sendKey6);
            // 
            // buttonSend1
            // 
            this.buttonSend1.Location = new System.Drawing.Point(31, 84);
            this.buttonSend1.Name = "buttonSend1";
            this.buttonSend1.Size = new System.Drawing.Size(30, 30);
            this.buttonSend1.TabIndex = 31;
            this.buttonSend1.Text = "1";
            this.buttonSend1.UseVisualStyleBackColor = true;
            this.buttonSend1.Click += new System.EventHandler(this.sendKey1);
            // 
            // buttonSend2
            // 
            this.buttonSend2.Location = new System.Drawing.Point(61, 84);
            this.buttonSend2.Name = "buttonSend2";
            this.buttonSend2.Size = new System.Drawing.Size(30, 30);
            this.buttonSend2.TabIndex = 28;
            this.buttonSend2.Text = "2";
            this.buttonSend2.UseVisualStyleBackColor = true;
            this.buttonSend2.Click += new System.EventHandler(this.sendKey2);
            // 
            // buttonSend3
            // 
            this.buttonSend3.Location = new System.Drawing.Point(91, 84);
            this.buttonSend3.Name = "buttonSend3";
            this.buttonSend3.Size = new System.Drawing.Size(30, 30);
            this.buttonSend3.TabIndex = 33;
            this.buttonSend3.Text = "3";
            this.buttonSend3.UseVisualStyleBackColor = true;
            this.buttonSend3.Click += new System.EventHandler(this.sendKey3);
            // 
            // labelGameInfo
            // 
            this.labelGameInfo.AutoSize = true;
            this.labelGameInfo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGameInfo.Location = new System.Drawing.Point(157, 25);
            this.labelGameInfo.Name = "labelGameInfo";
            this.labelGameInfo.Size = new System.Drawing.Size(105, 15);
            this.labelGameInfo.TabIndex = 34;
            this.labelGameInfo.Text = "room-nr      1";
            // 
            // tasButton1
            // 
            this.tasButton1.Location = new System.Drawing.Point(332, 25);
            this.tasButton1.Name = "tasButton1";
            this.tasButton1.Size = new System.Drawing.Size(145, 30);
            this.tasButton1.TabIndex = 35;
            this.tasButton1.Text = "change-dosbox-cycles";
            this.tasButton1.UseVisualStyleBackColor = true;
            this.tasButton1.Click += new System.EventHandler(this.buttonChangeDosboxCycles);
            // 
            // KQ1TasPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tasButton1);
            this.Controls.Add(this.labelGameInfo);
            this.Controls.Add(this.buttonSend7);
            this.Controls.Add(this.buttonSend8);
            this.Controls.Add(this.buttonSend9);
            this.Controls.Add(this.buttonSend4);
            this.Controls.Add(this.buttonSend6);
            this.Controls.Add(this.buttonSend1);
            this.Controls.Add(this.buttonSend2);
            this.Controls.Add(this.buttonSend3);
            this.Name = "KQ1TasPanel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label labelGameInfo;
        private TasButton buttonSend7;
        private TasButton buttonSend8;
        private TasButton buttonSend9;
        private TasButton buttonSend4;
        private TasButton buttonSend6;
        private TasButton buttonSend1;
        private TasButton buttonSend2;
        private TasButton buttonSend3;
        private TasButton tasButton1;
    }
}