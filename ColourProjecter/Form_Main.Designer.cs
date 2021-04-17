namespace ColourProjecter
{
    partial class Form_Main
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
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.Box_Reset = new System.Windows.Forms.PictureBox();
            this.Box_Close = new System.Windows.Forms.PictureBox();
            this.Box_Minimize = new System.Windows.Forms.PictureBox();
            this.colourPicker = new System.Windows.Forms.ColorDialog();
            this.colourGroupPanel = new System.Windows.Forms.Panel();
            this.Box_Colour_Custom = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Violet = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Indigo = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Blue = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Green = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Yellow = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Orange = new System.Windows.Forms.PictureBox();
            this.Box_Colour_Red = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.controlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Minimize)).BeginInit();
            this.colourGroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Custom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Violet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Indigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Blue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Yellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Orange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Red)).BeginInit();
            this.SuspendLayout();
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.controlGroupBox.Controls.Add(this.Box_Reset);
            this.controlGroupBox.Controls.Add(this.Box_Close);
            this.controlGroupBox.Controls.Add(this.Box_Minimize);
            this.controlGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlGroupBox.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.controlGroupBox.Location = new System.Drawing.Point(0, 459);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(839, 52);
            this.controlGroupBox.TabIndex = 1;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control Box";
            // 
            // Box_Reset
            // 
            this.Box_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Reset.BackColor = System.Drawing.Color.Black;
            this.Box_Reset.BackgroundImage = global::ColourProjecter.Properties.Resources.reset;
            this.Box_Reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box_Reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Reset.InitialImage = null;
            this.Box_Reset.Location = new System.Drawing.Point(707, 11);
            this.Box_Reset.Name = "Box_Reset";
            this.Box_Reset.Size = new System.Drawing.Size(38, 37);
            this.Box_Reset.TabIndex = 10;
            this.Box_Reset.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Reset, "Reset to Default");
            this.Box_Reset.Click += new System.EventHandler(this.Box_Reset_Click);
            // 
            // Box_Close
            // 
            this.Box_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Close.BackColor = System.Drawing.Color.Black;
            this.Box_Close.BackgroundImage = global::ColourProjecter.Properties.Resources.close_150_458082;
            this.Box_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Close.InitialImage = null;
            this.Box_Close.Location = new System.Drawing.Point(795, 11);
            this.Box_Close.Name = "Box_Close";
            this.Box_Close.Size = new System.Drawing.Size(38, 37);
            this.Box_Close.TabIndex = 9;
            this.Box_Close.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Close, "Close");
            this.Box_Close.Click += new System.EventHandler(this.Box_Close_Click);
            // 
            // Box_Minimize
            // 
            this.Box_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Box_Minimize.BackColor = System.Drawing.Color.Black;
            this.Box_Minimize.BackgroundImage = global::ColourProjecter.Properties.Resources._758593_arrows_512x512;
            this.Box_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Minimize.InitialImage = null;
            this.Box_Minimize.Location = new System.Drawing.Point(751, 11);
            this.Box_Minimize.Name = "Box_Minimize";
            this.Box_Minimize.Size = new System.Drawing.Size(38, 37);
            this.Box_Minimize.TabIndex = 8;
            this.Box_Minimize.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Minimize, "Minimize");
            this.Box_Minimize.Click += new System.EventHandler(this.Box_Minimize_Click);
            // 
            // colourPicker
            // 
            this.colourPicker.AnyColor = true;
            this.colourPicker.FullOpen = true;
            // 
            // colourGroupPanel
            // 
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Custom);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Violet);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Indigo);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Blue);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Green);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Yellow);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Orange);
            this.colourGroupPanel.Controls.Add(this.Box_Colour_Red);
            this.colourGroupPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.colourGroupPanel.Location = new System.Drawing.Point(0, 0);
            this.colourGroupPanel.Name = "colourGroupPanel";
            this.colourGroupPanel.Size = new System.Drawing.Size(839, 72);
            this.colourGroupPanel.TabIndex = 2;
            // 
            // Box_Colour_Custom
            // 
            this.Box_Colour_Custom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Custom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Box_Colour_Custom.BackgroundImage = global::ColourProjecter.Properties.Resources.Custom_Colour;
            this.Box_Colour_Custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Box_Colour_Custom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Custom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Custom.Location = new System.Drawing.Point(548, 0);
            this.Box_Colour_Custom.Name = "Box_Colour_Custom";
            this.Box_Colour_Custom.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Custom.TabIndex = 7;
            this.Box_Colour_Custom.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Custom, "Custom");
            this.Box_Colour_Custom.Click += new System.EventHandler(this.Box_Colour_Custom_Click);
            // 
            // Box_Colour_Violet
            // 
            this.Box_Colour_Violet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Violet.BackColor = System.Drawing.Color.Violet;
            this.Box_Colour_Violet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Violet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Violet.Location = new System.Drawing.Point(504, 0);
            this.Box_Colour_Violet.Name = "Box_Colour_Violet";
            this.Box_Colour_Violet.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Violet.TabIndex = 6;
            this.Box_Colour_Violet.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Violet, "Violet");
            this.Box_Colour_Violet.Click += new System.EventHandler(this.Box_Colour_Violet_Click);
            // 
            // Box_Colour_Indigo
            // 
            this.Box_Colour_Indigo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Indigo.BackColor = System.Drawing.Color.Indigo;
            this.Box_Colour_Indigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Indigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Indigo.Location = new System.Drawing.Point(460, 0);
            this.Box_Colour_Indigo.Name = "Box_Colour_Indigo";
            this.Box_Colour_Indigo.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Indigo.TabIndex = 5;
            this.Box_Colour_Indigo.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Indigo, "Indigo");
            this.Box_Colour_Indigo.Click += new System.EventHandler(this.Box_Colour_Indigo_Click);
            // 
            // Box_Colour_Blue
            // 
            this.Box_Colour_Blue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Blue.BackColor = System.Drawing.Color.Blue;
            this.Box_Colour_Blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Blue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Blue.Location = new System.Drawing.Point(416, 0);
            this.Box_Colour_Blue.Name = "Box_Colour_Blue";
            this.Box_Colour_Blue.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Blue.TabIndex = 4;
            this.Box_Colour_Blue.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Blue, "Blue");
            this.Box_Colour_Blue.Click += new System.EventHandler(this.Box_Colour_Blue_Click);
            // 
            // Box_Colour_Green
            // 
            this.Box_Colour_Green.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Green.BackColor = System.Drawing.Color.Green;
            this.Box_Colour_Green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Green.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Green.Location = new System.Drawing.Point(372, 0);
            this.Box_Colour_Green.Name = "Box_Colour_Green";
            this.Box_Colour_Green.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Green.TabIndex = 3;
            this.Box_Colour_Green.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Green, "Green");
            this.Box_Colour_Green.Click += new System.EventHandler(this.Box_Colour_Green_Click);
            // 
            // Box_Colour_Yellow
            // 
            this.Box_Colour_Yellow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Box_Colour_Yellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Yellow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Yellow.Location = new System.Drawing.Point(328, 0);
            this.Box_Colour_Yellow.Name = "Box_Colour_Yellow";
            this.Box_Colour_Yellow.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Yellow.TabIndex = 2;
            this.Box_Colour_Yellow.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Yellow, "Yellow");
            this.Box_Colour_Yellow.Click += new System.EventHandler(this.Box_Colour_Yellow_Click);
            // 
            // Box_Colour_Orange
            // 
            this.Box_Colour_Orange.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Orange.BackColor = System.Drawing.Color.Orange;
            this.Box_Colour_Orange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Orange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Orange.Location = new System.Drawing.Point(284, 0);
            this.Box_Colour_Orange.Name = "Box_Colour_Orange";
            this.Box_Colour_Orange.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Orange.TabIndex = 1;
            this.Box_Colour_Orange.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Orange, "Orange");
            this.Box_Colour_Orange.Click += new System.EventHandler(this.Box_Colour_Orange_Click);
            // 
            // Box_Colour_Red
            // 
            this.Box_Colour_Red.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Box_Colour_Red.BackColor = System.Drawing.Color.Red;
            this.Box_Colour_Red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Box_Colour_Red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Box_Colour_Red.Location = new System.Drawing.Point(240, 0);
            this.Box_Colour_Red.Name = "Box_Colour_Red";
            this.Box_Colour_Red.Size = new System.Drawing.Size(38, 37);
            this.Box_Colour_Red.TabIndex = 0;
            this.Box_Colour_Red.TabStop = false;
            this.toolTip.SetToolTip(this.Box_Colour_Red, "Red");
            this.Box_Colour_Red.Click += new System.EventHandler(this.Box_Colour_Red_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(839, 511);
            this.Controls.Add(this.colourGroupPanel);
            this.Controls.Add(this.controlGroupBox);
            this.Name = "Form_Main";
            this.Text = "Colour Projector";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_Main_KeyUp);
            this.controlGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Minimize)).EndInit();
            this.colourGroupPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Custom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Violet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Indigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Blue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Yellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Orange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Box_Colour_Red)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.ColorDialog colourPicker;
        private System.Windows.Forms.Panel colourGroupPanel;
        private System.Windows.Forms.PictureBox Box_Colour_Orange;
        private System.Windows.Forms.PictureBox Box_Colour_Red;
        private System.Windows.Forms.PictureBox Box_Colour_Custom;
        private System.Windows.Forms.PictureBox Box_Colour_Violet;
        private System.Windows.Forms.PictureBox Box_Colour_Indigo;
        private System.Windows.Forms.PictureBox Box_Colour_Blue;
        private System.Windows.Forms.PictureBox Box_Colour_Green;
        private System.Windows.Forms.PictureBox Box_Colour_Yellow;
        private System.Windows.Forms.PictureBox Box_Close;
        private System.Windows.Forms.PictureBox Box_Minimize;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox Box_Reset;
    }
}

