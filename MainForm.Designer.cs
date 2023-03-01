namespace Csengoszimulator_Lambda
{
    partial class MainForm
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
        public void InitializeComponent()
        {
            this.gombStart = new System.Windows.Forms.Button();
            this.gombStop = new System.Windows.Forms.Button();
            this.listboxCsengetések = new System.Windows.Forms.ListBox();
            this.groupBeállítások = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkedListBMunkanapok = new System.Windows.Forms.CheckedListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButton_BECS = new System.Windows.Forms.RadioButton();
            this.radioButton_JELZ = new System.Windows.Forms.RadioButton();
            this.radioButton_KICS = new System.Windows.Forms.RadioButton();
            this.textBoxPERC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxORA = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gomb_IDP_DEL = new System.Windows.Forms.Button();
            this.gomb_IDP_OVRW = new System.Windows.Forms.Button();
            this.gomb_IDP_ÚJ = new System.Windows.Forms.Button();
            this.logOutputScreen = new System.Windows.Forms.RichTextBox();
            this.groupKapcsoló = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBeállítások.SuspendLayout();
            this.groupKapcsoló.SuspendLayout();
            this.SuspendLayout();
            // 
            // gombStart
            // 
            this.gombStart.ForeColor = System.Drawing.Color.Green;
            this.gombStart.Location = new System.Drawing.Point(6, 15);
            this.gombStart.Name = "gombStart";
            this.gombStart.Size = new System.Drawing.Size(99, 58);
            this.gombStart.TabIndex = 1;
            this.gombStart.Text = "BEKAPCSOLÁS";
            this.gombStart.UseVisualStyleBackColor = true;
            this.gombStart.Click += new System.EventHandler(this.powerSwitchOn);
            // 
            // gombStop
            // 
            this.gombStop.Enabled = false;
            this.gombStop.ForeColor = System.Drawing.Color.Red;
            this.gombStop.Location = new System.Drawing.Point(111, 15);
            this.gombStop.Name = "gombStop";
            this.gombStop.Size = new System.Drawing.Size(99, 58);
            this.gombStop.TabIndex = 2;
            this.gombStop.Text = "LEÁLLÍTÁS";
            this.gombStop.UseVisualStyleBackColor = true;
            this.gombStop.Click += new System.EventHandler(this.powerSwitchOff);
            // 
            // listboxCsengetések
            // 
            this.listboxCsengetések.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listboxCsengetések.FormattingEnabled = true;
            this.listboxCsengetések.ItemHeight = 16;
            this.listboxCsengetések.Location = new System.Drawing.Point(335, 43);
            this.listboxCsengetések.Name = "listboxCsengetések";
            this.listboxCsengetések.Size = new System.Drawing.Size(223, 260);
            this.listboxCsengetések.TabIndex = 3;
            this.listboxCsengetések.Click += new System.EventHandler(this.listboxCsengetések_Click);
            // 
            // groupBeállítások
            // 
            this.groupBeállítások.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBeállítások.Controls.Add(this.button1);
            this.groupBeállítások.Controls.Add(this.label10);
            this.groupBeállítások.Controls.Add(this.checkedListBMunkanapok);
            this.groupBeállítások.Controls.Add(this.label7);
            this.groupBeállítások.Controls.Add(this.radioButton_BECS);
            this.groupBeállítások.Controls.Add(this.radioButton_JELZ);
            this.groupBeállítások.Controls.Add(this.radioButton_KICS);
            this.groupBeállítások.Controls.Add(this.textBoxPERC);
            this.groupBeállítások.Controls.Add(this.label6);
            this.groupBeállítások.Controls.Add(this.label5);
            this.groupBeállítások.Controls.Add(this.textBoxORA);
            this.groupBeállítások.Controls.Add(this.label4);
            this.groupBeállítások.Controls.Add(this.label3);
            this.groupBeállítások.Controls.Add(this.gomb_IDP_DEL);
            this.groupBeállítások.Controls.Add(this.gomb_IDP_OVRW);
            this.groupBeállítások.Controls.Add(this.gomb_IDP_ÚJ);
            this.groupBeállítások.Controls.Add(this.listboxCsengetések);
            this.groupBeállítások.Location = new System.Drawing.Point(12, 20);
            this.groupBeállítások.Name = "groupBeállítások";
            this.groupBeállítások.Size = new System.Drawing.Size(574, 358);
            this.groupBeállítások.TabIndex = 4;
            this.groupBeállítások.TabStop = false;
            this.groupBeállítások.Text = "BEÁLLÍTÁSOK";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(118, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 55);
            this.button1.TabIndex = 21;
            this.button1.Text = "Napok Mentése";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MunkanapokMentes_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(24, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Csengetett napok";
            // 
            // checkedListBMunkanapok
            // 
            this.checkedListBMunkanapok.CheckOnClick = true;
            this.checkedListBMunkanapok.FormattingEnabled = true;
            this.checkedListBMunkanapok.Items.AddRange(new object[] {
            "Hétfő",
            "Kedd",
            "Szerda",
            "Csütörtök",
            "Péntek",
            "Szombat",
            "Vasárnap"});
            this.checkedListBMunkanapok.Location = new System.Drawing.Point(19, 214);
            this.checkedListBMunkanapok.Name = "checkedListBMunkanapok";
            this.checkedListBMunkanapok.Size = new System.Drawing.Size(93, 109);
            this.checkedListBMunkanapok.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(25, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Csengetés típusa";
            // 
            // radioButton_BECS
            // 
            this.radioButton_BECS.AutoSize = true;
            this.radioButton_BECS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_BECS.Location = new System.Drawing.Point(28, 172);
            this.radioButton_BECS.Name = "radioButton_BECS";
            this.radioButton_BECS.Size = new System.Drawing.Size(105, 20);
            this.radioButton_BECS.TabIndex = 15;
            this.radioButton_BECS.TabStop = true;
            this.radioButton_BECS.Text = "Becsengetés";
            this.radioButton_BECS.UseVisualStyleBackColor = true;
            this.radioButton_BECS.Click += new System.EventHandler(this.ValueDoboz_TextChanged);
            // 
            // radioButton_JELZ
            // 
            this.radioButton_JELZ.AutoSize = true;
            this.radioButton_JELZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_JELZ.Location = new System.Drawing.Point(28, 152);
            this.radioButton_JELZ.Name = "radioButton_JELZ";
            this.radioButton_JELZ.Size = new System.Drawing.Size(102, 20);
            this.radioButton_JELZ.TabIndex = 14;
            this.radioButton_JELZ.TabStop = true;
            this.radioButton_JELZ.Text = "Jelzőcsengő";
            this.radioButton_JELZ.UseVisualStyleBackColor = true;
            this.radioButton_JELZ.Click += new System.EventHandler(this.ValueDoboz_TextChanged);
            // 
            // radioButton_KICS
            // 
            this.radioButton_KICS.AutoSize = true;
            this.radioButton_KICS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton_KICS.Location = new System.Drawing.Point(28, 132);
            this.radioButton_KICS.Name = "radioButton_KICS";
            this.radioButton_KICS.Size = new System.Drawing.Size(99, 20);
            this.radioButton_KICS.TabIndex = 13;
            this.radioButton_KICS.TabStop = true;
            this.radioButton_KICS.Text = "Kicsengetés";
            this.radioButton_KICS.UseVisualStyleBackColor = true;
            this.radioButton_KICS.Click += new System.EventHandler(this.ValueDoboz_TextChanged);
            // 
            // textBoxPERC
            // 
            this.textBoxPERC.Location = new System.Drawing.Point(73, 86);
            this.textBoxPERC.Name = "textBoxPERC";
            this.textBoxPERC.Size = new System.Drawing.Size(39, 20);
            this.textBoxPERC.TabIndex = 12;
            this.textBoxPERC.Text = "0";
            this.textBoxPERC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPERC.TextChanged += new System.EventHandler(this.ValueDoboz_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(24, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Csengetés időpontja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(43, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Óra:Perc";
            // 
            // textBoxORA
            // 
            this.textBoxORA.Location = new System.Drawing.Point(27, 86);
            this.textBoxORA.Name = "textBoxORA";
            this.textBoxORA.Size = new System.Drawing.Size(39, 20);
            this.textBoxORA.TabIndex = 9;
            this.textBoxORA.Text = "0";
            this.textBoxORA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxORA.TextChanged += new System.EventHandler(this.ValueDoboz_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Csengetési beállítások";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(331, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Csengetési időpontok";
            // 
            // gomb_IDP_DEL
            // 
            this.gomb_IDP_DEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gomb_IDP_DEL.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomb_IDP_DEL.Location = new System.Drawing.Point(234, 187);
            this.gomb_IDP_DEL.Name = "gomb_IDP_DEL";
            this.gomb_IDP_DEL.Size = new System.Drawing.Size(95, 63);
            this.gomb_IDP_DEL.TabIndex = 6;
            this.gomb_IDP_DEL.Text = "Időpont törlés";
            this.gomb_IDP_DEL.UseVisualStyleBackColor = true;
            this.gomb_IDP_DEL.Click += new System.EventHandler(this.gomb_IDP_DEL_Click);
            // 
            // gomb_IDP_OVRW
            // 
            this.gomb_IDP_OVRW.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gomb_IDP_OVRW.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomb_IDP_OVRW.Location = new System.Drawing.Point(234, 116);
            this.gomb_IDP_OVRW.Name = "gomb_IDP_OVRW";
            this.gomb_IDP_OVRW.Size = new System.Drawing.Size(95, 63);
            this.gomb_IDP_OVRW.TabIndex = 5;
            this.gomb_IDP_OVRW.Text = "Időpont felülírás";
            this.gomb_IDP_OVRW.UseVisualStyleBackColor = true;
            this.gomb_IDP_OVRW.Click += new System.EventHandler(this.gomb_IDP_OVRW_Click);
            // 
            // gomb_IDP_ÚJ
            // 
            this.gomb_IDP_ÚJ.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gomb_IDP_ÚJ.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gomb_IDP_ÚJ.Location = new System.Drawing.Point(234, 47);
            this.gomb_IDP_ÚJ.Name = "gomb_IDP_ÚJ";
            this.gomb_IDP_ÚJ.Size = new System.Drawing.Size(95, 63);
            this.gomb_IDP_ÚJ.TabIndex = 4;
            this.gomb_IDP_ÚJ.Text = "Időpont létrehozás";
            this.gomb_IDP_ÚJ.UseVisualStyleBackColor = true;
            this.gomb_IDP_ÚJ.Click += new System.EventHandler(this.gomb_IDP_ÚJ_Click);
            // 
            // logOutputScreen
            // 
            this.logOutputScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutputScreen.Location = new System.Drawing.Point(1, 0);
            this.logOutputScreen.Name = "logOutputScreen";
            this.logOutputScreen.ReadOnly = true;
            this.logOutputScreen.Size = new System.Drawing.Size(598, 376);
            this.logOutputScreen.TabIndex = 10;
            this.logOutputScreen.Text = "";
            this.logOutputScreen.Visible = false;
            // 
            // groupKapcsoló
            // 
            this.groupKapcsoló.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupKapcsoló.Controls.Add(this.gombStart);
            this.groupKapcsoló.Controls.Add(this.gombStop);
            this.groupKapcsoló.Location = new System.Drawing.Point(363, 384);
            this.groupKapcsoló.Name = "groupKapcsoló";
            this.groupKapcsoló.Size = new System.Drawing.Size(223, 88);
            this.groupKapcsoló.TabIndex = 5;
            this.groupKapcsoló.TabStop = false;
            this.groupKapcsoló.Text = "FŐKAPCSOLÓ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Alapváltozat Vasadi Vendeltől\r\nex 2011-2019 A";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(334, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = "FIGYELEM, A RENDSZER AUTOMATIKUS MENTÉST ALKALMAZ,\r\nA CSENGETETT NAPOKAT KIVÉVE B" +
    "ÁRMELY MÓDOSÍTÁS\r\nAZONNALI MENTÉSRE KERÜL";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(598, 481);
            this.Controls.Add(this.logOutputScreen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupKapcsoló);
            this.Controls.Add(this.groupBeállítások);
            this.Name = "MainForm";
            this.Text = "Csengőszimulátor - V.: 8.1 Lambda";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBeállítások.ResumeLayout(false);
            this.groupBeállítások.PerformLayout();
            this.groupKapcsoló.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button gombStart;
        private System.Windows.Forms.Button gombStop;
        private System.Windows.Forms.ListBox listboxCsengetések;
        private System.Windows.Forms.GroupBox groupBeállítások;
        private System.Windows.Forms.GroupBox groupKapcsoló;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxORA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button gomb_IDP_DEL;
        private System.Windows.Forms.Button gomb_IDP_OVRW;
        private System.Windows.Forms.Button gomb_IDP_ÚJ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButton_BECS;
        private System.Windows.Forms.RadioButton radioButton_JELZ;
        private System.Windows.Forms.RadioButton radioButton_KICS;
        private System.Windows.Forms.TextBox textBoxPERC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox logOutputScreen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckedListBox checkedListBMunkanapok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
    }
}

