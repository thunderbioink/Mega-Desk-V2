namespace MegaDesk_Tapia
{
    partial class AddQuote
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
            this.name = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.delivery = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.depth = new System.Windows.Forms.Label();
            this.widthlabel = new System.Windows.Forms.Label();
            this.customerName = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtNumDrawers = new System.Windows.Forms.TextBox();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.cmbRushOrder = new System.Windows.Forms.ComboBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(63, 60);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(53, 20);
            this.name.TabIndex = 0;
            this.name.Text = "Name";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material.Location = new System.Drawing.Point(63, 212);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(69, 20);
            this.material.TabIndex = 1;
            this.material.Text = "Material";
            // 
            // delivery
            // 
            this.delivery.AutoSize = true;
            this.delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delivery.Location = new System.Drawing.Point(63, 306);
            this.delivery.Name = "delivery";
            this.delivery.Size = new System.Drawing.Size(70, 20);
            this.delivery.TabIndex = 2;
            this.delivery.Text = "Delivery";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawers.Location = new System.Drawing.Point(63, 160);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(73, 20);
            this.drawers.TabIndex = 3;
            this.drawers.Text = "Drawers";
            // 
            // depth
            // 
            this.depth.AutoSize = true;
            this.depth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depth.Location = new System.Drawing.Point(304, 114);
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(54, 20);
            this.depth.TabIndex = 4;
            this.depth.Text = "Depth";
            // 
            // widthlabel
            // 
            this.widthlabel.AutoSize = true;
            this.widthlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthlabel.Location = new System.Drawing.Point(63, 114);
            this.widthlabel.Name = "widthlabel";
            this.widthlabel.Size = new System.Drawing.Size(52, 20);
            this.widthlabel.TabIndex = 5;
            this.widthlabel.Text = "Width";
            // 
            // customerName
            // 
            this.customerName.Location = new System.Drawing.Point(122, 58);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(357, 22);
            this.customerName.TabIndex = 6;
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(364, 114);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(72, 22);
            this.txtDepth.TabIndex = 8;
            this.txtDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_Validating);
            // 
            // txtNumDrawers
            // 
            this.txtNumDrawers.Location = new System.Drawing.Point(142, 160);
            this.txtNumDrawers.Name = "txtNumDrawers";
            this.txtNumDrawers.Size = new System.Drawing.Size(72, 22);
            this.txtNumDrawers.TabIndex = 9;
            // 
            // cmbMaterial
            // 
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.FormattingEnabled = true;
            this.cmbMaterial.Location = new System.Drawing.Point(142, 212);
            this.cmbMaterial.Name = "cmbMaterial";
            this.cmbMaterial.Size = new System.Drawing.Size(121, 24);
            this.cmbMaterial.TabIndex = 10;
            // 
            // cmbRushOrder
            // 
            this.cmbRushOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRushOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRushOrder.FormattingEnabled = true;
            this.cmbRushOrder.Location = new System.Drawing.Point(142, 302);
            this.cmbRushOrder.Name = "cmbRushOrder";
            this.cmbRushOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbRushOrder.Size = new System.Drawing.Size(121, 24);
            this.cmbRushOrder.TabIndex = 11;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(328, 340);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(160, 52);
            this.submitbtn.TabIndex = 12;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(628, 408);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(160, 30);
            this.cancel.TabIndex = 13;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(142, 114);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(72, 22);
            this.txtWidth.TabIndex = 14;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.Width_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "1 up to 9 ";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.cmbRushOrder);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.txtNumDrawers);
            this.Controls.Add(this.txtDepth);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.widthlabel);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.delivery);
            this.Controls.Add(this.material);
            this.Controls.Add(this.name);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.Label delivery;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.Label depth;
        private System.Windows.Forms.Label widthlabel;
        private System.Windows.Forms.TextBox customerName;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtNumDrawers;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.ComboBox cmbRushOrder;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label1;
    }
}