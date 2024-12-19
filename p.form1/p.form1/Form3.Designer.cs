namespace p.form1
{
    partial class Form3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Namee = new System.Windows.Forms.TextBox();
            this.Pricee = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.Open = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.SQUEEZE = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Read = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.IDD = new System.Windows.Forms.TextBox();
            this.BUY = new System.Windows.Forms.Button();
            this.SELL = new System.Windows.Forms.Button();
            this.IDBUY = new System.Windows.Forms.TextBox();
            this.NUMBUY = new System.Windows.Forms.TextBox();
            this.IDSELL = new System.Windows.Forms.TextBox();
            this.NUMSELL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "amount";
            // 
            // Namee
            // 
            this.Namee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namee.Location = new System.Drawing.Point(146, 63);
            this.Namee.Name = "Namee";
            this.Namee.Size = new System.Drawing.Size(829, 44);
            this.Namee.TabIndex = 2;
            // 
            // Pricee
            // 
            this.Pricee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pricee.Location = new System.Drawing.Point(143, 121);
            this.Pricee.Name = "Pricee";
            this.Pricee.Size = new System.Drawing.Size(829, 44);
            this.Pricee.TabIndex = 2;
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(143, 176);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(829, 44);
            this.Amount.TabIndex = 2;
            // 
            // Open
            // 
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(12, 226);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(963, 85);
            this.Open.TabIndex = 3;
            this.Open.Text = "Open file";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Insert
            // 
            this.Insert.Enabled = false;
            this.Insert.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.Location = new System.Drawing.Point(12, 317);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(232, 116);
            this.Insert.TabIndex = 4;
            this.Insert.Text = "Insert record";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // SQUEEZE
            // 
            this.SQUEEZE.Enabled = false;
            this.SQUEEZE.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQUEEZE.Location = new System.Drawing.Point(12, 571);
            this.SQUEEZE.Name = "SQUEEZE";
            this.SQUEEZE.Size = new System.Drawing.Size(470, 178);
            this.SQUEEZE.TabIndex = 6;
            this.SQUEEZE.Text = "Squeeze";
            this.SQUEEZE.UseVisualStyleBackColor = true;
            this.SQUEEZE.Click += new System.EventHandler(this.SQUEEZE_Click);
            // 
            // Delete
            // 
            this.Delete.Enabled = false;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(250, 449);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(232, 116);
            this.Delete.TabIndex = 5;
            this.Delete.Text = "Delete record";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Read
            // 
            this.Read.Enabled = false;
            this.Read.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Read.Location = new System.Drawing.Point(250, 317);
            this.Read.Name = "Read";
            this.Read.Size = new System.Drawing.Size(232, 116);
            this.Read.TabIndex = 7;
            this.Read.Text = "Read record";
            this.Read.UseVisualStyleBackColor = true;
            this.Read.Click += new System.EventHandler(this.Read_Click);
            // 
            // search
            // 
            this.search.Enabled = false;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(12, 449);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(232, 116);
            this.search.TabIndex = 5;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(12, 9);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(48, 37);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // IDD
            // 
            this.IDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDD.Location = new System.Drawing.Point(146, 9);
            this.IDD.Name = "IDD";
            this.IDD.Size = new System.Drawing.Size(829, 44);
            this.IDD.TabIndex = 2;
            // 
            // BUY
            // 
            this.BUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUY.Location = new System.Drawing.Point(617, 317);
            this.BUY.Name = "BUY";
            this.BUY.Size = new System.Drawing.Size(246, 72);
            this.BUY.TabIndex = 8;
            this.BUY.Text = "Buy";
            this.BUY.UseVisualStyleBackColor = true;
            this.BUY.Click += new System.EventHandler(this.BUY_Click);
            // 
            // SELL
            // 
            this.SELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELL.Location = new System.Drawing.Point(617, 523);
            this.SELL.Name = "SELL";
            this.SELL.Size = new System.Drawing.Size(246, 72);
            this.SELL.TabIndex = 8;
            this.SELL.Text = "Sell";
            this.SELL.UseVisualStyleBackColor = true;
            this.SELL.Click += new System.EventHandler(this.SELL_Click);
            // 
            // IDBUY
            // 
            this.IDBUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBUY.ForeColor = System.Drawing.Color.LightGray;
            this.IDBUY.Location = new System.Drawing.Point(500, 402);
            this.IDBUY.Name = "IDBUY";
            this.IDBUY.Size = new System.Drawing.Size(461, 31);
            this.IDBUY.TabIndex = 9;
            this.IDBUY.Text = "ID";
            this.IDBUY.Enter += new System.EventHandler(this.IDBUY_Enter);
            this.IDBUY.Leave += new System.EventHandler(this.IDBUY_Leave);
            // 
            // NUMBUY
            // 
            this.NUMBUY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMBUY.ForeColor = System.Drawing.Color.LightGray;
            this.NUMBUY.Location = new System.Drawing.Point(500, 449);
            this.NUMBUY.Name = "NUMBUY";
            this.NUMBUY.Size = new System.Drawing.Size(461, 31);
            this.NUMBUY.TabIndex = 9;
            this.NUMBUY.Text = "NUMBER";
            this.NUMBUY.Enter += new System.EventHandler(this.NUMBUY_Enter);
            this.NUMBUY.Leave += new System.EventHandler(this.NUMBUY_Leave);
            // 
            // IDSELL
            // 
            this.IDSELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDSELL.ForeColor = System.Drawing.Color.LightGray;
            this.IDSELL.Location = new System.Drawing.Point(500, 625);
            this.IDSELL.Name = "IDSELL";
            this.IDSELL.Size = new System.Drawing.Size(461, 31);
            this.IDSELL.TabIndex = 9;
            this.IDSELL.Text = "ID";
            this.IDSELL.Enter += new System.EventHandler(this.IDSELL_Enter);
            this.IDSELL.Leave += new System.EventHandler(this.IDSELL_Leave);
            // 
            // NUMSELL
            // 
            this.NUMSELL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUMSELL.ForeColor = System.Drawing.Color.LightGray;
            this.NUMSELL.Location = new System.Drawing.Point(500, 672);
            this.NUMSELL.Name = "NUMSELL";
            this.NUMSELL.Size = new System.Drawing.Size(461, 31);
            this.NUMSELL.TabIndex = 9;
            this.NUMSELL.Text = "NUMBER";
            this.NUMSELL.Enter += new System.EventHandler(this.NUMSELL_Enter);
            this.NUMSELL.Leave += new System.EventHandler(this.NUMSELL_Leave);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.NUMSELL);
            this.Controls.Add(this.NUMBUY);
            this.Controls.Add(this.IDSELL);
            this.Controls.Add(this.IDBUY);
            this.Controls.Add(this.SELL);
            this.Controls.Add(this.BUY);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.SQUEEZE);
            this.Controls.Add(this.search);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.Pricee);
            this.Controls.Add(this.IDD);
            this.Controls.Add(this.Namee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Namee;
        private System.Windows.Forms.TextBox Pricee;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button SQUEEZE;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Read;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox IDD;
        private System.Windows.Forms.Button BUY;
        private System.Windows.Forms.Button SELL;
        private System.Windows.Forms.TextBox IDBUY;
        private System.Windows.Forms.TextBox NUMBUY;
        private System.Windows.Forms.TextBox IDSELL;
        private System.Windows.Forms.TextBox NUMSELL;
    }
}