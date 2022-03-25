namespace Simulador
{
    partial class Dados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dados));
            this.dgwDados = new System.Windows.Forms.DataGridView();
            this.LBPlaneta = new System.Windows.Forms.Label();
            this.RTBox = new System.Windows.Forms.RichTextBox();
            this.PCBOX2 = new System.Windows.Forms.PictureBox();
            this.PCBOX1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBOX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBOX1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwDados
            // 
            this.dgwDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwDados.BackgroundColor = System.Drawing.Color.Black;
            this.dgwDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDados.GridColor = System.Drawing.Color.Black;
            this.dgwDados.Location = new System.Drawing.Point(-40, -43);
            this.dgwDados.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgwDados.Name = "dgwDados";
            this.dgwDados.Size = new System.Drawing.Size(348, 525);
            this.dgwDados.TabIndex = 1;
            // 
            // LBPlaneta
            // 
            this.LBPlaneta.AutoSize = true;
            this.LBPlaneta.BackColor = System.Drawing.Color.Transparent;
            this.LBPlaneta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBPlaneta.ForeColor = System.Drawing.Color.Aqua;
            this.LBPlaneta.Location = new System.Drawing.Point(477, 68);
            this.LBPlaneta.Name = "LBPlaneta";
            this.LBPlaneta.Size = new System.Drawing.Size(66, 24);
            this.LBPlaneta.TabIndex = 2;
            this.LBPlaneta.Text = "label1";
            this.LBPlaneta.Click += new System.EventHandler(this.LBPlaneta_Click);
            // 
            // RTBox
            // 
            this.RTBox.BackColor = System.Drawing.Color.Black;
            this.RTBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBox.ForeColor = System.Drawing.Color.Aqua;
            this.RTBox.Location = new System.Drawing.Point(315, 139);
            this.RTBox.Name = "RTBox";
            this.RTBox.Size = new System.Drawing.Size(403, 172);
            this.RTBox.TabIndex = 3;
            this.RTBox.Text = "";
            // 
            // PCBOX2
            // 
            this.PCBOX2.Image = ((System.Drawing.Image)(resources.GetObject("PCBOX2.Image")));
            this.PCBOX2.Location = new System.Drawing.Point(641, 381);
            this.PCBOX2.Name = "PCBOX2";
            this.PCBOX2.Size = new System.Drawing.Size(32, 30);
            this.PCBOX2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBOX2.TabIndex = 26;
            this.PCBOX2.TabStop = false;
            this.PCBOX2.Click += new System.EventHandler(this.PCBOX2_Click);
            // 
            // PCBOX1
            // 
            this.PCBOX1.Image = ((System.Drawing.Image)(resources.GetObject("PCBOX1.Image")));
            this.PCBOX1.Location = new System.Drawing.Point(679, 381);
            this.PCBOX1.Name = "PCBOX1";
            this.PCBOX1.Size = new System.Drawing.Size(32, 30);
            this.PCBOX1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCBOX1.TabIndex = 25;
            this.PCBOX1.TabStop = false;
            this.PCBOX1.Click += new System.EventHandler(this.PCBOX1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(736, 419);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PCBOX2);
            this.Controls.Add(this.PCBOX1);
            this.Controls.Add(this.LBPlaneta);
            this.Controls.Add(this.dgwDados);
            this.Controls.Add(this.RTBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dados_FormClosing);
            this.Load += new System.EventHandler(this.Dados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBOX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PCBOX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwDados;
        private System.Windows.Forms.Label LBPlaneta;
        private System.Windows.Forms.RichTextBox RTBox;
        private System.Windows.Forms.PictureBox PCBOX2;
        private System.Windows.Forms.PictureBox PCBOX1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}