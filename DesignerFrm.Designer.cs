using DevExpress.DXperience.Demos;

namespace DevExpress.XtraDiagram.Demos {
    partial class DesignerFrm {
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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesignerFrm));
            skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            rpgAppearance = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            bbiRoundedMode = new DevExpress.XtraBars.BarCheckItem();
            SuspendLayout();
            // 
            // skinDropDownButtonItem1
            // 
            skinDropDownButtonItem1.ActAsDropDown = true;
            skinDropDownButtonItem1.ButtonStyle = XtraBars.BarButtonStyle.DropDown;
            skinDropDownButtonItem1.Id = 1;
            skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // rpgAppearance
            // 
            rpgAppearance.ItemLinks.Add(skinDropDownButtonItem1);
            rpgAppearance.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1);
            rpgAppearance.ItemLinks.Add(bbiRoundedMode);
            rpgAppearance.Name = "rpgAppearance";
            rpgAppearance.CaptionButtonClick += RpgAppearance_CaptionButtonClick;
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            skinPaletteRibbonGalleryBarItem1.Id = 2;
            skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // bbiRoundedMode
            // 
            bbiRoundedMode.Id = 3;
            bbiRoundedMode.Name = "bbiRoundedMode";
            bbiRoundedMode.CheckedChanged += OnRoundedModeCheckedChanged;
            // 
            // DesignerFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1549, 833);
            IconOptions.Icon = (System.Drawing.Icon)resources.GetObject("DesignerFrm.IconOptions.Icon");
            Name = "DesignerFrm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private XtraBars.Ribbon.RibbonPageGroup rpgAppearance;
        private XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private XtraBars.BarCheckItem bbiRoundedMode;
        private DevExpress.XtraBars.PopupMenu pmAppearance;
    }
}

