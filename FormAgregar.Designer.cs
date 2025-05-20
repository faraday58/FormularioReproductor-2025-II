namespace FormularioReproductor_2025_II
{
    partial class FormAgregar
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
            label1 = new Label();
            txtbTitle = new TextBox();
            label2 = new Label();
            txtbArtist = new TextBox();
            label3 = new Label();
            txtbAlbum = new TextBox();
            ptbLoadImage = new PictureBox();
            label4 = new Label();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLoadImage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 113);
            label1.Name = "label1";
            label1.Size = new Size(164, 25);
            label1.TabIndex = 0;
            label1.Text = "Título de la canción";
            // 
            // txtbTitle
            // 
            txtbTitle.Location = new Point(289, 113);
            txtbTitle.Name = "txtbTitle";
            txtbTitle.Size = new Size(375, 31);
            txtbTitle.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 216);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "Artísta";
            // 
            // txtbArtist
            // 
            txtbArtist.Location = new Point(289, 216);
            txtbArtist.Name = "txtbArtist";
            txtbArtist.Size = new Size(375, 31);
            txtbArtist.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(106, 306);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 0;
            label3.Text = "Álbum";
            // 
            // txtbAlbum
            // 
            txtbAlbum.Location = new Point(289, 300);
            txtbAlbum.Name = "txtbAlbum";
            txtbAlbum.Size = new Size(375, 31);
            txtbAlbum.TabIndex = 1;
            // 
            // ptbLoadImage
            // 
            ptbLoadImage.Image = Properties.Resources.descarga_arrow;
            ptbLoadImage.Location = new Point(403, 368);
            ptbLoadImage.Name = "ptbLoadImage";
            ptbLoadImage.Size = new Size(128, 128);
            ptbLoadImage.SizeMode = PictureBoxSizeMode.AutoSize;
            ptbLoadImage.TabIndex = 2;
            ptbLoadImage.TabStop = false;
            ptbLoadImage.Click += ptbLoadImage_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(104, 405);
            label4.Name = "label4";
            label4.Size = new Size(128, 25);
            label4.TabIndex = 0;
            label4.Text = "Cargar imagen";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(278, 523);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(375, 81);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 658);
            Controls.Add(btnAdd);
            Controls.Add(ptbLoadImage);
            Controls.Add(txtbAlbum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtbArtist);
            Controls.Add(label2);
            Controls.Add(txtbTitle);
            Controls.Add(label1);
            Name = "FormAgregar";
            Text = "FormAgregar";
            ((System.ComponentModel.ISupportInitialize)ptbLoadImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbTitle;
        private Label label2;
        private TextBox txtbArtist;
        private Label label3;
        private TextBox txtbAlbum;
        private PictureBox ptbLoadImage;
        private Label label4;
        private Button btnAdd;
    }
}