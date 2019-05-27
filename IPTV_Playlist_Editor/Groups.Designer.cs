namespace Kodi_M3U_IPTV_Editor
{
    partial class Groups
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
            this.groupsGridView = new System.Windows.Forms.DataGridView();
            this.deleteGroupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupsGridView
            // 
            this.groupsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupsGridView.Location = new System.Drawing.Point(12, 26);
            this.groupsGridView.Name = "groupsGridView";
            this.groupsGridView.Size = new System.Drawing.Size(488, 579);
            this.groupsGridView.TabIndex = 0;
            // 
            // deleteGroupButton
            // 
            this.deleteGroupButton.Location = new System.Drawing.Point(368, 625);
            this.deleteGroupButton.Name = "deleteGroupButton";
            this.deleteGroupButton.Size = new System.Drawing.Size(132, 42);
            this.deleteGroupButton.TabIndex = 1;
            this.deleteGroupButton.Text = "Delete";
            this.deleteGroupButton.UseVisualStyleBackColor = true;
            this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
            // 
            // Groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 711);
            this.Controls.Add(this.deleteGroupButton);
            this.Controls.Add(this.groupsGridView);
            this.Name = "Groups";
            this.Text = "Groups";
            ((System.ComponentModel.ISupportInitialize)(this.groupsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView groupsGridView;
        private System.Windows.Forms.Button deleteGroupButton;
    }
}