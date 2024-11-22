namespace Calculater
{
    partial class FrmCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtStore = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnMod = new Guna.UI2.WinForms.Guna2Button();
            this.btnDevide = new Guna.UI2.WinForms.Guna2Button();
            this.btnSeven = new Guna.UI2.WinForms.Guna2Button();
            this.btnEight = new Guna.UI2.WinForms.Guna2Button();
            this.btnNine = new Guna.UI2.WinForms.Guna2Button();
            this.BtnMulti = new Guna.UI2.WinForms.Guna2Button();
            this.btnFour = new Guna.UI2.WinForms.Guna2Button();
            this.btnFive = new Guna.UI2.WinForms.Guna2Button();
            this.btnSix = new Guna.UI2.WinForms.Guna2Button();
            this.btnPlus = new Guna.UI2.WinForms.Guna2Button();
            this.btnOne = new Guna.UI2.WinForms.Guna2Button();
            this.btnTwo = new Guna.UI2.WinForms.Guna2Button();
            this.btnThree = new Guna.UI2.WinForms.Guna2Button();
            this.btnMin = new Guna.UI2.WinForms.Guna2Button();
            this.btnDot = new Guna.UI2.WinForms.Guna2Button();
            this.btnZero = new Guna.UI2.WinForms.Guna2Button();
            this.btnEqual = new Guna.UI2.WinForms.Guna2Button();
            this.txtResult = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Image = global::Calculator_Project.Properties.Resources.red_power_button_icon_black_background_polygonal_vector_1901511;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.Location = new System.Drawing.Point(508, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.Size = new System.Drawing.Size(114, 83);
            this.btnExit.TabIndex = 1;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtStore
            // 
            this.txtStore.BorderColor = System.Drawing.Color.Black;
            this.txtStore.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtStore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStore.DefaultText = "";
            this.txtStore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStore.FillColor = System.Drawing.Color.Black;
            this.txtStore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStore.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            this.txtStore.ForeColor = System.Drawing.Color.Crimson;
            this.txtStore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStore.Location = new System.Drawing.Point(13, 153);
            this.txtStore.Margin = new System.Windows.Forms.Padding(4);
            this.txtStore.Name = "txtStore";
            this.txtStore.PasswordChar = '\0';
            this.txtStore.PlaceholderText = "";
            this.txtStore.SelectedText = "";
            this.txtStore.Size = new System.Drawing.Size(591, 54);
            this.txtStore.TabIndex = 2;
            this.txtStore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.Animated = true;
            this.btnClear.AutoRoundedCorners = true;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.BorderColor = System.Drawing.Color.IndianRed;
            this.btnClear.BorderRadius = 30;
            this.btnClear.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnClear.BorderThickness = 2;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Black;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClear.IndicateFocus = true;
            this.btnClear.Location = new System.Drawing.Point(50, 244);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(166, 63);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseTransparentBackground = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMod
            // 
            this.btnMod.Animated = true;
            this.btnMod.AutoRoundedCorners = true;
            this.btnMod.BackColor = System.Drawing.Color.Transparent;
            this.btnMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMod.BorderColor = System.Drawing.Color.IndianRed;
            this.btnMod.BorderRadius = 30;
            this.btnMod.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnMod.BorderThickness = 2;
            this.btnMod.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnMod.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnMod.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnMod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMod.FillColor = System.Drawing.Color.Black;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnMod.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMod.IndicateFocus = true;
            this.btnMod.Location = new System.Drawing.Point(263, 244);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(126, 63);
            this.btnMod.TabIndex = 4;
            this.btnMod.Text = "%";
            this.btnMod.UseTransparentBackground = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnDevide
            // 
            this.btnDevide.Animated = true;
            this.btnDevide.AutoRoundedCorners = true;
            this.btnDevide.BackColor = System.Drawing.Color.Transparent;
            this.btnDevide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDevide.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDevide.BorderRadius = 30;
            this.btnDevide.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDevide.BorderThickness = 2;
            this.btnDevide.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnDevide.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnDevide.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnDevide.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevide.FillColor = System.Drawing.Color.Black;
            this.btnDevide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnDevide.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDevide.IndicateFocus = true;
            this.btnDevide.Location = new System.Drawing.Point(438, 244);
            this.btnDevide.Name = "btnDevide";
            this.btnDevide.Size = new System.Drawing.Size(121, 63);
            this.btnDevide.TabIndex = 5;
            this.btnDevide.Text = "/";
            this.btnDevide.UseTransparentBackground = true;
            this.btnDevide.Click += new System.EventHandler(this.btnDevide_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.Animated = true;
            this.btnSeven.AutoRoundedCorners = true;
            this.btnSeven.BackColor = System.Drawing.Color.Transparent;
            this.btnSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSeven.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSeven.BorderRadius = 29;
            this.btnSeven.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSeven.BorderThickness = 2;
            this.btnSeven.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnSeven.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSeven.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnSeven.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSeven.FillColor = System.Drawing.Color.Black;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnSeven.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSeven.IndicateFocus = true;
            this.btnSeven.Location = new System.Drawing.Point(50, 352);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(105, 60);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseTransparentBackground = true;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.Animated = true;
            this.btnEight.AutoRoundedCorners = true;
            this.btnEight.BackColor = System.Drawing.Color.Transparent;
            this.btnEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEight.BorderColor = System.Drawing.Color.IndianRed;
            this.btnEight.BorderRadius = 29;
            this.btnEight.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEight.BorderThickness = 2;
            this.btnEight.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnEight.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEight.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnEight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEight.FillColor = System.Drawing.Color.Black;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnEight.ForeColor = System.Drawing.Color.IndianRed;
            this.btnEight.IndicateFocus = true;
            this.btnEight.Location = new System.Drawing.Point(187, 352);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(105, 60);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseTransparentBackground = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.Animated = true;
            this.btnNine.AutoRoundedCorners = true;
            this.btnNine.BackColor = System.Drawing.Color.Transparent;
            this.btnNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNine.BorderColor = System.Drawing.Color.IndianRed;
            this.btnNine.BorderRadius = 29;
            this.btnNine.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnNine.BorderThickness = 2;
            this.btnNine.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnNine.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnNine.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnNine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNine.FillColor = System.Drawing.Color.Black;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnNine.ForeColor = System.Drawing.Color.IndianRed;
            this.btnNine.IndicateFocus = true;
            this.btnNine.Location = new System.Drawing.Point(319, 352);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(105, 60);
            this.btnNine.TabIndex = 8;
            this.btnNine.Text = "9";
            this.btnNine.UseTransparentBackground = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // BtnMulti
            // 
            this.BtnMulti.Animated = true;
            this.BtnMulti.AutoRoundedCorners = true;
            this.BtnMulti.BackColor = System.Drawing.Color.Transparent;
            this.BtnMulti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMulti.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnMulti.BorderRadius = 33;
            this.BtnMulti.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.BtnMulti.BorderThickness = 2;
            this.BtnMulti.CheckedState.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnMulti.CustomBorderColor = System.Drawing.Color.IndianRed;
            this.BtnMulti.DisabledState.BorderColor = System.Drawing.Color.IndianRed;
            this.BtnMulti.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.BtnMulti.DisabledState.FillColor = System.Drawing.Color.Black;
            this.BtnMulti.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMulti.FillColor = System.Drawing.Color.Black;
            this.BtnMulti.Font = new System.Drawing.Font("Palatino Linotype", 24F);
            this.BtnMulti.ForeColor = System.Drawing.Color.IndianRed;
            this.BtnMulti.IndicateFocus = true;
            this.BtnMulti.Location = new System.Drawing.Point(467, 343);
            this.BtnMulti.Name = "BtnMulti";
            this.BtnMulti.ShadowDecoration.Color = System.Drawing.Color.IndianRed;
            this.BtnMulti.Size = new System.Drawing.Size(92, 69);
            this.BtnMulti.TabIndex = 9;
            this.BtnMulti.Text = "x";
            this.BtnMulti.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.BtnMulti.UseTransparentBackground = true;
            this.BtnMulti.Click += new System.EventHandler(this.BtnMulti_Click);
            // 
            // btnFour
            // 
            this.btnFour.Animated = true;
            this.btnFour.AutoRoundedCorners = true;
            this.btnFour.BackColor = System.Drawing.Color.Transparent;
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFour.BorderColor = System.Drawing.Color.IndianRed;
            this.btnFour.BorderRadius = 29;
            this.btnFour.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnFour.BorderThickness = 2;
            this.btnFour.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnFour.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnFour.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnFour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFour.FillColor = System.Drawing.Color.Black;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnFour.ForeColor = System.Drawing.Color.IndianRed;
            this.btnFour.IndicateFocus = true;
            this.btnFour.Location = new System.Drawing.Point(50, 453);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(105, 60);
            this.btnFour.TabIndex = 10;
            this.btnFour.Text = "4";
            this.btnFour.UseTransparentBackground = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Animated = true;
            this.btnFive.AutoRoundedCorners = true;
            this.btnFive.BackColor = System.Drawing.Color.Transparent;
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFive.BorderColor = System.Drawing.Color.IndianRed;
            this.btnFive.BorderRadius = 29;
            this.btnFive.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnFive.BorderThickness = 2;
            this.btnFive.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnFive.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnFive.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnFive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFive.FillColor = System.Drawing.Color.Black;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnFive.ForeColor = System.Drawing.Color.IndianRed;
            this.btnFive.IndicateFocus = true;
            this.btnFive.Location = new System.Drawing.Point(187, 453);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(105, 60);
            this.btnFive.TabIndex = 11;
            this.btnFive.Text = "5";
            this.btnFive.UseTransparentBackground = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.Animated = true;
            this.btnSix.AutoRoundedCorners = true;
            this.btnSix.BackColor = System.Drawing.Color.Transparent;
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSix.BorderColor = System.Drawing.Color.IndianRed;
            this.btnSix.BorderRadius = 29;
            this.btnSix.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnSix.BorderThickness = 2;
            this.btnSix.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnSix.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnSix.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnSix.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSix.FillColor = System.Drawing.Color.Black;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnSix.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSix.IndicateFocus = true;
            this.btnSix.Location = new System.Drawing.Point(319, 453);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(105, 60);
            this.btnSix.TabIndex = 12;
            this.btnSix.Text = "6";
            this.btnSix.UseTransparentBackground = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Animated = true;
            this.btnPlus.AutoRoundedCorners = true;
            this.btnPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnPlus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlus.BorderColor = System.Drawing.Color.IndianRed;
            this.btnPlus.BorderRadius = 33;
            this.btnPlus.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnPlus.BorderThickness = 2;
            this.btnPlus.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnPlus.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnPlus.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlus.FillColor = System.Drawing.Color.Black;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnPlus.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPlus.IndicateFocus = true;
            this.btnPlus.Location = new System.Drawing.Point(467, 444);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(92, 69);
            this.btnPlus.TabIndex = 13;
            this.btnPlus.Text = "+";
            this.btnPlus.UseTransparentBackground = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnOne
            // 
            this.btnOne.Animated = true;
            this.btnOne.AutoRoundedCorners = true;
            this.btnOne.BackColor = System.Drawing.Color.Transparent;
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOne.BorderColor = System.Drawing.Color.IndianRed;
            this.btnOne.BorderRadius = 29;
            this.btnOne.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnOne.BorderThickness = 2;
            this.btnOne.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnOne.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnOne.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnOne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOne.FillColor = System.Drawing.Color.Black;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnOne.ForeColor = System.Drawing.Color.IndianRed;
            this.btnOne.IndicateFocus = true;
            this.btnOne.Location = new System.Drawing.Point(50, 551);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(105, 60);
            this.btnOne.TabIndex = 14;
            this.btnOne.Text = "1";
            this.btnOne.UseTransparentBackground = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Animated = true;
            this.btnTwo.AutoRoundedCorners = true;
            this.btnTwo.BackColor = System.Drawing.Color.Transparent;
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTwo.BorderColor = System.Drawing.Color.IndianRed;
            this.btnTwo.BorderRadius = 29;
            this.btnTwo.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnTwo.BorderThickness = 2;
            this.btnTwo.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnTwo.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnTwo.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnTwo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTwo.FillColor = System.Drawing.Color.Black;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnTwo.ForeColor = System.Drawing.Color.IndianRed;
            this.btnTwo.IndicateFocus = true;
            this.btnTwo.Location = new System.Drawing.Point(187, 551);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(105, 60);
            this.btnTwo.TabIndex = 15;
            this.btnTwo.Text = "2";
            this.btnTwo.UseTransparentBackground = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.Animated = true;
            this.btnThree.AutoRoundedCorners = true;
            this.btnThree.BackColor = System.Drawing.Color.Transparent;
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThree.BorderColor = System.Drawing.Color.IndianRed;
            this.btnThree.BorderRadius = 29;
            this.btnThree.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnThree.BorderThickness = 2;
            this.btnThree.CausesValidation = false;
            this.btnThree.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnThree.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnThree.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnThree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThree.FillColor = System.Drawing.Color.Black;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnThree.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThree.IndicateFocus = true;
            this.btnThree.Location = new System.Drawing.Point(319, 551);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(105, 60);
            this.btnThree.TabIndex = 16;
            this.btnThree.Text = "3";
            this.btnThree.UseTransparentBackground = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnMin
            // 
            this.btnMin.Animated = true;
            this.btnMin.AutoRoundedCorners = true;
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.BorderColor = System.Drawing.Color.IndianRed;
            this.btnMin.BorderRadius = 33;
            this.btnMin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnMin.BorderThickness = 2;
            this.btnMin.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnMin.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnMin.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnMin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMin.FillColor = System.Drawing.Color.Black;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnMin.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMin.IndicateFocus = true;
            this.btnMin.Location = new System.Drawing.Point(467, 542);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(92, 69);
            this.btnMin.TabIndex = 17;
            this.btnMin.Text = "-";
            this.btnMin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnMin.UseTransparentBackground = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnDot
            // 
            this.btnDot.Animated = true;
            this.btnDot.AutoRoundedCorners = true;
            this.btnDot.BackColor = System.Drawing.Color.Transparent;
            this.btnDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDot.BorderColor = System.Drawing.Color.IndianRed;
            this.btnDot.BorderRadius = 29;
            this.btnDot.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnDot.BorderThickness = 2;
            this.btnDot.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnDot.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnDot.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnDot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDot.FillColor = System.Drawing.Color.Black;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnDot.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDot.IndicateFocus = true;
            this.btnDot.Location = new System.Drawing.Point(187, 640);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(127, 60);
            this.btnDot.TabIndex = 18;
            this.btnDot.Text = ".";
            this.btnDot.UseTransparentBackground = true;
            this.btnDot.Click += new System.EventHandler(this.btnDot_Click);
            // 
            // btnZero
            // 
            this.btnZero.Animated = true;
            this.btnZero.AutoRoundedCorners = true;
            this.btnZero.BackColor = System.Drawing.Color.Transparent;
            this.btnZero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnZero.BorderColor = System.Drawing.Color.IndianRed;
            this.btnZero.BorderRadius = 29;
            this.btnZero.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnZero.BorderThickness = 2;
            this.btnZero.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnZero.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnZero.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnZero.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnZero.FillColor = System.Drawing.Color.Black;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnZero.ForeColor = System.Drawing.Color.IndianRed;
            this.btnZero.IndicateFocus = true;
            this.btnZero.Location = new System.Drawing.Point(50, 640);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(105, 60);
            this.btnZero.TabIndex = 19;
            this.btnZero.Text = "0";
            this.btnZero.UseTransparentBackground = true;
            this.btnZero.Click += new System.EventHandler(this.btnzero_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.Animated = true;
            this.btnEqual.AutoRoundedCorners = true;
            this.btnEqual.BackColor = System.Drawing.Color.Transparent;
            this.btnEqual.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEqual.BorderColor = System.Drawing.Color.IndianRed;
            this.btnEqual.BorderRadius = 34;
            this.btnEqual.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.btnEqual.BorderThickness = 2;
            this.btnEqual.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.btnEqual.DisabledState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnEqual.DisabledState.FillColor = System.Drawing.Color.Black;
            this.btnEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEqual.FillColor = System.Drawing.Color.IndianRed;
            this.btnEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.btnEqual.ForeColor = System.Drawing.Color.Black;
            this.btnEqual.IndicateFocus = true;
            this.btnEqual.Location = new System.Drawing.Point(368, 640);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(191, 70);
            this.btnEqual.TabIndex = 21;
            this.btnEqual.Text = "=";
            this.btnEqual.UseTransparentBackground = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // txtResult
            // 
            this.txtResult.BorderColor = System.Drawing.Color.Black;
            this.txtResult.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtResult.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtResult.DefaultText = "";
            this.txtResult.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtResult.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtResult.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtResult.FillColor = System.Drawing.Color.Black;
            this.txtResult.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold);
            this.txtResult.ForeColor = System.Drawing.Color.LightCoral;
            this.txtResult.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtResult.Location = new System.Drawing.Point(13, 79);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.PasswordChar = '\0';
            this.txtResult.PlaceholderText = "";
            this.txtResult.SelectedText = "";
            this.txtResult.Size = new System.Drawing.Size(591, 54);
            this.txtResult.TabIndex = 22;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(617, 742);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.BtnMulti);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnDevide);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.Name = "FrmCalculator";
            this.ShowIcon = false;
            this.Text = "Calculator";
            //this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private Guna.UI2.WinForms.Guna2TextBox txtStore;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnMod;
        private Guna.UI2.WinForms.Guna2Button btnDevide;
        private Guna.UI2.WinForms.Guna2Button btnSeven;
        private Guna.UI2.WinForms.Guna2Button btnEight;
        private Guna.UI2.WinForms.Guna2Button btnNine;
        private Guna.UI2.WinForms.Guna2Button BtnMulti;
        private Guna.UI2.WinForms.Guna2Button btnFour;
        private Guna.UI2.WinForms.Guna2Button btnFive;
        private Guna.UI2.WinForms.Guna2Button btnSix;
        private Guna.UI2.WinForms.Guna2Button btnPlus;
        private Guna.UI2.WinForms.Guna2Button btnOne;
        private Guna.UI2.WinForms.Guna2Button btnTwo;
        private Guna.UI2.WinForms.Guna2Button btnThree;
        private Guna.UI2.WinForms.Guna2Button btnMin;
        private Guna.UI2.WinForms.Guna2Button btnDot;
        private Guna.UI2.WinForms.Guna2Button btnZero;
        private Guna.UI2.WinForms.Guna2Button btnEqual;
        private Guna.UI2.WinForms.Guna2TextBox txtResult;
    }
}

