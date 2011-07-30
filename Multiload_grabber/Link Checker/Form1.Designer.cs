namespace MultiloadGrabber
{
    partial class LinkCheckerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinkCheckerForm));
            this.linkCheckerResults = new System.Windows.Forms.DataGridView();
            this.checkButton = new System.Windows.Forms.Button();
            this.multiLoadLinky = new System.Windows.Forms.GroupBox();
            this.inputLinks = new System.Windows.Forms.TextBox();
            this.excludeSR = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.linkCheckerResults)).BeginInit();
            this.multiLoadLinky.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkCheckerResults
            // 
            this.linkCheckerResults.AllowUserToAddRows = false;
            this.linkCheckerResults.AllowUserToDeleteRows = false;
            this.linkCheckerResults.AllowUserToResizeColumns = false;
            this.linkCheckerResults.AllowUserToResizeRows = false;
            this.linkCheckerResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.linkCheckerResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.linkCheckerResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linkCheckerResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.linkCheckerResults.Location = new System.Drawing.Point(12, 180);
            this.linkCheckerResults.MultiSelect = false;
            this.linkCheckerResults.Name = "linkCheckerResults";
            this.linkCheckerResults.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.linkCheckerResults.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.linkCheckerResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkCheckerResults.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.linkCheckerResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.linkCheckerResults.ShowCellToolTips = false;
            this.linkCheckerResults.ShowEditingIcon = false;
            this.linkCheckerResults.Size = new System.Drawing.Size(947, 288);
            this.linkCheckerResults.TabIndex = 1;
            this.linkCheckerResults.SelectionChanged += new System.EventHandler(this.linkCheckerResults_SelectionChanged);
            // 
            // checkButton
            // 
            this.checkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkButton.Location = new System.Drawing.Point(690, 135);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(269, 39);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Kontroluj!";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiLoadLinky
            // 
            this.multiLoadLinky.Controls.Add(this.inputLinks);
            this.multiLoadLinky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiLoadLinky.Location = new System.Drawing.Point(12, 12);
            this.multiLoadLinky.Name = "multiLoadLinky";
            this.multiLoadLinky.Size = new System.Drawing.Size(538, 162);
            this.multiLoadLinky.TabIndex = 4;
            this.multiLoadLinky.TabStop = false;
            this.multiLoadLinky.Text = "Linky na Multiload";
            // 
            // inputLinks
            // 
            this.inputLinks.Location = new System.Drawing.Point(6, 18);
            this.inputLinks.Multiline = true;
            this.inputLinks.Name = "inputLinks";
            this.inputLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.inputLinks.Size = new System.Drawing.Size(525, 137);
            this.inputLinks.TabIndex = 1;
            this.inputLinks.WordWrap = false;
            // 
            // excludeSR
            // 
            this.excludeSR.AutoSize = true;
            this.excludeSR.Location = new System.Drawing.Point(556, 157);
            this.excludeSR.Name = "excludeSR";
            this.excludeSR.Size = new System.Drawing.Size(133, 17);
            this.excludeSR.TabIndex = 5;
            this.excludeSR.Text = "Vynechat Share-Rapid";
            this.excludeSR.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(556, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "OK";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(559, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 63);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(690, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(125, 63);
            this.panel2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(32, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dead";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(821, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 63);
            this.panel3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(0, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nevybráno";
            // 
            // LinkCheckerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 467);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.excludeSR);
            this.Controls.Add(this.multiLoadLinky);
            this.Controls.Add(this.linkCheckerResults);
            this.Controls.Add(this.checkButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinkCheckerForm";
            this.Text = "Link Checker";
            ((System.ComponentModel.ISupportInitialize)(this.linkCheckerResults)).EndInit();
            this.multiLoadLinky.ResumeLayout(false);
            this.multiLoadLinky.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView linkCheckerResults;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.GroupBox multiLoadLinky;
        private System.Windows.Forms.TextBox inputLinks;
        private System.Windows.Forms.CheckBox excludeSR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
    }
}