namespace AFSystem
{
    partial class Manual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manual));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.bunifuElipse2 = new ns1.BunifuElipse(this.components);
            this.btnClose = new ns1.BunifuImageButton();
            this.header = new System.Windows.Forms.Panel();
            this.lblLogoText = new ns1.BunifuCustomLabel();
            this.lblname = new ns1.BunifuCustomLabel();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new ns1.BunifuDragControl(this.components);
            this.lblAngleDown = new ns1.BunifuCustomLabel();
            this.lblAngleFlat = new ns1.BunifuCustomLabel();
            this.lblDistanceTooFar = new ns1.BunifuCustomLabel();
            this.lblDistanceFar = new ns1.BunifuCustomLabel();
            this.lblDistanceNear = new ns1.BunifuCustomLabel();
            this.lblSpeedFast = new ns1.BunifuCustomLabel();
            this.lblSpeedMedium = new ns1.BunifuCustomLabel();
            this.lblSpeedSlow = new ns1.BunifuCustomLabel();
            this.bunifuSeparator1 = new ns1.BunifuSeparator();
            this.bunifuSeparator2 = new ns1.BunifuSeparator();
            this.bunifuSeparator3 = new ns1.BunifuSeparator();
            this.bunifuSeparator4 = new ns1.BunifuSeparator();
            this.bunifuSeparator5 = new ns1.BunifuSeparator();
            this.bunifuSeparator6 = new ns1.BunifuSeparator();
            this.bunifuMetroTextbox1 = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox2 = new ns1.BunifuMetroTextbox();
            this.bunifuMetroTextbox3 = new ns1.BunifuMetroTextbox();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.bunifuSeparator7 = new ns1.BunifuSeparator();
            this.lblAngleUp = new ns1.BunifuCustomLabel();
            this.bunifuSeparator8 = new ns1.BunifuSeparator();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuProgressBar1 = new ns1.BunifuProgressBar();
            this.bunifuSeparator9 = new ns1.BunifuSeparator();
            this.bunifuSeparator10 = new ns1.BunifuSeparator();
            this.bunifuSeparator11 = new ns1.BunifuSeparator();
            this.bunifuSeparator12 = new ns1.BunifuSeparator();
            this.lblBrakeMed = new ns1.BunifuCustomLabel();
            this.lblBrakeStrong = new ns1.BunifuCustomLabel();
            this.lblBrakeWeak = new ns1.BunifuCustomLabel();
            this.bunifuSeparator13 = new ns1.BunifuSeparator();
            this.bunifuSeparator14 = new ns1.BunifuSeparator();
            this.lblCOG = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new ns1.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.header.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 0;
            this.bunifuElipse2.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(10, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 37);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 6;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.header.Controls.Add(this.btnClose);
            this.header.Controls.Add(this.lblLogoText);
            this.header.Controls.Add(this.lblname);
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(4);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(532, 53);
            this.header.TabIndex = 7;
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.Font = new System.Drawing.Font("Open Sans", 12F);
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(183, 13);
            this.lblLogoText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(81, 27);
            this.lblLogoText.TabIndex = 7;
            this.lblLogoText.Text = "Manual";
            this.lblLogoText.Click += new System.EventHandler(this.lblLogoText_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(59, 13);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(118, 27);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "AutoBreak";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.header;
            this.bunifuDragControl2.Vertical = true;
            // 
            // lblAngleDown
            // 
            this.lblAngleDown.AutoSize = true;
            this.lblAngleDown.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblAngleDown.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAngleDown.Location = new System.Drawing.Point(202, 437);
            this.lblAngleDown.Name = "lblAngleDown";
            this.lblAngleDown.Size = new System.Drawing.Size(78, 23);
            this.lblAngleDown.TabIndex = 21;
            this.lblAngleDown.Text = "Down : 0";
            // 
            // lblAngleFlat
            // 
            this.lblAngleFlat.AutoSize = true;
            this.lblAngleFlat.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblAngleFlat.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAngleFlat.Location = new System.Drawing.Point(202, 378);
            this.lblAngleFlat.Name = "lblAngleFlat";
            this.lblAngleFlat.Size = new System.Drawing.Size(61, 23);
            this.lblAngleFlat.TabIndex = 20;
            this.lblAngleFlat.Text = "Flat : 0";
            // 
            // lblDistanceTooFar
            // 
            this.lblDistanceTooFar.AutoSize = true;
            this.lblDistanceTooFar.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblDistanceTooFar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDistanceTooFar.Location = new System.Drawing.Point(347, 437);
            this.lblDistanceTooFar.Name = "lblDistanceTooFar";
            this.lblDistanceTooFar.Size = new System.Drawing.Size(72, 23);
            this.lblDistanceTooFar.TabIndex = 18;
            this.lblDistanceTooFar.Text = "T.Far : 0";
            // 
            // lblDistanceFar
            // 
            this.lblDistanceFar.AutoSize = true;
            this.lblDistanceFar.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblDistanceFar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDistanceFar.Location = new System.Drawing.Point(347, 378);
            this.lblDistanceFar.Name = "lblDistanceFar";
            this.lblDistanceFar.Size = new System.Drawing.Size(58, 23);
            this.lblDistanceFar.TabIndex = 17;
            this.lblDistanceFar.Text = "Far : 0";
            // 
            // lblDistanceNear
            // 
            this.lblDistanceNear.AutoSize = true;
            this.lblDistanceNear.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblDistanceNear.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDistanceNear.Location = new System.Drawing.Point(347, 314);
            this.lblDistanceNear.Name = "lblDistanceNear";
            this.lblDistanceNear.Size = new System.Drawing.Size(72, 23);
            this.lblDistanceNear.TabIndex = 16;
            this.lblDistanceNear.Text = "Near : 0";
            // 
            // lblSpeedFast
            // 
            this.lblSpeedFast.AutoSize = true;
            this.lblSpeedFast.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblSpeedFast.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpeedFast.Location = new System.Drawing.Point(54, 437);
            this.lblSpeedFast.Name = "lblSpeedFast";
            this.lblSpeedFast.Size = new System.Drawing.Size(65, 23);
            this.lblSpeedFast.TabIndex = 15;
            this.lblSpeedFast.Text = "Fast : 0";
            // 
            // lblSpeedMedium
            // 
            this.lblSpeedMedium.AutoSize = true;
            this.lblSpeedMedium.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblSpeedMedium.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpeedMedium.Location = new System.Drawing.Point(54, 378);
            this.lblSpeedMedium.Name = "lblSpeedMedium";
            this.lblSpeedMedium.Size = new System.Drawing.Size(68, 23);
            this.lblSpeedMedium.TabIndex = 14;
            this.lblSpeedMedium.Text = "Med : 0";
            // 
            // lblSpeedSlow
            // 
            this.lblSpeedSlow.AutoSize = true;
            this.lblSpeedSlow.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblSpeedSlow.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSpeedSlow.Location = new System.Drawing.Point(54, 314);
            this.lblSpeedSlow.Name = "lblSpeedSlow";
            this.lblSpeedSlow.Size = new System.Drawing.Size(69, 23);
            this.lblSpeedSlow.TabIndex = 13;
            this.lblSpeedSlow.Text = "Slow : 0";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(36, 297);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(8, 181);
            this.bunifuSeparator1.TabIndex = 22;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator2.LineThickness = 2;
            this.bunifuSeparator2.Location = new System.Drawing.Point(187, 297);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(8, 181);
            this.bunifuSeparator2.TabIndex = 23;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator3.LineThickness = 2;
            this.bunifuSeparator3.Location = new System.Drawing.Point(332, 297);
            this.bunifuSeparator3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(8, 181);
            this.bunifuSeparator3.TabIndex = 24;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator4.LineThickness = 2;
            this.bunifuSeparator4.Location = new System.Drawing.Point(41, 341);
            this.bunifuSeparator4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator4.TabIndex = 25;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator5.LineThickness = 2;
            this.bunifuSeparator5.Location = new System.Drawing.Point(41, 400);
            this.bunifuSeparator5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator5.TabIndex = 26;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // bunifuSeparator6
            // 
            this.bunifuSeparator6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator6.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator6.LineThickness = 2;
            this.bunifuSeparator6.Location = new System.Drawing.Point(40, 277);
            this.bunifuSeparator6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator6.Name = "bunifuSeparator6";
            this.bunifuSeparator6.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator6.TabIndex = 27;
            this.bunifuSeparator6.Transparency = 255;
            this.bunifuSeparator6.Vertical = false;
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox1.BorderThickness = 2;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(128, 21);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(277, 52);
            this.bunifuMetroTextbox1.TabIndex = 28;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox2
            // 
            this.bunifuMetroTextbox2.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuMetroTextbox2.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox2.BorderThickness = 2;
            this.bunifuMetroTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuMetroTextbox2.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox2.isPassword = false;
            this.bunifuMetroTextbox2.Location = new System.Drawing.Point(128, 83);
            this.bunifuMetroTextbox2.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMetroTextbox2.Name = "bunifuMetroTextbox2";
            this.bunifuMetroTextbox2.Size = new System.Drawing.Size(277, 52);
            this.bunifuMetroTextbox2.TabIndex = 32;
            this.bunifuMetroTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMetroTextbox3
            // 
            this.bunifuMetroTextbox3.BorderColorFocused = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuMetroTextbox3.BorderColorMouseHover = System.Drawing.Color.Gray;
            this.bunifuMetroTextbox3.BorderThickness = 2;
            this.bunifuMetroTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuMetroTextbox3.ForeColor = System.Drawing.Color.Silver;
            this.bunifuMetroTextbox3.isPassword = false;
            this.bunifuMetroTextbox3.Location = new System.Drawing.Point(128, 145);
            this.bunifuMetroTextbox3.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuMetroTextbox3.Name = "bunifuMetroTextbox3";
            this.bunifuMetroTextbox3.Size = new System.Drawing.Size(277, 52);
            this.bunifuMetroTextbox3.TabIndex = 33;
            this.bunifuMetroTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "CALCULATE";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = false;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 50D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(40, 214);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(25)))), ((int)(((byte)(31)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(440, 63);
            this.bunifuFlatButton1.TabIndex = 34;
            this.bunifuFlatButton1.Text = "CALCULATE";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.SystemColors.Control;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuSeparator7
            // 
            this.bunifuSeparator7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator7.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator7.LineThickness = 2;
            this.bunifuSeparator7.Location = new System.Drawing.Point(39, 460);
            this.bunifuSeparator7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator7.Name = "bunifuSeparator7";
            this.bunifuSeparator7.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator7.TabIndex = 35;
            this.bunifuSeparator7.Transparency = 255;
            this.bunifuSeparator7.Vertical = false;
            // 
            // lblAngleUp
            // 
            this.lblAngleUp.AutoSize = true;
            this.lblAngleUp.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblAngleUp.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAngleUp.Location = new System.Drawing.Point(202, 314);
            this.lblAngleUp.Name = "lblAngleUp";
            this.lblAngleUp.Size = new System.Drawing.Size(55, 23);
            this.lblAngleUp.TabIndex = 19;
            this.lblAngleUp.Text = "Up : 0";
            // 
            // bunifuSeparator8
            // 
            this.bunifuSeparator8.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator8.LineThickness = 2;
            this.bunifuSeparator8.Location = new System.Drawing.Point(472, 297);
            this.bunifuSeparator8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator8.Name = "bunifuSeparator8";
            this.bunifuSeparator8.Size = new System.Drawing.Size(8, 181);
            this.bunifuSeparator8.TabIndex = 36;
            this.bunifuSeparator8.Transparency = 255;
            this.bunifuSeparator8.Vertical = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(63, 36);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(59, 23);
            this.bunifuCustomLabel1.TabIndex = 37;
            this.bunifuCustomLabel1.Text = "Speed";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(45, 98);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(77, 23);
            this.bunifuCustomLabel2.TabIndex = 38;
            this.bunifuCustomLabel2.Text = "Distance";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(68, 160);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(54, 23);
            this.bunifuCustomLabel3.TabIndex = 39;
            this.bunifuCustomLabel3.Text = "Angle";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(15)))), ((int)(((byte)(21)))));
            this.panel1.Controls.Add(this.bunifuProgressBar1);
            this.panel1.Controls.Add(this.bunifuSeparator9);
            this.panel1.Controls.Add(this.bunifuSeparator10);
            this.panel1.Controls.Add(this.bunifuSeparator11);
            this.panel1.Controls.Add(this.bunifuSeparator12);
            this.panel1.Controls.Add(this.lblBrakeMed);
            this.panel1.Controls.Add(this.lblBrakeStrong);
            this.panel1.Controls.Add(this.lblBrakeWeak);
            this.panel1.Controls.Add(this.bunifuSeparator13);
            this.panel1.Controls.Add(this.bunifuSeparator14);
            this.panel1.Controls.Add(this.lblCOG);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuSeparator8);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuMetroTextbox3);
            this.panel1.Controls.Add(this.bunifuMetroTextbox2);
            this.panel1.Controls.Add(this.bunifuMetroTextbox1);
            this.panel1.Controls.Add(this.bunifuSeparator3);
            this.panel1.Controls.Add(this.bunifuSeparator2);
            this.panel1.Controls.Add(this.bunifuSeparator1);
            this.panel1.Controls.Add(this.lblAngleDown);
            this.panel1.Controls.Add(this.lblAngleFlat);
            this.panel1.Controls.Add(this.lblAngleUp);
            this.panel1.Controls.Add(this.lblDistanceTooFar);
            this.panel1.Controls.Add(this.lblDistanceFar);
            this.panel1.Controls.Add(this.lblDistanceNear);
            this.panel1.Controls.Add(this.lblSpeedFast);
            this.panel1.Controls.Add(this.lblSpeedMedium);
            this.panel1.Controls.Add(this.lblSpeedSlow);
            this.panel1.Controls.Add(this.bunifuSeparator4);
            this.panel1.Controls.Add(this.bunifuSeparator5);
            this.panel1.Controls.Add(this.bunifuSeparator6);
            this.panel1.Controls.Add(this.bunifuSeparator7);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 640);
            this.panel1.TabIndex = 45;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuProgressBar1.BorderRadius = 0;
            this.bunifuProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(0, 628);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar1.MaximumValue = 10;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(119)))), ((int)(((byte)(215)))));
            this.bunifuProgressBar1.Size = new System.Drawing.Size(532, 12);
            this.bunifuProgressBar1.TabIndex = 53;
            this.bunifuProgressBar1.Value = 0;
            // 
            // bunifuSeparator9
            // 
            this.bunifuSeparator9.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator9.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator9.LineThickness = 2;
            this.bunifuSeparator9.Location = new System.Drawing.Point(473, 506);
            this.bunifuSeparator9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator9.Name = "bunifuSeparator9";
            this.bunifuSeparator9.Size = new System.Drawing.Size(8, 62);
            this.bunifuSeparator9.TabIndex = 52;
            this.bunifuSeparator9.Transparency = 255;
            this.bunifuSeparator9.Vertical = true;
            // 
            // bunifuSeparator10
            // 
            this.bunifuSeparator10.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator10.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator10.LineThickness = 2;
            this.bunifuSeparator10.Location = new System.Drawing.Point(332, 506);
            this.bunifuSeparator10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator10.Name = "bunifuSeparator10";
            this.bunifuSeparator10.Size = new System.Drawing.Size(8, 62);
            this.bunifuSeparator10.TabIndex = 49;
            this.bunifuSeparator10.Transparency = 255;
            this.bunifuSeparator10.Vertical = true;
            // 
            // bunifuSeparator11
            // 
            this.bunifuSeparator11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator11.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator11.LineThickness = 2;
            this.bunifuSeparator11.Location = new System.Drawing.Point(187, 506);
            this.bunifuSeparator11.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator11.Name = "bunifuSeparator11";
            this.bunifuSeparator11.Size = new System.Drawing.Size(8, 62);
            this.bunifuSeparator11.TabIndex = 48;
            this.bunifuSeparator11.Transparency = 255;
            this.bunifuSeparator11.Vertical = true;
            // 
            // bunifuSeparator12
            // 
            this.bunifuSeparator12.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator12.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator12.LineThickness = 2;
            this.bunifuSeparator12.Location = new System.Drawing.Point(35, 506);
            this.bunifuSeparator12.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator12.Name = "bunifuSeparator12";
            this.bunifuSeparator12.Size = new System.Drawing.Size(8, 62);
            this.bunifuSeparator12.TabIndex = 47;
            this.bunifuSeparator12.Transparency = 255;
            this.bunifuSeparator12.Vertical = true;
            // 
            // lblBrakeMed
            // 
            this.lblBrakeMed.AutoSize = true;
            this.lblBrakeMed.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblBrakeMed.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrakeMed.Location = new System.Drawing.Point(202, 523);
            this.lblBrakeMed.Name = "lblBrakeMed";
            this.lblBrakeMed.Size = new System.Drawing.Size(68, 23);
            this.lblBrakeMed.TabIndex = 46;
            this.lblBrakeMed.Text = "Med : 0";
            // 
            // lblBrakeStrong
            // 
            this.lblBrakeStrong.AutoSize = true;
            this.lblBrakeStrong.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblBrakeStrong.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrakeStrong.Location = new System.Drawing.Point(347, 523);
            this.lblBrakeStrong.Name = "lblBrakeStrong";
            this.lblBrakeStrong.Size = new System.Drawing.Size(84, 23);
            this.lblBrakeStrong.TabIndex = 45;
            this.lblBrakeStrong.Text = "Strong : 0";
            // 
            // lblBrakeWeak
            // 
            this.lblBrakeWeak.AutoSize = true;
            this.lblBrakeWeak.Font = new System.Drawing.Font("Open Sans", 10F);
            this.lblBrakeWeak.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBrakeWeak.Location = new System.Drawing.Point(54, 523);
            this.lblBrakeWeak.Name = "lblBrakeWeak";
            this.lblBrakeWeak.Size = new System.Drawing.Size(77, 23);
            this.lblBrakeWeak.TabIndex = 44;
            this.lblBrakeWeak.Text = "Weak : 0";
            // 
            // bunifuSeparator13
            // 
            this.bunifuSeparator13.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator13.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator13.LineThickness = 2;
            this.bunifuSeparator13.Location = new System.Drawing.Point(39, 550);
            this.bunifuSeparator13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator13.Name = "bunifuSeparator13";
            this.bunifuSeparator13.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator13.TabIndex = 50;
            this.bunifuSeparator13.Transparency = 255;
            this.bunifuSeparator13.Vertical = false;
            // 
            // bunifuSeparator14
            // 
            this.bunifuSeparator14.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator14.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(61)))), ((int)(((byte)(74)))));
            this.bunifuSeparator14.LineThickness = 2;
            this.bunifuSeparator14.Location = new System.Drawing.Point(39, 486);
            this.bunifuSeparator14.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuSeparator14.Name = "bunifuSeparator14";
            this.bunifuSeparator14.Size = new System.Drawing.Size(439, 37);
            this.bunifuSeparator14.TabIndex = 51;
            this.bunifuSeparator14.Transparency = 255;
            this.bunifuSeparator14.Vertical = false;
            // 
            // lblCOG
            // 
            this.lblCOG.AutoSize = true;
            this.lblCOG.Font = new System.Drawing.Font("Open Sans", 11F);
            this.lblCOG.ForeColor = System.Drawing.Color.White;
            this.lblCOG.Location = new System.Drawing.Point(171, 588);
            this.lblCOG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCOG.Name = "lblCOG";
            this.lblCOG.Size = new System.Drawing.Size(141, 26);
            this.lblCOG.TabIndex = 43;
            this.lblCOG.Text = "COG Brake :  0";
            this.lblCOG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(421, 160);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(17, 23);
            this.bunifuCustomLabel6.TabIndex = 42;
            this.bunifuCustomLabel6.Text = "°";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(421, 98);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(59, 23);
            this.bunifuCustomLabel5.TabIndex = 41;
            this.bunifuCustomLabel5.Text = "meter";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Open Sans", 10F);
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(421, 36);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(59, 23);
            this.bunifuCustomLabel4.TabIndex = 40;
            this.bunifuCustomLabel4.Text = "km / h";
            // 
            // Manual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(520, 690);
            this.Controls.Add(this.header);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manual";
            this.Text = "FuzzyExplain";
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuElipse bunifuElipse2;
        private ns1.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel header;
        private ns1.BunifuCustomLabel lblLogoText;
        private ns1.BunifuCustomLabel lblname;
        private ns1.BunifuDragControl bunifuDragControl1;
        private ns1.BunifuDragControl bunifuDragControl2;
        private ns1.BunifuSeparator bunifuSeparator3;
        private ns1.BunifuSeparator bunifuSeparator2;
        private ns1.BunifuSeparator bunifuSeparator1;
        private ns1.BunifuCustomLabel lblAngleDown;
        private ns1.BunifuCustomLabel lblAngleFlat;
        private ns1.BunifuCustomLabel lblDistanceTooFar;
        private ns1.BunifuCustomLabel lblDistanceFar;
        private ns1.BunifuCustomLabel lblDistanceNear;
        private ns1.BunifuCustomLabel lblSpeedFast;
        private ns1.BunifuCustomLabel lblSpeedMedium;
        private ns1.BunifuCustomLabel lblSpeedSlow;
        private ns1.BunifuSeparator bunifuSeparator4;
        private ns1.BunifuSeparator bunifuSeparator5;
        private ns1.BunifuSeparator bunifuSeparator6;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox1;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox3;
        private ns1.BunifuMetroTextbox bunifuMetroTextbox2;
        private ns1.BunifuSeparator bunifuSeparator7;
        private ns1.BunifuSeparator bunifuSeparator8;
        private ns1.BunifuCustomLabel lblAngleUp;
        private ns1.BunifuCustomLabel bunifuCustomLabel3;
        private ns1.BunifuCustomLabel bunifuCustomLabel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel lblCOG;
        private ns1.BunifuSeparator bunifuSeparator9;
        private ns1.BunifuSeparator bunifuSeparator10;
        private ns1.BunifuSeparator bunifuSeparator11;
        private ns1.BunifuSeparator bunifuSeparator12;
        private ns1.BunifuCustomLabel lblBrakeMed;
        private ns1.BunifuCustomLabel lblBrakeStrong;
        private ns1.BunifuCustomLabel lblBrakeWeak;
        private ns1.BunifuSeparator bunifuSeparator13;
        private ns1.BunifuSeparator bunifuSeparator14;
        private ns1.BunifuProgressBar bunifuProgressBar1;
        private ns1.BunifuCustomLabel bunifuCustomLabel6;
        private ns1.BunifuCustomLabel bunifuCustomLabel5;
        private ns1.BunifuCustomLabel bunifuCustomLabel4;
    }
}