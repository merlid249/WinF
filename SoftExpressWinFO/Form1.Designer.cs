namespace SoftExpressWinFO
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.Label();
            this.lbEmertimi = new System.Windows.Forms.Label();
            this.lblNjesia = new System.Windows.Forms.Label();
            this.lblDSkadenc = new System.Windows.Forms.Label();
            this.lblCmimi = new System.Windows.Forms.Label();
            this.lblLloji = new System.Windows.Forms.Label();
            this.lblKaTvsh = new System.Windows.Forms.Label();
            this.lblTipi = new System.Windows.Forms.Label();
            this.lblBarkodi = new System.Windows.Forms.Label();
            this.btnTeDhenat = new System.Windows.Forms.Button();
            this.btnRuaj = new System.Windows.Forms.Button();
            this.btnKerko = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmertimi = new System.Windows.Forms.TextBox();
            this.txtNjesia = new System.Windows.Forms.TextBox();
            this.txtBarkodi = new System.Windows.Forms.TextBox();
            this.txtCmimi = new System.Windows.Forms.TextBox();
            this.rbLloji = new System.Windows.Forms.RadioButton();
            this.rdlloji2 = new System.Windows.Forms.RadioButton();
            this.cbKaTVSH = new System.Windows.Forms.CheckBox();
            this.dtSkadenc = new System.Windows.Forms.DateTimePicker();
            this.cbTipi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-6, 398);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(934, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Title.Location = new System.Drawing.Point(15, 22);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(248, 20);
            this.Title.TabIndex = 1;
            this.Title.Text = "Regjistrimi Artikullit Ne Datbaze";
            // 
            // lbEmertimi
            // 
            this.lbEmertimi.AutoSize = true;
            this.lbEmertimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEmertimi.Location = new System.Drawing.Point(15, 69);
            this.lbEmertimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmertimi.Name = "lbEmertimi";
            this.lbEmertimi.Size = new System.Drawing.Size(76, 20);
            this.lbEmertimi.TabIndex = 2;
            this.lbEmertimi.Text = "Emertimi";
            // 
            // lblNjesia
            // 
            this.lblNjesia.AutoSize = true;
            this.lblNjesia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNjesia.Location = new System.Drawing.Point(15, 132);
            this.lblNjesia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNjesia.Name = "lblNjesia";
            this.lblNjesia.Size = new System.Drawing.Size(56, 20);
            this.lblNjesia.TabIndex = 3;
            this.lblNjesia.Text = "Njesia";
            // 
            // lblDSkadenc
            // 
            this.lblDSkadenc.AutoSize = true;
            this.lblDSkadenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDSkadenc.Location = new System.Drawing.Point(15, 195);
            this.lblDSkadenc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDSkadenc.Name = "lblDSkadenc";
            this.lblDSkadenc.Size = new System.Drawing.Size(132, 20);
            this.lblDSkadenc.TabIndex = 4;
            this.lblDSkadenc.Text = "Data Skadences";
            // 
            // lblCmimi
            // 
            this.lblCmimi.AutoSize = true;
            this.lblCmimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCmimi.Location = new System.Drawing.Point(15, 272);
            this.lblCmimi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmimi.Name = "lblCmimi";
            this.lblCmimi.Size = new System.Drawing.Size(57, 20);
            this.lblCmimi.TabIndex = 5;
            this.lblCmimi.Text = "Cmimi";
            // 
            // lblLloji
            // 
            this.lblLloji.AutoSize = true;
            this.lblLloji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLloji.Location = new System.Drawing.Point(488, 74);
            this.lblLloji.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLloji.Name = "lblLloji";
            this.lblLloji.Size = new System.Drawing.Size(40, 20);
            this.lblLloji.TabIndex = 6;
            this.lblLloji.Text = "Lloji";
            // 
            // lblKaTvsh
            // 
            this.lblKaTvsh.AutoSize = true;
            this.lblKaTvsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKaTvsh.Location = new System.Drawing.Point(488, 142);
            this.lblKaTvsh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKaTvsh.Name = "lblKaTvsh";
            this.lblKaTvsh.Size = new System.Drawing.Size(93, 20);
            this.lblKaTvsh.TabIndex = 7;
            this.lblKaTvsh.Text = "Ka TVSH ?";
            // 
            // lblTipi
            // 
            this.lblTipi.AutoSize = true;
            this.lblTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipi.Location = new System.Drawing.Point(488, 218);
            this.lblTipi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipi.Name = "lblTipi";
            this.lblTipi.Size = new System.Drawing.Size(36, 20);
            this.lblTipi.TabIndex = 8;
            this.lblTipi.Text = "Tipi";
            // 
            // lblBarkodi
            // 
            this.lblBarkodi.AutoSize = true;
            this.lblBarkodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarkodi.Location = new System.Drawing.Point(488, 280);
            this.lblBarkodi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarkodi.Name = "lblBarkodi";
            this.lblBarkodi.Size = new System.Drawing.Size(66, 20);
            this.lblBarkodi.TabIndex = 9;
            this.lblBarkodi.Text = "Barkodi";
            // 
            // btnTeDhenat
            // 
            this.btnTeDhenat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTeDhenat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeDhenat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTeDhenat.Location = new System.Drawing.Point(92, 331);
            this.btnTeDhenat.Margin = new System.Windows.Forms.Padding(0);
            this.btnTeDhenat.Name = "btnTeDhenat";
            this.btnTeDhenat.Size = new System.Drawing.Size(139, 52);
            this.btnTeDhenat.TabIndex = 10;
            this.btnTeDhenat.Text = "Te dhenat ";
            this.btnTeDhenat.UseVisualStyleBackColor = false;
            this.btnTeDhenat.Click += new System.EventHandler(this.btnTeDhenat_Click);
            // 
            // btnRuaj
            // 
            this.btnRuaj.BackColor = System.Drawing.Color.Lime;
            this.btnRuaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRuaj.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnRuaj.Location = new System.Drawing.Point(274, 331);
            this.btnRuaj.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuaj.Name = "btnRuaj";
            this.btnRuaj.Size = new System.Drawing.Size(139, 52);
            this.btnRuaj.TabIndex = 11;
            this.btnRuaj.Text = "Ruaj";
            this.btnRuaj.UseVisualStyleBackColor = false;
            this.btnRuaj.Click += new System.EventHandler(this.btnRuaj_Click);
            // 
            // btnKerko
            // 
            this.btnKerko.BackColor = System.Drawing.Color.Aqua;
            this.btnKerko.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKerko.Location = new System.Drawing.Point(444, 331);
            this.btnKerko.Margin = new System.Windows.Forms.Padding(4);
            this.btnKerko.Name = "btnKerko";
            this.btnKerko.Size = new System.Drawing.Size(137, 52);
            this.btnKerko.TabIndex = 12;
            this.btnKerko.Text = "Kerko";
            this.btnKerko.UseVisualStyleBackColor = false;
            this.btnKerko.Click += new System.EventHandler(this.btnKerko_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.IndianRed;
            this.btnUpdate.Location = new System.Drawing.Point(619, 331);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 52);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmertimi
            // 
            this.txtEmertimi.Location = new System.Drawing.Point(191, 71);
            this.txtEmertimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmertimi.Name = "txtEmertimi";
            this.txtEmertimi.Size = new System.Drawing.Size(220, 27);
            this.txtEmertimi.TabIndex = 14;
            // 
            // txtNjesia
            // 
            this.txtNjesia.Location = new System.Drawing.Point(191, 135);
            this.txtNjesia.Margin = new System.Windows.Forms.Padding(4);
            this.txtNjesia.Name = "txtNjesia";
            this.txtNjesia.Size = new System.Drawing.Size(220, 27);
            this.txtNjesia.TabIndex = 15;
            // 
            // txtBarkodi
            // 
            this.txtBarkodi.Location = new System.Drawing.Point(619, 280);
            this.txtBarkodi.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarkodi.Name = "txtBarkodi";
            this.txtBarkodi.Size = new System.Drawing.Size(195, 27);
            this.txtBarkodi.TabIndex = 16;
            // 
            // txtCmimi
            // 
            this.txtCmimi.Location = new System.Drawing.Point(193, 265);
            this.txtCmimi.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmimi.Name = "txtCmimi";
            this.txtCmimi.Size = new System.Drawing.Size(220, 27);
            this.txtCmimi.TabIndex = 17;
            // 
            // rbLloji
            // 
            this.rbLloji.AutoSize = true;
            this.rbLloji.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLloji.Location = new System.Drawing.Point(631, 69);
            this.rbLloji.Margin = new System.Windows.Forms.Padding(4);
            this.rbLloji.Name = "rbLloji";
            this.rbLloji.Size = new System.Drawing.Size(32, 26);
            this.rbLloji.TabIndex = 18;
            this.rbLloji.TabStop = true;
            this.rbLloji.Text = "I";
            this.rbLloji.UseCompatibleTextRendering = true;
            this.rbLloji.UseVisualStyleBackColor = true;
            // 
            // rdlloji2
            // 
            this.rdlloji2.AutoSize = true;
            this.rdlloji2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlloji2.Location = new System.Drawing.Point(688, 69);
            this.rdlloji2.Margin = new System.Windows.Forms.Padding(4);
            this.rdlloji2.Name = "rdlloji2";
            this.rdlloji2.Size = new System.Drawing.Size(41, 24);
            this.rdlloji2.TabIndex = 19;
            this.rdlloji2.TabStop = true;
            this.rdlloji2.Text = "V";
            this.rdlloji2.UseVisualStyleBackColor = true;
            // 
            // cbKaTVSH
            // 
            this.cbKaTVSH.AutoSize = true;
            this.cbKaTVSH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKaTVSH.Location = new System.Drawing.Point(631, 145);
            this.cbKaTVSH.Margin = new System.Windows.Forms.Padding(4);
            this.cbKaTVSH.Name = "cbKaTVSH";
            this.cbKaTVSH.Size = new System.Drawing.Size(18, 17);
            this.cbKaTVSH.TabIndex = 20;
            this.cbKaTVSH.UseVisualStyleBackColor = true;
            // 
            // dtSkadenc
            // 
            this.dtSkadenc.Location = new System.Drawing.Point(191, 192);
            this.dtSkadenc.Margin = new System.Windows.Forms.Padding(4);
            this.dtSkadenc.Name = "dtSkadenc";
            this.dtSkadenc.Size = new System.Drawing.Size(220, 27);
            this.dtSkadenc.TabIndex = 21;
            // 
            // cbTipi
            // 
            this.cbTipi.AutoCompleteCustomSource.AddRange(new string[] {
            "",
            "\"Ushqimore\"",
            "Bulmet",
            "Pije",
            "Embelsire"});
            this.cbTipi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipi.FormattingEnabled = true;
            this.cbTipi.Items.AddRange(new object[] {
            "Ushqimore",
            "Bulmet",
            "Pije",
            "Embelsire"});
            this.cbTipi.Location = new System.Drawing.Point(619, 212);
            this.cbTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cbTipi.Name = "cbTipi";
            this.cbTipi.Size = new System.Drawing.Size(195, 28);
            this.cbTipi.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(928, 572);
            this.ControlBox = false;
            this.Controls.Add(this.cbTipi);
            this.Controls.Add(this.dtSkadenc);
            this.Controls.Add(this.cbKaTVSH);
            this.Controls.Add(this.rdlloji2);
            this.Controls.Add(this.rbLloji);
            this.Controls.Add(this.txtCmimi);
            this.Controls.Add(this.txtBarkodi);
            this.Controls.Add(this.txtNjesia);
            this.Controls.Add(this.txtEmertimi);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnKerko);
            this.Controls.Add(this.btnRuaj);
            this.Controls.Add(this.btnTeDhenat);
            this.Controls.Add(this.lblBarkodi);
            this.Controls.Add(this.lblTipi);
            this.Controls.Add(this.lblKaTvsh);
            this.Controls.Add(this.lblLloji);
            this.Controls.Add(this.lblCmimi);
            this.Controls.Add(this.lblDSkadenc);
            this.Controls.Add(this.lblNjesia);
            this.Controls.Add(this.lbEmertimi);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label lbEmertimi;
        private System.Windows.Forms.Label lblNjesia;
        private System.Windows.Forms.Label lblDSkadenc;
        private System.Windows.Forms.Label lblCmimi;
        private System.Windows.Forms.Label lblLloji;
        private System.Windows.Forms.Label lblKaTvsh;
        private System.Windows.Forms.Label lblTipi;
        private System.Windows.Forms.Label lblBarkodi;
        private System.Windows.Forms.Button btnTeDhenat;
        private System.Windows.Forms.Button btnRuaj;
        private System.Windows.Forms.Button btnKerko;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmertimi;
        private System.Windows.Forms.TextBox txtNjesia;
        private System.Windows.Forms.TextBox txtBarkodi;
        private System.Windows.Forms.TextBox txtCmimi;
        private System.Windows.Forms.RadioButton rbLloji;
        private System.Windows.Forms.RadioButton rdlloji2;
        private System.Windows.Forms.CheckBox cbKaTVSH;
        private System.Windows.Forms.DateTimePicker dtSkadenc;
        private System.Windows.Forms.ComboBox cbTipi;
    }
}

