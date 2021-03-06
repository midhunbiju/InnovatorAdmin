﻿namespace InnovatorAdmin
{
  partial class ConnectionEditor
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
      this.lblDatabase = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.lblUser = new System.Windows.Forms.Label();
      this.lblUrl = new System.Windows.Forms.Label();
      this.lblName = new System.Windows.Forms.Label();
      this.toolTipManager = new System.Windows.Forms.ToolTip(this.components);
      this.btnMoveDown = new InnovatorAdmin.Controls.FlatButton();
      this.btnNew = new InnovatorAdmin.Controls.FlatButton();
      this.btnMoveUp = new InnovatorAdmin.Controls.FlatButton();
      this.btnCopy = new InnovatorAdmin.Controls.FlatButton();
      this.btnDelete = new InnovatorAdmin.Controls.FlatButton();
      this.tlpControls = new System.Windows.Forms.TableLayoutPanel();
      this.lstConnections = new InnovatorAdmin.MultiselectListBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
      this.chkPassword = new System.Windows.Forms.CheckBox();
      this.chkWindows = new System.Windows.Forms.CheckBox();
      this.chkAnonymous = new System.Windows.Forms.CheckBox();
      this.txtUrl = new InnovatorAdmin.Controls.PlaceholderTextBox();
      this.txtName = new InnovatorAdmin.Controls.PlaceholderTextBox();
      this.txtUser = new InnovatorAdmin.Controls.PlaceholderTextBox();
      this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
      this.exploreButton = new InnovatorAdmin.Controls.FlatButton();
      this.btnAdvanced = new InnovatorAdmin.Controls.FlatButton();
      this.btnTest = new InnovatorAdmin.Controls.FlatButton();
      this.txtPassword = new InnovatorAdmin.Controls.PlaceholderTextBox();
      this.lblType = new System.Windows.Forms.Label();
      this.cmbType = new System.Windows.Forms.ComboBox();
      this.cmbDatabase = new System.Windows.Forms.ComboBox();
      this.btnColor = new System.Windows.Forms.Button();
      this.tlpControls.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.flowLayoutPanel2.SuspendLayout();
      this.flowLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblDatabase
      // 
      this.lblDatabase.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblDatabase.AutoSize = true;
      this.lblDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblDatabase.Location = new System.Drawing.Point(3, 141);
      this.lblDatabase.Name = "lblDatabase";
      this.lblDatabase.Size = new System.Drawing.Size(56, 13);
      this.lblDatabase.TabIndex = 26;
      this.lblDatabase.Text = "Database:";
      this.lblDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblPassword
      // 
      this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblPassword.AutoSize = true;
      this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblPassword.Location = new System.Drawing.Point(3, 114);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(56, 13);
      this.lblPassword.TabIndex = 24;
      this.lblPassword.Text = "Password:";
      // 
      // lblUser
      // 
      this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblUser.AutoSize = true;
      this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblUser.Location = new System.Drawing.Point(27, 88);
      this.lblUser.Name = "lblUser";
      this.lblUser.Size = new System.Drawing.Size(32, 13);
      this.lblUser.TabIndex = 22;
      this.lblUser.Text = "User:";
      this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblUrl
      // 
      this.lblUrl.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblUrl.AutoSize = true;
      this.lblUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblUrl.Location = new System.Drawing.Point(27, 6);
      this.lblUrl.Name = "lblUrl";
      this.lblUrl.Size = new System.Drawing.Size(32, 13);
      this.lblUrl.TabIndex = 20;
      this.lblUrl.Text = "URL:";
      this.lblUrl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // lblName
      // 
      this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblName.AutoSize = true;
      this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblName.Location = new System.Drawing.Point(21, 189);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(38, 13);
      this.lblName.TabIndex = 32;
      this.lblName.Text = "Name:";
      this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // btnMoveDown
      // 
      this.btnMoveDown.AutoSize = true;
      this.btnMoveDown.BackColor = System.Drawing.Color.White;
      this.btnMoveDown.FlatAppearance.BorderSize = 0;
      this.btnMoveDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnMoveDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMoveDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnMoveDown.ForeColor = System.Drawing.Color.Black;
      this.btnMoveDown.Location = new System.Drawing.Point(187, 272);
      this.btnMoveDown.Margin = new System.Windows.Forms.Padding(2);
      this.btnMoveDown.Name = "btnMoveDown";
      this.btnMoveDown.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnMoveDown.Padding = new System.Windows.Forms.Padding(1);
      this.btnMoveDown.Size = new System.Drawing.Size(30, 30);
      this.btnMoveDown.TabIndex = 11;
      this.btnMoveDown.TabStop = false;
      this.btnMoveDown.Theme = InnovatorAdmin.Controls.FlatButtonTheme.Icon;
      this.toolTipManager.SetToolTip(this.btnMoveDown, "Move Down");
      this.btnMoveDown.UseVisualStyleBackColor = false;
      this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
      // 
      // btnNew
      // 
      this.btnNew.AutoSize = true;
      this.btnNew.BackColor = System.Drawing.Color.White;
      this.btnNew.FlatAppearance.BorderSize = 0;
      this.btnNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnNew.ForeColor = System.Drawing.Color.Black;
      this.btnNew.Location = new System.Drawing.Point(2, 272);
      this.btnNew.Margin = new System.Windows.Forms.Padding(2);
      this.btnNew.Name = "btnNew";
      this.btnNew.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnNew.Padding = new System.Windows.Forms.Padding(1);
      this.btnNew.Size = new System.Drawing.Size(30, 30);
      this.btnNew.TabIndex = 7;
      this.btnNew.TabStop = false;
      this.btnNew.Theme = InnovatorAdmin.Controls.FlatButtonTheme.Icon;
      this.toolTipManager.SetToolTip(this.btnNew, "Add New");
      this.btnNew.UseVisualStyleBackColor = false;
      this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
      // 
      // btnMoveUp
      // 
      this.btnMoveUp.AutoSize = true;
      this.btnMoveUp.BackColor = System.Drawing.Color.White;
      this.btnMoveUp.FlatAppearance.BorderSize = 0;
      this.btnMoveUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnMoveUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMoveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnMoveUp.ForeColor = System.Drawing.Color.Black;
      this.btnMoveUp.Location = new System.Drawing.Point(153, 272);
      this.btnMoveUp.Margin = new System.Windows.Forms.Padding(2);
      this.btnMoveUp.Name = "btnMoveUp";
      this.btnMoveUp.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnMoveUp.Padding = new System.Windows.Forms.Padding(1);
      this.btnMoveUp.Size = new System.Drawing.Size(30, 30);
      this.btnMoveUp.TabIndex = 10;
      this.btnMoveUp.TabStop = false;
      this.btnMoveUp.Theme = InnovatorAdmin.Controls.FlatButtonTheme.Icon;
      this.toolTipManager.SetToolTip(this.btnMoveUp, "Move Up");
      this.btnMoveUp.UseVisualStyleBackColor = false;
      this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
      // 
      // btnCopy
      // 
      this.btnCopy.AutoSize = true;
      this.btnCopy.BackColor = System.Drawing.Color.White;
      this.btnCopy.FlatAppearance.BorderSize = 0;
      this.btnCopy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnCopy.ForeColor = System.Drawing.Color.Black;
      this.btnCopy.Location = new System.Drawing.Point(36, 272);
      this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnCopy.Padding = new System.Windows.Forms.Padding(1);
      this.btnCopy.Size = new System.Drawing.Size(30, 30);
      this.btnCopy.TabIndex = 8;
      this.btnCopy.TabStop = false;
      this.btnCopy.Theme = InnovatorAdmin.Controls.FlatButtonTheme.Icon;
      this.toolTipManager.SetToolTip(this.btnCopy, "Duplicate");
      this.btnCopy.UseVisualStyleBackColor = false;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.AutoSize = true;
      this.btnDelete.BackColor = System.Drawing.Color.White;
      this.btnDelete.FlatAppearance.BorderSize = 0;
      this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnDelete.ForeColor = System.Drawing.Color.Black;
      this.btnDelete.Location = new System.Drawing.Point(70, 272);
      this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnDelete.Padding = new System.Windows.Forms.Padding(1);
      this.btnDelete.Size = new System.Drawing.Size(30, 30);
      this.btnDelete.TabIndex = 9;
      this.btnDelete.TabStop = false;
      this.btnDelete.Theme = InnovatorAdmin.Controls.FlatButtonTheme.Icon;
      this.toolTipManager.SetToolTip(this.btnDelete, "Delete");
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // tlpControls
      // 
      this.tlpControls.BackColor = System.Drawing.Color.White;
      this.tlpControls.ColumnCount = 8;
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
      this.tlpControls.Controls.Add(this.lstConnections, 0, 0);
      this.tlpControls.Controls.Add(this.btnMoveDown, 5, 1);
      this.tlpControls.Controls.Add(this.btnNew, 0, 1);
      this.tlpControls.Controls.Add(this.btnMoveUp, 4, 1);
      this.tlpControls.Controls.Add(this.btnCopy, 1, 1);
      this.tlpControls.Controls.Add(this.btnDelete, 2, 1);
      this.tlpControls.Controls.Add(this.panel1, 6, 0);
      this.tlpControls.Controls.Add(this.tableLayoutPanel1, 7, 0);
      this.tlpControls.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpControls.Location = new System.Drawing.Point(0, 0);
      this.tlpControls.Name = "tlpControls";
      this.tlpControls.RowCount = 2;
      this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpControls.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tlpControls.Size = new System.Drawing.Size(688, 304);
      this.tlpControls.TabIndex = 41;
      // 
      // lstConnections
      // 
      this.lstConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tlpControls.SetColumnSpan(this.lstConnections, 6);
      this.lstConnections.DataSource = null;
      this.lstConnections.DisplayMember = "";
      this.lstConnections.Location = new System.Drawing.Point(4, 4);
      this.lstConnections.Margin = new System.Windows.Forms.Padding(4);
      this.lstConnections.Multiselect = false;
      this.lstConnections.Name = "lstConnections";
      this.lstConnections.Size = new System.Drawing.Size(211, 262);
      this.lstConnections.TabIndex = 0;
      this.lstConnections.ValueMember = "";
      this.lstConnections.SelectionChanged += new System.EventHandler(this.lstConnections_SelectionChanged);
      this.lstConnections.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstConnections_MouseDoubleClick);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
      this.panel1.Location = new System.Drawing.Point(228, 3);
      this.panel1.Name = "panel1";
      this.tlpControls.SetRowSpan(this.panel1, 2);
      this.panel1.Size = new System.Drawing.Size(1, 298);
      this.panel1.TabIndex = 46;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.ColumnCount = 3;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.txtUrl, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 7);
      this.tableLayoutPanel1.Controls.Add(this.lblUrl, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblUser, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.txtUser, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 8);
      this.tableLayoutPanel1.Controls.Add(this.lblPassword, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.cmbType, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblDatabase, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.cmbDatabase, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.btnColor, 2, 7);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(239, 0);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 9;
      this.tlpControls.SetRowSpan(this.tableLayoutPanel1, 2);
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(449, 304);
      this.tableLayoutPanel1.TabIndex = 47;
      // 
      // flowLayoutPanel2
      // 
      this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel2.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel2, 2);
      this.flowLayoutPanel2.Controls.Add(this.chkPassword);
      this.flowLayoutPanel2.Controls.Add(this.chkWindows);
      this.flowLayoutPanel2.Controls.Add(this.chkAnonymous);
      this.flowLayoutPanel2.Location = new System.Drawing.Point(62, 53);
      this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel2.Name = "flowLayoutPanel2";
      this.flowLayoutPanel2.Size = new System.Drawing.Size(387, 29);
      this.flowLayoutPanel2.TabIndex = 0;
      // 
      // chkPassword
      // 
      this.chkPassword.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkPassword.AutoSize = true;
      this.chkPassword.Checked = true;
      this.chkPassword.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkPassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.chkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkPassword.Location = new System.Drawing.Point(3, 3);
      this.chkPassword.Name = "chkPassword";
      this.chkPassword.Size = new System.Drawing.Size(114, 23);
      this.chkPassword.TabIndex = 0;
      this.chkPassword.Text = "Login with Password";
      this.chkPassword.UseVisualStyleBackColor = true;
      this.chkPassword.CheckedChanged += new System.EventHandler(this.chkPassword_CheckedChanged);
      // 
      // chkWindows
      // 
      this.chkWindows.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkWindows.AutoSize = true;
      this.chkWindows.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkWindows.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkWindows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.chkWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkWindows.Location = new System.Drawing.Point(123, 3);
      this.chkWindows.Name = "chkWindows";
      this.chkWindows.Size = new System.Drawing.Size(112, 23);
      this.chkWindows.TabIndex = 1;
      this.chkWindows.Text = "Login with Windows";
      this.chkWindows.UseVisualStyleBackColor = true;
      this.chkWindows.CheckedChanged += new System.EventHandler(this.chkWindows_CheckedChanged);
      // 
      // chkAnonymous
      // 
      this.chkAnonymous.Appearance = System.Windows.Forms.Appearance.Button;
      this.chkAnonymous.AutoSize = true;
      this.chkAnonymous.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkAnonymous.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.chkAnonymous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.chkAnonymous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.chkAnonymous.Location = new System.Drawing.Point(241, 3);
      this.chkAnonymous.Name = "chkAnonymous";
      this.chkAnonymous.Size = new System.Drawing.Size(108, 23);
      this.chkAnonymous.TabIndex = 2;
      this.chkAnonymous.Text = "Login Anonymously";
      this.chkAnonymous.UseVisualStyleBackColor = true;
      this.chkAnonymous.CheckedChanged += new System.EventHandler(this.chkAnonymous_CheckedChanged);
      // 
      // txtUrl
      // 
      this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.txtUrl, 2);
      this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUrl.Location = new System.Drawing.Point(65, 3);
      this.txtUrl.MinimumSize = new System.Drawing.Size(4, 22);
      this.txtUrl.Name = "txtUrl";
      this.txtUrl.PlaceholderText = "Address / URL";
      this.txtUrl.Size = new System.Drawing.Size(381, 20);
      this.txtUrl.TabIndex = 3;
      // 
      // txtName
      // 
      this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtName.Location = new System.Drawing.Point(65, 184);
      this.txtName.MinimumSize = new System.Drawing.Size(4, 22);
      this.txtName.Name = "txtName";
      this.txtName.PlaceholderText = "Connection Name";
      this.txtName.Size = new System.Drawing.Size(348, 22);
      this.txtName.TabIndex = 1;
      this.txtName.Validated += new System.EventHandler(this.txtName_Validated);
      // 
      // txtUser
      // 
      this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.txtUser, 2);
      this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtUser.Location = new System.Drawing.Point(65, 85);
      this.txtUser.MaxLength = 32;
      this.txtUser.MinimumSize = new System.Drawing.Size(4, 22);
      this.txtUser.Name = "txtUser";
      this.txtUser.PlaceholderText = "User name";
      this.txtUser.Size = new System.Drawing.Size(381, 22);
      this.txtUser.TabIndex = 6;
      // 
      // flowLayoutPanel1
      // 
      this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.flowLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
      this.flowLayoutPanel1.Controls.Add(this.exploreButton);
      this.flowLayoutPanel1.Controls.Add(this.btnAdvanced);
      this.flowLayoutPanel1.Controls.Add(this.btnTest);
      this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
      this.flowLayoutPanel1.Location = new System.Drawing.Point(141, 210);
      this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
      this.flowLayoutPanel1.Name = "flowLayoutPanel1";
      this.flowLayoutPanel1.Size = new System.Drawing.Size(308, 42);
      this.flowLayoutPanel1.TabIndex = 45;
      // 
      // exploreButton
      // 
      this.exploreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.exploreButton.AutoSize = true;
      this.exploreButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.exploreButton.FlatAppearance.BorderSize = 0;
      this.exploreButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.exploreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.exploreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.exploreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.exploreButton.ForeColor = System.Drawing.Color.Black;
      this.exploreButton.Location = new System.Drawing.Point(205, 3);
      this.exploreButton.Name = "exploreButton";
      this.exploreButton.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.exploreButton.Padding = new System.Windows.Forms.Padding(2);
      this.exploreButton.Size = new System.Drawing.Size(100, 36);
      this.exploreButton.TabIndex = 1;
      this.exploreButton.Text = "E&xplore";
      this.exploreButton.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.exploreButton.UseVisualStyleBackColor = false;
      this.exploreButton.Click += new System.EventHandler(this.exploreButton_Click);
      // 
      // btnAdvanced
      // 
      this.btnAdvanced.AutoSize = true;
      this.btnAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnAdvanced.FlatAppearance.BorderSize = 0;
      this.btnAdvanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnAdvanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnAdvanced.ForeColor = System.Drawing.Color.Black;
      this.btnAdvanced.Location = new System.Drawing.Point(76, 3);
      this.btnAdvanced.Name = "btnAdvanced";
      this.btnAdvanced.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnAdvanced.Padding = new System.Windows.Forms.Padding(2);
      this.btnAdvanced.Size = new System.Drawing.Size(123, 36);
      this.btnAdvanced.TabIndex = 2;
      this.btnAdvanced.Text = "&Advanced";
      this.btnAdvanced.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnAdvanced.UseVisualStyleBackColor = false;
      this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
      // 
      // btnTest
      // 
      this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTest.AutoSize = true;
      this.btnTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
      this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
      this.btnTest.ForeColor = System.Drawing.Color.Black;
      this.btnTest.Location = new System.Drawing.Point(3, 3);
      this.btnTest.MaximumSize = new System.Drawing.Size(300, 0);
      this.btnTest.MinimumSize = new System.Drawing.Size(0, 31);
      this.btnTest.Name = "btnTest";
      this.btnTest.Orientation = System.Windows.Forms.Orientation.Horizontal;
      this.btnTest.Padding = new System.Windows.Forms.Padding(2);
      this.btnTest.Size = new System.Drawing.Size(67, 31);
      this.btnTest.TabIndex = 0;
      this.btnTest.Text = "&Test";
      this.btnTest.Theme = InnovatorAdmin.Controls.FlatButtonTheme.LightGray;
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.txtPassword, 2);
      this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtPassword.Location = new System.Drawing.Point(65, 111);
      this.txtPassword.MaxLength = 64;
      this.txtPassword.MinimumSize = new System.Drawing.Size(4, 22);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.PlaceholderText = "Password";
      this.txtPassword.Size = new System.Drawing.Size(381, 22);
      this.txtPassword.TabIndex = 7;
      this.txtPassword.WordWrap = false;
      // 
      // lblType
      // 
      this.lblType.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.lblType.AutoSize = true;
      this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.lblType.Location = new System.Drawing.Point(25, 33);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(34, 13);
      this.lblType.TabIndex = 43;
      this.lblType.Text = "Type:";
      // 
      // cmbType
      // 
      this.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.cmbType, 2);
      this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbType.FormattingEnabled = true;
      this.cmbType.Location = new System.Drawing.Point(65, 29);
      this.cmbType.Name = "cmbType";
      this.cmbType.Size = new System.Drawing.Size(381, 21);
      this.cmbType.TabIndex = 8;
      // 
      // cmbDatabase
      // 
      this.cmbDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.tableLayoutPanel1.SetColumnSpan(this.cmbDatabase, 2);
      this.cmbDatabase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbDatabase.FormattingEnabled = true;
      this.cmbDatabase.Location = new System.Drawing.Point(65, 137);
      this.cmbDatabase.Name = "cmbDatabase";
      this.cmbDatabase.Size = new System.Drawing.Size(381, 21);
      this.cmbDatabase.TabIndex = 9;
      this.cmbDatabase.DropDown += new System.EventHandler(this.cmbDatabase_DropDown);
      // 
      // btnColor
      // 
      this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnColor.Location = new System.Drawing.Point(419, 184);
      this.btnColor.Name = "btnColor";
      this.btnColor.Size = new System.Drawing.Size(27, 23);
      this.btnColor.TabIndex = 2;
      this.btnColor.UseVisualStyleBackColor = true;
      this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
      // 
      // ConnectionEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.tlpControls);
      this.MinimumSize = new System.Drawing.Size(425, 170);
      this.Name = "ConnectionEditor";
      this.Size = new System.Drawing.Size(688, 304);
      this.tlpControls.ResumeLayout(false);
      this.tlpControls.PerformLayout();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.flowLayoutPanel2.ResumeLayout(false);
      this.flowLayoutPanel2.PerformLayout();
      this.flowLayoutPanel1.ResumeLayout(false);
      this.flowLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lblDatabase;
    private Controls.PlaceholderTextBox txtPassword;
    private System.Windows.Forms.Label lblPassword;
    private Controls.PlaceholderTextBox txtUser;
    private System.Windows.Forms.Label lblUser;
    private Controls.PlaceholderTextBox txtUrl;
    private System.Windows.Forms.Label lblUrl;
    private Controls.FlatButton btnTest;
    private Controls.PlaceholderTextBox txtName;
    private System.Windows.Forms.Label lblName;
    private MultiselectListBox lstConnections;
    private Controls.FlatButton btnDelete;
    private Controls.FlatButton btnNew;
    private Controls.FlatButton btnCopy;
    private Controls.FlatButton btnMoveUp;
    private Controls.FlatButton btnMoveDown;
    private System.Windows.Forms.TableLayoutPanel tlpControls;
    private System.Windows.Forms.ToolTip toolTipManager;
    private System.Windows.Forms.ComboBox cmbDatabase;
    private System.Windows.Forms.Button btnColor;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.ComboBox cmbType;
    private Controls.FlatButton exploreButton;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    private System.Windows.Forms.CheckBox chkPassword;
    private System.Windows.Forms.CheckBox chkWindows;
    private System.Windows.Forms.CheckBox chkAnonymous;
    private Controls.FlatButton btnAdvanced;
  }
}
