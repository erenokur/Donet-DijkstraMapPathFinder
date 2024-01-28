namespace MapPathFinderApp
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
        private void InitializeComponent()
        {
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TopTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddMap = new System.Windows.Forms.Button();
            this.FindPath = new System.Windows.Forms.Button();
            this.ClearAll = new System.Windows.Forms.Button();
            this.SendPathRobot = new System.Windows.Forms.Button();
            this.MapSizeTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.HeightextBox = new System.Windows.Forms.RichTextBox();
            this.WidthTextBox = new System.Windows.Forms.RichTextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.MainTableLayout.SuspendLayout();
            this.TopTableLayout.SuspendLayout();
            this.MapSizeTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.TopTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.MapPanel, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainTableLayout.Size = new System.Drawing.Size(800, 450);
            this.MainTableLayout.TabIndex = 0;
            // 
            // TopTableLayout
            // 
            this.TopTableLayout.ColumnCount = 5;
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TopTableLayout.Controls.Add(this.AddMap, 0, 0);
            this.TopTableLayout.Controls.Add(this.FindPath, 1, 0);
            this.TopTableLayout.Controls.Add(this.ClearAll, 2, 0);
            this.TopTableLayout.Controls.Add(this.SendPathRobot, 3, 0);
            this.TopTableLayout.Controls.Add(this.MapSizeTableLayout, 4, 0);
            this.TopTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopTableLayout.Location = new System.Drawing.Point(3, 3);
            this.TopTableLayout.Name = "TopTableLayout";
            this.TopTableLayout.RowCount = 1;
            this.TopTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopTableLayout.Size = new System.Drawing.Size(794, 84);
            this.TopTableLayout.TabIndex = 5;
            // 
            // AddMap
            // 
            this.AddMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddMap.Location = new System.Drawing.Point(3, 3);
            this.AddMap.Name = "AddMap";
            this.AddMap.Size = new System.Drawing.Size(152, 78);
            this.AddMap.TabIndex = 2;
            this.AddMap.Text = "Add Map";
            this.AddMap.UseVisualStyleBackColor = true;
            this.AddMap.Click += new System.EventHandler(this.AddMap_Click);
            // 
            // FindPath
            // 
            this.FindPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FindPath.Location = new System.Drawing.Point(161, 3);
            this.FindPath.Name = "FindPath";
            this.FindPath.Size = new System.Drawing.Size(152, 78);
            this.FindPath.TabIndex = 3;
            this.FindPath.Text = "Find Path";
            this.FindPath.UseVisualStyleBackColor = true;
            this.FindPath.Click += new System.EventHandler(this.FindPath_Click);
            // 
            // ClearAll
            // 
            this.ClearAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearAll.Location = new System.Drawing.Point(319, 3);
            this.ClearAll.Name = "ClearAll";
            this.ClearAll.Size = new System.Drawing.Size(152, 78);
            this.ClearAll.TabIndex = 4;
            this.ClearAll.Text = "Clear ";
            this.ClearAll.UseVisualStyleBackColor = true;
            this.ClearAll.Click += new System.EventHandler(this.ClearAll_Click);
            // 
            // SendPathRobot
            // 
            this.SendPathRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendPathRobot.Location = new System.Drawing.Point(477, 3);
            this.SendPathRobot.Name = "SendPathRobot";
            this.SendPathRobot.Size = new System.Drawing.Size(152, 78);
            this.SendPathRobot.TabIndex = 2;
            this.SendPathRobot.Text = "Send Robot";
            this.SendPathRobot.UseVisualStyleBackColor = true;
            this.SendPathRobot.Click += new System.EventHandler(this.SendPathRobot_Click);
            // 
            // MapSizeTableLayout
            // 
            this.MapSizeTableLayout.ColumnCount = 2;
            this.MapSizeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MapSizeTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MapSizeTableLayout.Controls.Add(this.HeightextBox, 1, 1);
            this.MapSizeTableLayout.Controls.Add(this.WidthTextBox, 1, 0);
            this.MapSizeTableLayout.Controls.Add(this.HeightLabel, 0, 1);
            this.MapSizeTableLayout.Controls.Add(this.WidthLabel, 0, 0);
            this.MapSizeTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapSizeTableLayout.Location = new System.Drawing.Point(635, 3);
            this.MapSizeTableLayout.Name = "MapSizeTableLayout";
            this.MapSizeTableLayout.RowCount = 2;
            this.MapSizeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MapSizeTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MapSizeTableLayout.Size = new System.Drawing.Size(156, 78);
            this.MapSizeTableLayout.TabIndex = 6;
            // 
            // HeightextBox
            // 
            this.HeightextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightextBox.Location = new System.Drawing.Point(81, 42);
            this.HeightextBox.Name = "HeightextBox";
            this.HeightextBox.Size = new System.Drawing.Size(72, 33);
            this.HeightextBox.TabIndex = 7;
            this.HeightextBox.Text = "";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthTextBox.Location = new System.Drawing.Point(81, 3);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(72, 33);
            this.WidthTextBox.TabIndex = 8;
            this.WidthTextBox.Text = "";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeightLabel.Location = new System.Drawing.Point(3, 39);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(72, 39);
            this.HeightLabel.TabIndex = 9;
            this.HeightLabel.Text = "Height :";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WidthLabel.Location = new System.Drawing.Point(3, 0);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(72, 39);
            this.WidthLabel.TabIndex = 10;
            this.WidthLabel.Text = "Width :";
            // 
            // MapPanel
            // 
            this.MapPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapPanel.Location = new System.Drawing.Point(3, 93);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(794, 354);
            this.MapPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainTableLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MainTableLayout.ResumeLayout(false);
            this.TopTableLayout.ResumeLayout(false);
            this.MapSizeTableLayout.ResumeLayout(false);
            this.MapSizeTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.Button AddMap;
        private System.Windows.Forms.Button FindPath;
        private System.Windows.Forms.Button ClearAll;
        private System.Windows.Forms.Button SendPathRobot;
        private System.Windows.Forms.TableLayoutPanel TopTableLayout;
        private System.Windows.Forms.TableLayoutPanel MapSizeTableLayout;
        private System.Windows.Forms.RichTextBox HeightextBox;
        private System.Windows.Forms.RichTextBox WidthTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
    }
}
