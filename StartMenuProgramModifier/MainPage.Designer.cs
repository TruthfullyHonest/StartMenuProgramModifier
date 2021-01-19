
namespace StartMenuProgramModifier
{
    partial class FRM_SMPM
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
            this.BTN_LoadShortcut = new System.Windows.Forms.Button();
            this.BTN_EditShortcut = new System.Windows.Forms.Button();
            this.BTN_DuplicateShortcut = new System.Windows.Forms.Button();
            this.BTN_DeleteShortcut = new System.Windows.Forms.Button();
            this.BTN_Refresh = new System.Windows.Forms.Button();
            this.IMGLST_Images = new System.Windows.Forms.ImageList(this.components);
            this.LSTVW_Shortcuts = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // BTN_LoadShortcut
            // 
            this.BTN_LoadShortcut.Location = new System.Drawing.Point(29, 299);
            this.BTN_LoadShortcut.Name = "BTN_LoadShortcut";
            this.BTN_LoadShortcut.Size = new System.Drawing.Size(109, 35);
            this.BTN_LoadShortcut.TabIndex = 1;
            this.BTN_LoadShortcut.Text = "Load Shortcut";
            this.BTN_LoadShortcut.UseVisualStyleBackColor = true;
            this.BTN_LoadShortcut.Click += new System.EventHandler(this.BTN_LoadShortcut_Click);
            // 
            // BTN_EditShortcut
            // 
            this.BTN_EditShortcut.Location = new System.Drawing.Point(158, 299);
            this.BTN_EditShortcut.Name = "BTN_EditShortcut";
            this.BTN_EditShortcut.Size = new System.Drawing.Size(109, 35);
            this.BTN_EditShortcut.TabIndex = 2;
            this.BTN_EditShortcut.Text = "Edit Shortcut";
            this.BTN_EditShortcut.UseVisualStyleBackColor = true;
            // 
            // BTN_DuplicateShortcut
            // 
            this.BTN_DuplicateShortcut.Location = new System.Drawing.Point(287, 299);
            this.BTN_DuplicateShortcut.Name = "BTN_DuplicateShortcut";
            this.BTN_DuplicateShortcut.Size = new System.Drawing.Size(109, 35);
            this.BTN_DuplicateShortcut.TabIndex = 3;
            this.BTN_DuplicateShortcut.Text = "Duplicate Shortcut";
            this.BTN_DuplicateShortcut.UseVisualStyleBackColor = true;
            // 
            // BTN_DeleteShortcut
            // 
            this.BTN_DeleteShortcut.Location = new System.Drawing.Point(419, 299);
            this.BTN_DeleteShortcut.Name = "BTN_DeleteShortcut";
            this.BTN_DeleteShortcut.Size = new System.Drawing.Size(109, 35);
            this.BTN_DeleteShortcut.TabIndex = 4;
            this.BTN_DeleteShortcut.Text = "Delete Shortcut";
            this.BTN_DeleteShortcut.UseVisualStyleBackColor = true;
            // 
            // BTN_Refresh
            // 
            this.BTN_Refresh.Location = new System.Drawing.Point(548, 299);
            this.BTN_Refresh.Name = "BTN_Refresh";
            this.BTN_Refresh.Size = new System.Drawing.Size(109, 35);
            this.BTN_Refresh.TabIndex = 5;
            this.BTN_Refresh.Text = "Refresh";
            this.BTN_Refresh.UseVisualStyleBackColor = true;
            // 
            // IMGLST_Images
            // 
            this.IMGLST_Images.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.IMGLST_Images.ImageSize = new System.Drawing.Size(16, 16);
            this.IMGLST_Images.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // LSTVW_Shortcuts
            // 
            this.LSTVW_Shortcuts.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.LSTVW_Shortcuts.AllowColumnReorder = true;
            this.LSTVW_Shortcuts.FullRowSelect = true;
            this.LSTVW_Shortcuts.HideSelection = false;
            this.LSTVW_Shortcuts.LargeImageList = this.IMGLST_Images;
            this.LSTVW_Shortcuts.Location = new System.Drawing.Point(29, 16);
            this.LSTVW_Shortcuts.Name = "LSTVW_Shortcuts";
            this.LSTVW_Shortcuts.Size = new System.Drawing.Size(628, 271);
            this.LSTVW_Shortcuts.SmallImageList = this.IMGLST_Images;
            this.LSTVW_Shortcuts.TabIndex = 7;
            this.LSTVW_Shortcuts.UseCompatibleStateImageBehavior = false;
            this.LSTVW_Shortcuts.View = System.Windows.Forms.View.List;
            this.LSTVW_Shortcuts.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LSTVW_Shortcuts_ItemSelectionChanged);
            // 
            // FRM_SMPM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 346);
            this.Controls.Add(this.LSTVW_Shortcuts);
            this.Controls.Add(this.BTN_Refresh);
            this.Controls.Add(this.BTN_DeleteShortcut);
            this.Controls.Add(this.BTN_DuplicateShortcut);
            this.Controls.Add(this.BTN_EditShortcut);
            this.Controls.Add(this.BTN_LoadShortcut);
            this.Name = "FRM_SMPM";
            this.Text = "Start Menu Program Modifier";
            this.Load += new System.EventHandler(this.FRM_SMPM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_LoadShortcut;
        private System.Windows.Forms.Button BTN_EditShortcut;
        private System.Windows.Forms.Button BTN_DuplicateShortcut;
        private System.Windows.Forms.Button BTN_DeleteShortcut;
        private System.Windows.Forms.Button BTN_Refresh;
        private System.Windows.Forms.ImageList IMGLST_Images;
        private System.Windows.Forms.ListView LSTVW_Shortcuts;
    }
}

