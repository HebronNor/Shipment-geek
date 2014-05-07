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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.panType = new System.Windows.Forms.Panel();
            this.radIncoming = new System.Windows.Forms.RadioButton();
            this.radOutgoing = new System.Windows.Forms.RadioButton();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblReceived = new System.Windows.Forms.Label();
            this.dateSent = new System.Windows.Forms.DateTimePicker();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.panURL = new System.Windows.Forms.Panel();
            this.cmdURLopen = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.panStatus = new System.Windows.Forms.Panel();
            this.chkReceived = new System.Windows.Forms.CheckBox();
            this.chkMissing = new System.Windows.Forms.CheckBox();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.lblTracking = new System.Windows.Forms.Label();
            this.cmbCarrier = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdTrack = new System.Windows.Forms.Button();
            this.txtTracking = new System.Windows.Forms.TextBox();
            this.numItemCount = new System.Windows.Forms.NumericUpDown();
            this.cmdItemSave = new System.Windows.Forms.Button();
            this.txtItemText = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statStrip = new System.Windows.Forms.StatusStrip();
            this.srpSelected = new System.Windows.Forms.ToolStripStatusLabel();
            this.srpLoadSave = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpIncoming = new System.Windows.Forms.GroupBox();
            this.lstIncoming = new System.Windows.Forms.ListView();
            this.clmInID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmInItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpOutgoing = new System.Windows.Forms.GroupBox();
            this.lstOutgoing = new System.Windows.Forms.ListView();
            this.clmOutID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutDays = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmOutItems = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chkShowAll = new System.Windows.Forms.CheckBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.cmdItemAdd = new System.Windows.Forms.Button();
            this.splitShipments = new System.Windows.Forms.SplitContainer();
            this.splitDetails = new System.Windows.Forms.SplitContainer();
            this.cmdNew = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grpDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panType.SuspendLayout();
            this.panURL.SuspendLayout();
            this.panStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).BeginInit();
            this.statStrip.SuspendLayout();
            this.grpIncoming.SuspendLayout();
            this.grpOutgoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitShipments)).BeginInit();
            this.splitShipments.Panel1.SuspendLayout();
            this.splitShipments.Panel2.SuspendLayout();
            this.splitShipments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitDetails)).BeginInit();
            this.splitDetails.Panel1.SuspendLayout();
            this.splitDetails.Panel2.SuspendLayout();
            this.splitDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSave.Enabled = false;
            this.cmdSave.Image = global::ShipmentGeek.Properties.Resources.save;
            this.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSave.Location = new System.Drawing.Point(93, 502);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "Save";
            this.toolTip.SetToolTip(this.cmdSave, "Save selected shipment");
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.tableLayoutPanel1);
            this.grpDetails.Location = new System.Drawing.Point(3, 3);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(355, 289);
            this.grpDetails.TabIndex = 0;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Shipment Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.lblType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtComment, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.panType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblComment, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblReceived, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.dateSent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblValue, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblURL, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtValue, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panURL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panStatus, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblCarrier, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTracking, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.cmbCarrier, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(343, 264);
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(88, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 20);
            this.txtName.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 26);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(3, 52);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComment.Location = new System.Drawing.Point(88, 185);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(252, 50);
            this.txtComment.TabIndex = 8;
            // 
            // panType
            // 
            this.panType.Controls.Add(this.radIncoming);
            this.panType.Controls.Add(this.radOutgoing);
            this.panType.Location = new System.Drawing.Point(88, 3);
            this.panType.Name = "panType";
            this.panType.Size = new System.Drawing.Size(252, 19);
            this.panType.TabIndex = 0;
            // 
            // radIncoming
            // 
            this.radIncoming.AutoSize = true;
            this.radIncoming.Location = new System.Drawing.Point(0, 0);
            this.radIncoming.Name = "radIncoming";
            this.radIncoming.Size = new System.Drawing.Size(68, 17);
            this.radIncoming.TabIndex = 0;
            this.radIncoming.TabStop = true;
            this.radIncoming.Text = "Incoming";
            this.radIncoming.UseVisualStyleBackColor = true;
            // 
            // radOutgoing
            // 
            this.radOutgoing.AutoSize = true;
            this.radOutgoing.Location = new System.Drawing.Point(100, 0);
            this.radOutgoing.Name = "radOutgoing";
            this.radOutgoing.Size = new System.Drawing.Size(68, 17);
            this.radOutgoing.TabIndex = 1;
            this.radOutgoing.TabStop = true;
            this.radOutgoing.Text = "Outgoing";
            this.radOutgoing.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(3, 182);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(51, 13);
            this.lblComment.TabIndex = 8;
            this.lblComment.Text = "Comment";
            // 
            // lblReceived
            // 
            this.lblReceived.AutoSize = true;
            this.lblReceived.Location = new System.Drawing.Point(3, 238);
            this.lblReceived.Name = "lblReceived";
            this.lblReceived.Size = new System.Drawing.Size(37, 13);
            this.lblReceived.TabIndex = 9;
            this.lblReceived.Text = "Status";
            // 
            // dateSent
            // 
            this.dateSent.Location = new System.Drawing.Point(88, 55);
            this.dateSent.Name = "dateSent";
            this.dateSent.Size = new System.Drawing.Size(138, 20);
            this.dateSent.TabIndex = 3;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(3, 78);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(34, 13);
            this.lblValue.TabIndex = 13;
            this.lblValue.Text = "Value";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(3, 104);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "URL";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(88, 81);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 20);
            this.txtValue.TabIndex = 4;
            // 
            // panURL
            // 
            this.panURL.Controls.Add(this.cmdURLopen);
            this.panURL.Controls.Add(this.txtURL);
            this.panURL.Location = new System.Drawing.Point(88, 107);
            this.panURL.Name = "panURL";
            this.panURL.Size = new System.Drawing.Size(252, 19);
            this.panURL.TabIndex = 5;
            // 
            // cmdURLopen
            // 
            this.cmdURLopen.Enabled = false;
            this.cmdURLopen.Location = new System.Drawing.Point(222, 0);
            this.cmdURLopen.Margin = new System.Windows.Forms.Padding(0);
            this.cmdURLopen.Name = "cmdURLopen";
            this.cmdURLopen.Size = new System.Drawing.Size(30, 20);
            this.cmdURLopen.TabIndex = 1;
            this.cmdURLopen.Text = "...";
            this.cmdURLopen.UseVisualStyleBackColor = true;
            this.cmdURLopen.Click += new System.EventHandler(this.cmdURLopen_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(0, 0);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(216, 20);
            this.txtURL.TabIndex = 0;
            // 
            // panStatus
            // 
            this.panStatus.Controls.Add(this.chkReceived);
            this.panStatus.Controls.Add(this.chkMissing);
            this.panStatus.Location = new System.Drawing.Point(88, 241);
            this.panStatus.Name = "panStatus";
            this.panStatus.Size = new System.Drawing.Size(252, 19);
            this.panStatus.TabIndex = 9;
            // 
            // chkReceived
            // 
            this.chkReceived.AutoSize = true;
            this.chkReceived.Location = new System.Drawing.Point(0, 0);
            this.chkReceived.Name = "chkReceived";
            this.chkReceived.Size = new System.Drawing.Size(72, 17);
            this.chkReceived.TabIndex = 0;
            this.chkReceived.Text = "Received";
            this.chkReceived.UseVisualStyleBackColor = true;
            this.chkReceived.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // chkMissing
            // 
            this.chkMissing.AutoSize = true;
            this.chkMissing.Location = new System.Drawing.Point(100, 0);
            this.chkMissing.Name = "chkMissing";
            this.chkMissing.Size = new System.Drawing.Size(61, 17);
            this.chkMissing.TabIndex = 1;
            this.chkMissing.Text = "Missing";
            this.chkMissing.UseVisualStyleBackColor = true;
            this.chkMissing.CheckedChanged += new System.EventHandler(this.chkState_CheckedChanged);
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Location = new System.Drawing.Point(3, 130);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(37, 13);
            this.lblCarrier.TabIndex = 15;
            this.lblCarrier.Text = "Carrier";
            // 
            // lblTracking
            // 
            this.lblTracking.AutoSize = true;
            this.lblTracking.Location = new System.Drawing.Point(3, 156);
            this.lblTracking.Name = "lblTracking";
            this.lblTracking.Size = new System.Drawing.Size(67, 13);
            this.lblTracking.TabIndex = 16;
            this.lblTracking.Text = "Tracking no.";
            // 
            // cmbCarrier
            // 
            this.cmbCarrier.FormattingEnabled = true;
            this.cmbCarrier.Location = new System.Drawing.Point(88, 133);
            this.cmbCarrier.Name = "cmbCarrier";
            this.cmbCarrier.Size = new System.Drawing.Size(121, 21);
            this.cmbCarrier.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdTrack);
            this.panel1.Controls.Add(this.txtTracking);
            this.panel1.Location = new System.Drawing.Point(88, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(252, 20);
            this.panel1.TabIndex = 7;
            // 
            // cmdTrack
            // 
            this.cmdTrack.Enabled = false;
            this.cmdTrack.Location = new System.Drawing.Point(222, 0);
            this.cmdTrack.Margin = new System.Windows.Forms.Padding(0);
            this.cmdTrack.Name = "cmdTrack";
            this.cmdTrack.Size = new System.Drawing.Size(30, 20);
            this.cmdTrack.TabIndex = 1;
            this.cmdTrack.Text = "...";
            this.cmdTrack.UseVisualStyleBackColor = true;
            this.cmdTrack.Click += new System.EventHandler(this.cmdTrack_Click);
            // 
            // txtTracking
            // 
            this.txtTracking.Location = new System.Drawing.Point(0, 0);
            this.txtTracking.Name = "txtTracking";
            this.txtTracking.Size = new System.Drawing.Size(216, 20);
            this.txtTracking.TabIndex = 0;
            // 
            // numItemCount
            // 
            this.numItemCount.Location = new System.Drawing.Point(6, 19);
            this.numItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numItemCount.Name = "numItemCount";
            this.numItemCount.Size = new System.Drawing.Size(45, 20);
            this.numItemCount.TabIndex = 0;
            this.numItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdItemSave
            // 
            this.cmdItemSave.Enabled = false;
            this.cmdItemSave.Image = global::ShipmentGeek.Properties.Resources.save;
            this.cmdItemSave.Location = new System.Drawing.Point(319, 16);
            this.cmdItemSave.Name = "cmdItemSave";
            this.cmdItemSave.Size = new System.Drawing.Size(30, 23);
            this.cmdItemSave.TabIndex = 2;
            this.toolTip.SetToolTip(this.cmdItemSave, "Save selected shipment item");
            this.cmdItemSave.UseVisualStyleBackColor = true;
            this.cmdItemSave.Click += new System.EventHandler(this.cmdItemSave_Click);
            // 
            // txtItemText
            // 
            this.txtItemText.Location = new System.Drawing.Point(54, 19);
            this.txtItemText.Name = "txtItemText";
            this.txtItemText.Size = new System.Drawing.Size(208, 20);
            this.txtItemText.TabIndex = 1;
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.lstItems.FullRowSelect = true;
            this.lstItems.GridLines = true;
            this.lstItems.HideSelection = false;
            this.lstItems.Location = new System.Drawing.Point(6, 45);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(343, 162);
            this.lstItems.TabIndex = 4;
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
            // statStrip
            // 
            this.statStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.srpSelected,
            this.srpLoadSave});
            this.statStrip.Location = new System.Drawing.Point(0, 531);
            this.statStrip.Name = "statStrip";
            this.statStrip.Size = new System.Drawing.Size(774, 22);
            this.statStrip.TabIndex = 4;
            this.statStrip.Text = "statusStrip1";
            // 
            // srpSelected
            // 
            this.srpSelected.Image = global::ShipmentGeek.Properties.Resources.selected;
            this.srpSelected.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.srpSelected.Name = "srpSelected";
            this.srpSelected.Size = new System.Drawing.Size(67, 17);
            this.srpSelected.Text = "Selected";
            this.srpSelected.Visible = false;
            // 
            // srpLoadSave
            // 
            this.srpLoadSave.Image = global::ShipmentGeek.Properties.Resources.save;
            this.srpLoadSave.Margin = new System.Windows.Forms.Padding(0, 3, 5, 2);
            this.srpLoadSave.Name = "srpLoadSave";
            this.srpLoadSave.Size = new System.Drawing.Size(73, 17);
            this.srpLoadSave.Text = "LoadSave";
            this.srpLoadSave.Visible = false;
            // 
            // grpIncoming
            // 
            this.grpIncoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpIncoming.Controls.Add(this.lstIncoming);
            this.grpIncoming.Location = new System.Drawing.Point(3, 3);
            this.grpIncoming.Name = "grpIncoming";
            this.grpIncoming.Size = new System.Drawing.Size(377, 235);
            this.grpIncoming.TabIndex = 0;
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
            this.clmInDays,
            this.clmInItems});
            this.lstIncoming.FullRowSelect = true;
            this.lstIncoming.GridLines = true;
            this.lstIncoming.HideSelection = false;
            this.lstIncoming.Location = new System.Drawing.Point(6, 19);
            this.lstIncoming.MultiSelect = false;
            this.lstIncoming.Name = "lstIncoming";
            this.lstIncoming.Size = new System.Drawing.Size(365, 208);
            this.lstIncoming.TabIndex = 0;
            this.lstIncoming.UseCompatibleStateImageBehavior = false;
            this.lstIncoming.View = System.Windows.Forms.View.Details;
            this.lstIncoming.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Shipment_ColumnSort);
            this.lstIncoming.SelectedIndexChanged += new System.EventHandler(this.lstIncoming_SelectedIndexChanged);
            this.lstIncoming.Enter += new System.EventHandler(this.lstIncoming_Enter);
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
            // clmInDays
            // 
            this.clmInDays.Text = "Days";
            this.clmInDays.Width = 40;
            // 
            // clmInItems
            // 
            this.clmInItems.Text = "Items";
            this.clmInItems.Width = 40;
            // 
            // grpOutgoing
            // 
            this.grpOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpOutgoing.Controls.Add(this.lstOutgoing);
            this.grpOutgoing.Location = new System.Drawing.Point(3, 3);
            this.grpOutgoing.Name = "grpOutgoing";
            this.grpOutgoing.Size = new System.Drawing.Size(377, 231);
            this.grpOutgoing.TabIndex = 1;
            this.grpOutgoing.TabStop = false;
            this.grpOutgoing.Text = "Outgoing Shipments";
            // 
            // lstOutgoing
            // 
            this.lstOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstOutgoing.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmOutID,
            this.clmOutName,
            this.clmOutDate,
            this.clmOutDays,
            this.clmOutItems});
            this.lstOutgoing.FullRowSelect = true;
            this.lstOutgoing.GridLines = true;
            this.lstOutgoing.HideSelection = false;
            this.lstOutgoing.Location = new System.Drawing.Point(6, 19);
            this.lstOutgoing.MultiSelect = false;
            this.lstOutgoing.Name = "lstOutgoing";
            this.lstOutgoing.Size = new System.Drawing.Size(365, 206);
            this.lstOutgoing.TabIndex = 0;
            this.lstOutgoing.UseCompatibleStateImageBehavior = false;
            this.lstOutgoing.View = System.Windows.Forms.View.Details;
            this.lstOutgoing.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Shipment_ColumnSort);
            this.lstOutgoing.SelectedIndexChanged += new System.EventHandler(this.lstOutgoing_SelectedIndexChanged);
            this.lstOutgoing.Enter += new System.EventHandler(this.lstOutgoing_Enter);
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
            // clmOutDays
            // 
            this.clmOutDays.Text = "Days";
            this.clmOutDays.Width = 40;
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
            this.chkShowAll.Location = new System.Drawing.Point(277, 506);
            this.chkShowAll.Name = "chkShowAll";
            this.chkShowAll.Size = new System.Drawing.Size(118, 17);
            this.chkShowAll.TabIndex = 4;
            this.chkShowAll.Text = "Show all Shipments";
            this.chkShowAll.UseVisualStyleBackColor = true;
            this.chkShowAll.CheckedChanged += new System.EventHandler(this.chkShowReceived_CheckedChanged);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // grpItems
            // 
            this.grpItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItems.Controls.Add(this.cmdItemAdd);
            this.grpItems.Controls.Add(this.lstItems);
            this.grpItems.Controls.Add(this.cmdItemSave);
            this.grpItems.Controls.Add(this.numItemCount);
            this.grpItems.Controls.Add(this.txtItemText);
            this.grpItems.Enabled = false;
            this.grpItems.Location = new System.Drawing.Point(3, 3);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(355, 213);
            this.grpItems.TabIndex = 1;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Shipment Items";
            // 
            // cmdItemAdd
            // 
            this.cmdItemAdd.Image = global::ShipmentGeek.Properties.Resources.add;
            this.cmdItemAdd.Location = new System.Drawing.Point(283, 16);
            this.cmdItemAdd.Name = "cmdItemAdd";
            this.cmdItemAdd.Size = new System.Drawing.Size(30, 23);
            this.cmdItemAdd.TabIndex = 6;
            this.toolTip.SetToolTip(this.cmdItemAdd, "Add new shipment item");
            this.cmdItemAdd.UseVisualStyleBackColor = true;
            this.cmdItemAdd.Click += new System.EventHandler(this.cmdItemSave_Click);
            // 
            // splitShipments
            // 
            this.splitShipments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitShipments.Location = new System.Drawing.Point(12, 12);
            this.splitShipments.Name = "splitShipments";
            this.splitShipments.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitShipments.Panel1
            // 
            this.splitShipments.Panel1.Controls.Add(this.grpIncoming);
            this.splitShipments.Panel1MinSize = 100;
            // 
            // splitShipments.Panel2
            // 
            this.splitShipments.Panel2.Controls.Add(this.grpOutgoing);
            this.splitShipments.Panel2MinSize = 100;
            this.splitShipments.Size = new System.Drawing.Size(383, 482);
            this.splitShipments.SplitterDistance = 241;
            this.splitShipments.TabIndex = 0;
            // 
            // splitDetails
            // 
            this.splitDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitDetails.Location = new System.Drawing.Point(401, 12);
            this.splitDetails.Name = "splitDetails";
            this.splitDetails.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitDetails.Panel1
            // 
            this.splitDetails.Panel1.Controls.Add(this.grpDetails);
            this.splitDetails.Panel1MinSize = 293;
            // 
            // splitDetails.Panel2
            // 
            this.splitDetails.Panel2.Controls.Add(this.grpItems);
            this.splitDetails.Panel2MinSize = 125;
            this.splitDetails.Size = new System.Drawing.Size(361, 516);
            this.splitDetails.SplitterDistance = 293;
            this.splitDetails.TabIndex = 1;
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdNew.Image = global::ShipmentGeek.Properties.Resources.add;
            this.cmdNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdNew.Location = new System.Drawing.Point(12, 502);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(75, 23);
            this.cmdNew.TabIndex = 5;
            this.cmdNew.Text = "New";
            this.toolTip.SetToolTip(this.cmdNew, "Add new shipment");
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 553);
            this.Controls.Add(this.cmdNew);
            this.Controls.Add(this.splitDetails);
            this.Controls.Add(this.splitShipments);
            this.Controls.Add(this.chkShowAll);
            this.Controls.Add(this.statStrip);
            this.Controls.Add(this.cmdSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Shipment Geek";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panType.ResumeLayout(false);
            this.panType.PerformLayout();
            this.panURL.ResumeLayout(false);
            this.panURL.PerformLayout();
            this.panStatus.ResumeLayout(false);
            this.panStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numItemCount)).EndInit();
            this.statStrip.ResumeLayout(false);
            this.statStrip.PerformLayout();
            this.grpIncoming.ResumeLayout(false);
            this.grpOutgoing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.grpItems.ResumeLayout(false);
            this.grpItems.PerformLayout();
            this.splitShipments.Panel1.ResumeLayout(false);
            this.splitShipments.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitShipments)).EndInit();
            this.splitShipments.ResumeLayout(false);
            this.splitDetails.Panel1.ResumeLayout(false);
            this.splitDetails.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitDetails)).EndInit();
            this.splitDetails.ResumeLayout(false);
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
        private System.Windows.Forms.DateTimePicker dateSent;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblReceived;
        private System.Windows.Forms.CheckBox chkReceived;
        private System.Windows.Forms.StatusStrip statStrip;
        private System.Windows.Forms.ToolStripStatusLabel srpSelected;
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
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.CheckBox chkMissing;
        private System.Windows.Forms.ColumnHeader clmInDays;
        private System.Windows.Forms.ColumnHeader clmOutDays;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.SplitContainer splitShipments;
        private System.Windows.Forms.SplitContainer splitDetails;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Panel panType;
        private System.Windows.Forms.Panel panURL;
        private System.Windows.Forms.Button cmdURLopen;
        private System.Windows.Forms.Panel panStatus;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.Label lblTracking;
        private System.Windows.Forms.ComboBox cmbCarrier;
        private System.Windows.Forms.TextBox txtTracking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdTrack;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button cmdItemAdd;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripStatusLabel srpLoadSave;

    }
}

