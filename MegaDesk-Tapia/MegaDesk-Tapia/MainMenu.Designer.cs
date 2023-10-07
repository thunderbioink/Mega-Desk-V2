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
            this.btnAddQuote.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddQuote.FlatAppearance.BorderSize = 2;
            this.btnAddQuote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddQuote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuote.Location = new System.Drawing.Point(50, 20);
            this.btnAddQuote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddQuote.Name = "btnAddQuote";
            this.btnAddQuote.Size = new System.Drawing.Size(700, 80);
            this.btnAddQuote.TabIndex = 0;
            this.btnAddQuote.Text = "Add New Quote";
            this.btnAddQuote.UseVisualStyleBackColor = false;
            this.btnAddQuote.Click += new System.EventHandler(this.BtnAddQuote);
            // 
            // btnSearchQuotes
            // 
            this.btnSearchQuotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearchQuotes.FlatAppearance.BorderSize = 2;
            this.btnSearchQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnSearchQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchQuotes.Location = new System.Drawing.Point(50, 220);
            this.btnSearchQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchQuotes.Name = "btnSearchQuotes";
            this.btnSearchQuotes.Size = new System.Drawing.Size(700, 80);
            this.btnSearchQuotes.TabIndex = 1;
            this.btnSearchQuotes.Text = "Search Quotes";
            this.btnSearchQuotes.UseVisualStyleBackColor = false;
            this.btnSearchQuotes.Click += new System.EventHandler(this.BtnSearchQuotes);
            // 
            // btnViewQuotes
            // 
            this.btnViewQuotes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnViewQuotes.FlatAppearance.BorderSize = 2;
            this.btnViewQuotes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewQuotes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnViewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewQuotes.Location = new System.Drawing.Point(50, 120);
            this.btnViewQuotes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewQuotes.Name = "btnViewQuotes";
            this.btnViewQuotes.Size = new System.Drawing.Size(700, 80);
            this.btnViewQuotes.TabIndex = 2;
            this.btnViewQuotes.Text = "View Quotes";
            this.btnViewQuotes.UseVisualStyleBackColor = false;
            this.btnViewQuotes.Click += new System.EventHandler(this.BtnViewQuotes);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(50, 320);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(700, 80);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.BtnExit);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 424);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnViewQuotes);
            this.Controls.Add(this.btnSearchQuotes);
            this.Controls.Add(this.btnAddQuote);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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

