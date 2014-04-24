namespace ShipmentGeek
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdSave = new System.Windows.Forms.Button();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.cmdItemClear = new System.Windows.Forms.Button();
            this.numItemCount = new System.Windows.Forms.NumericUpDown();
            this.cmdItemSave = new System.Windows.Forms.Button();
            this.txtItemText = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.radIncoming = new System.Windows.Forms.RadioButton();
            this.radOutgoing = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdClear = new System.Windows.Forms.Button();
            this.grpIncoming = new System.Windows.Forms.GroupBox();
            this.lstIncoming = new System.Windows.Forms.ListView();
            this.clmInID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpOutgoing = new System.Windows.Forms.GroupBox();
            this.lstOutgoing = new System.Windows.Forms.ListView();
            this.clmOutID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblMissing = new System.Windows.Forms.Label();
            this.chkMissing = new System.Windows.Forms.CheckBox();
            this.grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statStrip.SuspendLayout();
            this.grpIncoming.SuspendLayout();
            this.grpOutgoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.Image = global::ShipmentGeek.Properties.Resources.save;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(12, 424);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.cmdItemClear);
            this.grpDetails.Controls.Add(this.numItemCount);
            this.grpDetails.Controls.Add(this.cmdItemSave);
            this.grpDetails.Controls.Add(this.txtItemText);
            this.grpDetails.Controls.Add(this.lstItems);
            this.grpDetails.Controls.Add(this.tableLayoutPanel1);
            this.grpDetails.Location = new System.Drawing.Point(338, 12);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(337, 433);
            this.grpDetails.TabIndex = 3;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Shipment Details";
            // 
            // cmdItemClear
            // 
            this.cmdItemClear.Image = global::ShipmentGeek.Properties.Resources.clean;
            this.cmdItemClear.Location = new System.Drawing.Point(301, 234);
            this.cmdItemClear.Name = "cmdItemClear";
            this.cmdItemClear.Size = new System.Drawing.Size(30, 23);
            this.cmdItemClear.TabIndex = 5;
            this.cmdItemClear.UseVisualStyleBackColor = true;
            this.cmdItemClear.Click += new System.EventHandler(this.cmdItemClear_Click);
            // 
            // numItemCount
            // 
            this.numItemCount.Location = new System.Drawing.Point(6, 234);
            this.numItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemCount.Name = "numItemCount";
            this.numItemCount.Size = new System.Drawing.Size(38, 20);
            this.numItemCount.TabIndex = 4;
            this.numItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdItemSave
            // 
            this.cmdItemSave.Image = global::ShipmentGeek.Properties.Resources.save;
            this.cmdItemSave.Location = new System.Drawing.Point(265, 234);
            this.cmdItemSave.Name = "cmdItemSave";
            this.cmdItemSave.Size = new System.Drawing.Size(30, 23);
            this.cmdItemSave.TabIndex = 3;
            this.cmdItemSave.UseVisualStyleBackColor = true;
            this.cmdItemSave.Click += new System.EventHandler(this.cmdItemSave_Click);
            // 
            // txtItemText
            // 
            this.txtItemText.Location = new System.Drawing.Point(50, 234);
            this.txtItemText.Name = "txtItemText";
            this.txtItemText.Size = new System.Drawing.Size(198, 20);
            this.txtItemText.TabIndex = 2;
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.HideSelection = false;
            this.lstItems.Location = new System.Drawing.Point(6, 263);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(325, 164);
            this.lstItems.TabIndex = 1;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstItems_ColumnClick);
            this.lstItems.SelectedIndexChanged += new System.EventHandler(this.lstItems_SelectedIndexChanged);
            this.lstItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lstItems_MouseUp);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 250;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radIncoming, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radOutgoing, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblComment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblReceived, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkReceived, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMissing, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkMissing, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(325, 209);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(3, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            // 
            // radIncoming
            // 
            this.radIncoming.AutoSize = true;
            this.radIncoming.Location = new System.Drawing.Point(84, 3);
            this.radIncoming.Name = "radIncoming";
            this.radIncoming.Size = new System.Drawing.Size(68, 17);
            this.radIncoming.TabIndex = 1;
            this.radIncoming.TabStop = true;
            this.radIncoming.Text = "Incoming";
            this.radIncoming.UseVisualStyleBackColor = true;
            // 
            // radOutgoing
            // 
            this.radOutgoing.AutoSize = true;
            this.radOutgoing.Location = new System.Drawing.Point(84, 28);
            this.radOutgoing.Name = "radOutgoing";
            this.radOutgoing.Size = new System.Drawing.Size(68, 17);
            this.radOutgoing.TabIndex = 2;
            this.radOutgoing.TabStop = true;
            this.radOutgoing.Text = "Outgoing";
            this.radOutgoing.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(84, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(224, 20);
            this.txtName.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(84, 103);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(224, 54);
            this.txtComment.TabIndex = 7;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(3, 100);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Comment";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(3, 160);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(53, 13);
            this.lblReceived.TabIndex = 9;
            this.lblReceived.Text = "Received";
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Location = new System.Drawing.Point(84, 163);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(15, 14);
            this.chkReceived.TabIndex = 10;
            this.chkReceived.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(84, 78);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(224, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatStrip});
            this.statStrip.Location = new System.Drawing.Point(0, 453);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(687, 22);
            this.statStrip.TabIndex = 4;
            this.statStrip.Text = "statusStrip1";
            // 
            // lblStatStrip
            // 
            this.lblStatStrip.Name = "lblStatStrip";
            this.lblStatStrip.Size = new System.Drawing.Size(39, 17);
            this.lblStatStrip.Text = "Status";
            // 
            // cmdClear
            // 
            this.cmdClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdClear.Image = global::ShipmentGeek.Properties.Resources.clean;
            this.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdClear.Location = new System.Drawing.Point(93, 424);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 23);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // grpIncoming
            // 
            this.grpIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIncoming.Controls.Add(this.lstIncoming);
            this.grpIncoming.Location = new System.Drawing.Point(12, 12);
            this.grpIncoming.Name = "grpIncoming";
            this.grpIncoming.Size = new System.Drawing.Size(320, 200);
            this.grpIncoming.TabIndex = 7;
            this.grpIncoming.TabStop = false;
            this.grpIncoming.Text = "Incoming Shipments";
            // 
            // lstIncoming
            // 
            this.lstIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstIncoming.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmInID,
            this.clmInName,
            this.clmInDate,
            this.clmInItems});
            this.lstIncoming.FullRowSelect = true;
            this.lstIncoming.GridLines = true;
            this.lstIncoming.HideSelection = false;
            this.lstIncoming.Location = new System.Drawing.Point(6, 19);
            this.lstIncoming.MultiSelect = false;
            this.lstIncoming.Name = "lstIncoming";
            this.lstIncoming.Size = new System.Drawing.Size(308, 173);
            this.lstIncoming.TabIndex = 1;
            this.lstIncoming.UseCompatibleStateImageBehavior = false;
            this.lstIncoming.View = System.Windows.Forms.View.Details;
            this.lstIncoming.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Shipment_ColumnSort);
            this.lstIncoming.SelectedIndexChanged += new System.EventHandler(this.lstIncoming_SelectedIndexChanged);
            this.lstIncoming.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseUp);
            // 
            // clmInID
            // 
            this.clmInID.Text = "ID";
            this.clmInID.Width = 25;
            // 
            // clmInName
            // 
            this.clmInName.Text = "Name";
            this.clmInName.Width = 150;
            // 
            // clmInDate
            // 
            this.clmInDate.Text = "Date";
            this.clmInDate.Width = 75;
            // 
            // clmInItems
            // 
            this.clmInItems.Text = "Items";
            this.clmInItems.Width = 40;
            // 
            // grpOutgoing
            // 
            this.grpOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutgoing.Controls.Add(this.lstOutgoing);
            this.grpOutgoing.Location = new System.Drawing.Point(12, 218);
            this.grpOutgoing.Name = "grpOutgoing";
            this.grpOutgoing.Size = new System.Drawing.Size(320, 200);
            this.grpOutgoing.TabIndex = 8;
            this.grpOutgoing.TabStop = false;
            this.grpOutgoing.Text = "Outgoing Shipments";
            // 
            // lstOutgoing
            // 
            this.lstOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutgoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOutID,
            this.clmOutName,
            this.clmOutDate,
            this.clmOutItems});
            this.lstOutgoing.FullRowSelect = true;
            this.lstOutgoing.GridLines = true;
            this.lstOutgoing.HideSelection = false;
            this.lstOutgoing.Location = new System.Drawing.Point(6, 19);
            this.lstOutgoing.MultiSelect = false;
            this.lstOutgoing.Name = "lstOutgoing";
            this.lstOutgoing.Size = new System.Drawing.Size(308, 175);
            this.lstOutgoing.TabIndex = 2;
            this.lstOutgoing.UseCompatibleStateImageBehavior = false;
            this.lstOutgoing.View = System.Windows.Forms.View.Details;
            this.lstOutgoing.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Shipment_ColumnSort);
            this.lstOutgoing.SelectedIndexChanged += new System.EventHandler(this.lstOutgoing_SelectedIndexChanged);
            this.lstOutgoing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseUp);
            // 
            // clmOutID
            // 
            this.clmOutID.Text = "ID";
            this.clmOutID.Width = 25;
            // 
            // clmOutName
            // 
            this.clmOutName.Text = "Name";
            this.clmOutName.Width = 150;
            // 
            // clmOutDate
            // 
            this.clmOutDate.Text = "Date";
            this.clmOutDate.Width = 75;
            // 
            // clmOutItems
            // 
            this.clmOutItems.Text = "Items";
            this.clmOutItems.Width = 40;
            // 
            // chkShowAll
            // 
            this.chkShowAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkShowAll.AutoSize = true;
            this.chkShowAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowAll.Location = new System.Drawing.Point(214, 428);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(118, 17);
            this.chkShowAll.TabIndex = 9;
            this.chkShowAll.Text = "Show all Shipments";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowReceived_CheckedChanged);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // lblMissing
            // 
            this.lblMissing.AutoSize = true;
            this.lblMissing.Location = new System.Drawing.Point(3, 185);
            this.lblMissing.Name = "lblMissing";
            this.lblMissing.Size = new System.Drawing.Size(42, 13);
            this.lblMissing.TabIndex = 11;
            this.lblMissing.Text = "Missing";
            // 
            // chkMissing
            // 
            this.chkMissing.AutoSize = true;
            this.chkMissing.Location = new System.Drawing.Point(84, 188);
            this.chkMissing.Name = "chkMissing";
            this.chkMissing.Size = new System.Drawing.Size(15, 14);
            this.chkMissing.TabIndex = 12;
            this.chkMissing.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 475);
            this.Controls.Add(this.chkShowAll);
            this.Controls.Add(this.grpOutgoing);
            this.Controls.Add(this.grpIncoming);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.cmdSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Shipment Geek";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.grpIncoming.ResumeLayout(false);
            this.grpOutgoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton radIncoming;
        private System.Windows.Forms.RadioButton radOutgoing;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.CheckBox chkReceived;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatStrip;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Button cmdItemSave;
        private System.Windows.Forms.TextBox txtItemText;
        private System.Windows.Forms.NumericUpDown numItemCount;
        private System.Windows.Forms.GroupBox grpIncoming;
        private System.Windows.Forms.ListView lstIncoming;
        private System.Windows.Forms.ColumnHeader clmInID;
        private System.Windows.Forms.ColumnHeader clmInName;
        private System.Windows.Forms.ColumnHeader clmInDate;
        private System.Windows.Forms.ColumnHeader clmInItems;
        private System.Windows.Forms.GroupBox grpOutgoing;
        private System.Windows.Forms.ListView lstOutgoing;
        private System.Windows.Forms.ColumnHeader clmOutID;
        private System.Windows.Forms.ColumnHeader clmOutName;
        private System.Windows.Forms.ColumnHeader clmOutDate;
        private System.Windows.Forms.ColumnHeader clmOutItems;
        private System.Windows.Forms.CheckBox chkShowAll;
        private System.Windows.Forms.Button cmdItemClear;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label lblMissing;
        private System.Windows.Forms.CheckBox chkMissing;

    }
}

