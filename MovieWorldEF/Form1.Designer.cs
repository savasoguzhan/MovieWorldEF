namespace MovieWorldEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cbGenra = new System.Windows.Forms.ComboBox();
            this.dgvMovies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genra:";
            // 
            // cbGenra
            // 
            this.cbGenra.FormattingEnabled = true;
            this.cbGenra.Location = new System.Drawing.Point(80, 21);
            this.cbGenra.Name = "cbGenra";
            this.cbGenra.Size = new System.Drawing.Size(239, 33);
            this.cbGenra.TabIndex = 1;
            this.cbGenra.SelectedIndexChanged += new System.EventHandler(this.cbGenra_SelectedIndexChanged);
            // 
            // dgvMovies
            // 
            this.dgvMovies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMovies.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovies.Location = new System.Drawing.Point(12, 106);
            this.dgvMovies.Name = "dgvMovies";
            this.dgvMovies.RowHeadersWidth = 62;
            this.dgvMovies.RowTemplate.Height = 33;
            this.dgvMovies.Size = new System.Drawing.Size(988, 422);
            this.dgvMovies.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Movies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMovies);
            this.Controls.Add(this.cbGenra);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "MovieWorld";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cbGenra;
        private DataGridView dgvMovies;
        private Label label2;
    }
}