#region copyright
/*
This Source Code Form is subject to the terms of the Mozilla Public License, v. 2.0.
If a copy of the MPL was not distributed with this file,
You can obtain one at https://mozilla.org/MPL/2.0/.

Copyright 2021 By Thomas Ruigrok. Some Rights Reserved
*/
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColourProjecter
{
    public partial class Form_Main : Form
    {

        //Class Variables
        //Default settings
        private FormBorderStyle defaultBorder;
        private bool defaultControlBox;
        private FormWindowState defaultWindowState;
        private int defaultWidth;
        private int defaultHeight;
        private Color defaultBGColour;

        //Other Variables
        private Color bgColour;

        /// <summary>
        /// The Colour Background Getters & Setters
        /// </summary>
        private Color BgColour
        {
            get
            {
                return bgColour;
            }

            set
            {
                bgColour = value;
                this.BackColor = BgColour;
            }
        }

        /// <summary>
        /// On Form Load, Change the header text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.Text = "Colour Projector";
        }

        /// <summary>
        /// Check for key-up events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Main_KeyUp(object sender, KeyEventArgs e)
        {
            //If key was the escape key, Close the application
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Form Constructor
        /// </summary>
        /// <param name="ScrnWidth"></param>
        /// <param name="ScrnHeight"></param>
        public Form_Main(float ScrnWidth, float ScrnHeight)
        {
            //Set the background colour to black
            this.BgColour = Color.Black;

            //Set the border style to none
            this.FormBorderStyle = FormBorderStyle.None;

            //Remove the windows default control box (Minimize, Maxmamize, & Close Button)
            this.ControlBox = false;

            //Set the window to maxamized
            this.WindowState = FormWindowState.Maximized;

            //Set the width of the window to the screen width
            this.Width = (int)ScrnWidth;

            //Set the height of the window to the screen height
            this.defaultHeight = (int)ScrnHeight;

            //Call a void function to save these values for reset
            SetDefaultSettings();

            //Initialize the window
            InitializeComponent();
        }

        /// <summary>
        /// Set the current window settings to the default for reset.
        /// </summary>
        private void SetDefaultSettings()
        {
            defaultWindowState = this.WindowState;
            defaultBorder = this.FormBorderStyle;
            defaultControlBox = this.ControlBox;
            defaultWidth = this.Width;
            defaultHeight = this.Height;
            defaultBGColour = this.BackColor;

        }

        /// <summary>
        /// Reset the window to the default settings
        /// </summary>
        private void ResetSettings()
        {
            this.WindowState = defaultWindowState;
            this.FormBorderStyle = defaultBorder;
            this.ControlBox = defaultControlBox;
            this.Width = defaultWidth;
            this.Height = defaultHeight;
            this.BackColor = defaultBGColour;
        }

        /// <summary>
        /// Close box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Minimize box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Red Colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Red_Click(object sender, EventArgs e)
        {
            BgColour = Color.Red;
        }

        /// <summary>
        /// Orange colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Orange_Click(object sender, EventArgs e)
        {
            BgColour = Color.Orange;
        }

        /// <summary>
        /// Yellow colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Yellow_Click(object sender, EventArgs e)
        {
            BgColour = Color.Yellow;
        }

        /// <summary>
        /// Green colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Green_Click(object sender, EventArgs e)
        {
            BgColour = Color.Green;
        }

        /// <summary>
        /// Blue colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Blue_Click(object sender, EventArgs e)
        {
            BgColour = Color.Blue;
        }

        /// <summary>
        /// Indigo colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Indigo_Click(object sender, EventArgs e)
        {
            BgColour = Color.Indigo;
        }

        /// <summary>
        /// Violet colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Violet_Click(object sender, EventArgs e)
        {
            BgColour = Color.Violet;
        }

        /// <summary>
        /// Custom colour box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Colour_Custom_Click(object sender, EventArgs e)
        {
            //Open the Colour Picker dialog and capture the result
            DialogResult result = colourPicker.ShowDialog();
            if(result == DialogResult.OK)
            {
                BgColour = colourPicker.Color;
            }
        }

        /// <summary>
        /// Reset box click handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Box_Reset_Click(object sender, EventArgs e)
        {
            ResetSettings();
        }
    }
}
