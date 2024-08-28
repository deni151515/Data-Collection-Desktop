
namespace TrackandTrace2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panelBeranda = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.layout_3card = new System.Windows.Forms.TableLayoutPanel();
            this.Summury = new System.Windows.Forms.Label();
            this.paneloverlay = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.panel_doo = new RoundedPanel();
            this.combox_year = new CustomControls.RJControls.RJComboBox();
            this.chart_doo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel_retur = new RoundedPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelretur = new System.Windows.Forms.Label();
            this.iconretur = new FontAwesome.Sharp.IconButton();
            this.panel_packing = new RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lebelpacking = new System.Windows.Forms.Label();
            this.iconpacking = new FontAwesome.Sharp.IconButton();
            this.panel_receiving = new RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelreceiving = new System.Windows.Forms.Label();
            this.iconReceiving = new FontAwesome.Sharp.IconButton();
            this.roundedPanel1 = new RoundedPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_receiving = new TrackandTrace2.component.RoundedIconButton();
            this.btn_packing = new TrackandTrace2.component.RoundedIconButton();
            this.btn_retur = new TrackandTrace2.component.RoundedIconButton();
            this.btn_warehouse = new TrackandTrace2.component.RoundedIconButton();
            this.btn_decom = new TrackandTrace2.component.RoundedIconButton();
            this.btn_com = new TrackandTrace2.component.RoundedIconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_warehouse = new RoundedPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.table_warehouse = new System.Windows.Forms.DataGridView();
            this.warehouse_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.btn_logout = new FontAwesome.Sharp.IconButton();
            this.btn_back = new FontAwesome.Sharp.IconButton();
            this.btn_setting = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelBeranda.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.layout_3card.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_doo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_doo)).BeginInit();
            this.panel_retur.SuspendLayout();
            this.panel_packing.SuspendLayout();
            this.panel_receiving.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_warehouse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_warehouse)).BeginInit();
            this.roundedPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBeranda
            // 
            this.panelBeranda.Controls.Add(this.tableLayoutPanel1);
            this.panelBeranda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBeranda.Location = new System.Drawing.Point(0, 62);
            this.panelBeranda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBeranda.Name = "panelBeranda";
            this.panelBeranda.Size = new System.Drawing.Size(1902, 993);
            this.panelBeranda.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel_warehouse, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 993);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel_doo, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.layout_3card, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Summury, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.roundedPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(573, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1326, 989);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // layout_3card
            // 
            this.layout_3card.ColumnCount = 3;
            this.layout_3card.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_3card.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_3card.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.layout_3card.Controls.Add(this.panel_retur, 0, 0);
            this.layout_3card.Controls.Add(this.panel_packing, 0, 0);
            this.layout_3card.Controls.Add(this.panel_receiving, 0, 0);
            this.layout_3card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout_3card.Location = new System.Drawing.Point(3, 347);
            this.layout_3card.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layout_3card.Name = "layout_3card";
            this.layout_3card.RowCount = 1;
            this.layout_3card.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout_3card.Size = new System.Drawing.Size(1320, 243);
            this.layout_3card.TabIndex = 2;
            // 
            // Summury
            // 
            this.Summury.AutoSize = true;
            this.Summury.BackColor = System.Drawing.Color.Transparent;
            this.Summury.Dock = System.Windows.Forms.DockStyle.Left;
            this.Summury.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summury.Location = new System.Drawing.Point(3, 296);
            this.Summury.Name = "Summury";
            this.Summury.Size = new System.Drawing.Size(115, 49);
            this.Summury.TabIndex = 0;
            this.Summury.Text = "Summary";
            this.Summury.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // paneloverlay
            // 
            this.paneloverlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.paneloverlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneloverlay.Location = new System.Drawing.Point(0, 0);
            this.paneloverlay.Name = "paneloverlay";
            this.paneloverlay.Size = new System.Drawing.Size(1459, 878);
            this.paneloverlay.TabIndex = 0;
            this.paneloverlay.Visible = false;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Control;
            this.panel_header.Controls.Add(this.roundedPanel2);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1902, 62);
            this.panel_header.TabIndex = 0;
            // 
            // panel_doo
            // 
            this.panel_doo.BackColor = System.Drawing.Color.White;
            this.panel_doo.Controls.Add(this.combox_year);
            this.panel_doo.Controls.Add(this.chart_doo);
            this.panel_doo.CornerRadius = 20;
            this.panel_doo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_doo.Location = new System.Drawing.Point(11, 602);
            this.panel_doo.Margin = new System.Windows.Forms.Padding(11, 10, 20, 20);
            this.panel_doo.Name = "panel_doo";
            this.panel_doo.Size = new System.Drawing.Size(1295, 367);
            this.panel_doo.TabIndex = 5;
            // 
            // combox_year
            // 
            this.combox_year.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combox_year.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combox_year.BackColor = System.Drawing.Color.White;
            this.combox_year.BorderColor = System.Drawing.Color.Gainsboro;
            this.combox_year.BorderSize = 2;
            this.combox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.combox_year.Font = new System.Drawing.Font("Roboto", 14F);
            this.combox_year.ForeColor = System.Drawing.Color.Black;
            this.combox_year.IconColor = System.Drawing.Color.Gainsboro;
            this.combox_year.ListBackColor = System.Drawing.Color.WhiteSmoke;
            this.combox_year.ListTextColor = System.Drawing.Color.Black;
            this.combox_year.Location = new System.Drawing.Point(57, 17);
            this.combox_year.MinimumSize = new System.Drawing.Size(200, 30);
            this.combox_year.Name = "combox_year";
            this.combox_year.Padding = new System.Windows.Forms.Padding(2);
            this.combox_year.Size = new System.Drawing.Size(200, 44);
            this.combox_year.TabIndex = 6;
            this.combox_year.Texts = "";
            this.combox_year.OnSelectedIndexChanged += new System.EventHandler(this.combox_year_SelectedIndexChanged);
            // 
            // chart_doo
            // 
            this.chart_doo.AccessibleName = "";
            this.chart_doo.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarginVisible = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Roboto", 9F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LineWidth = 0;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            chartArea1.AxisX.MajorTickMark.LineWidth = 3;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Empty;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Roboto", 9F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.LineWidth = 0;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(146)))), ((int)(((byte)(166)))));
            chartArea1.AxisY.MajorTickMark.LineWidth = 3;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartAreas";
            this.chart_doo.ChartAreas.Add(chartArea1);
            this.chart_doo.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart_doo.Legends.Add(legend1);
            this.chart_doo.Location = new System.Drawing.Point(0, 0);
            this.chart_doo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_doo.Name = "chart_doo";
            this.chart_doo.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartAreas";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            series1.Font = new System.Drawing.Font("Roboto", 8F);
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Transparent;
            series1.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(76)))), ((int)(((byte)(132)))));
            series1.MarkerSize = 10;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series";
            this.chart_doo.Series.Add(series1);
            this.chart_doo.Size = new System.Drawing.Size(1295, 367);
            this.chart_doo.TabIndex = 5;
            this.chart_doo.Text = "chart2";
            title1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title1.Font = new System.Drawing.Font("Roboto", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            title1.Name = "Title";
            this.chart_doo.Titles.Add(title1);
            // 
            // panel_retur
            // 
            this.panel_retur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(86)))));
            this.panel_retur.Controls.Add(this.label4);
            this.panel_retur.Controls.Add(this.labelretur);
            this.panel_retur.Controls.Add(this.iconretur);
            this.panel_retur.CornerRadius = 20;
            this.panel_retur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_retur.Location = new System.Drawing.Point(891, 10);
            this.panel_retur.Margin = new System.Windows.Forms.Padding(11, 10, 20, 10);
            this.panel_retur.Name = "panel_retur";
            this.panel_retur.Size = new System.Drawing.Size(409, 223);
            this.panel_retur.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 41);
            this.label4.TabIndex = 9;
            this.label4.Text = "Retur";
            // 
            // labelretur
            // 
            this.labelretur.AccessibleName = "";
            this.labelretur.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelretur.AutoSize = true;
            this.labelretur.BackColor = System.Drawing.Color.Transparent;
            this.labelretur.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelretur.ForeColor = System.Drawing.Color.White;
            this.labelretur.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelretur.Location = new System.Drawing.Point(13, 80);
            this.labelretur.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelretur.Name = "labelretur";
            this.labelretur.Size = new System.Drawing.Size(162, 70);
            this.labelretur.TabIndex = 8;
            this.labelretur.Text = "1413";
            // 
            // iconretur
            // 
            this.iconretur.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconretur.AutoSize = true;
            this.iconretur.BackColor = System.Drawing.Color.Transparent;
            this.iconretur.FlatAppearance.BorderSize = 0;
            this.iconretur.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconretur.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconretur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconretur.ForeColor = System.Drawing.Color.Black;
            this.iconretur.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.iconretur.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.iconretur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconretur.IconSize = 150;
            this.iconretur.Location = new System.Drawing.Point(201, 45);
            this.iconretur.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconretur.Name = "iconretur";
            this.iconretur.Size = new System.Drawing.Size(208, 192);
            this.iconretur.TabIndex = 10;
            this.iconretur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconretur.UseVisualStyleBackColor = false;
            // 
            // panel_packing
            // 
            this.panel_packing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(225)))), ((int)(((byte)(100)))));
            this.panel_packing.Controls.Add(this.label1);
            this.panel_packing.Controls.Add(this.lebelpacking);
            this.panel_packing.Controls.Add(this.iconpacking);
            this.panel_packing.CornerRadius = 20;
            this.panel_packing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_packing.Location = new System.Drawing.Point(451, 10);
            this.panel_packing.Margin = new System.Windows.Forms.Padding(11, 10, 20, 10);
            this.panel_packing.Name = "panel_packing";
            this.panel_packing.Size = new System.Drawing.Size(409, 223);
            this.panel_packing.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Packing";
            // 
            // lebelpacking
            // 
            this.lebelpacking.AccessibleName = "";
            this.lebelpacking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lebelpacking.AutoSize = true;
            this.lebelpacking.BackColor = System.Drawing.Color.Transparent;
            this.lebelpacking.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lebelpacking.ForeColor = System.Drawing.Color.White;
            this.lebelpacking.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lebelpacking.Location = new System.Drawing.Point(13, 80);
            this.lebelpacking.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.lebelpacking.Name = "lebelpacking";
            this.lebelpacking.Size = new System.Drawing.Size(162, 70);
            this.lebelpacking.TabIndex = 8;
            this.lebelpacking.Text = "1413";
            // 
            // iconpacking
            // 
            this.iconpacking.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconpacking.AutoSize = true;
            this.iconpacking.BackColor = System.Drawing.Color.Transparent;
            this.iconpacking.FlatAppearance.BorderSize = 0;
            this.iconpacking.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconpacking.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconpacking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconpacking.ForeColor = System.Drawing.Color.Black;
            this.iconpacking.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.iconpacking.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.iconpacking.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconpacking.IconSize = 150;
            this.iconpacking.Location = new System.Drawing.Point(201, 45);
            this.iconpacking.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconpacking.Name = "iconpacking";
            this.iconpacking.Size = new System.Drawing.Size(208, 192);
            this.iconpacking.TabIndex = 10;
            this.iconpacking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconpacking.UseVisualStyleBackColor = false;
            // 
            // panel_receiving
            // 
            this.panel_receiving.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(109)))), ((int)(((byte)(208)))));
            this.panel_receiving.Controls.Add(this.label3);
            this.panel_receiving.Controls.Add(this.labelreceiving);
            this.panel_receiving.Controls.Add(this.iconReceiving);
            this.panel_receiving.CornerRadius = 20;
            this.panel_receiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_receiving.Location = new System.Drawing.Point(11, 10);
            this.panel_receiving.Margin = new System.Windows.Forms.Padding(11, 10, 20, 10);
            this.panel_receiving.Name = "panel_receiving";
            this.panel_receiving.Size = new System.Drawing.Size(409, 223);
            this.panel_receiving.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 41);
            this.label3.TabIndex = 9;
            this.label3.Text = "Receiving";
            // 
            // labelreceiving
            // 
            this.labelreceiving.AccessibleName = "lebel_receiving";
            this.labelreceiving.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelreceiving.AutoSize = true;
            this.labelreceiving.BackColor = System.Drawing.Color.Transparent;
            this.labelreceiving.Font = new System.Drawing.Font("Roboto", 34.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelreceiving.ForeColor = System.Drawing.Color.White;
            this.labelreceiving.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelreceiving.Location = new System.Drawing.Point(13, 80);
            this.labelreceiving.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelreceiving.Name = "labelreceiving";
            this.labelreceiving.Size = new System.Drawing.Size(162, 70);
            this.labelreceiving.TabIndex = 8;
            this.labelreceiving.Text = "1413";
            // 
            // iconReceiving
            // 
            this.iconReceiving.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconReceiving.AutoSize = true;
            this.iconReceiving.BackColor = System.Drawing.Color.Transparent;
            this.iconReceiving.FlatAppearance.BorderSize = 0;
            this.iconReceiving.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconReceiving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconReceiving.ForeColor = System.Drawing.Color.Black;
            this.iconReceiving.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.iconReceiving.IconColor = System.Drawing.Color.CornflowerBlue;
            this.iconReceiving.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconReceiving.IconSize = 150;
            this.iconReceiving.Location = new System.Drawing.Point(201, 45);
            this.iconReceiving.Margin = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.iconReceiving.Name = "iconReceiving";
            this.iconReceiving.Size = new System.Drawing.Size(208, 192);
            this.iconReceiving.TabIndex = 10;
            this.iconReceiving.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconReceiving.UseVisualStyleBackColor = false;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.roundedPanel1.Controls.Add(this.flowLayoutPanel1);
            this.roundedPanel1.Controls.Add(this.pictureBox1);
            this.roundedPanel1.CornerRadius = 30;
            this.roundedPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedPanel1.Location = new System.Drawing.Point(11, 20);
            this.roundedPanel1.Margin = new System.Windows.Forms.Padding(11, 20, 20, 10);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(1295, 266);
            this.roundedPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.btn_receiving);
            this.flowLayoutPanel1.Controls.Add(this.btn_packing);
            this.flowLayoutPanel1.Controls.Add(this.btn_retur);
            this.flowLayoutPanel1.Controls.Add(this.btn_warehouse);
            this.flowLayoutPanel1.Controls.Add(this.btn_decom);
            this.flowLayoutPanel1.Controls.Add(this.btn_com);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(508, 263);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // btn_receiving
            // 
            this.btn_receiving.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_receiving.BackColor = System.Drawing.Color.White;
            this.btn_receiving.BorderColor = System.Drawing.Color.Transparent;
            this.btn_receiving.BorderRadius = 20;
            this.btn_receiving.FlatAppearance.BorderSize = 0;
            this.btn_receiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_receiving.Font = new System.Drawing.Font("Roboto", 6.5F);
            this.btn_receiving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_receiving.IconChar = FontAwesome.Sharp.IconChar.BoxOpen;
            this.btn_receiving.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_receiving.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_receiving.IconSize = 58;
            this.btn_receiving.Location = new System.Drawing.Point(20, 20);
            this.btn_receiving.Margin = new System.Windows.Forms.Padding(20);
            this.btn_receiving.Name = "btn_receiving";
            this.btn_receiving.Size = new System.Drawing.Size(100, 100);
            this.btn_receiving.TabIndex = 0;
            this.btn_receiving.Text = "Receiving";
            this.btn_receiving.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_receiving.UseVisualStyleBackColor = false;
            this.btn_receiving.Click += new System.EventHandler(this.btn_receiving_Click);
            // 
            // btn_packing
            // 
            this.btn_packing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_packing.BackColor = System.Drawing.Color.White;
            this.btn_packing.BorderColor = System.Drawing.Color.Transparent;
            this.btn_packing.BorderRadius = 20;
            this.btn_packing.FlatAppearance.BorderSize = 0;
            this.btn_packing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_packing.Font = new System.Drawing.Font("Roboto", 7F);
            this.btn_packing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_packing.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.btn_packing.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_packing.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_packing.IconSize = 58;
            this.btn_packing.Location = new System.Drawing.Point(160, 20);
            this.btn_packing.Margin = new System.Windows.Forms.Padding(20);
            this.btn_packing.Name = "btn_packing";
            this.btn_packing.Size = new System.Drawing.Size(100, 100);
            this.btn_packing.TabIndex = 1;
            this.btn_packing.Text = "Packing";
            this.btn_packing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_packing.UseVisualStyleBackColor = false;
            this.btn_packing.Click += new System.EventHandler(this.btn_packing_Click);
            // 
            // btn_retur
            // 
            this.btn_retur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_retur.BackColor = System.Drawing.Color.White;
            this.btn_retur.BorderColor = System.Drawing.Color.Transparent;
            this.btn_retur.BorderRadius = 20;
            this.btn_retur.FlatAppearance.BorderSize = 0;
            this.btn_retur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_retur.Font = new System.Drawing.Font("Roboto", 7F);
            this.btn_retur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_retur.IconChar = FontAwesome.Sharp.IconChar.Rotate;
            this.btn_retur.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_retur.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_retur.IconSize = 58;
            this.btn_retur.Location = new System.Drawing.Point(300, 20);
            this.btn_retur.Margin = new System.Windows.Forms.Padding(20);
            this.btn_retur.Name = "btn_retur";
            this.btn_retur.Size = new System.Drawing.Size(100, 100);
            this.btn_retur.TabIndex = 2;
            this.btn_retur.Text = "Retur";
            this.btn_retur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_retur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_retur.UseVisualStyleBackColor = false;
            this.btn_retur.Click += new System.EventHandler(this.btn_retur_Click);
            // 
            // btn_warehouse
            // 
            this.btn_warehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_warehouse.BackColor = System.Drawing.Color.White;
            this.btn_warehouse.BorderColor = System.Drawing.Color.Transparent;
            this.btn_warehouse.BorderRadius = 20;
            this.btn_warehouse.FlatAppearance.BorderSize = 0;
            this.btn_warehouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_warehouse.Font = new System.Drawing.Font("Roboto", 6F);
            this.btn_warehouse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_warehouse.IconChar = FontAwesome.Sharp.IconChar.Warehouse;
            this.btn_warehouse.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_warehouse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_warehouse.IconSize = 58;
            this.btn_warehouse.Location = new System.Drawing.Point(20, 160);
            this.btn_warehouse.Margin = new System.Windows.Forms.Padding(20);
            this.btn_warehouse.Name = "btn_warehouse";
            this.btn_warehouse.Size = new System.Drawing.Size(100, 100);
            this.btn_warehouse.TabIndex = 3;
            this.btn_warehouse.Text = "Warehouse";
            this.btn_warehouse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_warehouse.UseVisualStyleBackColor = false;
            this.btn_warehouse.Click += new System.EventHandler(this.btn_warehouse_Click);
            // 
            // btn_decom
            // 
            this.btn_decom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_decom.BackColor = System.Drawing.Color.White;
            this.btn_decom.BorderColor = System.Drawing.Color.Transparent;
            this.btn_decom.BorderRadius = 20;
            this.btn_decom.FlatAppearance.BorderSize = 0;
            this.btn_decom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decom.Font = new System.Drawing.Font("Roboto", 5F);
            this.btn_decom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_decom.IconChar = FontAwesome.Sharp.IconChar.FileCircleMinus;
            this.btn_decom.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_decom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_decom.IconSize = 58;
            this.btn_decom.Location = new System.Drawing.Point(160, 160);
            this.btn_decom.Margin = new System.Windows.Forms.Padding(20);
            this.btn_decom.Name = "btn_decom";
            this.btn_decom.Size = new System.Drawing.Size(100, 100);
            this.btn_decom.TabIndex = 5;
            this.btn_decom.Text = "Decommision";
            this.btn_decom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_decom.UseVisualStyleBackColor = false;
            this.btn_decom.Click += new System.EventHandler(this.btn_decom_Click);
            // 
            // btn_com
            // 
            this.btn_com.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_com.BackColor = System.Drawing.Color.White;
            this.btn_com.BorderColor = System.Drawing.Color.Transparent;
            this.btn_com.BorderRadius = 20;
            this.btn_com.FlatAppearance.BorderSize = 0;
            this.btn_com.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_com.Font = new System.Drawing.Font("Roboto", 6F);
            this.btn_com.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_com.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btn_com.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(234)))));
            this.btn_com.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_com.IconSize = 58;
            this.btn_com.Location = new System.Drawing.Point(300, 160);
            this.btn_com.Margin = new System.Windows.Forms.Padding(20);
            this.btn_com.Name = "btn_com";
            this.btn_com.Size = new System.Drawing.Size(100, 100);
            this.btn_com.TabIndex = 4;
            this.btn_com.Text = "Commision";
            this.btn_com.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_com.UseVisualStyleBackColor = false;
            this.btn_com.Click += new System.EventHandler(this.btn_com_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DataCollection.Properties.Resources.imagedashboard;
            this.pictureBox1.Location = new System.Drawing.Point(878, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(0, 0, 51, 0);
            this.pictureBox1.Size = new System.Drawing.Size(339, 258);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel_warehouse
            // 
            this.panel_warehouse.BackColor = System.Drawing.Color.White;
            this.panel_warehouse.Controls.Add(this.label10);
            this.panel_warehouse.Controls.Add(this.table_warehouse);
            this.panel_warehouse.Controls.Add(this.label12);
            this.panel_warehouse.CornerRadius = 20;
            this.panel_warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_warehouse.Location = new System.Drawing.Point(20, 20);
            this.panel_warehouse.Margin = new System.Windows.Forms.Padding(20, 20, 11, 20);
            this.panel_warehouse.Name = "panel_warehouse";
            this.panel_warehouse.Size = new System.Drawing.Size(539, 953);
            this.panel_warehouse.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto Medium", 10F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(12, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Select your Warehouse";
            // 
            // table_warehouse
            // 
            this.table_warehouse.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.table_warehouse.AllowUserToAddRows = false;
            this.table_warehouse.AllowUserToDeleteRows = false;
            this.table_warehouse.AllowUserToResizeRows = false;
            this.table_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.table_warehouse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_warehouse.BackgroundColor = System.Drawing.Color.White;
            this.table_warehouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_warehouse.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.table_warehouse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_warehouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.table_warehouse.ColumnHeadersHeight = 40;
            this.table_warehouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.table_warehouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.warehouse_name,
            this.quantity});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table_warehouse.DefaultCellStyle = dataGridViewCellStyle2;
            this.table_warehouse.EnableHeadersVisualStyles = false;
            this.table_warehouse.GridColor = System.Drawing.Color.WhiteSmoke;
            this.table_warehouse.Location = new System.Drawing.Point(0, 101);
            this.table_warehouse.Margin = new System.Windows.Forms.Padding(20);
            this.table_warehouse.Name = "table_warehouse";
            this.table_warehouse.ReadOnly = true;
            this.table_warehouse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_warehouse.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.table_warehouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.table_warehouse.RowHeadersVisible = false;
            this.table_warehouse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.table_warehouse.RowTemplate.Height = 45;
            this.table_warehouse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.table_warehouse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.table_warehouse.Size = new System.Drawing.Size(539, 624);
            this.table_warehouse.TabIndex = 39;
            this.table_warehouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_warehouse_CellClick);
            // 
            // warehouse_name
            // 
            this.warehouse_name.FillWeight = 140F;
            this.warehouse_name.HeaderText = "Warehouse Name";
            this.warehouse_name.MinimumWidth = 6;
            this.warehouse_name.Name = "warehouse_name";
            this.warehouse_name.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.FillWeight = 60F;
            this.quantity.HeaderText = "Quantity";
            this.quantity.MinimumWidth = 6;
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto Medium", 18F);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(111)))), ((int)(((byte)(121)))));
            this.label12.Location = new System.Drawing.Point(9, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(20, 20, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 37);
            this.label12.TabIndex = 8;
            this.label12.Text = "Warehouse";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel2.BackColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.btn_logout);
            this.roundedPanel2.Controls.Add(this.btn_back);
            this.roundedPanel2.Controls.Add(this.btn_setting);
            this.roundedPanel2.Controls.Add(this.lblTitleChildForm);
            this.roundedPanel2.CornerRadius = 15;
            this.roundedPanel2.Location = new System.Drawing.Point(20, 0);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(1859, 62);
            this.roundedPanel2.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_logout.IconColor = System.Drawing.Color.Black;
            this.btn_logout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_logout.IconSize = 40;
            this.btn_logout.Location = new System.Drawing.Point(16, 2);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(49, 58);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btn_back.IconColor = System.Drawing.Color.Black;
            this.btn_back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_back.IconSize = 40;
            this.btn_back.Location = new System.Drawing.Point(16, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(49, 58);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_setting
            // 
            this.btn_setting.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_setting.FlatAppearance.BorderSize = 0;
            this.btn_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setting.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_setting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btn_setting.IconColor = System.Drawing.Color.Black;
            this.btn_setting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_setting.IconSize = 40;
            this.btn_setting.Location = new System.Drawing.Point(1789, 6);
            this.btn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setting.Name = "btn_setting";
            this.btn_setting.Size = new System.Drawing.Size(55, 49);
            this.btn_setting.TabIndex = 1;
            this.btn_setting.UseVisualStyleBackColor = false;
            this.btn_setting.Click += new System.EventHandler(this.btn_setting_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Roboto Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.Location = new System.Drawing.Point(862, 14);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(147, 33);
            this.lblTitleChildForm.TabIndex = 0;
            this.lblTitleChildForm.Text = "Dashboard";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1055);
            this.Controls.Add(this.panelBeranda);
            this.Controls.Add(this.panel_header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1900, 1018);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Collection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panelBeranda.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.layout_3card.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_doo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_doo)).EndInit();
            this.panel_retur.ResumeLayout(false);
            this.panel_retur.PerformLayout();
            this.panel_packing.ResumeLayout(false);
            this.panel_packing.PerformLayout();
            this.panel_receiving.ResumeLayout(false);
            this.panel_receiving.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_warehouse.ResumeLayout(false);
            this.panel_warehouse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_warehouse)).EndInit();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_logout;
        private FontAwesome.Sharp.IconButton btn_setting;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelBeranda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Summury;
        private System.Windows.Forms.TableLayoutPanel layout_3card;
        private RoundedPanel panel_receiving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelreceiving;
        private FontAwesome.Sharp.IconButton iconReceiving;
        private RoundedPanel panel_retur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelretur;
        private FontAwesome.Sharp.IconButton iconretur;
        private RoundedPanel panel_packing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lebelpacking;
        private FontAwesome.Sharp.IconButton iconpacking;
        private RoundedPanel panel_warehouse;
        private System.Windows.Forms.Label label12;
        private RoundedPanel roundedPanel1;
        private component.RoundedIconButton btn_receiving;
        private component.RoundedIconButton btn_decom;
        private component.RoundedIconButton btn_com;
        private component.RoundedIconButton btn_warehouse;
        private component.RoundedIconButton btn_retur;
        private component.RoundedIconButton btn_packing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private RoundedPanel panel_doo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_doo;
        private System.Windows.Forms.Panel paneloverlay;
        private System.Windows.Forms.DataGridView table_warehouse;
        private System.Windows.Forms.DataGridViewTextBoxColumn warehouse_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_header;
        private RoundedPanel roundedPanel2;
        private FontAwesome.Sharp.IconButton btn_back;
        private CustomControls.RJControls.RJComboBox combox_year;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

