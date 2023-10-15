namespace MegaDesk_Tapia
{
    partial class SearchQuotes
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
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depthSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.drawersSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rushDaysSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceSearch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(199, 41);
            this.cmbMaterial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(931, 33);
            this.cmbMaterial.TabIndex = 0;
            this.cmbMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbMaterial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameSearch,
            this.dateSearch,
            this.widthSearch,
            this.depthSearch,
            this.drawersSearch,
            this.materialSearch,
            this.rushDaysSearch,
            this.priceSearch});
            this.dataGridView.Enabled = false;
            this.dataGridView.Location = new System.Drawing.Point(58, 84);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1657, 821);
            this.dataGridView.TabIndex = 2;
            // 
            // nameSearch
            // 
            this.nameSearch.HeaderText = "Name";
            this.nameSearch.MinimumWidth = 10;
            this.nameSearch.Name = "nameSearch";
            // 
            // dateSearch
            // 
            this.dateSearch.HeaderText = "Date";
            this.dateSearch.MinimumWidth = 10;
            this.dateSearch.Name = "dateSearch";
            // 
            // widthSearch
            // 
            this.widthSearch.HeaderText = "Width";
            this.widthSearch.MinimumWidth = 10;
            this.widthSearch.Name = "widthSearch";
            // 
            // depthSearch
            // 
            this.depthSearch.HeaderText = "Depth";
            this.depthSearch.MinimumWidth = 10;
            this.depthSearch.Name = "depthSearch";
            // 
            // drawersSearch
            // 
            this.drawersSearch.HeaderText = "Drawers";
            this.drawersSearch.MinimumWidth = 10;
            this.drawersSearch.Name = "drawersSearch";
            // 
            // materialSearch
            // 
            this.materialSearch.HeaderText = "Material";
            this.materialSearch.MinimumWidth = 10;
            this.materialSearch.Name = "materialSearch";
            // 
            // rushDaysSearch
            // 
            this.rushDaysSearch.HeaderText = "Rush Days";
            this.rushDaysSearch.MinimumWidth = 10;
            this.rushDaysSearch.Name = "rushDaysSearch";
            // 
            // priceSearch
            // 
            this.priceSearch.HeaderText = "Price";
            this.priceSearch.MinimumWidth = 10;
            this.priceSearch.Name = "priceSearch";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1837, 978);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMaterial);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn depthSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn drawersSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn materialSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn rushDaysSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceSearch;
    }
}