namespace MegaDesk_Tapia
{
    partial class MainMenu
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
            this.btnAddQuote = new System.Windows.Forms.Button();
            this.btnSearchQuotes = new System.Windows.Forms.Button();
            this.btnViewQuotes = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddQuote
            // 
            this.btnAddQuote.FlatAppearance.BorderSize = 2;
            this.btnAddQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(32, 50);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(172, 85);
            this.btnAddQuote.TabIndex = 0;
            this.btnAddQuote.Text = "Add New Quote";
            this.btnAddQuote.UseVisualStyleBackColor = true;
            this.btnAddQuote.Click += new System.EventHandler(this.BtnAddQuote);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.FlatAppearance.BorderSize = 2;
            this.btnSearchQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(32, 267);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(172, 85);
            this.btnSearchQuotes.TabIndex = 1;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = true;
            this.btnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.FlatAppearance.BorderSize = 2;
            this.btnViewQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(32, 158);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(172, 85);
            this.btnViewQuotes.TabIndex = 2;
            this.btnViewQuotes.Text = "View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = true;
            this.btnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(32, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 85);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 498);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnAddQuote);
            this.Name = "MainMenu";
            this.Text = "MegaDesk";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddQuote;
        private System.Windows.Forms.Button btnSearchQuotes;
        private System.Windows.Forms.Button btnViewQuotes;
        private System.Windows.Forms.Button btnExit;
    }
}

