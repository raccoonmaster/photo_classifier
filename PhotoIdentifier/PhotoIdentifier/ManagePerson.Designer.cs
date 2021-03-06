﻿namespace PhotoIdentifier {
    partial class ManagePerson {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePerson));
            this.TSSL_infos = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_validate = new System.Windows.Forms.Button();
            this.CB_name = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.x200ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x150ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x120ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x96ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x48ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSDDB_size = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_clear = new System.Windows.Forms.ToolStripButton();
            this.TSB_remove = new System.Windows.Forms.ToolStripButton();
            this.TSB_add = new System.Windows.Forms.ToolStripButton();
            this.SS_infos = new System.Windows.Forms.StatusStrip();
            this.TS_action = new System.Windows.Forms.ToolStrip();
            this.ILV_photos = new Manina.Windows.Forms.ImageListView();
            this.groupBox1.SuspendLayout();
            this.SS_infos.SuspendLayout();
            this.TS_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // TSSL_infos
            // 
            this.TSSL_infos.Name = "TSSL_infos";
            this.TSSL_infos.Size = new System.Drawing.Size(79, 20);
            this.TSSL_infos.Text = "No photos";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BT_validate);
            this.groupBox1.Controls.Add(this.CB_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(733, 65);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit person";
            // 
            // BT_validate
            // 
            this.BT_validate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_validate.Location = new System.Drawing.Point(416, 21);
            this.BT_validate.Margin = new System.Windows.Forms.Padding(4);
            this.BT_validate.Name = "BT_validate";
            this.BT_validate.Size = new System.Drawing.Size(129, 28);
            this.BT_validate.TabIndex = 10;
            this.BT_validate.Text = "Validate changes";
            this.BT_validate.UseVisualStyleBackColor = true;
            this.BT_validate.Click += new System.EventHandler(this.BT_validate_Click);
            // 
            // CB_name
            // 
            this.CB_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CB_name.FormattingEnabled = true;
            this.CB_name.Location = new System.Drawing.Point(247, 23);
            this.CB_name.Margin = new System.Windows.Forms.Padding(4);
            this.CB_name.Name = "CB_name";
            this.CB_name.Size = new System.Drawing.Size(160, 24);
            this.CB_name.TabIndex = 9;
            this.CB_name.Text = "Select name";
            this.CB_name.SelectedIndexChanged += new System.EventHandler(this.CB_name_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // x200ToolStripMenuItem
            // 
            this.x200ToolStripMenuItem.Name = "x200ToolStripMenuItem";
            this.x200ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.x200ToolStripMenuItem.Text = "200 x 200";
            this.x200ToolStripMenuItem.Click += new System.EventHandler(this.x200ToolStripMenuItem_Click);
            // 
            // x150ToolStripMenuItem
            // 
            this.x150ToolStripMenuItem.Name = "x150ToolStripMenuItem";
            this.x150ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.x150ToolStripMenuItem.Text = "150 x 150";
            this.x150ToolStripMenuItem.Click += new System.EventHandler(this.x150ToolStripMenuItem_Click);
            // 
            // x120ToolStripMenuItem
            // 
            this.x120ToolStripMenuItem.Name = "x120ToolStripMenuItem";
            this.x120ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.x120ToolStripMenuItem.Text = "120 x 120";
            this.x120ToolStripMenuItem.Click += new System.EventHandler(this.x120ToolStripMenuItem_Click);
            // 
            // x96ToolStripMenuItem
            // 
            this.x96ToolStripMenuItem.Name = "x96ToolStripMenuItem";
            this.x96ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.x96ToolStripMenuItem.Text = "96 x 96";
            this.x96ToolStripMenuItem.Click += new System.EventHandler(this.x96ToolStripMenuItem_Click);
            // 
            // x48ToolStripMenuItem
            // 
            this.x48ToolStripMenuItem.Name = "x48ToolStripMenuItem";
            this.x48ToolStripMenuItem.Size = new System.Drawing.Size(147, 26);
            this.x48ToolStripMenuItem.Text = "48 x 48";
            this.x48ToolStripMenuItem.Click += new System.EventHandler(this.x48ToolStripMenuItem_Click);
            // 
            // TSDDB_size
            // 
            this.TSDDB_size.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSDDB_size.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x48ToolStripMenuItem,
            this.x96ToolStripMenuItem,
            this.x120ToolStripMenuItem,
            this.x150ToolStripMenuItem,
            this.x200ToolStripMenuItem});
            this.TSDDB_size.Image = ((System.Drawing.Image)(resources.GetObject("TSDDB_size.Image")));
            this.TSDDB_size.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSDDB_size.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSDDB_size.Name = "TSDDB_size";
            this.TSDDB_size.Size = new System.Drawing.Size(38, 28);
            this.TSDDB_size.Text = "Photos size";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // TSB_clear
            // 
            this.TSB_clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_clear.Enabled = false;
            this.TSB_clear.Image = ((System.Drawing.Image)(resources.GetObject("TSB_clear.Image")));
            this.TSB_clear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_clear.Name = "TSB_clear";
            this.TSB_clear.Size = new System.Drawing.Size(28, 28);
            this.TSB_clear.Text = "Remove all photos";
            this.TSB_clear.Click += new System.EventHandler(this.TSB_clear_Click);
            // 
            // TSB_remove
            // 
            this.TSB_remove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_remove.Enabled = false;
            this.TSB_remove.Image = ((System.Drawing.Image)(resources.GetObject("TSB_remove.Image")));
            this.TSB_remove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_remove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_remove.Name = "TSB_remove";
            this.TSB_remove.Size = new System.Drawing.Size(28, 28);
            this.TSB_remove.Text = "Remove selected photos";
            this.TSB_remove.Click += new System.EventHandler(this.TSB_remove_Click);
            // 
            // TSB_add
            // 
            this.TSB_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_add.Image = ((System.Drawing.Image)(resources.GetObject("TSB_add.Image")));
            this.TSB_add.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSB_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_add.Name = "TSB_add";
            this.TSB_add.Size = new System.Drawing.Size(28, 28);
            this.TSB_add.Text = "Add photos";
            this.TSB_add.Click += new System.EventHandler(this.TSB_add_Click);
            // 
            // SS_infos
            // 
            this.SS_infos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SS_infos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_infos});
            this.SS_infos.Location = new System.Drawing.Point(0, 427);
            this.SS_infos.Name = "SS_infos";
            this.SS_infos.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.SS_infos.Size = new System.Drawing.Size(765, 25);
            this.SS_infos.TabIndex = 15;
            // 
            // TS_action
            // 
            this.TS_action.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TS_action.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TS_action.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_add,
            this.TSB_remove,
            this.TSB_clear,
            this.toolStripSeparator1,
            this.TSDDB_size});
            this.TS_action.Location = new System.Drawing.Point(0, 0);
            this.TS_action.Name = "TS_action";
            this.TS_action.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TS_action.Size = new System.Drawing.Size(765, 31);
            this.TS_action.TabIndex = 13;
            // 
            // ILV_photos
            // 
            this.ILV_photos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ILV_photos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ILV_photos.DefaultImage = ((System.Drawing.Image)(resources.GetObject("ILV_photos.DefaultImage")));
            this.ILV_photos.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ILV_photos.ErrorImage")));
            this.ILV_photos.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ILV_photos.Location = new System.Drawing.Point(-1, 111);
            this.ILV_photos.Margin = new System.Windows.Forms.Padding(4);
            this.ILV_photos.Name = "ILV_photos";
            this.ILV_photos.Size = new System.Drawing.Size(767, 313);
            this.ILV_photos.TabIndex = 12;
            this.ILV_photos.Text = "";
            // 
            // ManagePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 452);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SS_infos);
            this.Controls.Add(this.TS_action);
            this.Controls.Add(this.ILV_photos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(781, 488);
            this.Name = "ManagePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PI - Manage person";
            this.Load += new System.EventHandler(this.ManagePerson_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.SS_infos.ResumeLayout(false);
            this.SS_infos.PerformLayout();
            this.TS_action.ResumeLayout(false);
            this.TS_action.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripStatusLabel TSSL_infos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CB_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem x200ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x150ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x120ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x96ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x48ToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton TSDDB_size;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton TSB_clear;
        private System.Windows.Forms.ToolStripButton TSB_remove;
        private System.Windows.Forms.ToolStripButton TSB_add;
        private System.Windows.Forms.StatusStrip SS_infos;
        private System.Windows.Forms.ToolStrip TS_action;
        private Manina.Windows.Forms.ImageListView ILV_photos;
        private System.Windows.Forms.Button BT_validate;
    }
}