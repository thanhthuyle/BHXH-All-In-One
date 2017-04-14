﻿namespace BHXH.List.UI
{
    partial class frmListQuocGia
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
        ///
        private void InitializeComponent()
        {
            this.gridcontrolListNationlity = new DevExpress.XtraGrid.GridControl();
            this.gridviewListNationlity = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolListNationlity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListNationlity)).BeginInit();
            this.SuspendLayout();
            // 
            // gridcontrolListNationlity
            // 
            this.gridcontrolListNationlity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.gridcontrolListNationlity.Location = new System.Drawing.Point(1, -1);
            this.gridcontrolListNationlity.MainView = this.gridviewListNationlity;
            this.gridcontrolListNationlity.Name = "gridcontrolListNationlity";
            this.gridcontrolListNationlity.Size = new System.Drawing.Size(784, 502);
            this.gridcontrolListNationlity.TabIndex = 3;
            this.gridcontrolListNationlity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridviewListNationlity});
            this.gridcontrolListNationlity.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // gridviewListNationlity
            // 
            this.gridviewListNationlity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.gridviewListNationlity.GridControl = this.gridcontrolListNationlity;
            this.gridviewListNationlity.Name = "gridviewListNationlity";
            this.gridviewListNationlity.OptionsBehavior.FocusLeaveOnTab = true;
            this.gridviewListNationlity.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridviewListNationlity.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridviewListNationlity.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridviewListNationlity.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridviewListNationlity.OptionsView.ShowAutoFilterRow = true;
            this.gridviewListNationlity.OptionsView.ShowGroupPanel = false;
            this.gridviewListNationlity.OptionsView.ShowViewCaption = true;
            this.gridviewListNationlity.ViewCaption = "Danh mục quốc gia";

            // 
            // gridColumn7
            // 
            this.gridColumn7.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn7.AppearanceHeader.Options.UseFont = true;
            this.gridColumn7.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn7.Caption = "Mã";
            this.gridColumn7.FieldName = "NationalityCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.ReadOnly = true;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 150;
            // 
            // gridColumn8
            // 
            this.gridColumn8.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gridColumn8.AppearanceHeader.Options.UseFont = true;
            this.gridColumn8.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumn8.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumn8.Caption = "Quốc gia";
            this.gridColumn8.FieldName = "TenQuocGia";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.ReadOnly = true;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            this.gridColumn8.Width = 448;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "IDQuocGia";
            this.gridColumn9.FieldName = "IDQuocGia";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.ReadOnly = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(698, 525);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 24);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Location = new System.Drawing.Point(611, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 24;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Location = new System.Drawing.Point(525, 525);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 24);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Location = new System.Drawing.Point(433, 525);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 24);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmListNationlity
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gridcontrolListNationlity);
            this.Name = "frmListNationlity";
            this.Load += new System.EventHandler(this.frmListNationlity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridcontrolListNationlity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewListNationlity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraGrid.GridControl gridcontrolListNationlity;
        internal DevExpress.XtraGrid.Views.Grid.GridView gridviewListNationlity;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        internal DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        internal DevExpress.XtraEditors.SimpleButton btnThoat;
        internal DevExpress.XtraEditors.SimpleButton btnXoa;
        internal DevExpress.XtraEditors.SimpleButton btnSua;
        internal DevExpress.XtraEditors.SimpleButton btnThem;
    }
}